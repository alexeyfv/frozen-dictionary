## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,21394C05C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,21394C05C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21394C05C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC305B320
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
       mov       rdx,7FFCC305BBB0
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
       mov       rdx,7FFCC305BBC8
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
       mov       rdx,7FFCC305C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC305BBE8
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
       mov       rdx,7FFCC305BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70520
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
; Total bytes of code 877
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
       mov       rax,21394C00B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305CEE8
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
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3125600
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
       mov       rcx,21394C01DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L08
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L07
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L10
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M08_L15
       mov       r15d,r10d
       jmp       near ptr M08_L03
M08_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B70510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L12
M08_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       bpl,1
       jne       short M08_L14
M08_L13:
       cmp       r8d,r15d
       jae       near ptr M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       bpl,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M08_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B70508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M08_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M08_L13
       cmp       bpl,2
       jne       short M08_L18
M08_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC316DD40]
       int       3
M08_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M08_L07
M08_L20:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 698
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,1C2E5C05C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3045E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3047B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3047B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C2E5C05C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3041D88
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C2E5C05C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30273E8
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
       mov       rdx,7FFCC3027C78
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
       mov       rdx,7FFCC3027C90
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
       mov       rdx,7FFCC3028818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3027CB0
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
       mov       rdx,7FFCC3028020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30279D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30279F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3027A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30279D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       je        near ptr M02_L25
       mov       rdx,1C2E5C01DE8
       cmp       qword ptr [rbp+20],0
       mov       rdx,[rdx]
       cmovne    rdx,[rbp+20]
       mov       [rbp+20],rdx
       mov       rdx,[rcx+10]
       mov       r8,[rdx+18]
       test      r8,r8
       je        near ptr M02_L04
M02_L00:
       mov       rcx,r8
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L26
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
       je        near ptr M02_L08
       mov       rax,rdx
       mov       r8d,[rax+38]
       sub       r8d,[rax+40]
       je        near ptr M02_L07
       mov       rdx,[rdx+18]
       test      rdx,rdx
       jne       short M02_L03
       mov       rdx,1C2E5C01DE8
       mov       rdx,[rdx]
M02_L03:
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
       cmp       rax,r8
       jne       short M02_L06
       cmp       qword ptr [rbp+20],0
       je        short M02_L08
       mov       rdx,[rdx]
       mov       rax,[rbp+20]
       cmp       rdx,[rax]
       je        short M02_L07
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFCC3029B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rdx
       mov       rdx,[rbp+20]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M02_L08
M02_L07:
       mov       rcx,[rbp+28]
       mov       rax,[rcx]
       mov       ecx,[rax+38]
       sub       ecx,[rax+40]
       je        near ptr M02_L17
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L08:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M02_L15
M02_L09:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rbp+20]
       xor       edx,edx
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp+28]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M02_L16
M02_L10:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       jmp       short M02_L14
M02_L11:
       mov       rax,[rbp+10]
       mov       rdx,[rax+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rax
       mov       rdx,7FFCC3029C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L14:
       mov       rcx,rax
       mov       r11,7FFCC2B60558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L11
       mov       rcx,rsp
       call      M02_L27
       jmp       near ptr M02_L07
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3029B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L09
M02_L16:
       mov       rcx,rax
       mov       rdx,7FFCC3029C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L17:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rax
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       call      qword ptr [7FFCC2EBEF88]
       mov       rcx,[rax+8]
       cmp       rcx,[rbp+20]
       je        short M02_L22
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L20
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rax
       mov       rdx,7FFCC302A4C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
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
M02_L22:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rax
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L24:
       call      qword ptr [7FFCC2EBEF88]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L25:
       mov       ecx,65B
       mov       rdx,7FFCC2EF1C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3047C00]
       int       3
M02_L26:
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
M02_L27:
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-30],0
       je        short M02_L28
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B60560
       call      qword ptr [r11]
M02_L28:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 939
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       je        short M03_L00
       mov       rdx,1C2E5C01DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L14
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M03_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L04
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3065ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L05
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L05
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L06
M03_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC302E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFCC302D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L06:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L07:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC302CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC302D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3064C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L12
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC302D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CA43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L03
M03_L14:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L17
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L15
       jmp       short M03_L16
M03_L15:
       mov       rcx,rsi
       mov       rdx,7FFCC302CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC304F918]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L17:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rsi
       mov       rdx,7FFCC302C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC304ED78]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 499
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
       mov       r8,1C2E5C00B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3028FB0
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
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3041D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3125490
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
       mov       rcx,1C2E5C01DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L12
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L07
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L08
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L10
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L13
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B60550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L08:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M10_L17
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L14
M10_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L22
M10_L12:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3046190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L13:
       mov       rcx,rbx
       call      qword ptr [7FFCC30461D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L14:
       cmp       bpl,1
       jne       short M10_L16
M10_L15:
       cmp       r8d,r15d
       jae       near ptr M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L16:
       cmp       bpl,2
       jne       short M10_L20
       jmp       short M10_L18
M10_L17:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M10_L21
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B60548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M10_L19
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M10_L15
       cmp       bpl,2
       jne       short M10_L20
M10_L18:
       mov       ecx,esi
       call      qword ptr [7FFCC315E100]
       int       3
M10_L19:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
       jmp       short M10_L21
M10_L20:
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
M10_L21:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M10_L08
M10_L22:
       call      qword ptr [7FFCC2E5F000]
       int       3
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 702
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1C2E5C01DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3045FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3066820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC302F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3045FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3005CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC302F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3066B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CA43A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,27151005C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27151005C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27151005C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC305B320
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
       mov       rdx,7FFCC305BBB0
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
       mov       rdx,7FFCC305BBC8
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
       mov       rdx,7FFCC305C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC305BBE8
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
       mov       rdx,7FFCC305BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70520
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
; Total bytes of code 877
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
       mov       rax,27151000B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305CEE8
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
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3125600
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
       mov       rcx,27151001DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L08
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L07
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L10
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M08_L15
       mov       r15d,r10d
       jmp       near ptr M08_L03
M08_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B70510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L12
M08_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       bpl,1
       jne       short M08_L14
M08_L13:
       cmp       r8d,r15d
       jae       near ptr M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       bpl,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M08_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B70508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M08_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M08_L13
       cmp       bpl,2
       jne       short M08_L18
M08_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC316DD40]
       int       3
M08_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M08_L07
M08_L20:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 698
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,1FB3DC05C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3065E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3067B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3067B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1FB3DC05C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3061D88
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FB3DC05C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30473E8
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
       mov       rdx,7FFCC3047C78
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
       mov       rdx,7FFCC3047C90
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
       mov       rdx,7FFCC3048818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3047CB0
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
       mov       rdx,7FFCC3048020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30479D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30479F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3047A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30479D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,1FB3DC01DE8
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
       mov       rax,1FB3DC01DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC3049B20
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
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3049C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B80558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3049B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3049C08
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EDEF88]
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
       mov       rdx,7FFCC304A4C8
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EDEF88]
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
       call      qword ptr [7FFCC3067C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B80560
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 938
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       jne       short M03_L04
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L09
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M03_L05
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L05
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3085ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L06
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L06
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L08
M03_L03:
       jmp       short M03_L07
M03_L04:
       mov       rdx,1FB3DC01DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L16
       jmp       short M03_L00
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFCC304E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC304D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L08:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L09:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC304CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L11:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC304D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3084C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L14
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC304D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L07
M03_L16:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L19
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,7FFCC304CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L18:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC306F918]
       mov       rax,rsi
       jmp       near ptr M03_L07
M03_L19:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFCC304C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L21:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC306ED78]
       mov       rax,rsi
       jmp       near ptr M03_L07
; Total bytes of code 503
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
       mov       r8,1FB3DC00B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3048FB0
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
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3061D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
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
       mov       rdx,7FFCC3145490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M09_L00
M09_L04:
       mov       ecx,16
       call      qword ptr [7FFCC2E7ED00]
       int       3
M09_L05:
       mov       rcx,1FB3DC01DE8
       cmp       rsi,[rcx]
       je        short M09_L02
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L02
; Total bytes of code 229
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L20
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L09
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L07
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L21
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L08
M10_L03:
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L19
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M10_L13
       cmp       dword ptr [rbx+40],0
       mov       r15d,r10d
       jle       near ptr M10_L03
M10_L08:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L09:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B80550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L10:
       cmp       bpl,1
       jne       short M10_L12
M10_L11:
       cmp       r8d,r15d
       jae       near ptr M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L12:
       cmp       bpl,2
       jne       short M10_L16
       jmp       short M10_L14
M10_L13:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M10_L17
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B80548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M10_L15
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M10_L11
       cmp       bpl,2
       jne       short M10_L16
M10_L14:
       mov       ecx,esi
       call      qword ptr [7FFCC317DD40]
       int       3
M10_L15:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M10_L07
M10_L18:
       call      qword ptr [7FFCC2E7F000]
       int       3
M10_L19:
       mov       rcx,rbx
       call      qword ptr [7FFCC30661D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L20:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3066190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L21:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L22
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        near ptr M10_L10
M10_L22:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L18
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 707
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1FB3DC01DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3065FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3086820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC304F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3065FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3025CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC304F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3086B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CC43A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,2C68D005C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3056808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2C68D005C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3052730
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C68D005C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC306B320
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
       mov       rdx,7FFCC306BBB0
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
       mov       rdx,7FFCC306BBC8
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
       mov       rdx,7FFCC306C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC306BBE8
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
       mov       rdx,7FFCC306BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC306B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC306B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC306B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EDED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC306B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80520
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
; Total bytes of code 877
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
       mov       rax,2C68D000B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC306CEE8
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
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3052730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2EDED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3135600
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
       mov       rcx,2C68D001DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L08
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L07
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L10
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M08_L15
       mov       r15d,r10d
       jmp       near ptr M08_L03
M08_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B80510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L12
M08_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       bpl,1
       jne       short M08_L14
M08_L13:
       cmp       r8d,r15d
       jae       near ptr M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       bpl,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M08_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B80508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M08_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M08_L13
       cmp       bpl,2
       jne       short M08_L18
M08_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC317DD40]
       int       3
M08_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M08_L07
M08_L20:
       call      qword ptr [7FFCC2E7F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EDED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EDED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 698
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,1F421405C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3065E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3067B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3067B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F421405C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3061D88
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F421405C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30473E8
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
       mov       rdx,7FFCC3047C78
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
       mov       rdx,7FFCC3047C90
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
       mov       rdx,7FFCC3048818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3047CB0
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
       mov       rdx,7FFCC3048020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30479D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30479F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3047A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30479D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,1F421401DE8
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
       mov       rax,1F421401DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3049678
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
       mov       rdx,7FFCC3049B20
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
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3049C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B80558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3049B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3049C08
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EDEF88]
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
       mov       rdx,7FFCC304A4C8
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EDEF88]
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
       call      qword ptr [7FFCC3067C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B80560
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 934
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       je        short M03_L00
       mov       rdx,1F421401DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L14
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M03_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L04
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3085ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L05
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L05
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L06
M03_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC304E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFCC304D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L06:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L07:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC304CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC304D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3084C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L12
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC304D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L03
M03_L14:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L17
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L15
       jmp       short M03_L16
M03_L15:
       mov       rcx,rsi
       mov       rdx,7FFCC304CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC306F918]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L17:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rsi
       mov       rdx,7FFCC304C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC306ED78]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 499
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
       mov       r8,1F421400B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3048FB0
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
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3061D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC31455D8
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
       mov       rcx,1F421401DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L12
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L07
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L08
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L10
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L13
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B80550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L08:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M10_L17
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L14
M10_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L22
M10_L12:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3066190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L13:
       mov       rcx,rbx
       call      qword ptr [7FFCC30661D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L14:
       cmp       bpl,1
       jne       short M10_L16
M10_L15:
       cmp       r8d,r15d
       jae       near ptr M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L16:
       cmp       bpl,2
       jne       short M10_L20
       jmp       short M10_L18
M10_L17:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M10_L21
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B80548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M10_L19
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M10_L15
       cmp       bpl,2
       jne       short M10_L20
M10_L18:
       mov       ecx,esi
       call      qword ptr [7FFCC317DD40]
       int       3
M10_L19:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
       jmp       short M10_L21
M10_L20:
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
M10_L21:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M10_L08
M10_L22:
       call      qword ptr [7FFCC2E7F000]
       int       3
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 702
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1F421401DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3065FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3086820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC304F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3065FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3025CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC304F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3086B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CC43A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1D70B405C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1D70B405C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D70B405C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC305B320
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
       mov       rdx,7FFCC305BBB0
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
       mov       rdx,7FFCC305BBC8
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
       mov       rdx,7FFCC305C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC305BBE8
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
       mov       rdx,7FFCC305BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70520
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
; Total bytes of code 877
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
       mov       rax,1D70B400B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305CEE8
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
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3125600
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
       mov       rcx,1D70B401DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L17
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L07
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L09
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L18
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L08
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L16
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+20],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+20]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B70510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L08:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L09:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       jbe       near ptr M08_L12
       mov       ecx,r10d
       mov       r10,r15
       mov       r15d,ecx
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       near ptr M08_L14
       mov       [rsp+20],rax
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,esi
       mov       r11,7FFCC2B70508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+20]
       mov       r10,[rsp+28]
       je        short M08_L11
       cmp       bpl,1
       mov       r8d,[rsp+34]
       je        near ptr M08_L21
       cmp       bpl,2
       jne       short M08_L13
M08_L10:
       mov       ecx,esi
       call      qword ptr [7FFCC316DD40]
       int       3
M08_L11:
       mov       r8d,[rsp+34]
       jmp       short M08_L14
M08_L12:
       mov       r15d,r10d
       jmp       near ptr M08_L03
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       mov       r15,r10
       jae       near ptr M08_L09
M08_L15:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L16:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L17:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L18:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L20
M08_L19:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L15
M08_L20:
       cmp       bpl,1
       jne       short M08_L22
M08_L21:
       cmp       r8d,r15d
       jae       short M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L22:
       cmp       bpl,2
       jne       near ptr M08_L13
       jmp       near ptr M08_L10
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 720
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,201F6405C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3035E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3037B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3037B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,201F6405C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3031D88
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,201F6405C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30173E8
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
       mov       rdx,7FFCC3017C78
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
       mov       rdx,7FFCC3017C90
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
       mov       rdx,7FFCC3018818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3017CB0
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
       mov       rdx,7FFCC3018020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30179D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30179F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3017A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30361A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B50590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30179D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B50598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,201F6401DE8
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
       mov       rax,201F6401DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3019678
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
       mov       rdx,7FFCC3019B20
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
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3019C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30361A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B50558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3019B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3019C08
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
       mov       rdx,7FFCC3019678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EAEF88]
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
       mov       rdx,7FFCC301A4C8
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
       mov       rdx,7FFCC3019678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EAEF88]
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
       call      qword ptr [7FFCC3037C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B50560
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 934
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       cmp       qword ptr [rcx+10],48
       jle       short M03_L03
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L03
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3055ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],38
       jle       short M03_L04
       jmp       short M03_L06
M03_L02:
       mov       rdx,201F6401DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L16
       jmp       short M03_L00
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFCC301E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC301D848
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
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC301CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L11:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC301D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2C943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3054C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L14
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC301D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       mov       rdx,rbp
       call      qword ptr [7FFCC2C943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L08
M03_L16:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L19
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,7FFCC301CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L18:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC303F918]
       mov       rax,rsi
       jmp       near ptr M03_L08
M03_L19:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFCC301C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L21:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC303ED78]
       mov       rax,rsi
       jmp       near ptr M03_L08
; Total bytes of code 504
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
       mov       r8,201F6400B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3018FB0
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
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3031D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30361A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC31155D8
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
       mov       rcx,201F6401DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L16
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L08
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L09
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L18
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        short M10_L07
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L17
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+20],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+20]
       mov       [rdi],r12d
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
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       short M10_L05
M10_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B50550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L09:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       jbe       near ptr M10_L12
       mov       ecx,r10d
       mov       r10,r15
       mov       r15d,ecx
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       near ptr M10_L14
       mov       [rsp+20],rax
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,esi
       mov       r11,7FFCC2B50548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+20]
       mov       r10,[rsp+28]
       je        short M10_L11
       cmp       bpl,1
       mov       r8d,[rsp+34]
       je        near ptr M10_L21
       cmp       bpl,2
       jne       short M10_L13
M10_L10:
       mov       ecx,esi
       call      qword ptr [7FFCC314DD40]
       int       3
M10_L11:
       mov       r8d,[rsp+34]
       jmp       short M10_L14
M10_L12:
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L13:
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
M10_L14:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       mov       r15,r10
       jae       near ptr M10_L09
M10_L15:
       call      qword ptr [7FFCC2E4F000]
       int       3
M10_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3036190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC30361D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L18:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L20
M10_L19:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L15
M10_L20:
       cmp       bpl,1
       jne       short M10_L22
M10_L21:
       cmp       r8d,r15d
       jae       short M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L22:
       cmp       bpl,2
       jne       near ptr M10_L13
       jmp       near ptr M10_L10
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,201F6401DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3035FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3056820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC301F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3035FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC2FF5CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC301F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3056B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2C943A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,22DFE805C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3036808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22DFE805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3032730
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22DFE805C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC304B320
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
       mov       rdx,7FFCC304BBB0
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
       mov       rdx,7FFCC304BBC8
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
       mov       rdx,7FFCC304C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC304BBE8
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
       mov       rdx,7FFCC304BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC304B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EBEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC304B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC304B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EBED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC304B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EBEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60520
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
; Total bytes of code 877
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
       jmp       qword ptr [7FFCC2CA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       rax,22DFE800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC304CEE8
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
       call      qword ptr [7FFCC2EBEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3032730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2EBED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       call      qword ptr [7FFCC2CAF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3115600
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
       call      qword ptr [7FFCC2E5ED00]
       int       3
M07_L05:
       mov       rcx,22DFE801DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L08
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L07
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L10
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M08_L15
       mov       r15d,r10d
       jmp       near ptr M08_L03
M08_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B60510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L12
M08_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       bpl,1
       jne       short M08_L14
M08_L13:
       cmp       r8d,r15d
       jae       near ptr M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       bpl,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M08_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B60508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M08_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M08_L13
       cmp       bpl,2
       jne       short M08_L18
M08_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC315DD40]
       int       3
M08_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M08_L07
M08_L20:
       call      qword ptr [7FFCC2E5F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EBED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EBED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 698
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,22949C05C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3035E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3037B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3037B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22949C05C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3031D88
       call      qword ptr [7FFCC2C94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22949C05C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30173E8
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
       mov       rdx,7FFCC3017C78
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
       mov       rdx,7FFCC3017C90
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
       mov       rdx,7FFCC3018818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3017CB0
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
       mov       rdx,7FFCC3018020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30179D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30179F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3017A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30361A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B50590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30179D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B50598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,22949C01DE8
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
       mov       rax,22949C01DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3019678
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
       mov       rdx,7FFCC3019B20
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
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3019C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30361A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B50558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3019B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3019C08
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
       mov       rdx,7FFCC3019678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EAEF88]
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
       mov       rdx,7FFCC301A4C8
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
       mov       rdx,7FFCC3019678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EAEF88]
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
       call      qword ptr [7FFCC3037C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B50560
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 934
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       cmp       qword ptr [rcx+10],48
       jle       short M03_L03
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L03
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3055ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],38
       jle       short M03_L04
       jmp       short M03_L06
M03_L02:
       mov       rdx,22949C01DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L16
       jmp       short M03_L00
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFCC301E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC301D848
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
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC301CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L11:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC301D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2C943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3054C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L14
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC301D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       mov       rdx,rbp
       call      qword ptr [7FFCC2C943D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L08
M03_L16:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L19
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,7FFCC301CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L18:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC303F918]
       mov       rax,rsi
       jmp       near ptr M03_L08
M03_L19:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFCC301C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L21:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC303ED78]
       mov       rax,rsi
       jmp       near ptr M03_L08
; Total bytes of code 504
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
       mov       r8,22949C00B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3018FB0
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
       call      qword ptr [7FFCC3035ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3031D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30361A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC31155D8
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
       mov       rcx,22949C01DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L22
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L07
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L08
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L10
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
M10_L03:
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L21
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B50550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L08:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M10_L15
       cmp       dword ptr [rbx+40],0
       mov       r15d,r10d
       jle       near ptr M10_L03
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L12
M10_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L20
M10_L12:
       cmp       bpl,1
       jne       short M10_L14
M10_L13:
       cmp       r8d,r15d
       jae       near ptr M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L14:
       cmp       bpl,2
       jne       short M10_L18
       jmp       short M10_L16
M10_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M10_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B50548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M10_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M10_L13
       cmp       bpl,2
       jne       short M10_L18
M10_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC314DD40]
       int       3
M10_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M10_L08
M10_L20:
       call      qword ptr [7FFCC2E4F000]
       int       3
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC30361D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3036190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 703
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,22949C01DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3035FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3056820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC301F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3035FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC2FF5CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC301F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3056B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2C943A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,1720D805C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3056808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1720D805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3052730
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1720D805C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC306B320
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
       mov       rdx,7FFCC306BBB0
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
       mov       rdx,7FFCC306BBC8
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
       mov       rdx,7FFCC306C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC306BBE8
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
       mov       rdx,7FFCC306BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC306B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC306B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC306B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EDED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC306B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80520
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
; Total bytes of code 877
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
       mov       rax,1720D800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC306CEE8
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
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3052730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2EDED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3135600
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
       mov       rcx,1720D801DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L07
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L08
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L10
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
M08_L03:
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B80510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L08:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M08_L15
       cmp       dword ptr [rbx+40],0
       mov       r15d,r10d
       jle       near ptr M08_L03
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L12
M08_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       bpl,1
       jne       short M08_L14
M08_L13:
       cmp       r8d,r15d
       jae       near ptr M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       bpl,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M08_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B80508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M08_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M08_L13
       cmp       bpl,2
       jne       short M08_L18
M08_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC317DD40]
       int       3
M08_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M08_L08
M08_L20:
       call      qword ptr [7FFCC2E7F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EDED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EDED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 703
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,24D0E405C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3055E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3057B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3057B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24D0E405C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3051D88
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24D0E405C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30373E8
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
       mov       rdx,7FFCC3037C78
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
       mov       rdx,7FFCC3037C90
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
       mov       rdx,7FFCC3038818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3037CB0
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
       mov       rdx,7FFCC3038020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30379D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3055ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30379F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3037A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30561A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70580
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30379D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3055ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70588
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,24D0E401DE8
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
       call      qword ptr [7FFCC2CB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFCC2CB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rax,24D0E401DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3039678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC3039B20
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
       call      qword ptr [7FFCC3055ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3039C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30561A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B70590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3039B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3039C08
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
       mov       rdx,7FFCC3039678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2ECEF88]
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
       mov       rdx,7FFCC303A4C8
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
       mov       rdx,7FFCC3039678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2ECEF88]
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L24:
       mov       ecx,65B
       mov       rdx,7FFCC2F01C88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFCC3057C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B70598
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 938
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       jne       short M03_L04
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L09
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M03_L05
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L05
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3075ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L06
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L06
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L08
M03_L03:
       jmp       short M03_L07
M03_L04:
       mov       rdx,24D0E401DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L16
       jmp       short M03_L00
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFCC303E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FFCC303D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L08:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L09:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC303CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L11:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC303D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CB43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3074C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L14
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC303D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CB43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L07
M03_L16:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L19
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,7FFCC303CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L18:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC305F918]
       mov       rax,rsi
       jmp       near ptr M03_L07
M03_L19:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFCC303C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L21:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC305ED78]
       mov       rax,rsi
       jmp       near ptr M03_L07
; Total bytes of code 503
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
       jmp       qword ptr [7FFCC2CB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       r8,24D0E400B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3038FB0
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
       call      qword ptr [7FFCC3055ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3051D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30561A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       call      qword ptr [7FFCC2CBF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3135278
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
       call      qword ptr [7FFCC2E6ED00]
       int       3
M09_L05:
       mov       rcx,24D0E401DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L22
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L08
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L07
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L10
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M10_L09
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L21
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M10_L15
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B70550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M10_L05
M10_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L12
M10_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L20
M10_L12:
       cmp       bpl,1
       jne       short M10_L14
M10_L13:
       cmp       r8d,r15d
       jae       near ptr M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L14:
       cmp       bpl,2
       jne       short M10_L18
       jmp       short M10_L16
M10_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M10_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B70548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M10_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M10_L13
       cmp       bpl,2
       jne       short M10_L18
M10_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC316DD40]
       int       3
M10_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M10_L07
M10_L20:
       call      qword ptr [7FFCC2E6F000]
       int       3
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC30561D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3056190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 698
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,24D0E401DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3055FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3076820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC303F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3055FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3015CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC303F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3076B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
       jmp       qword ptr [7FFCC2CB43A8]
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CB43A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,2133E805C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3046808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2133E805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3042730
       call      qword ptr [7FFCC2CB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2133E805C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC305B320
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
       mov       rdx,7FFCC305BBB0
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
       mov       rdx,7FFCC305BBC8
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
       mov       rdx,7FFCC305C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC305BBE8
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
       mov       rdx,7FFCC305BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC305B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC305B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC305B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B70520
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
; Total bytes of code 877
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
       mov       rax,2133E800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC305CEE8
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
       call      qword ptr [7FFCC2ECEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3042730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2ECED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3125600
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
       mov       rcx,2133E801DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L16
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L08
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L09
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L18
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        short M08_L07
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L17
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+20],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+20]
       mov       [rdi],r12d
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
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       short M08_L05
M08_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B70510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L09:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       jbe       near ptr M08_L12
       mov       ecx,r10d
       mov       r10,r15
       mov       r15d,ecx
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       near ptr M08_L14
       mov       [rsp+20],rax
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,esi
       mov       r11,7FFCC2B70508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+20]
       mov       r10,[rsp+28]
       je        short M08_L11
       cmp       bpl,1
       mov       r8d,[rsp+34]
       je        near ptr M08_L21
       cmp       bpl,2
       jne       short M08_L13
M08_L10:
       mov       ecx,esi
       call      qword ptr [7FFCC316DD40]
       int       3
M08_L11:
       mov       r8d,[rsp+34]
       jmp       short M08_L14
M08_L12:
       mov       r15d,r10d
       jmp       near ptr M08_L03
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       mov       r15,r10
       jae       near ptr M08_L09
M08_L15:
       call      qword ptr [7FFCC2E6F000]
       int       3
M08_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2ECED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC2ECED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L18:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L20
M08_L19:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L15
M08_L20:
       cmp       bpl,1
       jne       short M08_L22
M08_L21:
       cmp       r8d,r15d
       jae       short M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L22:
       cmp       bpl,2
       jne       near ptr M08_L13
       jmp       near ptr M08_L10
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,2298B805C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3045E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3047B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3047B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2298B805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3041D88
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2298B805C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30273E8
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
       mov       rdx,7FFCC3027C78
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
       mov       rdx,7FFCC3027C90
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
       mov       rdx,7FFCC3028818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3027CB0
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
       mov       rdx,7FFCC3028020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30279D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30279F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3027A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60580
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30279D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60588
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,2298B801DE8
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
       mov       rax,2298B801DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3029678
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
       mov       rdx,7FFCC3029B20
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
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3029C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B60590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3029B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3029C08
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
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EBEF88]
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
       mov       rdx,7FFCC302A4C8
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
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EBEF88]
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
       call      qword ptr [7FFCC3047C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B60598
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 934
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       je        short M03_L00
       mov       rdx,2298B801DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L14
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M03_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L04
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3065ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L05
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L05
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L06
M03_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC302E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFCC302D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L06:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L07:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC302CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC302D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3064C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L12
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC302D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CA43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L03
M03_L14:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L17
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L15
       jmp       short M03_L16
M03_L15:
       mov       rcx,rsi
       mov       rdx,7FFCC302CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC304F918]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L17:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rsi
       mov       rdx,7FFCC302C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC304ED78]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 499
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
       mov       r8,2298B800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3028FB0
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
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3041D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC3125278
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
       mov       rcx,2298B801DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L16
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L08
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L09
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L18
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        short M10_L07
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L17
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+20],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+20]
       mov       [rdi],r12d
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
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       short M10_L05
M10_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B60550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L09:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       jbe       near ptr M10_L12
       mov       ecx,r10d
       mov       r10,r15
       mov       r15d,ecx
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       near ptr M10_L14
       mov       [rsp+20],rax
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,esi
       mov       r11,7FFCC2B60548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+20]
       mov       r10,[rsp+28]
       je        short M10_L11
       cmp       bpl,1
       mov       r8d,[rsp+34]
       je        near ptr M10_L21
       cmp       bpl,2
       jne       short M10_L13
M10_L10:
       mov       ecx,esi
       call      qword ptr [7FFCC310ECE8]
       int       3
M10_L11:
       mov       r8d,[rsp+34]
       jmp       short M10_L14
M10_L12:
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L13:
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
M10_L14:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       mov       r15,r10
       jae       near ptr M10_L09
M10_L15:
       call      qword ptr [7FFCC2E5F000]
       int       3
M10_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3046190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC30461D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L18:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L20
M10_L19:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L15
M10_L20:
       cmp       bpl,1
       jne       short M10_L22
M10_L21:
       cmp       r8d,r15d
       jae       short M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L22:
       cmp       bpl,2
       jne       near ptr M10_L13
       jmp       near ptr M10_L10
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,2298B801DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3045FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3066820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC302F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3045FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3005CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC302F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3066B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CA43A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,2A97F805C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3056808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2A97F805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3052730
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A97F805C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC306B320
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
       mov       rdx,7FFCC306BBB0
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
       mov       rdx,7FFCC306BBC8
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
       mov       rdx,7FFCC306C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC306BBE8
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
       mov       rdx,7FFCC306BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3057708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC306B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC306B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC306B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EDED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC306B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80520
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
; Total bytes of code 877
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
       mov       rax,2A97F800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC306CEE8
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
       call      qword ptr [7FFCC2EDEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3052730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2EDED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3135600
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
       mov       rcx,2A97F801DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L22
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L07
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L08
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L10
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L09
M08_L03:
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L21
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B80510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L08:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        near ptr M08_L15
       cmp       dword ptr [rbx+40],0
       mov       r15d,r10d
       jle       near ptr M08_L03
M08_L09:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L10:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L11
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L12
M08_L11:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L20
M08_L12:
       cmp       bpl,1
       jne       short M08_L14
M08_L13:
       cmp       r8d,r15d
       jae       near ptr M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       cmp       bpl,2
       jne       short M08_L18
       jmp       short M08_L16
M08_L15:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M08_L19
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B80508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M08_L17
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M08_L13
       cmp       bpl,2
       jne       short M08_L18
M08_L16:
       mov       ecx,esi
       call      qword ptr [7FFCC317DD40]
       int       3
M08_L17:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M08_L08
M08_L20:
       call      qword ptr [7FFCC2E7F000]
       int       3
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EDED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EDED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 703
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,26204805C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3045E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3047B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3047B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,26204805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3041D88
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26204805C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30273E8
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
       mov       rdx,7FFCC3027C78
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
       mov       rdx,7FFCC3027C90
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
       mov       rdx,7FFCC3028818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3027CB0
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
       mov       rdx,7FFCC3028020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3047330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30279D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30279F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3027A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30279D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,26204801DE8
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
       mov       rax,26204801DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3029678
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
       mov       rdx,7FFCC3029B20
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
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3029C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B60558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L04
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3029B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3029C08
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
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EBEF88]
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
       mov       rdx,7FFCC302A4C8
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
       mov       rdx,7FFCC3029678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EBEF88]
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
       call      qword ptr [7FFCC3047C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B60560
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 934
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       cmp       qword ptr [rcx+10],48
       jle       short M03_L03
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L03
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3065ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],38
       jle       short M03_L04
       jmp       short M03_L06
M03_L02:
       mov       rdx,26204801DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L16
       jmp       short M03_L00
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFCC302E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC302D848
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
       call      qword ptr [7FFCC2CA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC302CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L11:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC302D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CA43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3064C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L14
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rcx,rsi
       mov       rdx,7FFCC302D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L15:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CA43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L08
M03_L16:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L19
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,7FFCC302CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L18:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC304F918]
       mov       rax,rsi
       jmp       near ptr M03_L08
M03_L19:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L20
       jmp       short M03_L21
M03_L20:
       mov       rcx,rsi
       mov       rdx,7FFCC302C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L21:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC304ED78]
       mov       rax,rsi
       jmp       near ptr M03_L08
; Total bytes of code 504
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
       mov       r8,26204800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3028FB0
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
       call      qword ptr [7FFCC3045ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3041D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30461A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC31255D8
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
       mov       rcx,26204801DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L19
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L09
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L08
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L21
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        short M10_L07
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L20
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+28]
       mov       [rdi],r12d
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
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       short M10_L05
M10_L08:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       ja        short M10_L13
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B60550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L10:
       cmp       bpl,1
       jne       short M10_L12
M10_L11:
       cmp       r8d,r15d
       jae       near ptr M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L12:
       cmp       bpl,2
       jne       short M10_L16
       jmp       short M10_L14
M10_L13:
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       short M10_L17
       mov       [rsp+28],rax
       mov       [rsp+30],r10d
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FFCC2B60548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       je        short M10_L15
       cmp       bpl,1
       mov       r8d,[rsp+34]
       mov       r15d,[rsp+30]
       je        short M10_L11
       cmp       bpl,2
       jne       short M10_L16
M10_L14:
       mov       ecx,esi
       call      qword ptr [7FFCC315DD40]
       int       3
M10_L15:
       mov       r8d,[rsp+34]
       mov       r10d,[rsp+30]
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r10d,r12d
       jae       near ptr M10_L08
M10_L18:
       call      qword ptr [7FFCC2E5F000]
       int       3
M10_L19:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3046190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L20:
       mov       rcx,rbx
       call      qword ptr [7FFCC30461D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L21:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L22
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        near ptr M10_L10
M10_L22:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L18
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 691
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,26204801DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3045FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3066820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC302F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3045FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3005CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC302F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3066B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CA43A8]
; Total bytes of code 83
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.Dictionary()
;     public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);
;                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+8]
       mov       r8,159A7805C88
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFCC3036808]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,159A7805C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3032730
       call      qword ptr [7FFCC2CA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,159A7805C88
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       short M00_L00
; Total bytes of code 129
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC304B320
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
       mov       rdx,7FFCC304BBB0
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
       mov       rdx,7FFCC304BBC8
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
       mov       rdx,7FFCC304C750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037750]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC304BBE8
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
       mov       rdx,7FFCC304BF58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3037708]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC304B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC2EBEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC304B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC304B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC2EBED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60518
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC304B910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC2EBEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B60520
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
; Total bytes of code 877
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
       jmp       qword ptr [7FFCC2CA4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       rax,159A7800B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFCC304CEE8
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
       call      qword ptr [7FFCC2EBEA90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M05_L04
M05_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3032730
       cmp       [rsi+18],rcx
       jne       short M05_L05
       mov       edx,[rdx+8]
M05_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC2EBED60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M05_L02
M05_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M05_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       call      qword ptr [7FFCC2CAF678]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M07_L00
       mov       rcx,rax
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3115600
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
       call      qword ptr [7FFCC2E5ED00]
       int       3
M07_L05:
       mov       rcx,159A7801DE8
       cmp       rsi,[rcx]
       je        short M07_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M08_L17
M08_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M08_L07
       mov       r13d,esi
M08_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M08_L09
       mov       r15d,[r14+8]
M08_L02:
       cmp       r15d,r8d
       ja        near ptr M08_L18
M08_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M08_L08
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M08_L16
M08_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M08_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M08_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+20],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+20]
       mov       [rdi],r12d
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
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B60510
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M08_L01
M08_L08:
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M08_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       near ptr M08_L05
M08_L09:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       jbe       near ptr M08_L12
       mov       ecx,r10d
       mov       r10,r15
       mov       r15d,ecx
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       near ptr M08_L14
       mov       [rsp+20],rax
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,esi
       mov       r11,7FFCC2B60508
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+20]
       mov       r10,[rsp+28]
       je        short M08_L11
       cmp       bpl,1
       mov       r8d,[rsp+34]
       je        near ptr M08_L21
       cmp       bpl,2
       jne       short M08_L13
M08_L10:
       mov       ecx,esi
       call      qword ptr [7FFCC315DD40]
       int       3
M08_L11:
       mov       r8d,[rsp+34]
       jmp       short M08_L14
M08_L12:
       mov       r15d,r10d
       jmp       near ptr M08_L03
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
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       mov       r15,r10
       jae       near ptr M08_L09
M08_L15:
       call      qword ptr [7FFCC2E5F000]
       int       3
M08_L16:
       mov       rcx,rbx
       call      qword ptr [7FFCC2EBED90]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M08_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M08_L04
M08_L17:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC2EBED48]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M08_L00
M08_L18:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M08_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M08_L20
M08_L19:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M08_L02
       jmp       near ptr M08_L15
M08_L20:
       cmp       bpl,1
       jne       short M08_L22
M08_L21:
       cmp       r8d,r15d
       jae       short M08_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L22:
       cmp       bpl,2
       jne       near ptr M08_L13
       jmp       near ptr M08_L10
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 720
```

## .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
```assembly
; Benchmark.Benchmarks.SmallCollection_Int32Key_Create.FrozenDictionary()
;     public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
;                                                                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       r8,22516405C90
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L02
M00_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<MyClass>, System.Func`2<MyClass,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       r9d,r9d
       call      qword ptr [7FFCC3065E48]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rdx,rax
       lea       r9,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,MyClass>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,MyClass> ByRef)
       xor       r8d,r8d
       call      qword ptr [7FFCC3067B10]; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
       test      rax,rax
       jne       short M00_L01
       mov       rdx,[rsp+20]
       mov       rcx,offset MD_System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark]](System.Collections.Generic.Dictionary`2<Int32,MyClass>)
       call      qword ptr [7FFCC3067B58]; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
M00_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Func`2[[Benchmark.Benchmarks.SmallCollection_Int32Key_Create+MyClass, Benchmark],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,22516405C78
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFCC3061D88
       call      qword ptr [7FFCC2CC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22516405C90
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M00_L00
; Total bytes of code 194
```
```assembly
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-60],rsp
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
       mov       rdx,7FFCC30473E8
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
       mov       rdx,7FFCC3047C78
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
       mov       rdx,7FFCC3047C90
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
       mov       rdx,7FFCC3048818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,r12
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067378]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rdx,7FFCC3047CB0
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
       mov       rdx,7FFCC3048020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFCC3067330]
M01_L13:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFCC30479D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,rax
       mov       edx,r15d
       mov       r8,r14
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rcx,[rbp-58]
       mov       [rbp-48],rcx
       mov       rcx,[rbx+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FFCC30479F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-50],rax
       jmp       short M01_L21
M01_L18:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FFCC3047A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L20:
       mov       rcx,[rbp-50]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       mov       rcx,[rbp-48]
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L21:
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80590
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L18
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-48]
       add       rsp,48
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
       mov       rdx,7FFCC30479D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       mov       rax,rbx
       add       rsp,48
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
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-50],0
       je        short M01_L28
       mov       rcx,[rbp-50]
       mov       r11,7FFCC2B80598
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
; Total bytes of code 877
```
```assembly
; System.Collections.Frozen.FrozenDictionary.GetExistingFrozenOrNewDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<Int32,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<Int32>, System.Collections.Generic.Dictionary`2<Int32,System.__Canon> ByRef)
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
       mov       rdx,22516401DE8
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
       mov       rax,22516401DE8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rdx]
       mov       r8,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M02_L00
M02_L04:
       mov       rdx,7FFCC3049B20
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
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       [rbp-30],rax
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
       mov       rdx,7FFCC3049C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L12:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rcx,[rbp+28]
       mov       rdx,[rcx]
       mov       r8d,[rbp-20]
       mov       r9,[rbp-28]
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,r8d
       mov       r8,r9
       mov       r9d,1
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,[rbp-30]
M02_L13:
       mov       rcx,rax
       mov       r11,7FFCC2B80558
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L10
       mov       rcx,rsp
       call      M02_L26
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,rax
       mov       rdx,7FFCC3049B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L08
M02_L15:
       mov       rcx,rax
       mov       rdx,7FFCC3049C08
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      qword ptr [7FFCC2EDEF88]
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
       mov       rdx,7FFCC304A4C8
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
       mov       rdx,7FFCC3049678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L23:
       call      qword ptr [7FFCC2EDEF88]
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
       call      qword ptr [7FFCC3067C00]
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
       cmp       qword ptr [rbp-30],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       mov       r11,7FFCC2B80560
       call      qword ptr [r11]
M02_L27:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 938
```
```assembly
; System.Collections.Frozen.FrozenDictionary.CreateFromDictionary[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
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
       je        short M03_L00
       mov       rdx,22516401DE8
       cmp       rcx,[rdx]
       jne       near ptr M03_L14
M03_L00:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,0A
       jg        near ptr M03_L07
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],48
       jle       short M03_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M03_L04
M03_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC3085ED8]; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L05
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L05
M03_L02:
       mov       rax,rdi
       cmp       [rax],rcx
       jne       short M03_L06
M03_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,rsi
       mov       rdx,7FFCC304E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L01
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFCC304D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M03_L02
M03_L06:
       mov       rdx,rdi
       call      qword ptr [7FFCC2CC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       jmp       short M03_L03
M03_L07:
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FFCC304CB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdi,rax
M03_L09:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rsi
       mov       rdx,7FFCC304D7B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFCC2CC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3084C30]
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],38
       jle       short M03_L12
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L12
       jmp       short M03_L13
M03_L12:
       mov       rcx,rsi
       mov       rdx,7FFCC304D848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       mov       rdx,rbp
       call      qword ptr [7FFCC2CC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M03_L03
M03_L14:
       mov       ecx,[rbx+38]
       sub       ecx,[rbx+40]
       cmp       ecx,4
       jg        short M03_L17
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M03_L15
       jmp       short M03_L16
M03_L15:
       mov       rcx,rsi
       mov       rdx,7FFCC304CB58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC306F918]
       mov       rax,rsi
       jmp       near ptr M03_L03
M03_L17:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rcx,rsi
       mov       rdx,7FFCC304C420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFCC306ED78]
       mov       rax,rsi
       jmp       near ptr M03_L03
; Total bytes of code 499
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
       mov       r8,22516400B50
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
; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.__Canon[], System.Func`2<System.__Canon,Int32>, System.Collections.Generic.IEqualityComparer`1<Int32>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rdx,7FFCC3048FB0
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
       call      qword ptr [7FFCC3065ED8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
       xor       edi,edi
       test      r14d,r14d
       jle       short M07_L04
M07_L02:
       mov       ecx,edi
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,7FFCC3061D88
       cmp       [rsi+18],rcx
       jne       short M07_L05
       mov       edx,[rdx+8]
M07_L03:
       mov       ecx,edi
       mov       r8,[rbx+rcx*8+10]
       mov       rcx,rbp
       mov       r9d,2
       call      qword ptr [7FFCC30661A8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       inc       edi
       cmp       r14d,edi
       jg        short M07_L02
M07_L04:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       edx,eax
       jmp       short M07_L03
; Total bytes of code 174
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
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<Int32>)
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
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L00
       mov       rcx,rax
       jmp       short M09_L01
M09_L00:
       mov       rdx,7FFCC31455D8
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
       mov       rcx,22516401DE8
       cmp       rsi,[rcx]
       je        short M09_L03
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L03
; Total bytes of code 233
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       mov       esi,edx
       mov       rdi,r8
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L16
M10_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M10_L08
       mov       r13d,esi
M10_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
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
       lea       rax,[rcx+rdx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M10_L09
       mov       r15d,[r14+8]
M10_L02:
       cmp       r15d,r8d
       ja        near ptr M10_L18
M10_L03:
       cmp       dword ptr [rbx+40],0
       jg        short M10_L07
       mov       r12d,[rbx+38]
       cmp       r15d,r12d
       je        near ptr M10_L17
M10_L04:
       lea       ecx,[r12+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M10_L05:
       cmp       r12d,[r14+8]
       jae       near ptr M10_L23
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       [rcx+8],r13d
       mov       [rsp+20],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],esi
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       rdi,[rsp+20]
       mov       [rdi],r12d
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
       mov       ecx,[rbx+3C]
       mov       r12d,ecx
       cmp       ecx,r15d
       jae       near ptr M10_L23
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       short M10_L05
M10_L08:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFCC2B80550
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M10_L01
M10_L09:
       mov       ecx,[r14+8]
       mov       r10d,ecx
       cmp       r10d,r8d
       jbe       near ptr M10_L12
       mov       ecx,r10d
       mov       r10,r15
       mov       r15d,ecx
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r13d
       jne       near ptr M10_L14
       mov       [rsp+20],rax
       mov       [rsp+34],r8d
       mov       edx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       [rsp+28],r10
       mov       rcx,r10
       mov       r8d,esi
       mov       r11,7FFCC2B80548
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+20]
       mov       r10,[rsp+28]
       je        short M10_L11
       cmp       bpl,1
       mov       r8d,[rsp+34]
       je        near ptr M10_L21
       cmp       bpl,2
       jne       short M10_L13
M10_L10:
       mov       ecx,esi
       call      qword ptr [7FFCC317DD40]
       int       3
M10_L11:
       mov       r8d,[rsp+34]
       jmp       short M10_L14
M10_L12:
       mov       r15d,r10d
       jmp       near ptr M10_L03
M10_L13:
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
M10_L14:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       mov       r15,r10
       jae       near ptr M10_L09
M10_L15:
       call      qword ptr [7FFCC2E7F000]
       int       3
M10_L16:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC3066190]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M10_L00
M10_L17:
       mov       rcx,rbx
       call      qword ptr [7FFCC30661D8]
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       near ptr M10_L23
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M10_L04
M10_L18:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+18],r13d
       jne       short M10_L19
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],esi
       je        short M10_L20
M10_L19:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+1C]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M10_L02
       jmp       near ptr M10_L15
M10_L20:
       cmp       bpl,1
       jne       short M10_L22
M10_L21:
       cmp       r8d,r15d
       jae       short M10_L23
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L22:
       cmp       bpl,2
       jne       near ptr M10_L13
       jmp       near ptr M10_L10
M10_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 713
```
```assembly
; System.Collections.Frozen.SmallValueTypeComparableFrozenDictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.Dictionary`2<Int32,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,22516401DE8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC3065FB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Keys()
       mov       rcx,rax
       call      qword ptr [7FFCC3086820]; System.Linq.Enumerable.ToArray[[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>)
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rbp,[rdx+18]
       test      rbp,rbp
       je        short M11_L00
       jmp       short M11_L01
M11_L00:
       mov       rdx,7FFCC304F498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rbp,rax
M11_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCC3065FF8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Values()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFCC3025CB0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rcx,rdi
       mov       rdx,7FFCC304F548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M11_L03:
       mov       rdx,[rbx+10]
       mov       r8,[rbx+18]
       call      qword ptr [7FFCC3086B20]; System.Array.Sort[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](Int32[], System.__Canon[])
       mov       rax,[rbx+10]
       mov       rcx,rax
       mov       eax,[rax+8]
       dec       eax
       cmp       eax,[rcx+8]
       jae       short M11_L04
       mov       eax,[rcx+rax*4+10]
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 242
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L02
       cmp       [rdx],rcx
       je        short M13_L02
       mov       r8,[rdx]
M13_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       mov       rax,rdx
       ret
M13_L03:
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       je        short M13_L04
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M13_L01
       test      r8,r8
       jne       short M13_L00
M13_L04:
       jmp       qword ptr [7FFCC2CC43A8]
; Total bytes of code 83
```

