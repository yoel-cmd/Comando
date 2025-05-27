public class Enemy
{
    public string name { get; set; }
    public int life { get; set; } = 100;
    public bool status { get; set; }
    public string shout { get; } = "I am an enemy.";
    //----------------------------------------------------------
    public Enemy(string name, bool status)
    {
        this.name = name;
        this.status = status;
    }
    //----------------------------------------------------------

}