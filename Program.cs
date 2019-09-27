using System;

namespace methodhw
{
    class Program
    {
        static void Main(string[] args)
        { 
        var prog = new Program();
        prog.myNewMethod();
            prog.floatMethod(100, 50);
            int[] numbersOfArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        prog.arrayMethod(numbersOfArray);


        }
    public void myNewMethod()
    {
        Console.WriteLine("myNewMethod is successful");
    }
    public void myFloatMethod(float num1, float num2)
    {
        var numfloat = num1 / num2;
        Console.WriteLine(numfloat);
    }
    public void arrayMethod(int[] intLoop2)
    {
        foreach (int i in intLoop2)
        {
            if (i == 7)
            {
                Console.WriteLine("lucky number");
            }
            else
            {
                Console.WriteLine("unlucky number");
            }
        }
    }



}

