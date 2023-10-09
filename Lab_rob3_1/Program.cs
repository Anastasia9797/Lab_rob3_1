// Батьківський клас, що описує пошиття одягу
class Parent
{
    protected double Pole1; // Ширина тканини 
    protected double Pole2; // Норма витрати

    // Конструктор з двома параметрами
    public Parent(double Pole1, double Pole2)
    {
        this.Pole1 = Pole1;
        this.Pole2 = Pole2;
    }

    // Метод, що виводить значення полів на екран
    public void Print()
    {
        Console.WriteLine("\nШирина тканини в м: {0} Норма витрати в м: {1}", Pole1, Pole2);
    }

    // Метод обчислює витрату тканини на одиницю продукції
    public double Metod()
    {
        return Math.Round((2 - Pole1) * Pole2, 2);
    }
}

// Дочірній клас Child1, що описує пошив пальта
class Child1 : Parent
{
    int Pole3; // Розмір пальта 

    // Конструктор з трьома параметрами
    public Child1(double Pole1, double Pole2, int Pole3): base(Pole1, Pole2)
    {
        this.Pole3 = Pole3;
    }

    // Перевизначений метод, що виводить значення полів класу Child1
    public new void Print()
    {
        base.Print();
        Console.WriteLine("Розмiр: {0}", Pole3);
    }

    // Перевизначений метод, що обчислює витрату тканини на пальто
    public new double Metod()
    {
        double x = base.Metod();
        return Math.Round(x + ((Pole3 / 6.5 + 0.5) / 10), 2);
    }
}

// Дочірній клас Child2, що описує пошив костюма
class Child2 : Parent
{
    int Pole4; // Зрозтання

    // Конструктор з трьома параметрами
    public Child2(double Pole1, double Pole2, int Pole4) : base (Pole1, Pole2)
    {
        this.Pole4 = Pole4;
    }

    // Перевизначений метод, що виводить значення полів класу Child2
    public new void Print()
    {
        base.Print();
        Console.WriteLine("Зростання: {0}", Pole4);
    }

    // Перевизначений метод обчислює витрату тканини на костюм
    public new double Metod()
    {
        double x = base.Metod();
        return Math.Round(x + ((2 * Pole4 + 0.3) / 8), 2);
    }
}

// У методі Main класу Program створимо об'єкти батьківського і дочірніх класів та застосуємо до них методи
class Program
{
    static void Main(string[] args)
    {
        Parent pr = new Parent(1.4, 2);
        pr.Print();
        Console.WriteLine("Витрата тканини на одяг: {0}", pr.Metod());

        Child1 ch1 = new Child1(1.4, 2, 50);
        ch1.Print();
        Console.WriteLine("Витрата тканини на пальто: {0}", ch1.Metod());

        Child2 ch2 = new Child2(1.4, 2, 2);
        ch2.Print();
        Console.WriteLine("Витрата тканини на костюм: {0}", ch2.Metod());
    }
}