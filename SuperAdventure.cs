
public class SuperAdventure
{
    // CurrentMonster, ThePlayer
    public Monster CurrentMonster;
    public Player ThePlayer;

    public SuperAdventure()
    {
        CurrentMonster = new();
        ThePlayer = new();
    }

    public void Start()
    {
        Console.WriteLine("Welkom to the Super Fantasy Adventure!");
    }
}