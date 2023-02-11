class words
{
    private List<string> _scriptureText = new List<string>();

    public words(List<string> text)
    {
        _scriptureText = text;
    }

    public void set_script(List<string> text)
    {
        _scriptureText = text;
    }

    public List<string> get_script()
    {
        return _scriptureText;
    }

    public List<string> hide_script(int words_removed, List<string> words)
    {

        Random Rand = new Random();

        int tooFewWordsCount = 0;
        for(int i = 0; i < words_removed+1; i++)
        {

            int x = Rand.Next(words.Count()); // randomly chooses word


            foreach (char c in words[x]) 
            {
                if (c.ToString() == "_")
                {
                    i = i-1;
                    break;
                }
            }


            foreach (char c in words[x]) 
            {
                words[x] = words[x].Replace(c.ToString(),"_");
            }
            
            tooFewWordsCount++;
            if (tooFewWordsCount > 100)
            {
                break;
            }
        }
        //
        return _scriptureText;
    }
}
