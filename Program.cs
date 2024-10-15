namespace backend_uke_1___dag_1;

class Program
{
    static void Main(string[] args)
    {
        // kompilering = overssette ett program fra et språk til et annet, når du kjører run oversetter den til binærfil også kjører den
        string jelloWorld = "Jello World!";
        Console.WriteLine(jelloWorld);

        // variabler
        double x = 7; // double; desimaltall
        int y = 5; // int; heltall
        Console.WriteLine(x / y);

        // I C# så kaller vi funksjoner for metoder
        // method (funsjoner i andre språk)
        double Add(double a, double b)
        {
            return a * b;
        }
        Console.WriteLine(Add(5, 5)); // -> 25

        // lager en ny instanse av klassen Person
        Person personEn = new Person();
        // gir objektet verdier
        personEn.Name = "Sigrid";
        personEn.Age = 28;
        personEn.Gender = "Female";

        // eksempel på string concatenation aka slå sammen flere strenger til en lengre streng
        Console.WriteLine("Hei " + personEn.Name + " du er " + personEn.Age + " år gammel.");
        // eksempel på string formatting aka slå sammen flere strenger til en streng på en litt enklere måte
        Console.WriteLine($"Hei {personEn.Name}! Du er {personEn.Age} år gammel!");

        Person personTo = new Person();
        personTo.Name = "Jørgen"; // reassign objektet
        personTo.Age = 30;
        personTo.Gender = "Male";

        Console.WriteLine($"Hei {personTo.Name} du er {personTo.Age} år gammel!");

        /**
        Datastrukturer
        **/
        string[] hanldeListe = {"melk", "brød", "egg", "brus", "middag", "snus"};
        Console.WriteLine("Her er handlelisten din");
        for (int i = 2; i < 4; i++)
        {
            Console.WriteLine(hanldeListe[i]); // henter ut strings fra index[] av i
        }

        foreach(string elementer in hanldeListe)
        {
            Console.WriteLine(elementer);
        }

        personEn.SayHello();

        // initiliserer et nytt utility objekt fra Utility klassen
        Utility utility = new Utility();
        string hello = "hello";
        string world = "world";
        Console.WriteLine(utility.SimpleConcat(hello, world));

        bool canEnterTheClub = false;
        int age = 19;
        // ! blir en "shorthand" for å reassigne canEnterClub til true, dvs; canEnterClub = true; er det samme som : !canEnterTheClub dersom det originalt var tildelt

        if (age >= 18 && !canEnterTheClub)
        {
            Console.WriteLine("You can enter the club!");
        }
        else {
            Console.WriteLine("You cannot enter the club");
        }
    }
}
