
//for (int i = 0; i < 5; i++)
//    {
//    Console.WriteLine(i);
//    }

//Console.Write("Informe a idade do Péricles: ");
//int idadePericles = int.Parse(Console.ReadLine()!);

//while (idadePericles != 57)
//{
//    Console.WriteLine("Tente novamente!");

//    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor!" : "Tente uma idade maior!");

//    idadePericles = int.Parse(Console.ReadLine()!);

//}

//Console.WriteLine("Você conseguiu adivinhar a idade do Péricles!");

int idadePericles;

do
{
    Console.Write("Informe a idade do Péricles: ");
    idadePericles = int.Parse(Console.ReadLine()!);

    if(idadePericles == 57)
    {
        Console.WriteLine("Você conseguiu adivinhar a idade do Péricles!");
        break;
    }

    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor!" : "Tente uma idade maior!");

}

while (idadePericles != 57);