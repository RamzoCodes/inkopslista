// Syftet med denna uppgiften är att göra en lista som innehåller varor och dess pris


List<string> Varor = []; // Varorna tillhör string (text)
List<int> pris = []; // priserna tillhör int (heltal)

Console.WriteLine("Hej och välkommen till inköpslistan!");

bool klar = false; //En bool kan vara antingen false eller true. denna är false, vilket betyder i denna kontext att programmet inte är klart

int totalPris = 0; // Detta är variabeln som håller reda på totalpriset. Den börjar på 0 för att det är startvärdet på summan, vilket kommer adderas med varje pris vi lägger till i listan.

while (!klar) //Loopen börjar här. så länge den är ! (inte), så fortsätter loopen köra. när den eventuellt blir true kommer loopen stanna. 
{
    Console.WriteLine("Ange vara");
    string Inputvara = Console.ReadLine()!; // vi anger varans namn här med text

        Console.WriteLine ("Mata in pris: ");
    if (!int.TryParse(Console.ReadLine(), out int Inputpris)) //vi anger varans pris här med ett heltal, maskinen försöker då att omvandla användarens input till en int, det vill säga så att den själv kan uppfatta det som en heltar
{
    Console.WriteLine("Ange en siffra!");
    continue;  //här avbryts denna varv och då hoppar vi tillbaka till början av while-loopen
} 

    Varor.Add(Inputvara); //lägger till varan i listan "Varor"
    pris.Add(Inputpris); //lägger till priset i listan "pris"

    totalPris += Inputpris; // lägger det inputpris i totalpris.



    for (int i = 0; i < Varor.Count; i++) //Börjar på 0, loopar genom alla varor i listan, lägger till 1 varje gång.
    {
        Console.WriteLine($"{i + 1}. {Varor[i]} - {pris[i]} kr"); // skriver ut varan och priset. i+1 gör att listan börjar på 1. Varor[i] hämtar priset på samma position, det gör pris[i] också.  
        
    }
   
   Console.WriteLine($"Totalsumma: {totalPris} kr"); //skriver ut aktuella totalsumman

        Console.WriteLine(" "); // jag la till en tom rad för att göra det fint

    Console.WriteLine("Vill du ta bort något?"); // frågar om användaren vill ta bort en vara

    string? input = Console.ReadLine()!.ToUpper(); // Läser svaret och tolkar det som stora bokstäver (för att få olika inmatningar som "ja", "Ja", "jA", "JA" att räknas på samma sätt.)

    if (input == "JA") //kontrollerar att användarens input är ja
    {
       Console.WriteLine("Ange nummer: "); //man ska ange numret som varan tillhör

        string? num= Console.ReadLine(); //här skrivs det

        if (int.TryParse(num, out int inputAsNum) && //kontrollerar att inputen går att omvandla till en int

        inputAsNum >=1 && // Kontrollerar att användaren inte väljer ett heltal mindre än 1

        inputAsNum <= Varor.Count) // Kontrollerar att numret faktiskt finns med i listan

    {totalPris -=pris[inputAsNum - 1]; //

    Varor.RemoveAt(inputAsNum - 1);

    pris.RemoveAt(inputAsNum - 1);
    
    }
    else
        {
            Console.WriteLine("Ange ett giltigt nummer tack.");
        }
            for (int i = 0; i < Varor.Count; i++) //loopar genom alla varor i listan, lägger till 1 varje gång.
    {
        Console.WriteLine($"{i + 1}. {Varor[i]} - {pris[i]} kr"); // skriver ut varan och priset. i+1 gör att listan börjar på 1. Varor[i] hämtar priset på samma position, det gör pris[i] också.  
        
    }
   
   Console.WriteLine($"Totalsumma: {totalPris} kr"); //skriver ut aktuella totalsumman
        Console.WriteLine(" "); // jag la till en tom rad för att göra det fint
    }

 Console.WriteLine("För att avsluta, ange S. För att fortsätta, tryck Y"); 
    string avsluta = Console.ReadLine()!.ToLower(); //läser vår svar, tolower gör stort bokstav till litet. 
    if (avsluta == "s")
    {
        klar = true; //ändrar klar till true så att while loopen stängs och vi blir klara.
    }
 
        
}
    
 