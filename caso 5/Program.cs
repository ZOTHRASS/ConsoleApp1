Console.WriteLine("elija desde que numero quiere empezar");
int numeroempezar = int.Parse(Console.ReadLine());
Console.WriteLine("elija hasta que numero quiere mostar");
int numerofinal = int.Parse(Console.ReadLine());
for (int i = 0; i < numerofinal; i++) 
{
    Console.WriteLine(numeroempezar);
    numeroempezar++;

}
Console.ReadKey();
