using System;
class HelloWorld
{
    static void Main()
    {
        int count=0;
        Console.Write("Enter the first number : ");
        int firstNumber=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int secondNumber=Convert.ToInt32(Console.ReadLine());

        if(firstNumber>secondNumber) {
            if(secondNumber%2==0)
                for (int i=secondNumber+1; i<firstNumber; i+=2)
                    count++;

            else
                for (int i=secondNumber+2; i<firstNumber; i+=2)
                    count++;

        } else {
            if(firstNumber%2==0)
                for (int i=firstNumber+1; i<secondNumber; i+=2)
                    count++;

            else
                for (int i=firstNumber+2; i<secondNumber; i+=2)
                    count++;
        }

        Console.WriteLine(count);
    }
}