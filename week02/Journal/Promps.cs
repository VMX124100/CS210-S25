public class Prompt
{
List<string> _prompts = new List<string>()
    {
        "How was your day?", "Where did you go?",
        "What was the most interesting thing that happened to you?",
        "What would you change is you could anything?", "Did you meet anyone now today?"
    };

 public string GetRandomPromp()
    {
        Random random= new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPromp = _prompts[randomIndex];
 
        return (randomPromp);
    }
 

 
}