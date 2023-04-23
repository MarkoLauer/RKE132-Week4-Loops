

using System.ComponentModel.Design;

//Random rnd = new Random();
//int cpuRandom;

//bool loopActive = true; //bool - true/false

//while (loopActive)
//{
//    cpuRandom = rnd.Next(1, 4);
//    Console.WriteLine($"cpu created rnd {cpuRandom}");
//    Console.WriteLine("Make a guess. Enter a number 1-3");
//    int userNumber = Int32.Parse(Console.ReadLine());

//    if (userNumber == cpuRandom) 
//    {
//        Console.WriteLine("Congratulations, you won!");
//        loopActive = false;
//        //"break" lõpetab while loopimise jõuga
//    } 
//    else
//    {
//        Console.WriteLine("Oops, try again!");
//    }
//}
//
//Console.WriteLine("Have a nice day!");


Console.WriteLine("Enter a number");
int userNumber = Int32.Parse(Console.ReadLine());
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i + 1} * {userNumber} = {(i +1) * userNumber}");
}