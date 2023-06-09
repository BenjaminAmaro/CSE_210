using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice;
        do
        {

    Console.WriteLine("Menu Options: ");
    Console.WriteLine("1. Start breathing activity ");
    Console.WriteLine("2. Start reflecting activity ");
    Console.WriteLine("3. Start listing activity ");
    Console.WriteLine("4. Start specialized Breathing activity ");
    Console.WriteLine("5. Quit ");
    Console.Write("Select a choice from the menu: ");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {


        case 1:
            Console.Clear();
            BreathingActivity breathe = new BreathingActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","Breath in...", "Breath out...");
            
            breathe.GetInfoStart();

            breathe.SetDuration();

            Console.WriteLine("Get Ready... ");
            Thread.Sleep(0500);
            breathe.MethodSpin();

            breathe.Breathing();
            breathe.GetInfoEnd();

            breathe.MethodSpin();
            Console.Clear();

            break;



        case 2:
            Console.Clear();
            ReflectingActivty reflecting1 = new ReflectingActivty("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
            
            reflecting1.GetInfoStart();
            reflecting1.SetDuration();

            Console.WriteLine("Get Ready... ");
            reflecting1.MethodSpin();

            reflecting1.prompt();
            reflecting1.StartReflect();
            reflecting1.ReflectingPrompts();

            reflecting1.GetInfoEnd();

            reflecting1.MethodSpin();
            Console.Clear();


            break;



        case 3:
            Console.Clear();
            ListingActivity reflecting3 = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ");

            reflecting3.GetInfoStart();

            reflecting3.SetDuration();

            Console.WriteLine("Get Ready... ");
            reflecting3.MethodSpin();
            reflecting3.StartListing();
            reflecting3.GetInfoEnd();
            reflecting3.MethodSpin();
            Console.Clear();


            break;



        case 4:
            Console.Clear();
            SpecializedActivity special = new SpecializedActivity("Specialized Breathing", "This activity will help you RELAX, FOCUS, or WAKE UP by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breath in...", "Breath out...", "Hold...");

            special.GetInfoStart();

            special.SetDuration();
            Console.Clear();
            int choice1;
            do
            {
                Console.WriteLine("Menu Specialized Breathing: ");
                Console.WriteLine("1. Deep relax breathing");
                Console.WriteLine("2. Focus breathing ");
                Console.WriteLine("3. Wake up breathing ");
                Console.WriteLine("4. Quit ");
                Console.Write("Select a choice from the menu: ");
                choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Deep relax breathing");
                        Console.WriteLine("Get Ready... ");
                        Thread.Sleep(0500);
                        special.MethodSpin();
                        special.BreathingLow();
                        special.GetInfoEnd();
                        special.MethodSpin();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Focus Breathing");
                        Console.WriteLine("Get Ready... ");
                        Thread.Sleep(0500);
                        special.MethodSpin();

                        special.BreathingFocus();
                        special.GetInfoEnd();
                        special.MethodSpin();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Wake Up Breathing");
                        Console.WriteLine("Get Ready... ");
                        Thread.Sleep(0500);
                        special.MethodSpin();

                        special.BreathingWakeUP();
                        special.GetInfoEnd();
                        special.MethodSpin();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Retunning to the main Menu");
                        special.MethodSpin();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice ");
                        break;
                }
            } while (choice1 != 4);
                break;

            case 5:
                Console.WriteLine("Nicely done bye! ");
                break;
            
            default:
                Console.WriteLine("Invalid Choice ");
                break;
        }
            }while (choice!= 5);
    }
}