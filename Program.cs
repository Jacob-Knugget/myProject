using System;

namespace myProject
{
    class myStore
    {
        static void Main(string[] args)
        {
            monster FirstMonster = new monster();
            FirstMonster.SetCount();
            FirstMonster.SetName("Archaic");
            FirstMonster.SetType("Celestial");
            FirstMonster.SetChallenge(18);

            monster SecondMonster = new monster();
            SecondMonster.SetCount();
            Console.Write("Please enter the monster's name: ");
            SecondMonster.SetName(Console.ReadLine());
            Console.Write("Please enter the monster's creature type: ");
            SecondMonster.SetType(Console.ReadLine());
            Console.Write("Please enter the monster's challenge rating: ");
            SecondMonster.SetChallenge(int.Parse(Console.ReadLine()));

            monster ThirdMonster = new monster("Iron Golem", "Construct", 16);
            ThirdMonster.SetCount();

            Console.Write("Please enter the monster's name: ");
            string tempName = Console.ReadLine();
            Console.Write("Please enter the monster's creature type: ");
            string tempType = Console.ReadLine();
            Console.Write("Please enter the monster's challenge rating: ");
            int tempChallenge = int.Parse(Console.ReadLine());
            monster FourthMonster = new monster(tempName, tempType, tempChallenge);
            FourthMonster.SetCount();

            Console.WriteLine($"There are currently {FirstMonster.GetCount()} monsters");
            Console.WriteLine("Here are the monsters listed: \n");
            displayBooks(FirstMonster);
            displayBooks(SecondMonster);
            displayBooks(ThirdMonster);
            displayBooks(FourthMonster);
        }

        static void displayBooks(monster number)
        {
            Console.WriteLine($"Monster Name: {number.GetName()}");
            Console.WriteLine($"Creature Type: {number.GetMonType()}");
            Console.WriteLine($"Challenge Rating: {number.GetChallenge()}\n");
        }
    }
}

class monster
{
    private string _name;
    private string _type;
    private int _challenge;
    private static int _counter = 0;

    public monster()
    {
        _name = "";
        _type = "";
        _challenge = 0;
    }

    public monster(string called, string sub, int difficulty)
    {
        _name = called;
        _type = sub;
        _challenge = difficulty;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetMonType()
    {
        return _type;
    }

    public int GetChallenge()
    {
        return _challenge;
    }

    public int GetCount()
    {
        return _counter;
    }

    public void SetName(string identify)
    {
        _name = identify;
    }

    public void SetType(string template)
    {
        _type = template;
    }

    public void SetChallenge(int cr)
    {
        _challenge = cr;
    }

    public void SetCount()
    {
        _counter++;
    }
}