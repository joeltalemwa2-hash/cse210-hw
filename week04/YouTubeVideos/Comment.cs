public class Comment
{
    public string _name = "";
    public string _text = "";

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}