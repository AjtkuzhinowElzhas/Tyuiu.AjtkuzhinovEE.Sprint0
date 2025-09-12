using Tyuiu.AjtkuzhinovEE.Sprint0.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        //Вызов класса DataService и метода GetMessage
        //Из библиотеки Tyuiu.Sprint0.Task2.V0.Lib
        Console.WriteLine(DataService.GetMessage("Елжас"));
        Console.ReadKey();
        Console.ReadKey();
    }
}