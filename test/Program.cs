class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}
class Program
{
    private static void Main(string[] args)
    {
        User user = new User(); //Начало

        Console.Write("Введите ваше имя: ");

        user.Name = Console.ReadLine();

        Console.Write("Введите ваш логин: ");

        user.Login = Console.ReadLine();

        Console.Write("Есть ли у вас премиум-подписка на наш сайт?: Да или Нет!: ");  //Условие

        string answer = Console.ReadLine();


        if (answer == "Нет")
        {
            ShowAds();
        }
        if (answer == "Да")
        {
            Console.WriteLine("Приятного просмотра!");
        }
        else
        {
            Console.WriteLine("Введена неверная команда!");
        }

        //Конец

    }
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");

        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");

        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");

        Thread.Sleep(3000);
    }
}
