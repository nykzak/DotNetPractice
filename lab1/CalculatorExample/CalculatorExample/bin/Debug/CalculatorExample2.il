
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly CalculatorExample
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 11 43 61 6C 63 75 6C 61 74 6F 72 45 78 61   // ...CalculatorExa
                                                                                              6D 70 6C 65 00 00 )                               // mple..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 11 43 61 6C 63 75 6C 61 74 6F 72 45 78 61   // ...CalculatorExa
                                                                                                6D 70 6C 65 00 00 )                               // mple..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 32 62 35 32 30 66 33 30 2D 37 37 39 35   // ..$2b520f30-7795
                                                                                                  2D 34 61 38 39 2D 38 32 61 66 2D 36 30 66 35 32   // -4a89-82af-60f52
                                                                                                  39 33 62 61 35 34 61 00 00 )                      // 93ba54a..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module CalculatorExample.exe
// MVID: {15A1A43A-876A-49C6-B6EA-C1ACC85BDD9C}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x06C70000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit CalculatorExample.Program
       extends [mscorlib]System.Object
{
  .class auto ansi nested private beforefieldinit Calc
         extends [mscorlib]System.Object
  {
    .method public hidebysig instance int32 
            Add(int32 x,
                int32 y) cil managed
    {
      // Размер кода:       9 (0x9)
      .maxstack  2
      .locals init ([0] int32 V_0)
      IL_0000:  nop
      IL_0001:  ldarg.1
      IL_0002:  ldarg.2
      IL_0003:  add
      IL_0004:  stloc.0
      IL_0005:  br.s       IL_0007

      IL_0007:  ldloc.0
      IL_0008:  ret
    } // end of method Calc::Add

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Размер кода:       8 (0x8)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  nop
      IL_0007:  ret
    } // end of method Calc::.ctor

  } // end of class Calc

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       42 (0x2a)
    .maxstack  3
    .locals init ([0] class CalculatorExample.Program/Calc c,
             [1] int32 ans)
    IL_0000:  nop
    IL_0001:  newobj     instance void CalculatorExample.Program/Calc::.ctor()
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  ldc.i4.s   10
    IL_000a:  ldc.i4.s   84
    IL_000c:  callvirt   instance int32 CalculatorExample.Program/Calc::Add(int32,
                                                                            int32)
    IL_0011:  stloc.1
    IL_0012:  ldstr      "It is Wrong Answer"
    IL_0017:  ldloc.1
    IL_0018:  box        [mscorlib]System.Int32
    IL_001d:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_0022:  nop
    IL_0023:  call       string [mscorlib]System.Console::ReadLine()
    IL_0028:  pop
    IL_0029:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class CalculatorExample.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\Users\nykza\Desktop\dotNET\CalculatorExample\CalculatorExample\bin\Debug\CalculatorExample2.res
