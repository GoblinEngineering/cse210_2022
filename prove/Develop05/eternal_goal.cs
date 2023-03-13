class eternal_goal : goal
{
    public eternal_goal(string name, string dialog, int points, int completedTasksCount, bool finished, int target_completions) : base (name, dialog, points, completedTasksCount, finished, target_completions)
    {
        //
    }

    public override void complete_task()
    {
        set_completedTasks(get_completedTasks() + 1);
    }
}