.assembly DemystifyingILChapter1 {}
.class public auto ansi HelloWorld extends [mscorlib]System.Object
{
 .method public hidebysig static void HelloWorld() cil managed
 {
 .entrypoint
 ldstr "Hello World."
 call void [mscorlib]System.Console::WriteLine(class System.String)
 ret
 }
 .method public hidebysig specialname rtspecialname
 instance void .ctor() cil managed
 {
 ldarg.0
 call instance void [mscorlib]System.Object::.ctor()
 ret
 }
}
