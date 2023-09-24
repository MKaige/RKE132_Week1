// This is a comment to my code

// Rakendus küsib kasutajal sisestada tema nime
// Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output - kõik mida kuvatakse on väljundid ehk output
//string = sõne ehk sisestada saab ainult teksti; loob koha vahemälus andmete salvestamiseks
//string userName;

// võtab andmed konsoolist ja salvestab sisestatud  nime
//userName = Console.ReadLine();

//lühem versioon:
string userName = Console.ReadLine(); //Input - kõik mida sisestatakse on input

// Console.WriteLine("Hello" + ", " + userName + "!"); //Output
//string interpolation - süstitamine
Console.WriteLine($"Hello, {userName}!"); //Output

//Käsud on alati sulgudega (), peale punkti on käsk mida tegema peab, käsud lõpevad alati ";" märgiga