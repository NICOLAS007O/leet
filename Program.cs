
string galinhapintadinha;
string nomeLeet;

Console.Clear();
Console.WriteLine("--- escreva uma frase que ela sera Criptografada --- ");
galinhapintadinha = Console.ReadLine().ToUpper();

nomeLeet = galinhapintadinha
            .Replace("A", "4")
            .Replace("E", "3")
            .Replace("I", "1")
            .Replace("O", "0")
            .Replace("T", "7")
            .Replace("S", "5");

Console.WriteLine(nomeLeet);

