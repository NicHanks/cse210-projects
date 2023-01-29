public class ScriptureGenerator
{
    int _randomPrompts = 0;
    public string GetScripture()
    {
        Random random = new Random();
        String _promptString = "";
        _randomPrompts = random.Next(1,6);

        if (_randomPrompts == 1)
        {
            _promptString = "D&C 58:26 For behold, it is not meet that I should command in all things; \nfor he that is compelled in all things, the same is a slothful and not a wise servant; wherefore he receiveth no reward.";
        }
        else if (_randomPrompts == 2)
        {
            _promptString = "D&C 18:10 Remember the worth of souls is great in the sight of God;";
        }
        else if (_randomPrompts == 3)
        {
            _promptString = "Joshua 24:15 And if it seem evil unto you to serve the Lord, choose you \nthis day whom ye will cserve; whether the gods which your fathers served that were on the other side of the flood, or the \ngods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.";
        }
        else if (_randomPrompts == 4)
        {
            _promptString = "Psalm 118:8 It is better to trust in the Lord than to put confidence in man.";
        }
        else if (_randomPrompts == 5)
        {
            _promptString = "D&C 3:7 For, behold, you should not have feared man more than God. Although men set at naught the counsels of God, and despise his words";
        }
    return _promptString;
    }
}