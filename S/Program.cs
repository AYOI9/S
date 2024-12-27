struct Computer
{
    public string Name;
    public double Frequency;
    public int Ram;
    public bool HasDvdRom;
    public double Price;
}

class Program
{
    static void Main()
    {
        Computer[] computers = new Computer[3];

        computers[0] = new Computer { Name = "Компьютер A", Frequency = 2.5, Ram = 8, HasDvdRom = true, Price = 500 };
        computers[1] = new Computer { Name = "Компьютер B", Frequency = 3.0, Ram = 16, HasDvdRom = false, Price = 800 };
        computers[2] = new Computer { Name = "Компьютер C", Frequency = 2.0, Ram = 4, HasDvdRom = true, Price = 300 };

        double totalPrice = 0;

        for (int i = 0; i < computers.Length; i++)
        {
            totalPrice += computers[i].Price;
        }

        double averagePrice = totalPrice / computers.Length;

        for (int i = 0; i < computers.Length; i++)
        {
            Console.WriteLine($"{computers[i].Name}: {averagePrice}");
        }
    }
}
