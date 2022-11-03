using System;

class Program
{

    static void Main(string[] args)
    {
        try
        {

            int age = 30;

            while (age >= 18)
            {
                Console.WriteLine("With " + age+ " years, the user can vote!"); 
                age--;
            }

            if(age<18)
            {
                 Console.WriteLine("The user has "+ age+ " years and can't vote!");
            }

            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while running the application" + ex);

        }
    }
}
