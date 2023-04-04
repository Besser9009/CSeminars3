Console.Clear();
System.Console.Write("Enter meaning N: ");
int N = int.Parse(Console.ReadLine());
for (int Z = 1; Z <= N; Z++){
    System.Console.WriteLine($"{Math.Pow(Z, 3)} ");
}