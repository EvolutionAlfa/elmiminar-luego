
using ListaEnlazadaDoble;

LocomotoraD loco = new LocomotoraD();
loco.AgregarFinal("Kawai");
loco.AgregarFinal("Doro");
loco.AgregarFinal("Vegeto");
loco.AgregarFinal("Vago");

Console.WriteLine(loco.Imprimir());
Console.WriteLine(loco.Contar());
Console.WriteLine(loco.Get(2));