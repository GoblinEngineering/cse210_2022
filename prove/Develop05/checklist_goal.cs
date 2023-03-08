class checklist_goal : goal
{

    checklist_goal(string name, string dialog, int points, int completedTasksCount, bool finished, int target_completions) : base (name, dialog, points, completedTasksCount, finished, target_completions)
    {
        //
    }

    

    public override void complete_task()
    {
        // if (get_finishedTask() == true){
        //     //
        //     return;
        // }
        set_completedTasks(get_completedTasks() + 1);
        if (get_completedTasks() >= get_targetCompletions())
        {
            set_finishedTask(true);
        } 
        //
    }
}