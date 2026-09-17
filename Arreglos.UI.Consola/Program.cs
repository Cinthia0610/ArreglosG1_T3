using Arreglos.Logica;

Console.WriteLine("Hello, World!");

Console.WriteLine("Arreglo");
MiArreglo oMiArreglo = new MiArreglo(100);
oMiArreglo.Llenar(1, 20);

Console.WriteLine(oMiArreglo.ToString());


Console.ReadKey();