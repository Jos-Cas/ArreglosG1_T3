using Arreglos.Logica;

Console.WriteLine("Operaciones en pila");

Console.WriteLine("Arreglo lleno");
MiArreglo oMiArreglo = new MiArreglo(100);
oMiArreglo.Llenar(1, 20);

Console.WriteLine(oMiArreglo);

Console.ReadKey();
