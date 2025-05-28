public class Enemy
{
    public string name { get; set; }
    public int life { get; set; } = 100;
    public bool status { get; set; } = true;
    public string shout { get; } = "I am an enemy.";
    //----------------------------------------------------------
    public Enemy(string name)
    {
        this.name = name;
    }
    //----------------------------------------------------------

}