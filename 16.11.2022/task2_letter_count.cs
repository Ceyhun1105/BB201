using System.IO;
using System;

class Program
{
    static void Main()
    {
        string name;
        Console.Write("Enter the name : ");
        name=Console.ReadLine();
        
        char[] nameArray = new char[name.Length];
        for(int j=0;j<name.Length;j++){
            nameArray[j]=name[j];
        }
        
        foreach(char i in nameArray){
            int count=0;
            if(i=='0' | i==' ')
            continue;
            else{
            for(int j=0;j<nameArray.Length;j++){
                if(i==nameArray[j]){
                count++;
                nameArray[j]='0';
                }
            }
            }
            Console.WriteLine($"{i} - {count}");
        }
    }
}