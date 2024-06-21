## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B80530
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
       call      qword ptr [7FFCC3127A98]
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
       mov       r11,7FFCC2B80538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B50530
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
       call      qword ptr [7FFCC30F7DC8]
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
       mov       r11,7FFCC2B50538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B70530
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
       call      qword ptr [7FFCC2E6F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC3117DC8]
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
       mov       r11,7FFCC2B70538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B50530
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
       call      qword ptr [7FFCC30F7A98]
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
       mov       r11,7FFCC2B50538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L10
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L10
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L10
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L07
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
M00_L04:
       test      rbp,rbp
       je        short M00_L09
M00_L05:
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L10
       lea       rbp,[rax+r14*8+10]
       jmp       short M00_L04
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M00_L05
M00_L09:
       call      qword ptr [7FFCC3047858]
       int       3
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B80530
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
       call      qword ptr [7FFCC2E7F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC3127A98]
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
       mov       r11,7FFCC2B80538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B70530
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
       call      qword ptr [7FFCC2E6F000]
       int       3
M00_L11:
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       rcx,[rsp+30]
       call      qword ptr [7FFCC3117A98]
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
       mov       r11,7FFCC2B70538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B80530
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
       call      qword ptr [7FFCC3127DC8]
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
       mov       r11,7FFCC2B80538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
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
       mov       r11,7FFCC2B80530
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
       call      qword ptr [7FFCC3127A98]
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
       mov       r11,7FFCC2B80538
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
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L10
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L10
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L10
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L07
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
M00_L04:
       test      rbp,rbp
       je        short M00_L09
M00_L05:
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L10
       lea       rbp,[rax+r14*8+10]
       jmp       short M00_L04
M00_L08:
       mov       [rsp+20],edx
       mov       [rsp+24],edx
       mov       rdx,[rsp+20]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M00_L05
M00_L09:
       call      qword ptr [7FFCC3037858]
       int       3
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 313
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3054D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3127DC8]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L02
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L01
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       jne       near ptr M01_L05
M01_L01:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L02:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B80510
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L03:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L04:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L03
M01_L05:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L06:
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
M01_L07:
       xor       eax,eax
       jmp       short M01_L06
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B80518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L04
M01_L10:
       mov       rbx,[rsp+20]
       jmp       short M01_L05
M01_L11:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 434
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3054D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3127A98]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L02
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L01
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       jne       near ptr M01_L05
M01_L01:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L02:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B80510
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L03:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L04:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L03
M01_L05:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L06:
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
M01_L07:
       xor       eax,eax
       jmp       short M01_L06
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B80518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L04
M01_L10:
       mov       rbx,[rsp+20]
       jmp       short M01_L05
M01_L11:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 434
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3034D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3107DC8]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L04
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L03
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       je        short M01_L03
M01_L01:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L02:
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
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B60510
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L05:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L06:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L05
M01_L07:
       xor       eax,eax
       jmp       near ptr M01_L02
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B60518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L06
M01_L10:
       mov       rbx,[rsp+20]
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 436
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFCC3067858]
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3034D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3107A98]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L02
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L01
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       jne       near ptr M01_L05
M01_L01:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L02:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B60510
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L03:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L04:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L03
M01_L05:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L06:
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
M01_L07:
       xor       eax,eax
       jmp       short M01_L06
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B60518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L04
M01_L10:
       mov       rbx,[rsp+20]
       jmp       short M01_L05
M01_L11:
       call      qword ptr [7FFCC2E5F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 434
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3064D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3137DC8]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L02
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L01
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       jne       near ptr M01_L05
M01_L01:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L02:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B90518
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L03:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L04:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L03
M01_L05:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L06:
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
M01_L07:
       xor       eax,eax
       jmp       short M01_L06
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B90520
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L04
M01_L10:
       mov       rbx,[rsp+20]
       jmp       short M01_L05
M01_L11:
       call      qword ptr [7FFCC2E8F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 434
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFCC3037840]
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3044D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3117A98]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L02
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L01
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       jne       near ptr M01_L05
M01_L01:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L02:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B70518
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L03:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L04:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L03
M01_L05:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L06:
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
M01_L07:
       xor       eax,eax
       jmp       short M01_L06
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B70520
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L04
M01_L10:
       mov       rbx,[rsp+20]
       jmp       short M01_L05
M01_L11:
       call      qword ptr [7FFCC2E6F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 434
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFCC3037840]
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3054D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3127DC8]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L04
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L03
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       je        short M01_L03
M01_L01:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L02:
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
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B80518
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L05:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L06:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L05
M01_L07:
       xor       eax,eax
       jmp       near ptr M01_L02
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B80520
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L06
M01_L10:
       mov       rbx,[rsp+20]
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFCC2E7F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 436
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFCC3037840]
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3024D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3107DC8]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L04
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L03
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       je        short M01_L03
M01_L01:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L02:
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
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B50518
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L05:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L06:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L05
M01_L07:
       xor       eax,eax
       jmp       near ptr M01_L02
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B50520
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L06
M01_L10:
       mov       rbx,[rsp+20]
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFCC2E4F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 436
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFCC3057840]
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
; Total bytes of code 310
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.Dictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _dictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       xor       esi,esi
       xor       edi,edi
       cmp       dword ptr [rbx+18],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,edi
       mov       eax,edx
       cmp       [rcx],cl
       mov       [rsp+28],edx
       mov       [rsp+2C],eax
       mov       rdx,[rsp+28]
       call      qword ptr [7FFCC3044D50]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        short M00_L00
M00_L01:
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,[rsp+28]
       call      qword ptr [7FFCC3127DC8]
       int       3
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].FindValue(CustomKey)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],rdx
       mov       rbx,rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M01_L07
       mov       rsi,[rbx+18]
       test      rsi,rsi
       jne       near ptr M01_L04
       mov       edi,[rsp+78]
       imul      eax,edi,0A5555529
       mov       ebp,[rsp+7C]
       add       eax,ebp
       mov       edx,eax
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rcx+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L12
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
       mov       r12d,[r15+8]
M01_L00:
       cmp       r12d,r14d
       jbe       near ptr M01_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       rbx,[r15+rcx*8+10]
       cmp       [rbx+8],eax
       jne       short M01_L03
       mov       ecx,[rbx+10]
       mov       edx,[rbx+14]
       mov       r11d,edi
       mov       r8d,ebp
       cmp       ecx,r11d
       jne       near ptr M01_L08
       xor       ecx,ecx
       cmp       edx,r8d
       sete      cl
       test      ecx,ecx
       je        short M01_L03
M01_L01:
       cmp       [rbx],bl
       mov       rax,rbx
M01_L02:
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
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        near ptr M01_L11
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       mov       rdx,[rsp+78]
       mov       r11,7FFCC2B70518
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       near ptr M01_L12
       mov       edx,edx
       mov       edx,[rax+rdx*4+10]
       mov       rbx,[rbx+10]
       xor       ebp,ebp
       dec       edx
M01_L05:
       mov       r14d,[rbx+8]
       cmp       r14d,edx
       jbe       short M01_L07
       mov       edx,edx
       lea       rax,[rdx+rdx*2]
       lea       rax,[rbx+rax*8+10]
       cmp       [rax+8],edi
       je        short M01_L09
M01_L06:
       mov       edx,[rax+0C]
       inc       ebp
       cmp       r14d,ebp
       jb        short M01_L11
       jmp       short M01_L05
M01_L07:
       xor       eax,eax
       jmp       near ptr M01_L02
M01_L08:
       mov       r14d,[rbx+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M01_L00
       jmp       short M01_L11
M01_L09:
       mov       [rsp+20],rax
       mov       rdx,[rax+10]
       mov       rcx,rsi
       mov       r8,[rsp+78]
       mov       r11,7FFCC2B70520
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L10
       mov       r15,rbx
       mov       rbx,[rsp+20]
       mov       rax,rbx
       mov       rbx,r15
       jmp       short M01_L06
M01_L10:
       mov       rbx,[rsp+20]
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FFCC2E6F000]
       int       3
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 436
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get.FrozenDictionary()
;         var sum = 0;
;         ^^^^^^^^^^^^
;         for (int i = 0; i < DictionarySize; i++)
;              ^^^^^^^^^
;             sum += _frozenDictionary[new(i, i)].Sum;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return sum;
;         ^^^^^^^^^^^
       push      r15
       push      r14
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
       mov       r8,offset MT_System.Collections.Frozen.ValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+CustomKey, Benchmark],[Benchmark.Benchmarks.LargeCollection_CustomValueTypeKey_Get+MyClass, Benchmark]]
       cmp       [rcx],r8
       jne       near ptr M00_L08
       imul      r8d,edx,0A5555529
       add       r8d,eax
       lea       r10,[rcx+20]
       mov       r9,[r10]
       mov       r11d,r8d
       imul      r11,[r10+10]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       mov       ebp,r10d
       imul      r11,rbp
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M00_L09
       mov       r10d,r11d
       lea       r10,[r9+r10*8+10]
       mov       r9d,[r10]
       mov       r10d,[r10+4]
       cmp       r9d,r10d
       jg        short M00_L03
       mov       r11,[rcx+28]
M00_L01:
       mov       rbp,r11
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       mov       r14d,r9d
       cmp       [rbp+r14*4+10],r8d
       jne       short M00_L02
       mov       rbp,[rcx+10]
       cmp       r9d,[rbp+8]
       jae       near ptr M00_L09
       lea       rbp,[rbp+r14*8+10]
       mov       r15d,[rbp]
       mov       ebp,[rbp+4]
       cmp       edx,r15d
       jne       short M00_L02
       cmp       eax,ebp
       sete      bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M00_L04
M00_L02:
       inc       r9d
       cmp       r9d,r10d
       jle       short M00_L01
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L05
M00_L04:
       mov       rax,[rcx+18]
       cmp       r9d,[rax+8]
       jae       short M00_L09
       lea       rbp,[rax+r14*8+10]
M00_L05:
       test      rbp,rbp
       je        short M00_L07
       mov       rax,[rbp]
       add       esi,[rax+8]
       inc       edi
       cmp       edi,[rbx+18]
       jl        near ptr M00_L00
M00_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFCC3037840]
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
; Total bytes of code 310
```

