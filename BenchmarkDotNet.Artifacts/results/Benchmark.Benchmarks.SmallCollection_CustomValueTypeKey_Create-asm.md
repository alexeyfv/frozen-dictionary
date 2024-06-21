## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1EF4CC05C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EF4CC05C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EF4CC05C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC305B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC305BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC305BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CB4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC305C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30477B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC305BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC305C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B70538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E94F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E94F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B70540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2CB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,1EF4CC00B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2ECEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CBF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC305D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E6ED00]
       int       3
M07_L05:
       mov       rcx,1EF4CC01DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L16
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L09
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L07
M08_L02:
       mov       r14d,[rbp+8]
       cmp       r14d,eax
       ja        near ptr M08_L21
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L08
       mov       r13d,[rbx+38]
       cmp       r14d,r13d
       je        near ptr M08_L17
M08_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M08_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       mov       ecx,[rbp+8]
       mov       r8d,ecx
       cmp       r8d,eax
       ja        near ptr M08_L18
       mov       r14d,r8d
       jmp       near ptr M08_L03
M08_L08:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,r14d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L09:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B70530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L10:
       cmp       dil,1
       jne       short M08_L12
M08_L11:
       cmp       eax,r14d
       jae       near ptr M08_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L12:
       cmp       dil,2
       je        near ptr M08_L19
M08_L13:
       xor       eax,eax
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
M08_L14:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       r8d,r13d
       jae       near ptr M08_L07
M08_L15:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M08_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L18:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L14
       mov       [rsp+24],r8d
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B70528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L20
       cmp       dil,1
       mov       eax,[rsp+34]
       mov       r14d,[rsp+24]
       je        near ptr M08_L11
       cmp       dil,2
       jne       near ptr M08_L13
M08_L19:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC304C0C0]
       int       3
M08_L20:
       mov       eax,[rsp+34]
       mov       r8d,[rsp+24]
       jmp       near ptr M08_L14
M08_L21:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M08_L22
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2ECEA30]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       near ptr M08_L10
M08_L22:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       inc       r13d
       cmp       r14d,r13d
       jae       near ptr M08_L02
       jmp       near ptr M08_L15
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 764
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,2DD71405C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3065EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3067E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3067EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2DD71405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3061D88
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2DD71405C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30475A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30489D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30673D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30481E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3047B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3047BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3047BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B805A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3047B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B805B0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,2DD71401DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L04
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        near ptr M02_L06
       mov       rdx,[rdx+18]
       mov       rax,2DD71401DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L05
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L06
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC304A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L05:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L07
M02_L06:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC304A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B80570
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC304A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC304A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EDF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC304ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EDF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2F11C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3067F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B80578
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 951
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L00
       mov       rdx,2DD71401DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L10
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L06
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30845B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L05
M03_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC304E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L05:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC304E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L07:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC304DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3184B88]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC306EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L10:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L13
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFCC304D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC306F828]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC304CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC306EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 402
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2CC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,2DD71400B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3049168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3061D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CCF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3049550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M09_L05:
       mov       rcx,2DD71401DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L22
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L08
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L07
M10_L02:
       cmp       [rbp+8],eax
       ja        near ptr M10_L10
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L21
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       cmp       [rbp+8],eax
       ja        near ptr M10_L15
       jmp       near ptr M10_L03
M10_L08:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B80568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M10_L11
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EDEEC8]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       short M10_L12
M10_L11:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       mov       r14d,eax
       inc       r13d
       cmp       [rbp+8],r13d
       mov       eax,r14d
       jae       near ptr M10_L02
       jmp       near ptr M10_L20
M10_L12:
       cmp       dil,1
       jne       short M10_L14
M10_L13:
       cmp       eax,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L14:
       cmp       dil,2
       jne       short M10_L18
       jmp       short M10_L16
M10_L15:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L19
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B80560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L17
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M10_L13
       cmp       dil,2
       jne       short M10_L18
M10_L16:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3067CC0]
       int       3
M10_L17:
       mov       eax,[rsp+34]
       jmp       short M10_L19
M10_L18:
       xor       eax,eax
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
M10_L19:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L07
M10_L20:
       call      qword ptr [7FFCC2E7F000]
       int       3
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC3066238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30661F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 724
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,2DD71401DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3066010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC308CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30A02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3066058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC3025CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2CC43A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1E935C05C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3026868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E935C05C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3022730
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E935C05C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC303B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC303BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC303BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC303C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30277B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC303BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC303C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3027768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC303BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EAEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC303BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC303BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EAEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B50538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC303BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EAEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B50540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2C94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,1E935C00B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC303D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2EAEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3022730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2EAEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2C9F678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC303D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E4ED00]
       int       3
M07_L05:
       mov       rcx,1E935C01DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+98],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L19
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L10
       imul      r15d,[rsp+98],0A5555529
       add       r15d,[rsp+9C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L11
M08_L02:
       mov       r14d,[rbp+8]
       cmp       r14d,eax
       ja        short M08_L07
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       r13d,[rbx+38]
       cmp       r14d,r13d
       je        near ptr M08_L18
M08_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+98]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[rbp+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r15d
       mov       [rsp+44],eax
       je        near ptr M08_L20
M08_L08:
       mov       eax,[r8+0C]
       inc       r13d
       cmp       r14d,r13d
       jb        near ptr M08_L17
       jmp       near ptr M08_L02
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,r14d
       jae       near ptr M08_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       rcx,r14
       mov       rdx,[rsp+98]
       mov       r11,7FFCC2B50530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L11:
       mov       ecx,[rbp+8]
       mov       r10d,ecx
       cmp       r10d,eax
       jbe       short M08_L14
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L16
       mov       [rsp+44],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       [rsp+30],r10
       mov       rcx,r10
       mov       r8,[rsp+98]
       mov       r11,7FFCC2B50528
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+30]
       je        short M08_L13
       cmp       dil,1
       mov       eax,[rsp+44]
       je        near ptr M08_L21
       cmp       dil,2
       jne       short M08_L15
M08_L12:
       mov       rcx,[rsp+98]
       call      qword ptr [7FFCC302C0C0]
       int       3
M08_L13:
       mov       eax,[rsp+44]
       jmp       short M08_L16
M08_L14:
       mov       r14d,r10d
       jmp       near ptr M08_L03
M08_L15:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L16:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       r14d,r13d
       mov       r14,r10
       jae       near ptr M08_L11
M08_L17:
       call      qword ptr [7FFCC2E4F000]
       int       3
M08_L18:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EAEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L19:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EAEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L20:
       mov       rcx,[r8+10]
       mov       [rsp+38],rcx
       lea       rcx,[rsp+38]
       mov       rdx,[rsp+98]
       call      qword ptr [7FFCC2EAEA30]
       test      eax,eax
       mov       r8,[rsp+28]
       je        near ptr M08_L08
       mov       eax,[rsp+44]
       cmp       dil,1
       je        short M08_L21
       cmp       dil,2
       jne       near ptr M08_L15
       jmp       near ptr M08_L12
M08_L21:
       cmp       eax,r14d
       jae       short M08_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 758
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,1B5C2405C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3035EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3037E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3037EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1B5C2405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3031D88
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B5C2405C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30175A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30189D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30373D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30181E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3017B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3017BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3017BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B505A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3017B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B505B0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,1B5C2401DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L04
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        near ptr M02_L06
       mov       rdx,[rdx+18]
       mov       rax,1B5C2401DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L05
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L06
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC301A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L05:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L07
M02_L06:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC301A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B50570
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC301A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC301A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EAF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC301ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EAF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2EE1C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3037F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B50578
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 951
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L02
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L09
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L03
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30545B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],38
       jle       short M03_L04
       jmp       short M03_L06
M03_L02:
       mov       rdx,1B5C2401DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L12
       jmp       short M03_L00
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFCC301E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC301E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rax,rdi
       cmp       [rax],rcx
       je        short M03_L08
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L07:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M03_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC301DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3155458]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC303EC88]
       mov       rax,rsi
       jmp       short M03_L08
M03_L12:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L15
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L13
       jmp       short M03_L14
M03_L13:
       mov       rcx,rsi
       mov       rdx,7FFCC301D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC303F828]
       mov       rax,rsi
       jmp       near ptr M03_L08
M03_L15:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L16
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       rdx,7FFCC301CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L17:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC303EC88]
       mov       rax,rsi
       jmp       near ptr M03_L08
; Total bytes of code 406
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2C94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,1B5C2400B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3019168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3031D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2C9F678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3019550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E4ED00]
       int       3
M09_L05:
       mov       rcx,1B5C2401DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+98],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L19
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L10
       imul      r15d,[rsp+98],0A5555529
       add       r15d,[rsp+9C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L11
M10_L02:
       mov       r14d,[rbp+8]
       cmp       r14d,eax
       ja        short M10_L07
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r13d,[rbx+38]
       cmp       r14d,r13d
       je        near ptr M10_L18
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L22
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+98]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[rbp+rcx*8+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r15d
       mov       [rsp+44],eax
       je        near ptr M10_L20
M10_L08:
       mov       eax,[r8+0C]
       inc       r13d
       cmp       r14d,r13d
       jb        near ptr M10_L17
       jmp       near ptr M10_L02
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,r14d
       jae       near ptr M10_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       rcx,r14
       mov       rdx,[rsp+98]
       mov       r11,7FFCC2B50568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L11:
       mov       ecx,[rbp+8]
       mov       r10d,ecx
       cmp       r10d,eax
       jbe       short M10_L14
       mov       ecx,r10d
       mov       r10,r14
       mov       r14d,ecx
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L16
       mov       [rsp+44],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       [rsp+30],r10
       mov       rcx,r10
       mov       r8,[rsp+98]
       mov       r11,7FFCC2B50560
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+30]
       je        short M10_L13
       cmp       dil,1
       mov       eax,[rsp+44]
       je        near ptr M10_L21
       cmp       dil,2
       jne       short M10_L15
M10_L12:
       mov       rcx,[rsp+98]
       call      qword ptr [7FFCC3037CC0]
       int       3
M10_L13:
       mov       eax,[rsp+44]
       jmp       short M10_L16
M10_L14:
       mov       r14d,r10d
       jmp       near ptr M10_L03
M10_L15:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L16:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       r14d,r13d
       mov       r14,r10
       jae       near ptr M10_L11
M10_L17:
       call      qword ptr [7FFCC2E4F000]
       int       3
M10_L18:
       mov       rcx,rbx
       call      qword ptr [7FFCC3036238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L19:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30361F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L20:
       mov       rcx,[r8+10]
       mov       [rsp+38],rcx
       lea       rcx,[rsp+38]
       mov       rdx,[rsp+98]
       call      qword ptr [7FFCC2EAEEC8]
       test      eax,eax
       mov       r8,[rsp+28]
       je        near ptr M10_L08
       mov       eax,[rsp+44]
       cmp       dil,1
       je        short M10_L21
       cmp       dil,2
       jne       near ptr M10_L15
       jmp       near ptr M10_L12
M10_L21:
       cmp       eax,r14d
       jae       short M10_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 758
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1B5C2401DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3036010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC305CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30702C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3036058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC2FF5CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2C943A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1A0B6C05C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A0B6C05C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A0B6C05C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC305B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC305BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC305BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CB4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC305C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30477B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC305BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC305C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B70538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E94F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E94F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B70540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2CB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,1A0B6C00B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2ECEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CBF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC305D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E6ED00]
       int       3
M07_L05:
       mov       rcx,1A0B6C01DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L07
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L08
M08_L02:
       cmp       [rbp+8],eax
       ja        near ptr M08_L10
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
M08_L03:
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M08_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B70530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L08:
       cmp       [rbp+8],eax
       ja        near ptr M08_L15
       cmp       dword ptr [rbx+40],0
       jle       near ptr M08_L03
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M08_L11
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2ECEA30]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       short M08_L12
M08_L11:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       mov       r14d,eax
       inc       r13d
       cmp       [rbp+8],r13d
       mov       eax,r14d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       dil,1
       jne       short M08_L14
M08_L13:
       cmp       eax,[rbp+8]
       jae       near ptr M08_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       dil,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L19
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B70528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L17
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M08_L13
       cmp       dil,2
       jne       short M08_L18
M08_L16:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC304C0C0]
       int       3
M08_L17:
       mov       eax,[rsp+34]
       jmp       short M08_L19
M08_L18:
       xor       eax,eax
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
M08_L19:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M08_L08
M08_L20:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,22063405C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3035EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3037E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3037EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22063405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3031D88
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22063405C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30175A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30189D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30373D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30181E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3017B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3017BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3017BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B505A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3017B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B505B0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,22063401DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L05
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        short M02_L04
       mov       rdx,[rdx+18]
       mov       rax,22063401DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L06
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L04
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L05:
       mov       rdx,7FFCC301A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M02_L04
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC301A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B50570
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC301A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC301A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EAF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC301ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EAF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2EE1C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3037F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B50578
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 947
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L00
       mov       rdx,22063401DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L10
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L06
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30545B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L05
M03_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC301E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L05:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC301E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L07:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC301DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3155458]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC303EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L10:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L13
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFCC301D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC303F828]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC301CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC303EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 402
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2C94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,22063400B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3019168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3031D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2C9F678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3019550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E4ED00]
       int       3
M09_L05:
       mov       rcx,22063401DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L22
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L07
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L08
M10_L02:
       cmp       [rbp+8],eax
       ja        near ptr M10_L10
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
M10_L03:
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L21
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B50568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L08:
       cmp       [rbp+8],eax
       ja        near ptr M10_L15
       cmp       dword ptr [rbx+40],0
       jle       near ptr M10_L03
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M10_L11
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EAEEC8]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       short M10_L12
M10_L11:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       mov       r14d,eax
       inc       r13d
       cmp       [rbp+8],r13d
       mov       eax,r14d
       jae       near ptr M10_L02
       jmp       near ptr M10_L20
M10_L12:
       cmp       dil,1
       jne       short M10_L14
M10_L13:
       cmp       eax,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L14:
       cmp       dil,2
       jne       short M10_L18
       jmp       short M10_L16
M10_L15:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L19
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B50560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L17
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M10_L13
       cmp       dil,2
       jne       short M10_L18
M10_L16:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3037CC0]
       int       3
M10_L17:
       mov       eax,[rsp+34]
       jmp       short M10_L19
M10_L18:
       xor       eax,eax
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
M10_L19:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L08
M10_L20:
       call      qword ptr [7FFCC2E4F000]
       int       3
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC3036238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30361F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,22063401DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3036010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC305CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30702C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3036058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC2FF5CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2C943A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; BenchmarkDotNet.Autogenerated.Runnable_142.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+14],0B
       jne       short M00_L00
;                 return Dictionary();
;                 ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC2ED4CA8]
       nop
       add       rsp,20
       pop       rbp
       ret
;             return default(System.Collections.Generic.Dictionary<Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.CustomKey, Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.MyClass>);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 49
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,1854D005C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3075EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3077E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3077EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1854D005C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3071D88
       call      qword ptr [7FFCC2CD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1854D005C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30575A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3057E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3057E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CD4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30589D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30773D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3057E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30581E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3077390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3057B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3075F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3057BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3057BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3076208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B905A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EB4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EB4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3057B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3075F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B905B0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,1854D001DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L05
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2CD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        short M02_L04
       mov       rdx,[rdx+18]
       mov       rax,1854D001DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L06
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L04
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3059F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L05:
       mov       rdx,7FFCC305A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M02_L04
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3075F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC305A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3076208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B90570
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC305A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC305A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3059F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EEF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC305ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3059F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EEF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2F21C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3077F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B90578
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 947
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L00
       mov       rdx,1854D001DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L10
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L06
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30945B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L05
M03_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC305E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L05:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CD43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC305E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L07:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC305DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3194B88]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC307EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L10:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L13
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFCC305D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC307F828]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC305CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC307EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 402
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2CD4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,1854D000B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3059168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3075F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3071D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3076208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CDF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3059550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E8ED00]
       int       3
M09_L05:
       mov       rcx,1854D001DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L20
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L09
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L07
M10_L02:
       cmp       [rbp+8],eax
       ja        near ptr M10_L21
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L08
M10_L03:
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L19
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       cmp       [rbp+8],eax
       ja        near ptr M10_L13
       cmp       dword ptr [rbx+40],0
       jle       short M10_L03
M10_L08:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L09:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B90568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L10:
       cmp       dil,1
       jne       short M10_L12
M10_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L12:
       cmp       dil,2
       jne       short M10_L16
       jmp       short M10_L14
M10_L13:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L17
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B90560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L15
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M10_L11
       cmp       dil,2
       jne       short M10_L16
M10_L14:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3077CC0]
       int       3
M10_L15:
       mov       eax,[rsp+34]
       jmp       short M10_L17
M10_L16:
       xor       eax,eax
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
M10_L17:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L07
M10_L18:
       call      qword ptr [7FFCC2E8F000]
       int       3
M10_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC3076238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M10_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30761F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L21:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M10_L22
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EEEEC8]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       near ptr M10_L10
M10_L22:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       mov       r14d,eax
       inc       r13d
       cmp       [rbp+8],r13d
       mov       eax,r14d
       jae       near ptr M10_L02
       jmp       near ptr M10_L18
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 733
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1854D001DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3076010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC309CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30B02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3076058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC3035CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2CD43A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1A213805C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3056868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A213805C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3052730
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A213805C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC306B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC306BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC306BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC306C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30577B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC306BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC306C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC306BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EDEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2CC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,1A213800B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC306D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3052730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2EDEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CCF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC306D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M07_L05:
       mov       rcx,1A213801DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L20
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L11
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L10
M08_L02:
       cmp       [rbp+8],eax
       ja        short M08_L07
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       edi,[rbx+38]
       cmp       [rbp+8],edi
       je        near ptr M08_L19
M08_L04:
       lea       ecx,[rdi+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       edi,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       [r12],edi
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M08_L21
M08_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M08_L18
       jmp       near ptr M08_L02
M08_L09:
       mov       ecx,[rbx+3C]
       mov       edi,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       cmp       [rbp+8],eax
       ja        short M08_L13
       jmp       near ptr M08_L03
M08_L11:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B80530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L13:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L17
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B80528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L15
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M08_L12
       cmp       dil,2
       jne       short M08_L16
M08_L14:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC305C0C0]
       int       3
M08_L15:
       mov       eax,[rsp+34]
       jmp       short M08_L17
M08_L16:
       xor       eax,eax
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
M08_L17:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M08_L10
M08_L18:
       call      qword ptr [7FFCC2E7F000]
       int       3
M08_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EDEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EDEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L21:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EDEA30]
       test      eax,eax
       je        near ptr M08_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        near ptr M08_L12
       cmp       dil,2
       jne       near ptr M08_L16
       jmp       near ptr M08_L14
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,28E1D405C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3045EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3047E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3047EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28E1D405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3041D88
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28E1D405C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30275A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3027E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3027E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CA4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30289D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30473D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3027E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30281E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3027B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3027BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3027BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3046208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B60598
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E84F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E84F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3027B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B605A0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,28E1D401DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L05
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        short M02_L04
       mov       rdx,[rdx+18]
       mov       rax,28E1D401DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L06
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L04
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3029F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L05:
       mov       rdx,7FFCC302A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M02_L04
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC302A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3046208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B605A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC302A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC302A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3029F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EBF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC302ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3029F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EBF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2EF1C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3047F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B605B0
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 947
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L00
       mov       rdx,28E1D401DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L10
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L06
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30645B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L05
M03_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC302E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L05:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC302E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L07:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC302DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC31650B0]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC304EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L10:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L13
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFCC302D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC304F828]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC302CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC304EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 402
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2CA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,28E1D400B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3029168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3041D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3046208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CAF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3029550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E5ED00]
       int       3
M09_L05:
       mov       rcx,28E1D401DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L18
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L10
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L21
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L11
M10_L02:
       cmp       [rbp+8],eax
       ja        short M10_L07
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L17
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L21
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M10_L19
M10_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M10_L16
       jmp       near ptr M10_L02
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L21
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B60568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L11:
       cmp       [rbp+8],eax
       jbe       near ptr M10_L03
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L15
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B60560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L13
       cmp       dil,1
       mov       eax,[rsp+34]
       je        near ptr M10_L20
       cmp       dil,2
       jne       short M10_L14
M10_L12:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3047CC0]
       int       3
M10_L13:
       mov       eax,[rsp+34]
       jmp       short M10_L15
M10_L14:
       xor       eax,eax
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
M10_L15:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L11
M10_L16:
       call      qword ptr [7FFCC2E5F000]
       int       3
M10_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC3046238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L21
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L18:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30461F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L19:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EBEEC8]
       test      eax,eax
       je        near ptr M10_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        short M10_L20
       cmp       dil,2
       jne       near ptr M10_L14
       jmp       near ptr M10_L12
M10_L20:
       cmp       eax,[rbp+8]
       jae       short M10_L21
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 715
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,28E1D401DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3046010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC306CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30802C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3046058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC3005CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2CA43A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,2707F405C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2707F405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2707F405C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC305B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC305BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC305BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CB4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC305C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30477B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC305BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC305C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B70538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E94F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E94F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC305BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B70540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2CB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,2707F400B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2ECEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2ECEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CBF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC305D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E6ED00]
       int       3
M07_L05:
       mov       rcx,2707F401DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L20
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L11
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L10
M08_L02:
       cmp       [rbp+8],eax
       ja        short M08_L07
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       edi,[rbx+38]
       cmp       [rbp+8],edi
       je        near ptr M08_L19
M08_L04:
       lea       ecx,[rdi+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       edi,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       [r12],edi
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M08_L21
M08_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M08_L18
       jmp       near ptr M08_L02
M08_L09:
       mov       ecx,[rbx+3C]
       mov       edi,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       cmp       [rbp+8],eax
       ja        short M08_L13
       jmp       near ptr M08_L03
M08_L11:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B70530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L13:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L17
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B70528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L15
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M08_L12
       cmp       dil,2
       jne       short M08_L16
M08_L14:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC304C0C0]
       int       3
M08_L15:
       mov       eax,[rsp+34]
       jmp       short M08_L17
M08_L16:
       xor       eax,eax
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
M08_L17:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M08_L10
M08_L18:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L21:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2ECEA30]
       test      eax,eax
       je        near ptr M08_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        near ptr M08_L12
       cmp       dil,2
       jne       near ptr M08_L16
       jmp       near ptr M08_L14
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,217BF005C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3035EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3037E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3037EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,217BF005C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3031D88
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,217BF005C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30175A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30189D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30373D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3017E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30181E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3017B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3017BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3017BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B505A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3017B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B505B0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,217BF001DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L04
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        near ptr M02_L06
       mov       rdx,[rdx+18]
       mov       rax,217BF001DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L05
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L06
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC301A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L05:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L07
M02_L06:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC301A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B50570
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC301A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC301A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EAF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC301ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3019F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EAF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2EE1C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3037F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B50578
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 951
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L02
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L09
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L03
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30545B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],38
       jle       short M03_L04
       jmp       short M03_L06
M03_L02:
       mov       rdx,217BF001DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L12
       jmp       short M03_L00
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFCC301E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC301E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rax,rdi
       cmp       [rax],rcx
       je        short M03_L08
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L07:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M03_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC301DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3155458]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC303EC88]
       mov       rax,rsi
       jmp       short M03_L08
M03_L12:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L15
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L13
       jmp       short M03_L14
M03_L13:
       mov       rcx,rsi
       mov       rdx,7FFCC301D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC303F828]
       mov       rax,rsi
       jmp       near ptr M03_L08
M03_L15:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L16
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       rdx,7FFCC301CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L17:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC303EC88]
       mov       rax,rsi
       jmp       near ptr M03_L08
; Total bytes of code 406
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2C94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,217BF000B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3019168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3035F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3031D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3036208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2C9F678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3019550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E4ED00]
       int       3
M09_L05:
       mov       rcx,217BF001DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L20
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L11
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L10
M10_L02:
       cmp       [rbp+8],eax
       ja        short M10_L07
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       edi,[rbx+38]
       cmp       [rbp+8],edi
       je        near ptr M10_L19
M10_L04:
       lea       ecx,[rdi+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       edi,[rbp+8]
       jae       near ptr M10_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       [r12],edi
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M10_L21
M10_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M10_L18
       jmp       near ptr M10_L02
M10_L09:
       mov       ecx,[rbx+3C]
       mov       edi,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       cmp       [rbp+8],eax
       ja        short M10_L13
       jmp       near ptr M10_L03
M10_L11:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B50568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M10_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L13:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L17
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B50560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L15
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M10_L12
       cmp       dil,2
       jne       short M10_L16
M10_L14:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3037CC0]
       int       3
M10_L15:
       mov       eax,[rsp+34]
       jmp       short M10_L17
M10_L16:
       xor       eax,eax
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
M10_L17:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L10
M10_L18:
       call      qword ptr [7FFCC2E4F000]
       int       3
M10_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC3036238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30361F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L21:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EAEEC8]
       test      eax,eax
       je        near ptr M10_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        near ptr M10_L12
       cmp       dil,2
       jne       near ptr M10_L16
       jmp       near ptr M10_L14
M10_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,217BF001DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3036010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC305CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30702C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3036058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC2FF5CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2C943A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,12A96805C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3056868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,12A96805C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3052730
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,12A96805C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC306B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC306BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC306BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC306C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30577B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC306BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC306C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC306BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EDEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2CC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,12A96800B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC306D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3052730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2EDEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CCF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC306D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M07_L05:
       mov       rcx,12A96801DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L16
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L09
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L07
M08_L02:
       cmp       [rbp+8],eax
       ja        near ptr M08_L21
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L08
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M08_L17
M08_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M08_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       cmp       [rbp+8],eax
       ja        near ptr M08_L18
       jmp       near ptr M08_L03
M08_L08:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L09:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B80530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L10:
       cmp       dil,1
       jne       short M08_L12
M08_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M08_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L12:
       cmp       dil,2
       je        near ptr M08_L19
M08_L13:
       xor       eax,eax
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
M08_L14:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M08_L07
M08_L15:
       call      qword ptr [7FFCC2E7F000]
       int       3
M08_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EDEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EDEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M08_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L18:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L14
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B80528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L20
       cmp       dil,1
       mov       eax,[rsp+34]
       je        near ptr M08_L11
       cmp       dil,2
       jne       near ptr M08_L13
M08_L19:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC305C0C0]
       int       3
M08_L20:
       mov       eax,[rsp+34]
       jmp       near ptr M08_L14
M08_L21:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M08_L22
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EDEA30]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       near ptr M08_L10
M08_L22:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       mov       r14d,eax
       inc       r13d
       cmp       [rbp+8],r13d
       mov       eax,r14d
       jae       near ptr M08_L02
       jmp       near ptr M08_L15
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 745
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,22E03405C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3065EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3067E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3067EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22E03405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3061D88
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22E03405C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30475A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30489D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30673D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30481E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3047B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3047BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3047BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B805A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3047B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B805B0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,22E03401DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L04
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        near ptr M02_L06
       mov       rdx,[rdx+18]
       mov       rax,22E03401DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L05
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L06
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC304A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L05:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L07
M02_L06:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC304A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B80570
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC304A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC304A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EDF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC304ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EDF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2F11C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3067F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B80578
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 951
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L00
       mov       rdx,22E03401DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L10
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L06
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30845B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L05
M03_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC304E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L05:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC304E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L07:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC304DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3185458]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC306EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L10:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L13
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFCC304D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC306F828]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC304CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC306EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 402
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2CC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,22E03400B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3049168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3061D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       short M09_L01
       mov       ecx,edx
       call      qword ptr [7FFCC2CCF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L03
       mov       rcx,rax
M09_L00:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L01:
       test      rsi,rsi
       jne       short M09_L05
M09_L02:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L03:
       mov       rdx,7FFCC3049550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M09_L00
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M09_L05:
       mov       rcx,22E03401DF0
       cmp       rsi,[rcx]
       je        short M09_L02
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L02
; Total bytes of code 229
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L22
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L07
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L23
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L08
M10_L02:
       cmp       [rbp+8],eax
       ja        near ptr M10_L10
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
M10_L03:
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L21
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B80568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L08:
       cmp       [rbp+8],eax
       ja        near ptr M10_L15
       cmp       dword ptr [rbx+40],0
       jle       near ptr M10_L03
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       cmp       [rbp+rcx*8+18],r15d
       jne       short M10_L11
       mov       [rsp+34],eax
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       mov       rcx,[rbp+rcx*8+20]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EDEEC8]
       test      eax,eax
       mov       eax,[rsp+34]
       jne       short M10_L12
M10_L11:
       mov       eax,eax
       lea       rcx,[rax+rax*2]
       mov       eax,[rbp+rcx*8+1C]
       mov       r14d,eax
       inc       r13d
       cmp       [rbp+8],r13d
       mov       eax,r14d
       jae       near ptr M10_L02
       jmp       near ptr M10_L20
M10_L12:
       cmp       dil,1
       jne       short M10_L14
M10_L13:
       cmp       eax,[rbp+8]
       jae       near ptr M10_L23
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L14:
       cmp       dil,2
       jne       short M10_L18
       jmp       short M10_L16
M10_L15:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L19
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B80560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L17
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M10_L13
       cmp       dil,2
       jne       short M10_L18
M10_L16:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3067CC0]
       int       3
M10_L17:
       mov       eax,[rsp+34]
       jmp       short M10_L19
M10_L18:
       xor       eax,eax
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
M10_L19:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L08
M10_L20:
       call      qword ptr [7FFCC2E7F000]
       int       3
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC3066238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30661F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,22E03401DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3066010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC308CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30A02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3066058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC3025CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2CC43A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1F4DF405C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3026868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F4DF405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3022730
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F4DF405C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC303B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2C94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC303BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC303BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC303C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30277B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC303BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2C94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC303C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3027768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC303BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EAEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC303BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC303BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EAEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B50538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E74F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC303BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EAEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B50540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2C94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,1F4DF400B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC303D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2EAEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3022730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2EAEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2C9F678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC303D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E4ED00]
       int       3
M07_L05:
       mov       rcx,1F4DF401DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L20
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L11
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L10
M08_L02:
       cmp       [rbp+8],eax
       ja        short M08_L07
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       edi,[rbx+38]
       cmp       [rbp+8],edi
       je        near ptr M08_L19
M08_L04:
       lea       ecx,[rdi+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       edi,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       [r12],edi
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M08_L21
M08_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M08_L18
       jmp       near ptr M08_L02
M08_L09:
       mov       ecx,[rbx+3C]
       mov       edi,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       cmp       [rbp+8],eax
       ja        short M08_L13
       jmp       near ptr M08_L03
M08_L11:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B50530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L13:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L17
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B50528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L15
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M08_L12
       cmp       dil,2
       jne       short M08_L16
M08_L14:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC302C0C0]
       int       3
M08_L15:
       mov       eax,[rsp+34]
       jmp       short M08_L17
M08_L16:
       xor       eax,eax
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
M08_L17:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M08_L10
M08_L18:
       call      qword ptr [7FFCC2E4F000]
       int       3
M08_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EAEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EAEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L21:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EAEA30]
       test      eax,eax
       je        near ptr M08_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        near ptr M08_L12
       cmp       dil,2
       jne       near ptr M08_L16
       jmp       near ptr M08_L14
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,1D909405C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3065EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3067E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3067EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D909405C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3061D88
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D909405C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30475A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30489D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30673D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3047E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30481E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3047B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3047BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3047BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80598
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3047B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B805A0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,1D909401DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L05
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        short M02_L04
       mov       rdx,[rdx+18]
       mov       rax,1D909401DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L06
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L04
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L05:
       mov       rdx,7FFCC304A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M02_L04
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC304A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B805A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC304A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC304A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EDF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC304ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3049F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EDF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2F11C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3067F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B805B0
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 947
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M03_L02
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L09
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L03
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30845B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],38
       jle       short M03_L04
       jmp       short M03_L06
M03_L02:
       mov       rdx,1D909401DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L12
       jmp       short M03_L00
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFCC304E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC304E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L05:
       mov       rax,rdi
       cmp       [rax],rcx
       je        short M03_L08
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbp+38]
       test      rcx,rcx
       je        short M03_L04
       jmp       short M03_L05
M03_L07:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M03_L08:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC304DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3185470]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC306EC88]
       mov       rax,rsi
       jmp       short M03_L08
M03_L12:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L15
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L13
       jmp       short M03_L14
M03_L13:
       mov       rcx,rsi
       mov       rdx,7FFCC304D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC306F828]
       mov       rax,rsi
       jmp       near ptr M03_L08
M03_L15:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L16
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       rdx,7FFCC304CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L17:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC306EC88]
       mov       rax,rsi
       jmp       near ptr M03_L08
; Total bytes of code 406
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2CC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M06_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M06_L01
M06_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       r8,1D909400B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L04
M06_L03:
       test      ebx,ebx
       je        short M06_L06
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L02
       jmp       short M06_L06
M06_L04:
       cmp       ebx,[r11]
       jne       short M06_L06
M06_L05:
       cmp       esi,1
       je        near ptr M06_L00
       test      esi,esi
       jne       short M06_L07
       xor       edx,edx
       jmp       near ptr M06_L00
M06_L06:
       mov       esi,2
       jmp       short M06_L05
M06_L07:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 176
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3049168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3065F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3061D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3066208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CCF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3049550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M09_L05:
       mov       rcx,1D909401DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L18
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L10
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L21
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L11
M10_L02:
       cmp       [rbp+8],eax
       ja        short M10_L07
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L17
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L21
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M10_L19
M10_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M10_L16
       jmp       near ptr M10_L02
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L21
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B80568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L11:
       cmp       [rbp+8],eax
       jbe       near ptr M10_L03
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L15
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B80560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L13
       cmp       dil,1
       mov       eax,[rsp+34]
       je        near ptr M10_L20
       cmp       dil,2
       jne       short M10_L14
M10_L12:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3067CC0]
       int       3
M10_L13:
       mov       eax,[rsp+34]
       jmp       short M10_L15
M10_L14:
       xor       eax,eax
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
M10_L15:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L11
M10_L16:
       call      qword ptr [7FFCC2E7F000]
       int       3
M10_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC3066238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L21
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L18:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30661F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L19:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EDEEC8]
       test      eax,eax
       je        near ptr M10_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        short M10_L20
       cmp       dil,2
       jne       near ptr M10_L14
       jmp       near ptr M10_L12
M10_L20:
       cmp       eax,[rbp+8]
       jae       short M10_L21
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 715
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1D909401DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3066010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC308CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30A02C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3066058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC3025CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2CC43A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.Dictionary()
;     public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,23211005C50
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3056868]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,23211005C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3052730
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23211005C50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC306B4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC306BD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC306BD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC306C910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30577B0]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC306BDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC306C118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057768]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC306BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EDEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80538
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2EA4F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC306BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B80540
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
M03_L00:
       cmp       [r10],rcx
       je        short M03_L04
       cmp       [r10+8],rcx
       je        short M03_L04
       cmp       [r10+10],rcx
       je        short M03_L04
       cmp       [r10+18],rcx
       je        short M03_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L02
M03_L01:
       cmp       [r10],rcx
       je        short M03_L04
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L01
M03_L02:
       test      dword ptr [rax],406C0000
       je        short M03_L03
       jmp       qword ptr [7FFCC2CC4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L03:
       xor       edx,edx
M03_L04:
       mov       rax,rdx
       ret
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       r8,[rdx]
       cmp       r8,rcx
       jne       short M04_L02
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L02:
       mov       rax,23211000B50
       mov       rax,[rax]
       add       rax,10
       rorx      r10,r8,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[rax]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L03:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rax+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,r8
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
       jmp       short M04_L06
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[rax+4]
       cmp       r9d,8
       jl        short M04_L03
M04_L05:
       mov       esi,2
M04_L06:
       cmp       esi,1
       je        near ptr M04_L00
       test      esi,esi
       jne       near ptr M04_L01
       xor       edx,edx
       jmp       near ptr M04_L00
; Total bytes of code 178
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC306D0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M05_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC2EDEC28]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3052730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M05_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC2EDEEF8]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M05_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       jne       short M06_L01
M06_L00:
       ret
M06_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M06_L02:
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M06_L04
       test      rdx,rdx
       je        short M06_L03
       mov       rdx,[rdx+10]
       jmp       short M06_L02
M06_L03:
       xor       eax,eax
M06_L04:
       ret
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M07_L04
       test      edx,edx
       jle       near ptr M07_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CCF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC306D470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       test      rsi,rsi
       jne       short M07_L05
M07_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M07_L05:
       mov       rcx,23211001DF0
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L20
M08_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M08_L11
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M08_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M08_L22
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M08_L10
M08_L02:
       cmp       [rbp+8],eax
       ja        short M08_L07
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       edi,[rbx+38]
       cmp       [rbp+8],edi
       je        near ptr M08_L19
M08_L04:
       lea       ecx,[rdi+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M08_L05:
       cmp       edi,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       [r12],edi
       inc       dword ptr [rbx+44]
M08_L06:
       mov       eax,1
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
M08_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M08_L21
M08_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M08_L18
       jmp       near ptr M08_L02
M08_L09:
       mov       ecx,[rbx+3C]
       mov       edi,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L22
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       cmp       [rbp+8],eax
       ja        short M08_L13
       jmp       near ptr M08_L03
M08_L11:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B80530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M08_L01
M08_L12:
       cmp       eax,[rbp+8]
       jae       near ptr M08_L22
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L13:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M08_L17
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B80528
       call      qword ptr [r11]
       test      eax,eax
       je        short M08_L15
       cmp       dil,1
       mov       eax,[rsp+34]
       je        short M08_L12
       cmp       dil,2
       jne       short M08_L16
M08_L14:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC305C0C0]
       int       3
M08_L15:
       mov       eax,[rsp+34]
       jmp       short M08_L17
M08_L16:
       xor       eax,eax
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
M08_L17:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M08_L10
M08_L18:
       call      qword ptr [7FFCC2E7F000]
       int       3
M08_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EDEF28]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L22
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M08_L04
M08_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EDEEE0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L21:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EDEA30]
       test      eax,eax
       je        near ptr M08_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        near ptr M08_L12
       cmp       dil,2
       jne       near ptr M08_L16
       jmp       near ptr M08_L14
M08_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create.FrozenDictionary()
;     public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,21B7F005C58
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3045EA8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,MyClass>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3047E70]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<CustomKey,MyClass>)
       call      qword ptr [7FFCC3047EB8]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+MyClass, Benchmark],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,21B7F005C40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3041D88
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21B7F005C58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-70],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       test      rdi,rdi
       je        near ptr M01_L22
       test      rsi,rsi
       je        near ptr M01_L23
       xor       r15d,r15d
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rbx
       mov       rdx,7FFCC30275A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],38
       jle       short M01_L02
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFCC3027E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r13
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],40
       jle       short M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFCC3027E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,r13
       call      qword ptr [7FFCC2CA4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],58
       jle       short M01_L06
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rbx
       mov       rdx,7FFCC30289D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC30473D8]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
M01_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],48
       jle       short M01_L09
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FFCC3027E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdx,r13
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M01_L13
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+10],50
       jle       short M01_L11
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FFCC30281E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047390]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC3027B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       [rbp-58],r13
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC3027BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-60],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3027BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-60]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-48],rax
       mov       r13,[rbp-58]
       mov       rcx,r13
       mov       rdx,[rbp-48]
       mov       [rbp-50],rdx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC3046208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B60598
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,10
       call      qword ptr [7FFCC2E84F30]
       int       3
M01_L23:
       mov       ecx,9
       call      qword ptr [7FFCC2E84F30]
       int       3
M01_L24:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rbx
       mov       rdx,7FFCC3027B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-60],0
       je        short M01_L28
       mov       rcx,[rbp-60]
       mov       r11,7FFCC2B605A0
       call      qword ptr [r11]
M01_L28:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 885
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<CustomKey,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<CustomKey>, System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon> ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rdx,21B7F001DF0
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L03
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L25
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M02_L05
M02_L02:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M02_L07
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        short M02_L04
       mov       rdx,[rdx+18]
       mov       rax,21B7F001DF0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]]
       cmp       rax,r8
       jne       short M02_L06
       cmp       qword ptr [rbp+20],0
       je        short M02_L07
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L04
       jmp       short M02_L07
M02_L03:
       mov       rdx,7FFCC3029F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L16
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L05:
       mov       rdx,7FFCC302A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M02_L04
M02_L07:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L14
M02_L08:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-38],rax
       jmp       short M02_L13
M02_L10:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rax
       mov       rdx,7FFCC302A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9d,[rbp-1C]
       mov       rax,[rbp-28]
       cmp       [rdx],dl
       mov       [rbp-30],r8d
       mov       [rbp-2C],r9d
       mov       rcx,rdx
       mov       rdx,[rbp-30]
       mov       r8,rax
       mov       r9d,1
       call      qword ptr [7FFCC3046208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-38]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B605A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC302A428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC302A510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rax
       mov       rdx,7FFCC3029F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EBF120]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L21
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L19
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rcx,rax
       mov       rdx,7FFCC302ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L20:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L21:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L22
       jmp       short M02_L23
M02_L22:
       mov       rcx,rax
       mov       rdx,7FFCC3029F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EBF120]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2EF1C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3047F60]
       int       3
M02_L25:
       mov       rcx,[rsi+8]
       mov       rdx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M02_L01
       xor       eax,eax
       mov       rcx,[rbp+28]
       mov       [rcx],rax
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L26:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-38],0
       je        short M02_L27
       mov       rcx,[rbp-38]
       mov       r11,7FFCC2B605B0
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 947
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L00
       mov       rdx,21B7F001DF0
       cmp       rcx,[rdx]
       jne       near ptr M03_L10
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L06
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC30645B8]; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L04
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L05
M03_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC302E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L05:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC302E670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L07:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC302DE20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC3164258]
       mov       r8d,eax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC304EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L10:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L13
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L11
       jmp       short M03_L12
M03_L11:
       mov       rcx,rsi
       mov       rdx,7FFCC302D688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC304F828]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L13:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC302CF50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC304EC88]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 402
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD022F1D30]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFD02300870]
       int       3
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
M05_L00:
       cmp       [r10],rcx
       je        short M05_L03
       cmp       [r10+8],rcx
       je        short M05_L03
       cmp       [r10+10],rcx
       je        short M05_L03
       cmp       [r10+18],rcx
       je        short M05_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L00
       test      r8,r8
       je        short M05_L02
M05_L01:
       cmp       [r10],rcx
       je        short M05_L03
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L01
M05_L02:
       test      dword ptr [rax],406C0000
       jne       short M05_L04
       xor       edx,edx
M05_L03:
       mov       rax,rdx
       ret
M05_L04:
       jmp       qword ptr [7FFCC2CA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        near ptr M06_L04
       mov       rax,[rdx]
       cmp       rax,rcx
       je        near ptr M06_L04
       mov       r8,21B7F000B50
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L01
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M06_L02
M06_L01:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L02:
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L03:
       cmp       esi,1
       je        short M06_L04
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
M06_L04:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       esi,2
       jmp       short M06_L03
M06_L06:
       pop       rbx
       pop       rsi
       jmp       near ptr System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 175
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.__Canon[], System.Func`2<System.__Canon,CustomKey>, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3029168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M07_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       mov       r8,rdi
       call      qword ptr [7FFCC3045F38]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       r15d,edi
       mov       rdx,[rbx+r15*8+10]
       mov       rcx,7FFCC3041D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       ecx,[rdx+0C]
       mov       [rsp+28],ecx
       mov       ecx,[rdx+10]
       mov       [rsp+2C],ecx
M07_L03:
       mov       r8,[rbx+r15*8+10]
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       mov       r9d,2
       call      qword ptr [7FFCC3046208]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rsp+28],rax
       jmp       short M07_L03
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       jne       short M08_L01
M08_L00:
       ret
M08_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M08_L02:
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       jne       short M08_L05
M08_L03:
       xor       eax,eax
M08_L04:
       ret
M08_L05:
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M08_L04
       test      rdx,rdx
       je        short M08_L03
       mov       rdx,[rdx+10]
       jmp       short M08_L02
; Total bytes of code 82
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<CustomKey>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       test      edx,edx
       jl        near ptr M09_L04
       test      edx,edx
       jle       near ptr M09_L02
       mov       ecx,edx
       call      qword ptr [7FFCC2CAF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3029550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M09_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L02:
       test      rsi,rsi
       jne       short M09_L05
M09_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E5ED00]
       int       3
M09_L05:
       mov       rcx,21B7F001DF0
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].TryInsert(CustomKey, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+88],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L18
M10_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       test      r14,r14
       jne       near ptr M10_L10
       imul      r15d,[rsp+88],0A5555529
       add       r15d,[rsp+8C]
M10_L01:
       xor       r13d,r13d
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L21
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       test      r14,r14
       jne       near ptr M10_L11
M10_L02:
       cmp       [rbp+8],eax
       ja        short M10_L07
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r13d,[rbx+38]
       cmp       [rbp+8],r13d
       je        near ptr M10_L17
M10_L04:
       lea       ecx,[r13+1]
       mov       [rbx+38],ecx
       mov       rbp,[rbx+10]
M10_L05:
       cmp       r13d,[rbp+8]
       jae       near ptr M10_L21
       mov       ecx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       [rcx+8],r15d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,[rsp+88]
       mov       [rcx+10],rdx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       [r12],r13d
       inc       dword ptr [rbx+44]
M10_L06:
       mov       eax,1
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
M10_L07:
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rbp+rcx*8+10]
       cmp       [r14+8],r15d
       mov       [rsp+34],eax
       je        near ptr M10_L19
M10_L08:
       mov       eax,[r14+0C]
       inc       r13d
       cmp       [rbp+8],r13d
       jb        near ptr M10_L16
       jmp       near ptr M10_L02
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r13d,ecx
       cmp       ecx,[rbp+8]
       jae       near ptr M10_L21
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rbp+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       rcx,r14
       mov       rdx,[rsp+88]
       mov       r11,7FFCC2B60568
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L01
M10_L11:
       cmp       [rbp+8],eax
       jbe       near ptr M10_L03
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       cmp       [rbp+rdx*8+18],r15d
       jne       short M10_L15
       mov       [rsp+34],eax
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rbp+rdx*8+20]
       mov       rcx,r14
       mov       r8,[rsp+88]
       mov       r11,7FFCC2B60560
       call      qword ptr [r11]
       test      eax,eax
       je        short M10_L13
       cmp       dil,1
       mov       eax,[rsp+34]
       je        near ptr M10_L20
       cmp       dil,2
       jne       short M10_L14
M10_L12:
       mov       rcx,[rsp+88]
       call      qword ptr [7FFCC3047CC0]
       int       3
M10_L13:
       mov       eax,[rsp+34]
       jmp       short M10_L15
M10_L14:
       xor       eax,eax
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
M10_L15:
       mov       eax,eax
       lea       rax,[rax+rax*2]
       mov       eax,[rbp+rax*8+1C]
       inc       r13d
       cmp       [rbp+8],r13d
       jae       near ptr M10_L11
M10_L16:
       call      qword ptr [7FFCC2E5F000]
       int       3
M10_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC3046238]
       mov       rax,[rbx+8]
       mov       ecx,r15d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L21
       mov       ecx,ecx
       lea       r12,[rax+rcx*4+10]
       jmp       near ptr M10_L04
M10_L18:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC30461F0]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L19:
       mov       rcx,[r14+10]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,[rsp+88]
       call      qword ptr [7FFCC2EBEEC8]
       test      eax,eax
       je        near ptr M10_L08
       mov       eax,[rsp+34]
       cmp       dil,1
       je        short M10_L20
       cmp       dil,2
       jne       near ptr M10_L14
       jmp       near ptr M10_L12
M10_L20:
       cmp       eax,[rbp+8]
       jae       short M10_L21
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rbp+rcx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 715
```
```assembly
; System.Collections.Frozen.SmallValueTypeDefaultComparerFrozenDictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<CustomKey,System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,21B7F001DF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3046010]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC306CF00]; System.Linq.Enumerable.ToArray[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark]](System.Collections.Generic.IEnumerable`1<CustomKey>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdi,[rdx+18]
       test      rdi,rdi
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC30802C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdi,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3046058]; System.Collections.Generic.Dictionary`2[[Benchmark.Benchmarks.SmallCollection_CustomValueTypeKey_Create+CustomKey, Benchmark],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCC3005CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M12_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       jmp       qword ptr [7FFCC2CA43A8]
M12_L03:
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       je        short M12_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M12_L01
       test      r8,r8
       jne       short M12_L00
       jmp       short M12_L02
; Total bytes of code 71
```

