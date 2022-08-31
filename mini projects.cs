string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View english output:
    c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt");



int fahrenheit = 94;
double C = (Convert.ToDouble(fahrenheit) - 32) * 5 / 9;
Console.WriteLine($"{C} Celsius");

string[] IDs = { "B123", "C234", "A345", "C15", "B17", "B179", "C235", "G3003" };
foreach (string ID in IDs)
{
    if (ID.StartsWith("B"))
    {
        Console.WriteLine(ID);
    }
}


string permission = "Admin|Manager";
int level = 55;
bool result = level > 55 ? true : false;
if (result == true)
{
    Console.WriteLine("welcome");
}
else
{
    Console.WriteLine("Get out!");
}