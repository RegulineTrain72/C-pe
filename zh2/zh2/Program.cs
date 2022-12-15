using System;
using zh2;

List<engiszi> list = new List<engiszi>();
int size = 3628;

for (int i = 0; i < size; i++)
{
    list.Add(new engiszi());
}

int sum = 0;
int optimist = 0;
int ordinary = 0;
int pessimist = 0;

foreach (engiszi engiszi in list)
{
    sum += engiszi.mood;
    switch (engiszi.type)
    {
        case "ordinary":
            ordinary++;
            break;
        case "optimist":
            optimist++;
            break;
        case "pessimist":
            pessimist++;
            break;

    }
}
Console.WriteLine("összboldogság: " + sum);
Console.WriteLine("A bolygó népessége: " + size);
Console.WriteLine("optimista: " + ((float)optimist / size) * 100 + "% , pesszimista: " + ((float)pessimist / size) * 100 + "% , átlagos: " + ((float)ordinary / size) * 100 + "%");
