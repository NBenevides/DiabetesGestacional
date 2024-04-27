int glicemia;

Console.Write("Digite a sua glicemia (em mg/dL): ");
glicemia = Convert.ToInt32(Console.ReadLine());

if(glicemia > 126)
{
    ﻿Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Diabetes Mellitus na Gravidez"); 
}
else
{
    if(glicemia >= 92)
    {
        ﻿Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Compatível com Diabetes Gestacional");
    }
    else
    {
        ﻿Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
    }
}

Console.WriteLine();


Console.ResetColor();
