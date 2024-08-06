// Baby sınıfı tanımı
public class Baby
{
    // Özellikler (Properties)
    public DateTime BirthDate { get; private set; }
    public string Name { get; set; }
    public string LastName { get; set; }

    // Parametresiz constructor
    public Baby()
    {
        Initialize();
    }

    // Ad ve Soyad parametreli constructor
    public Baby(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
        Initialize();
    }

    // Her iki constructor'ın ortak işlemleri için yardımcı metod
    private void Initialize()
    {
        Console.WriteLine("Ingaaaa");
        BirthDate = DateTime.Now;
    }

    // Bebeğin bilgilerini yazdıran metod
    public void Introduce()
    {
        Console.WriteLine($"Doğum Tarihi: {BirthDate}");
        Console.WriteLine($"Adı: {Name}");
        Console.WriteLine($"Soyadı: {LastName}");
    }
}