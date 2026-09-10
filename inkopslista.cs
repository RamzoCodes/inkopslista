// Syftet med denna uppgiften är att göra en lista som innehåller varor och dess pris


List<string> Varor = []; // Varorna tillhör string
List<int> pris = []; // priserna tillhör int

Console.WriteLine("Hej och välkommen till inköpslistan!");

bool klar = false; 

while (!klar)
{
    Console.WriteLine("Ange vara");
    string Inputvara = Console.ReadLine();

    Console.WriteLine("Ange priset");
    int Inputpris = int.Parse(Console.ReadLine());

    Varor.Add(Inputvara);
    pris.Add(Inputpris);
    
}