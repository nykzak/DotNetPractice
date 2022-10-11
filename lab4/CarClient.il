
.assembly extern mscorlib
{
 .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
 .ver 4:0:0:0
}
.assembly extern CILCars
{
 .ver 1:0:0:0
}
// Наша исполняемая сборка.
.assembly CarClient
{
 .hash algorithm 0x00008004
 .ver 1:0:0:0
}
.module CarClient.exe
// Реализация типа Program.
.namespace CarClient
{
 .class private auto ansi beforefieldinit Program
 extends [mscorlib]System.Object
 {
 .method private hidebysig static void
 FOOBAR(string[] args) cil managed
 {
 .entrypoint
 .maxstack 8
 .locals init ([0] class
 [CILCars]CILCars.CILCar myCilCar)
 ldc.i4 55
 ldstr "Junior"
 newobj instance void
 [CILCars]CILCars.CILCar::.ctor(int32, string)
 stloc.0
 ldloc.0
 call void [CILCars]
 CILCars.CILCarInfo::Display(
 class [CILCars]CILCars.CILCar)
 ret
 }
 }
}
