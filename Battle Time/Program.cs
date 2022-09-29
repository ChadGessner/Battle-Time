using System;

Console.WriteLine("Enter the name of your character: ");
string name = Console.ReadLine();
int vanquished = 0;
int hp = 20;
int armor = 20;
int shield = 50;
Random random = new Random();

string[] enemies = new string[] 
{
    "Dracula",
    "Mr. T",
    "Liquid Metal Richard Simmons",
    "The Scary man from the Oatmeal box",
    "Brad Pit from Fight Club" 
};

string[] actions = new string[]
{
    "critical hit",
    "glancing blow",
    "miss",
    "fatality!",
    "Direct hit to the groin!"
};

while (hp > 0)
{
    if(vanquished > 9)
    {
        Console.WriteLine($"ヽ( ˋ(00)´ )ノヽ( ˋ(00)´ )ノヽ( ˋ(00)´ )ノ All {name}'s enemies have been vanquished! ヽ( ˋ(00)´ )ノヽ( ˋ(00)´ )ノヽ( ˋ(00)´ )ノ");
        break;
    }
    if(hp <= 0)
    {
        Console.WriteLine($"{name} got ded :(");
        break;
    }
    string enemy = enemies[random.Next(5)];
    bool isEnemy = true;
    Console.WriteLine($"A wild {enemy} appears!");
    while (isEnemy)
    {
        Console.WriteLine("Press <r> for run or <a> for attack : ");
        string input = Console.ReadLine();
        if (input.ToLower() == "r")
        {
            Console.WriteLine("Phew that was scary!");
            continue;
        }
        if (input.ToLower() == "a")
        {
            string act = actions[random.Next(5)];
            Console.WriteLine($"{name} struck with a {act}");
            if (act == "critical hit" || act == "fatality!" || act == "Direct hit to the groin!")
            {
                Console.WriteLine(" ヽ( ˋ(00)´ )ノ You have vanquished your opponent! ヽ( ˋ(00)´ )ノ");
                isEnemy = false;
                continue;
            }
            else
            {
                Console.WriteLine($"Now its {enemy}'s turn!");
                act = actions[random.Next(5)];
                Console.WriteLine($"{enemy} struck with a {act}!");
                if (act == "critical hit" || act == "fatality!" || act == "Direct hit to the groin!")
                {
                    if (shield > 0)
                    {
                        shield -= 20;
                        continue;
                    }
                    if (armor > 0)
                    {
                        armor -= 20;
                        continue;
                    }
                    if (hp > 0)
                    {
                        hp -= 20;
                    }
                    if (hp > 0 && hp < 6)
                    {
                        Console.WriteLine($"{name}'s hp is 5 or below!");
                        continue;
                    }
                    
                    Console.WriteLine($"Now its {name}'s turn!");
                    continue;
                }
            }
        }
    }
    
}
