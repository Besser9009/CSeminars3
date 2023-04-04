Console.Clear();
System.Console.Write("Введите пятизначное число: ");
int Num1 = int.Parse(Console.ReadLine());
int num1 = Num1 / 10000;
int num2 = Num1 % 10000 / 1000 * 10;
int num3 = Num1 % 1000 / 100 * 100;
int num4 = Num1 % 100 / 10 * 1000;
int num5 = Num1 % 10 * 10000;
int Num2 = num1 + num2 + num3 + num4 + num5;
Console.WriteLine(Num2);
if (Num1 == Num2){
    Console.WriteLine("Yes, it's palindrome");
}
else{
    System.Console.WriteLine("No, it's not palindrome");
}