## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3054B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC312EC70]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L07
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B804E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L07
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L05:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L04
M01_L06:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L07:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L06
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B804F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 357
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3067360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC310DC38]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L04
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       short M01_L03
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L05:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L03
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L06:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L05
M01_L07:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L07
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B604F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3047360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC310DED8]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B604F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3047360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3054B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC312DC38]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L04
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       short M01_L03
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B804E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L05:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L03
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L06:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L05
M01_L07:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L07
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B804F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3057360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC310DC38]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L04
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       short M01_L03
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L05:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L03
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L06:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L05
M01_L07:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L07
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B604F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3057360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3054B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC312DC38]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B804E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B804F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3067360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3024B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC30FDC38]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B504E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B504F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E4F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3037360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC310DC38]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604E8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B604F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3027360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3107AF8]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B60500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3027360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3064B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3137E28]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B904F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B90500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E8F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3027360]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3107E28]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L04
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       short M01_L03
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L05:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L03
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L06:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L05
M01_L07:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L07
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B60500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3027450]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3107AF8]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L04
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       short M01_L03
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L05:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L03
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L06:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L05
M01_L07:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L07
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B60500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3037450]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3054B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3127DE0]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B804F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B80500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3057438]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3107DE0]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B60500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3037438]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3107DE0]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B60500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3037438]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3034B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3107AB0]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L03
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L04
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       short M01_L03
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L08
       cmp       [r12+10],eax
       jne       near ptr M01_L08
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L04:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B604F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       eax,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       eax
M01_L05:
       mov       r13d,[rbx+8]
       cmp       r13d,eax
       jbe       short M01_L03
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L09
M01_L06:
       mov       eax,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jae       short M01_L05
M01_L07:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L08:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L07
M01_L09:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B60500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3057438]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,edi
       call      qword ptr [7FFCC3064B58]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,edi
       call      qword ptr [7FFCC3137DE0]
       int       3
; Total bytes of code 71
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L03
       mov       eax,esi
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       mov       ebp,[rcx+rdx*4+10]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ebp
       mov       r13d,[r14+8]
M01_L00:
       cmp       r13d,ebp
       jbe       near ptr M01_L06
       mov       ecx,ebp
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],esi
       jne       near ptr M01_L07
       cmp       [r12+10],eax
       jne       near ptr M01_L07
M01_L01:
       cmp       [r12],r12b
M01_L02:
       mov       rax,r12
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFCC2B904F8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbx+8]
       mov       edx,r14d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M01_L10
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L04:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L06
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       r12,[rbx+rax*8+10]
       cmp       [r12+8],r14d
       je        short M01_L08
M01_L05:
       mov       edx,[r12+0C]
       inc       ebp
       cmp       r13d,ebp
       jb        short M01_L09
       jmp       short M01_L04
M01_L06:
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L07:
       mov       ebp,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       near ptr M01_L00
       jmp       short M01_L09
M01_L08:
       mov       edx,[r12+10]
       mov       rcx,rdi
       mov       r8d,esi
       mov       r11,7FFCC2B90500
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFCC2E8F000]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 359
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_Int32Key_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[i].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jle       near ptr M00_L07
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.Int32FrozenDictionary`1[[Benchmark.Benchmarks.LargeCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L09
       lea       rax,[rcx+18]
       mov       rdx,[rax]
       mov       r8d,edi
       imul      r8,[rax+10]
       shr       r8,20
       inc       r8
       mov       eax,[rdx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L10
       mov       eax,r8d
       lea       rax,[rdx+rax*8+10]
       mov       edx,[rax]
       mov       eax,[rax+4]
       mov       r8,[rcx+20]
       cmp       edx,eax
       jg        short M00_L05
       test      r8,r8
       je        short M00_L04
       mov       r10d,edx
       or        r10d,eax
       jl        short M00_L04
       cmp       [r8+8],eax
       jle       short M00_L04
M00_L01:
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       jne       short M00_L03
M00_L02:
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M00_L10
       mov       ecx,edx
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L06
M00_L03:
       inc       edx
       cmp       edx,eax
       jle       short M00_L01
       jmp       short M00_L05
M00_L04:
       cmp       edx,[r8+8]
       jae       short M00_L10
       mov       r10d,edx
       cmp       [r8+r10*4+10],edi
       je        short M00_L02
       inc       edx
       cmp       edx,eax
       jle       short M00_L04
M00_L05:
       xor       ebp,ebp
M00_L06:
       test      rbp,rbp
       je        short M00_L08
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFCC3047438]
       int       3
M00_L09:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L06
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 257
```

