string parola = "";
char lettera = 'A';
int posizione = -1;
Console.WriteLine("Inserisci la stringa");
parola = Console.ReadLine();
Console.WriteLine("Inserisci la lettera che vuoi controllare");
lettera = Convert.ToChar(Console.ReadLine());
for (int i = 0; i < parola.Length; i++)
{
    if (lettera == parola[i])
    {
        posizione = i;
    }
}
Console.WriteLine($"la posizione di quella lettera e' {posizione}");