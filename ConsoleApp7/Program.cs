string name;
int hunger = 50;
int energy = 50;
int mood = 50;
bool alive = true;
int choice = 0;
Console.Write("Вашего питомца зовут: ");
name = Console.ReadLine();

while (alive == true)
{
    Console.WriteLine($"=== ПИТОМЕЦ: {name} ===");
    Console.WriteLine($"Голод: {hunger} | Энергия: {energy} | Настроение: {mood}" );
    Console.WriteLine("1 - Покормить");
    Console.WriteLine("2 - Поиграть");
    Console.WriteLine("3 - Уложить спать");
    Console.WriteLine("4 - Выход");
    Console.Write("Ваш выбор: ");
    choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            hunger -= 20;
            energy += 10;
            mood += 5;
            Console.WriteLine($"{name} поел! Голод: {hunger}, Энергия: {energy}, Настроение: {mood}");
            break;
        case 2:
            mood += 15;
            energy -= 20;
            hunger += 10;
            Console.WriteLine($"{name} поиграл! Настроение: {mood}, Энергия: {energy}, Голод: {hunger}");
            break;
        case 3:
            energy += 30;
            hunger += 10;
            Console.WriteLine($"{name} поспал! Энергия: {energy}, Голод: {hunger}, Настроение: {mood}");
            break;
        case 4:
            alive = false;
            break;
        default:
            Console.WriteLine("Выбран неверный вариант");
            break;
    }

    if (hunger > 100) hunger = 100;
    if (energy > 100) energy = 100;
    if (mood > 100) mood = 100;
    if (hunger < 0) hunger = 0;
    if (energy < 0) energy = 0;
    if (mood < 0) mood = 0;
    
    
    if (hunger >= 100 || energy <= 0 )
    {
        alive = false;
        Console.WriteLine($"{name} погиб...");
    } else if (hunger > 80)
    {
        Console.WriteLine($"{name} очень голоден");
    }  else if (energy < 20)
    {
        Console.WriteLine($"{name} очень устал!");
    } else if (mood < 20)
    {
        Console.WriteLine($"{name} очень грустит!");
    }
}

