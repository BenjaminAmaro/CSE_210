using System;

public class Program
{
    static void Main(string[] args)
    {
        Address LectureAdress = new Address("220 Gord Canning Dr", "Blue Mountains", "Ontario", "Canada");
        Address ReceptionAdress = new Address("5333 Bd Laurier", "Mascouche", "Quebec", "Canada");     
        Address OutdoorAdress = new Address("6705 Rue St-Hubert", "Montréal", "Quebec", "Canada");


        Lecture lecture = new Lecture("Jordan Petersen Lecture", "lecture in the University of Montreal.", "1-November-2023", "10:00 Am", LectureAdress, "Jordan Petersen", 84);
        Reception reception = new Reception("VIP F1 Fans", "an exclusive party with F1 drivers", "30-mars-2023", "12:00 Pm", ReceptionAdress, "f1_reservations@hotmail.com");
        OutdoorGathering gathering = new OutdoorGathering("Governor campain", "come support our governor", "19-september-2023", "8:00 Am", OutdoorAdress, "Rain");

        Console.WriteLine("Lecture :");
        Console.WriteLine("Standard Details");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("Full Details: ");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("Short Description: ");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("**********************************************************************");

        Console.WriteLine("Reception :");
        Console.WriteLine("Standard Details: ");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("Full Details: ");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("Short Description: ");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("**********************************************************************");

        Console.WriteLine("Outdoor Gathering :");
        Console.WriteLine("Standard Details: ");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("Full Details: ");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("Short Description: ");
        Console.WriteLine(gathering.GetShortDescription());
        Console.WriteLine("**********************************************************************");
    }
}