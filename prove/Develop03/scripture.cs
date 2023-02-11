class scripture

{

    private List<string> script_list = new List<string>();
    private string script = "Then said the lord of the vineyard, What shall I do? I will send my beloved son: it may be they will reverence him when they see him.";

    public scripture(string scripture)
    {
        script = scripture;
    }
    public scripture(){}


        public void set_script(string text)
    {
        script = text;
    }

    public string get_script()
    {
        return script;
    }

    public void set_script_list(List<string> text)
    {
        script_list = text;
    }

    public List<string> get_script_list()
    {
        return script_list;
    }

    public List<string> create_list(string text)
    {
        script_list = text.Split(" ").ToList();
        return script_list;
    }

}