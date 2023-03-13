class goal
{
    //
    private string _name;
    private int _completedTasks = 0;//
    private string _taskDialog;
    private bool _finishedTask;//
    private int _pointValue;
    private int _targetCompletions;

    
    

    public goal(string name, string dialog, int points, int completedTasksCount, bool finished, int target_completions)
    {
        _name = name;
        _taskDialog = dialog;
        _pointValue = points;
        _completedTasks = completedTasksCount;
        _finishedTask = finished;
        _targetCompletions = target_completions;
    }

    public virtual void complete_task()
    {
        //
    }

    public string get_name()
    {
        return _name;
    }

    public int get_completedTasks()
    {
        return _completedTasks;
    }

    public string get_taskDialog()
    {
        return _taskDialog;
    }
    public bool get_finishedTask()
    {
        return _finishedTask;
    }
    public int get_pointValue()
    {
        return _pointValue;
    }
    public int get_targetCompletions()
    {
        return _targetCompletions;
    }
    

    public void set_finishedTask(bool finishedTask)
    {
        _finishedTask = finishedTask;
    }

    public void set_completedTasks(int completedTask)
    {
        _completedTasks = completedTask;
    }



}