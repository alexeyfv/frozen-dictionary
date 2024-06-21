## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L05
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L14
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       r10d,r10d
       dec       r12d
M00_L01:
       mov       r9d,[r8+8]
       cmp       r9d,r12d
       jbe       near ptr M00_L08
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r8+rcx*8+10]
       cmp       [r12+8],eax
       jne       near ptr M00_L11
       mov       ecx,[r12+10]
       mov       edx,[r12+14]
       cmp       ecx,r15d
       jne       near ptr M00_L11
       xor       ecx,ecx
       cmp       edx,r15d
       sete      cl
       test      ecx,ecx
       je        near ptr M00_L11
M00_L02:
       cmp       [r12],r12b
       mov       rax,r12
M00_L03:
       test      rax,rax
       je        near ptr M00_L10
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B80548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L14
       mov       ecx,ecx
       mov       ecx,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       ecx
M00_L06:
       mov       r10d,[rbp+8]
       cmp       r10d,ecx
       jbe       short M00_L08
       mov       ecx,ecx
       lea       rax,[rcx+rcx*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L12
M00_L07:
       mov       ecx,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jb        short M00_L09
       jmp       short M00_L06
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       call      qword ptr [7FFCC2E7F000]
       int       3
M00_L10:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC312E6A0]
       int       3
M00_L11:
       mov       r12d,[r12+0C]
       inc       r10d
       cmp       r9d,r10d
       jae       near ptr M00_L01
       jmp       short M00_L09
M00_L12:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B80550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       mov       eax,r12d
       mov       r10d,[rsp+2C]
       mov       r12,[rsp+20]
       mov       ecx,eax
       mov       rax,r12
       mov       r12d,ecx
       jmp       near ptr M00_L07
M00_L13:
       mov       r12,[rsp+20]
       jmp       near ptr M00_L02
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 524
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3047858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L08
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L09
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L03
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L15
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       ecx,ecx
       dec       r12d
M00_L01:
       mov       r10d,[r8+8]
       cmp       r10d,r12d
       jbe       near ptr M00_L09
       mov       edx,r12d
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[r8+rdx*8+10]
       cmp       [rbp+8],eax
       jne       short M00_L02
       mov       edx,[rbp+10]
       mov       r11d,[rbp+14]
       cmp       edx,r15d
       jne       near ptr M00_L12
       xor       edx,edx
       cmp       r11d,r15d
       sete      dl
       test      edx,edx
       jne       near ptr M00_L06
M00_L02:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jb        near ptr M00_L10
       jmp       short M00_L01
M00_L03:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B50548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       mov       ecx,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       ecx
M00_L04:
       mov       r10d,[rbp+8]
       cmp       r10d,ecx
       jbe       short M00_L09
       mov       ecx,ecx
       lea       rax,[rcx+rcx*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L13
M00_L05:
       mov       ecx,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jb        short M00_L10
       jmp       short M00_L04
M00_L06:
       cmp       [rbp],bpl
M00_L07:
       test      rbp,rbp
       je        short M00_L11
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L08:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L07
M00_L10:
       call      qword ptr [7FFCC2E4F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC30FE6A0]
       int       3
M00_L12:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jae       near ptr M00_L01
       jmp       short M00_L10
M00_L13:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B50550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       mov       rax,rbp
       mov       rbp,[rsp+20]
       mov       r10d,[rsp+2C]
       mov       rcx,rax
       mov       rax,rbp
       mov       rbp,rcx
       jmp       near ptr M00_L05
M00_L14:
       mov       rbp,[rsp+20]
       jmp       near ptr M00_L06
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 521
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3057858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L05
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L06
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L14
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       r10d,r10d
       dec       r12d
M00_L01:
       mov       r9d,[r8+8]
       cmp       r9d,r12d
       jbe       short M00_L05
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r8+rcx*8+10]
       cmp       [r12+8],eax
       jne       near ptr M00_L11
       mov       ecx,[r12+10]
       mov       edx,[r12+14]
       cmp       ecx,r15d
       jne       near ptr M00_L11
       xor       ecx,ecx
       cmp       edx,r15d
       sete      cl
       test      ecx,ecx
       je        near ptr M00_L11
M00_L02:
       cmp       [r12],r12b
       mov       rax,r12
M00_L03:
       test      rax,rax
       je        near ptr M00_L10
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       eax,eax
       jmp       short M00_L03
M00_L06:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B80548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L14
       mov       ecx,ecx
       mov       eax,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       eax
M00_L07:
       mov       r10d,[rbp+8]
       cmp       r10d,eax
       jbe       short M00_L05
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L12
M00_L08:
       mov       eax,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jae       short M00_L07
M00_L09:
       call      qword ptr [7FFCC2E7F000]
       int       3
M00_L10:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC312E6A0]
       int       3
M00_L11:
       mov       r12d,[r12+0C]
       inc       r10d
       cmp       r9d,r10d
       jae       near ptr M00_L01
       jmp       short M00_L09
M00_L12:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B80550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       mov       eax,r12d
       mov       r10d,[rsp+2C]
       mov       r12,[rsp+20]
       mov       ecx,eax
       mov       rax,r12
       mov       r12d,ecx
       jmp       short M00_L08
M00_L13:
       mov       r12,[rsp+20]
       jmp       near ptr M00_L02
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 512
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3027858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L05
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L14
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       r10d,r10d
       dec       r12d
M00_L01:
       mov       r9d,[r8+8]
       cmp       r9d,r12d
       jbe       near ptr M00_L08
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r8+rcx*8+10]
       cmp       [r12+8],eax
       jne       near ptr M00_L11
       mov       ecx,[r12+10]
       mov       edx,[r12+14]
       cmp       ecx,r15d
       jne       near ptr M00_L11
       xor       ecx,ecx
       cmp       edx,r15d
       sete      cl
       test      ecx,ecx
       je        near ptr M00_L11
M00_L02:
       cmp       [r12],r12b
       mov       rax,r12
M00_L03:
       test      rax,rax
       je        near ptr M00_L10
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B60548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L14
       mov       ecx,ecx
       mov       ecx,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       ecx
M00_L06:
       mov       r10d,[rbp+8]
       cmp       r10d,ecx
       jbe       short M00_L08
       mov       ecx,ecx
       lea       rax,[rcx+rcx*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L12
M00_L07:
       mov       ecx,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jb        short M00_L09
       jmp       short M00_L06
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M00_L10:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC310E9D0]
       int       3
M00_L11:
       mov       r12d,[r12+0C]
       inc       r10d
       cmp       r9d,r10d
       jae       near ptr M00_L01
       jmp       short M00_L09
M00_L12:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B60550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       mov       eax,r12d
       mov       r10d,[rsp+2C]
       mov       r12,[rsp+20]
       mov       ecx,eax
       mov       rax,r12
       mov       r12d,ecx
       jmp       near ptr M00_L07
M00_L13:
       mov       r12,[rsp+20]
       jmp       near ptr M00_L02
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 524
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3027858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L07
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L15
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       ecx,ecx
       dec       r12d
M00_L01:
       mov       r10d,[r8+8]
       cmp       r10d,r12d
       jbe       short M00_L06
       mov       edx,r12d
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[r8+rdx*8+10]
       cmp       [rbp+8],eax
       jne       short M00_L05
       mov       edx,[rbp+10]
       mov       r11d,[rbp+14]
       cmp       edx,r15d
       jne       near ptr M00_L12
       xor       edx,edx
       cmp       r11d,r15d
       sete      dl
       test      edx,edx
       je        short M00_L05
M00_L02:
       cmp       [rbp],bpl
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jb        near ptr M00_L10
       jmp       short M00_L01
M00_L06:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L07:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B50548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       mov       eax,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       eax
M00_L08:
       mov       r10d,[rbp+8]
       cmp       r10d,eax
       jbe       short M00_L06
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L13
M00_L09:
       mov       eax,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jae       short M00_L08
M00_L10:
       call      qword ptr [7FFCC2E4F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC30FE9D0]
       int       3
M00_L12:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jae       near ptr M00_L01
       jmp       short M00_L10
M00_L13:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B50550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       mov       rax,rbp
       mov       rbp,[rsp+20]
       mov       r10d,[rsp+2C]
       mov       rcx,rax
       mov       rax,rbp
       mov       rbp,rcx
       jmp       short M00_L09
M00_L14:
       mov       rbp,[rsp+20]
       jmp       near ptr M00_L02
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 512
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3057858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L07
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L15
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       ecx,ecx
       dec       r12d
M00_L01:
       mov       r10d,[r8+8]
       cmp       r10d,r12d
       jbe       short M00_L06
       mov       edx,r12d
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[r8+rdx*8+10]
       cmp       [rbp+8],eax
       jne       short M00_L05
       mov       edx,[rbp+10]
       mov       r11d,[rbp+14]
       cmp       edx,r15d
       jne       near ptr M00_L12
       xor       edx,edx
       cmp       r11d,r15d
       sete      dl
       test      edx,edx
       je        short M00_L05
M00_L02:
       cmp       [rbp],bpl
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jb        near ptr M00_L10
       jmp       short M00_L01
M00_L06:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L07:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B90548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       mov       eax,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       eax
M00_L08:
       mov       r10d,[rbp+8]
       cmp       r10d,eax
       jbe       short M00_L06
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L13
M00_L09:
       mov       eax,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jae       short M00_L08
M00_L10:
       call      qword ptr [7FFCC2E8F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC313E9D0]
       int       3
M00_L12:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jae       near ptr M00_L01
       jmp       short M00_L10
M00_L13:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B90550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       mov       rax,rbp
       mov       rbp,[rsp+20]
       mov       r10d,[rsp+2C]
       mov       rcx,rax
       mov       rax,rbp
       mov       rbp,rcx
       jmp       short M00_L09
M00_L14:
       mov       rbp,[rsp+20]
       jmp       near ptr M00_L02
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 512
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3047858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L05
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L14
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       r10d,r10d
       dec       r12d
M00_L01:
       mov       r9d,[r8+8]
       cmp       r9d,r12d
       jbe       near ptr M00_L08
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r8+rcx*8+10]
       cmp       [r12+8],eax
       jne       near ptr M00_L11
       mov       ecx,[r12+10]
       mov       edx,[r12+14]
       cmp       ecx,r15d
       jne       near ptr M00_L11
       xor       ecx,ecx
       cmp       edx,r15d
       sete      cl
       test      ecx,ecx
       je        near ptr M00_L11
M00_L02:
       cmp       [r12],r12b
       mov       rax,r12
M00_L03:
       test      rax,rax
       je        near ptr M00_L10
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B60548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L14
       mov       ecx,ecx
       mov       ecx,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       ecx
M00_L06:
       mov       r10d,[rbp+8]
       cmp       r10d,ecx
       jbe       short M00_L08
       mov       ecx,ecx
       lea       rax,[rcx+rcx*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L12
M00_L07:
       mov       ecx,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jb        short M00_L09
       jmp       short M00_L06
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M00_L10:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC310E6A0]
       int       3
M00_L11:
       mov       r12d,[r12+0C]
       inc       r10d
       cmp       r9d,r10d
       jae       near ptr M00_L01
       jmp       short M00_L09
M00_L12:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B60550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       mov       eax,r12d
       mov       r10d,[rsp+2C]
       mov       r12,[rsp+20]
       mov       ecx,eax
       mov       rax,r12
       mov       r12d,ecx
       jmp       near ptr M00_L07
M00_L13:
       mov       r12,[rsp+20]
       jmp       near ptr M00_L02
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 524
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3047858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L07
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L15
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       ecx,ecx
       dec       r12d
M00_L01:
       mov       r10d,[r8+8]
       cmp       r10d,r12d
       jbe       short M00_L06
       mov       edx,r12d
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[r8+rdx*8+10]
       cmp       [rbp+8],eax
       jne       short M00_L05
       mov       edx,[rbp+10]
       mov       r11d,[rbp+14]
       cmp       edx,r15d
       jne       near ptr M00_L12
       xor       edx,edx
       cmp       r11d,r15d
       sete      dl
       test      edx,edx
       je        short M00_L05
M00_L02:
       cmp       [rbp],bpl
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jb        near ptr M00_L10
       jmp       short M00_L01
M00_L06:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L07:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B80548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       mov       eax,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       eax
M00_L08:
       mov       r10d,[rbp+8]
       cmp       r10d,eax
       jbe       short M00_L06
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L13
M00_L09:
       mov       eax,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jae       short M00_L08
M00_L10:
       call      qword ptr [7FFCC2E7F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC312E6A0]
       int       3
M00_L12:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jae       near ptr M00_L01
       jmp       short M00_L10
M00_L13:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B80550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       mov       rax,rbp
       mov       rbp,[rsp+20]
       mov       r10d,[rsp+2C]
       mov       rcx,rax
       mov       rax,rbp
       mov       rbp,rcx
       jmp       short M00_L09
M00_L14:
       mov       rbp,[rsp+20]
       jmp       near ptr M00_L02
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 512
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3037858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L04
M00_L00:
       mov       rbp,[rbx+8]
       mov       r14d,edi
       mov       r15d,r14d
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       r13,[rbp+18]
       test      r13,r13
       jne       near ptr M00_L07
       imul      eax,r15d,0A5555529
       add       eax,r15d
       mov       edx,eax
       imul      rdx,[rbp+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M00_L15
       mov       edx,edx
       mov       r12d,[rcx+rdx*4+10]
       mov       r8,[rbp+10]
       xor       ecx,ecx
       dec       r12d
M00_L01:
       mov       r10d,[r8+8]
       cmp       r10d,r12d
       jbe       short M00_L06
       mov       edx,r12d
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[r8+rdx*8+10]
       cmp       [rbp+8],eax
       jne       short M00_L05
       mov       edx,[rbp+10]
       mov       r11d,[rbp+14]
       cmp       edx,r15d
       jne       near ptr M00_L12
       xor       edx,edx
       cmp       r11d,r15d
       sete      dl
       test      edx,edx
       je        short M00_L05
M00_L02:
       cmp       [rbp],bpl
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L04:
       mov       eax,esi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jb        near ptr M00_L10
       jmp       short M00_L01
M00_L06:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L07:
       mov       [rsp+30],r15d
       mov       [rsp+34],r15d
       mov       rcx,r13
       mov       rdx,[rsp+30]
       mov       r11,7FFCC2B60548
       call      qword ptr [r11]
       mov       r15d,eax
       mov       rax,[rbp+8]
       mov       ecx,r15d
       imul      rcx,[rbp+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rax+8]
       mov       edx,r8d
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       mov       eax,[rax+rcx*4+10]
       mov       rbp,[rbp+10]
       xor       r12d,r12d
       dec       eax
M00_L08:
       mov       r10d,[rbp+8]
       cmp       r10d,eax
       jbe       short M00_L06
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rax,[rbp+rax*8+10]
       cmp       [rax+8],r15d
       je        short M00_L13
M00_L09:
       mov       eax,[rax+0C]
       inc       r12d
       cmp       r10d,r12d
       jae       short M00_L08
M00_L10:
       call      qword ptr [7FFCC2E5F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC310E9D0]
       int       3
M00_L12:
       mov       r12d,[rbp+0C]
       inc       ecx
       cmp       r10d,ecx
       jae       near ptr M00_L01
       jmp       short M00_L10
M00_L13:
       mov       [rsp+2C],r10d
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,r13
       mov       r8,[rsp+30]
       mov       r11,7FFCC2B60550
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       mov       rax,rbp
       mov       rbp,[rsp+20]
       mov       r10d,[rsp+2C]
       mov       rcx,rax
       mov       rax,rbp
       mov       rbp,rcx
       jmp       short M00_L09
M00_L14:
       mov       rbp,[rsp+20]
       jmp       near ptr M00_L02
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 512
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       near ptr M00_L06
M00_L00:
       mov       rcx,[rbx+10]
       mov       eax,edi
       mov       edx,eax
       mov       r8,offset MT_System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       short M00_L08
       mov       r8,[rcx+10]
       xor       r10d,r10d
       mov       r9d,[r8+8]
       test      r9d,r9d
       jle       short M00_L03
M00_L01:
       mov       r11d,r10d
       lea       r11,[r8+r11*8+10]
       mov       ebp,[r11]
       mov       r11d,[r11+4]
       cmp       ebp,edx
       jne       short M00_L02
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       jne       short M00_L04
M00_L02:
       inc       r10d
       cmp       r9d,r10d
       jg        short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r10d,[rax+8]
       jae       short M00_L09
       mov       edx,r10d
       lea       rbp,[rax+rdx*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      qword ptr [7FFCC3037858]
       int       3
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 200
```

