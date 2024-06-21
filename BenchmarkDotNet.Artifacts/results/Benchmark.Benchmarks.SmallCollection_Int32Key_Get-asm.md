## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC30FDF68]
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
       mov       r11,7FFCC2B504F8
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
       mov       r11,7FFCC2B50500
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L08
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L08
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L07
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L08
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
       jmp       short M00_L09
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       test      r11d,r11d
       jne       short M00_L08
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L05
M00_L08:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3027360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC310DF68]
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L08
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L08
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L07
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L08
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
       jmp       short M00_L09
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       test      r11d,r11d
       jne       short M00_L08
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L05
M00_L08:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3067360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC310DF68]
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L08
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L08
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L07
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L08
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
       jmp       short M00_L09
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       test      r11d,r11d
       jne       short M00_L08
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L05
M00_L08:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3027360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC310DF68]
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L07
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L07
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L05
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L07
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      r11d,r11d
       jne       short M00_L07
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L08
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       xor       ebp,ebp
M00_L08:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3057360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L08
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC30FE058]
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
       mov       r11,7FFCC2B504F8
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
       mov       r11,7FFCC2B50500
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L07
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L07
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L05
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L07
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      r11d,r11d
       jne       short M00_L07
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L08
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       xor       ebp,ebp
M00_L08:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3037360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L08
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC312DF68]
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
       mov       r11,7FFCC2B80500
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L07
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L07
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L05
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L07
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      r11d,r11d
       jne       short M00_L07
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L08
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       xor       ebp,ebp
M00_L08:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3057360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L08
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC312DF68]
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L07
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L07
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L05
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L07
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      r11d,r11d
       jne       short M00_L07
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L08
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       xor       ebp,ebp
M00_L08:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3037360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L08
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC313E058]
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L07
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L07
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L05
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L07
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      r11d,r11d
       jne       short M00_L07
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L08
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       xor       ebp,ebp
M00_L08:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3057360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L08
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.Dictionary()
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
       call      qword ptr [7FFCC30FDF68]
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
       mov       r11,7FFCC2B504F8
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
       call      qword ptr [7FFCC2E4F000]
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
       mov       r11,7FFCC2B50500
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
; Benchmark.Benchmarks.SmallCollection_Int32Key_Get.FrozenDictionary()
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
       jle       near ptr M00_L09
M00_L00:
       mov       rcx,[rbx+10]
       mov       rax,offset MT_System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Get+MyClass, Benchmark]]
       cmp       [rcx],rax
       jne       near ptr M00_L11
       mov       eax,edi
       mov       edx,[rcx+20]
       cmp       eax,edx
       jl        short M00_L01
       cmp       eax,edx
       jg        short M00_L08
M00_L01:
       mov       rdx,[rcx+10]
       xor       r8d,r8d
       mov       r10d,[rdx+8]
       test      r10d,r10d
       jle       short M00_L08
M00_L02:
       mov       eax,edi
       mov       r9d,r8d
       mov       r9d,[rdx+r9*4+10]
       cmp       eax,r9d
       jge       short M00_L04
       mov       r11d,0FFFFFFFF
M00_L03:
       test      r11d,r11d
       jle       short M00_L07
       inc       r8d
       cmp       r10d,r8d
       jle       short M00_L08
       jmp       short M00_L02
M00_L04:
       cmp       eax,r9d
       jg        short M00_L06
       xor       r11d,r11d
       jmp       short M00_L03
M00_L05:
       test      rbp,rbp
       je        short M00_L10
       mov       rax,[rbp]
       add       esi,[rax+0C]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
       jmp       short M00_L09
M00_L06:
       mov       r11d,1
       jmp       short M00_L03
M00_L07:
       test      r11d,r11d
       jne       short M00_L08
       mov       rax,[rcx+18]
       cmp       r8d,[rax+8]
       jae       short M00_L12
       mov       ecx,r8d
       lea       rbp,[rax+rcx*8+10]
       jmp       short M00_L05
M00_L08:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L09:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       call      qword ptr [7FFCC3057360]
       int       3
M00_L11:
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       short M00_L05
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 222
```

