// Syftet med denna uppgiften är att göra en lista som innehåller varor och dess pris


List<string> Varor = []; // Varorna tillhör string
List<int> pris = []; // priserna tillhör int

Console.WriteLine("Hej och välkommen till inköpslistan!");

bool klar = false; 

int totalPris = 0;

while (!klar) //så länge den är !, fortsätter koden
{
    Console.WriteLine("Ange vara");
    string Inputvara = Console.ReadLine()!; // vi anger varan här

    Console.WriteLine("Ange priset");
    int Inputpris = int.Parse(Console.ReadLine()!); //här anger vi priset, sedan omvandlas priset till en int, alltså ett heltal

    Varor.Add(Inputvara); //lägger till varan i listan "Varor"
    pris.Add(Inputpris); //lägger till priset i listan "pris"

    totalPris += Inputpris; // lägger det nya priset till totala summan.



    for (int i = 0; i < Varor.Count; i++) //loopar genom alla varor i listan, lägger till 1 varje gång.
    {
        Console.WriteLine($"{i + 1}. {Varor[i]} - {pris[i]} kr"); // skriver ut varan och priset. i+1 gör att listan börjar på 1. Varor[i] hämtar priset på samma position, det gör pris[i] också.  
        Console.WriteLine($"Totalsumma: {totalPris} kr"); //skriver ut aktuella totalsumman
        Console.WriteLine(" "); // jag la till en tom rad för att göra det fint
    }
    Console.WriteLine("För att avsluta, ange s. Annars forsätt skriva nästa vara:"); 
    string avsluta = Console.ReadLine().ToLower(); //läser vår svar, tolower gör stort bokstav till litet. 
    if (avsluta == "s")
    {
        klar = true; //ändrar klar till true så att while loopen stängs och vi blir klara.
    }
}
    
