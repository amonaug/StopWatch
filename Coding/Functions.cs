public static class Functions
{
    public static void Prestart()
    {
        ClearAndWrite("Ready...");
        Thread.Sleep(500);
        ClearAndWrite("Set...");
        Thread.Sleep(500);
        ClearAndWrite("Go...");
        Thread.Sleep(500);
        Console.Clear();
    }

    public static void Start(int timeInSeconds)
    {
        Prestart();
        int currentTime = 0;

        while (currentTime != timeInSeconds)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        ClearAndWrite("StopWatch Finalizado...");
        Thread.Sleep(500);
        Console.Clear();
    }

    private static void ClearAndWrite(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
    }
}