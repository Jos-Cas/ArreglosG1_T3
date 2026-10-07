using Arreglos.Logica;

Console.WriteLine("Operaciones en pila");

Console.WriteLine("Arreglo\n");
MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-3);

    Console.WriteLine(oMiArreglo);

    Console.ReadKey();
    oMiArreglo.Insertar(500, 20);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//oMiArreglo.Llenar(1, 20);

//Console.WriteLine("Arreglo desordenado\n");
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado ascendente\n");
//oMiArreglo.Ordenar(true);
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado descendente\n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);

Console.ReadKey();
