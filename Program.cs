using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

var summaryStyle = SummaryStyle
    .Default
    .WithRatioStyle(RatioStyle.Percentage);

var config = ManualConfig
    .Create(DefaultConfig.Instance)
    .WithSummaryStyle(summaryStyle);

BenchmarkSwitcher
    .FromAssembly(typeof(Program).Assembly)
    .Run(args, config);
