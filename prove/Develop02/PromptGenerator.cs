public class PromptGenerator
{
    int _randomPrompts = 0;  //ATTRIBUTE
    public string GetPrompt()   //METHOD
    {
        Random random = new Random();
        String _promptString = "";
        _randomPrompts = random.Next(1,5);

        if (_randomPrompts == 1)
        {
            _promptString = "What was your favorite thing that happend to you today? ";
        }
        else if (_randomPrompts == 2)
        {
            _promptString = "How was your day? ";
        }
        else if (_randomPrompts == 3)
        {
            _promptString = "What was the best part of your day? ";
        }
        else if (_randomPrompts == 4)
        {
            _promptString = "Is there anybody that you appreciated today? ";
        }
        else if (_randomPrompts == 5)
        {
            _promptString = "On a scale from 1 to 10, how was your day? ";
        }
    return _promptString;
    }
}