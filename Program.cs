using System.Buffers;
using System.Collections;
using System.Collections.Frozen;
using Benchmark.Benchmarks;
// using BenchmarkDotNet.Columns;
// using BenchmarkDotNet.Configs;
// using BenchmarkDotNet.Reports;
// using BenchmarkDotNet.Running;

// var summaryStyle = SummaryStyle
//     .Default
//     .WithRatioStyle(RatioStyle.Percentage);

// var config = ManualConfig
//     .Create(DefaultConfig.Instance)
//     .WithSummaryStyle(summaryStyle);

// BenchmarkSwitcher
//     .FromAssembly(typeof(Program).Assembly)
//     .Run(args, config);


var size = 15;
var source = new Dictionary<MyClass, int>();
var count = 0;
while (count < size)
{
    var rand = Random.Shared.Next(100);
    if(source.TryAdd(new MyClass(rand), rand * rand)) count++;
}

var frozenDictionary = source.ToFrozenDictionary();
if (frozenDictionary.GetType().Name != "DefaultFrozenDictionary`2")
{
    throw new Exception($"Invalid FrozenDictionary type: {frozenDictionary.GetType().Name}");
}

EqualityComparer<MyClass> Comparer = EqualityComparer<MyClass>.Default;
KeyValuePair<MyClass, int>[] entries = new KeyValuePair<MyClass, int>[source.Count];
((ICollection<KeyValuePair<MyClass, int>>)source).CopyTo(entries, 0);

var _keys = new MyClass[entries.Length];
var _values = new int[entries.Length];

int[] arrayPoolHashCodes = ArrayPool<int>.Shared.Rent(entries.Length);
Span<int> hashCodes = arrayPoolHashCodes.AsSpan(0, entries.Length);
for (int i = 0; i < entries.Length; i++)
{
    hashCodes[i] = Comparer.GetHashCode(entries[i].Key);
}

Console.WriteLine("Initial order:");
for (var i = 0; i < hashCodes.Length; i++)
{
    Console.WriteLine("[{0}] = {1} (hash: {2})", entries[i].Key, entries[i].Value, hashCodes[i]);
}
Console.WriteLine();

var _hashTable = FrozenHashTable.Create(hashCodes, true);
for (int srcIndex = 0; srcIndex < hashCodes.Length; srcIndex++)
{
    int destIndex = hashCodes[srcIndex];

    _keys[destIndex] = entries[srcIndex].Key;
    _values[destIndex] = entries[srcIndex].Value;
}

ArrayPool<int>.Shared.Return(arrayPoolHashCodes);

Console.WriteLine();
Console.WriteLine("Result order:");
for (var i = 0; i < hashCodes.Length; i++)
{
    Console.WriteLine("[{0}] = {1} (hash: {2})", _keys[i], _values[i], hashCodes[i]);
}
Console.WriteLine();

var hash = Comparer.GetHashCode(entries[0].Key);
_hashTable.FindMatchingEntries(hash, out var start, out var end);

Console.WriteLine($"entry: {entries[0]}, hash: {hash}, start: {start}, end: {end}, value: {_values[start]}");


Console.WriteLine(_hashTable.ToString());

public record MyClass(int Value);