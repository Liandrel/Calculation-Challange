using CalculationLibrary;

ITemperatureListModel temperatureList = new TemperatureListModel();

PopulateTempList(temperatureList);
PopulateTempListFromWords(temperatureList);

string action = "";
do
{
    Console.Clear();
    Console.WriteLine("List of actions: ");
    Console.WriteLine("* min = get min temperature from list");
    Console.WriteLine("* max = get max temperature from list");
    Console.WriteLine("* avg = get avg temperature from list");
    Console.WriteLine("* exit = exit application");
    Console.WriteLine();

    action = Console.ReadLine();

    switch (action.ToLower())
    {
        case "min":
            Console.WriteLine(temperatureList.minTemp);
            break;
        case "max":
            Console.WriteLine(temperatureList.maxTemp);
            break;
        case "avg":
            Console.WriteLine(temperatureList.avgTemp);
            break;
        default:
            break;
    }
    Console.WriteLine();
    Console.WriteLine("Press ENTER to continue");
    Console.ReadLine();
} while (action != "exit");




void PopulateTempList(ITemperatureListModel temperatureList)
{
    Random rnd = new Random();
    TemperatureModel temp = new();
    for (int i = 0; i < 101; i++)
    {
        temp = new();
        temp.Value = rnd.Next(0, 101);
        temperatureList.Insert(temp);
    }
}

void PopulateTempListFromWords(ITemperatureListModel temperatureList)
{
    List<string> words = new List<string>
    {
       "one",
       "two",
       "three",
       "four",
       "five",
       "six",
       "seven",
       "eight",
       "nine",
       "ten",
    };

    Random rnd = new Random();
    for (int i = 0; i < 100; i++)
    {
        temperatureList.Insert(words[rnd.Next(0,10)]);
    }
}
