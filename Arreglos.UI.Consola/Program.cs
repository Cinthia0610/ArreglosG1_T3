using Arreglos.Logica;

Console.WriteLine("Hello, World!");

Console.WriteLine("Arreglo");
MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);

    Console.WriteLine(oMiArreglo);
    Console.WriteLine("Insertar 500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("Eliminar 500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(oMiArreglo);

//oMiArreglo.Llenar(1, 20);

//Console.WriteLine("Arreglo desordenado \n");
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado ascendente \n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado descendente \n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);

//Console.ReadKey();

MiArreglo oMyArreglo = new(50000);


try
{
    Console.WriteLine("\nArreglo\n");
    var tiempo1 = DateTime.Now;
    oMiArreglo.Llenar(1, 999999);

    Console.WriteLine(oMiArreglo);
    var tiempo2 = DateTime.Now;

    var restaTiempo = tiempo2 - tiempo1;

    Console.WriteLine($"\nTiempo transcurrido:{restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos ");
    Console.ReadKey();

    //Console.WriteLine("\nPares\n");
    //var verPares =oMiArreglo.ObtenerPares();
    //Console.WriteLine(verPares);
    //Console.ReadKey();


    //Console.WriteLine("Pares Ordenados\n");
    //verPares.Ordenar(true);
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    Console.WriteLine("\nPrimos\n");
    var tiempo3 = DateTime.Now;
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    var tiempo4 = DateTime.Now;

    var restaTiempo2 = tiempo4 - tiempo3;
    Console.WriteLine($"\nTiempo transcurrido:{restaTiempo2.Minutes} minutos, {restaTiempo2.Seconds} segundos, {restaTiempo2.Milliseconds} milisegundos, {restaTiempo2.Nanoseconds} nanosegundos ");
    Console.ReadKey();


    Console.WriteLine("Primos Ordenados\n");
    var tiempo5 = DateTime.Now;
    verPrimos.Ordenar(true);
    Console.WriteLine(verPrimos);
    var tiempo6 = DateTime.Now;

    var restaTiempo3 = tiempo6 - tiempo5;
    Console.WriteLine($"\nTiempo transcurrido:{restaTiempo3.Minutes} minutos, {restaTiempo3.Seconds} segundos, {restaTiempo3.Milliseconds} milisegundos, {restaTiempo3.Nanoseconds} nanosegundos ");

    Console.ReadKey();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

