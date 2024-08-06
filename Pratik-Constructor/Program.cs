
// Parametresiz constructor ile bebek oluşturma
Baby baby1 = new Baby();
baby1.Name = "Can";
baby1.LastName = "Biricik";
Console.WriteLine("Baby 1:");
baby1.Introduce();

Console.WriteLine();

// Parametreli constructor ile bebek oluşturma
Baby baby2 = new Baby("Melih", "Uçar");
Console.WriteLine("Baby 2:");
baby2.Introduce();
    