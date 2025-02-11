using System;

public class Task
{
    public int TaskID { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public Task Next { get; set; }

    public Task(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

public class TaskSchedular
{
    private Task head;

    public TaskSchedular()
    {
        head = null;
    }

    public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head;
        }
        else
        {
            newTask.Next = head;
            head = newTask;
        }
    }
    public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
    }
    public void AddTaskAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Position should be >= 1.");
            return;
        }
        if (position == 1)
        {
            AddTaskAtBeginning(taskId, taskName, priority, dueDate);
            return;
        }
        Task newTask = new Task(taskId, taskName, priority, dueDate);
        Task temp = head;
        for (int i = 1; i < position - 1; i++)
        {
            if (temp.Next == head)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            temp = temp.Next;
        }
        newTask.Next = temp.Next;
        temp.Next = newTask;
    }
    public void RemoveTaskByTaskId(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("Task not found!");
            return;
        }
        if (head.TaskID == taskId)
        {
            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                Task temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = head.Next;
                head = head.Next;
            }
            return;
        }
        Task current = head;
        while (current.Next != head && current.Next.TaskID != taskId)
        {
            current = current.Next;
        }
        if (current.Next == head)
        {
            Console.WriteLine("Task not found!");
            return;
        }
        current.Next = current.Next.Next;
    }
    public void CurrentTask()
    {
        if (head == null)
        {
            Console.WriteLine("No task available.");
            return;
        }
        Console.WriteLine("Task ID: {0}", head.TaskID);
        Console.WriteLine("Task Name: {0}", head.TaskName);
        Console.WriteLine("Priority: {0}", head.Priority);
        Console.WriteLine("Due Date: {0}", head.DueDate);
        head = head.Next;
    }
    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No task available.");
            return;
        }
        Task temp = head;
        do
        {
            Console.WriteLine("Task ID: {0}", temp.TaskID);
            Console.WriteLine("Task Name: {0}", temp.TaskName);
            Console.WriteLine("Priority: {0}", temp.Priority);
            Console.WriteLine("Due Date: {0}", temp.DueDate);
            temp = temp.Next;
        } while (temp != head);
    }
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No task available.");
            return;
        }
        Task temp = head;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine("Task ID: {0}", temp.TaskID);
                Console.WriteLine("Task Name: {0}", temp.TaskName);
                Console.WriteLine("Priority: {0}", temp.Priority);
                Console.WriteLine("Due Date: {0}", temp.DueDate);
            }
            temp = temp.Next;
        } while (temp != head);
    }
}
public class Program
{
    public static void Main()
    {
        TaskSchedular taskSchedular = new TaskSchedular();
        
        taskSchedular.AddTaskAtBeginning(1, "Task 1", 1, DateTime.Now.AddDays(1));
        taskSchedular.AddTaskAtEnd(2, "Task 2", 2, DateTime.Now.AddDays(2));
        taskSchedular.AddTaskAtPosition(3, "Task 3", 3, DateTime.Now.AddDays(3), 2);
        
        Console.WriteLine("All tasks:");
        taskSchedular.DisplayAllTasks();
        
        Console.WriteLine("\nCurrent task:");
        taskSchedular.CurrentTask();
        
        Console.WriteLine("\nAll tasks after moving to next:");
        taskSchedular.DisplayAllTasks();
        
        Console.WriteLine("\nSearch tasks with priority 2:");
        taskSchedular.SearchByPriority(2);
        
        Console.WriteLine("\nRemoving task with ID 2:");
        taskSchedular.RemoveTaskByTaskId(2);
        
        Console.WriteLine("\nAll tasks after removal:");
        taskSchedular.DisplayAllTasks();
    }
}