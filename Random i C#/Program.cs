using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a person's name:");
        string personNavn = Console.ReadLine();

        string randomHobby = GetRandomHobby();

        Console.WriteLine($"{personNavn}'s random hobby is: {randomHobby}");

        Console.ReadLine(); 
    }

    static string GetRandomHobby()
    {
        string[] hobbies = { "Running", "Music", "Cooking", "Painting" };

        Random random = new Random();
        int index = random.Next(hobbies.Length);

        return hobbies[index];
    }
    


        

}




