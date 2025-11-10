using System;
using System.Collections.Generic;

public class TodoList
{
    // The list to store our tasks (strings)
    private static List<string> tasks = new List<string>();

    public static void Main(string[] args)
    {
        bool running = true;
        Console.WriteLine("--- Simple To-Do List Manager ---");

        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    running = false; // Exit the loop
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    break;
            }
            Console.WriteLine(); // Add a blank line for readability
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Add a task");
        Console.WriteLine("2. View all tasks");
        Console.WriteLine("3. Remove a task");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    private static void AddTask()
    {
        Console.Write("Enter the description of the new task: ");
        string newTask = Console.ReadLine();
        // Check to ensure the user actually typed something
        if (!string.IsNullOrWhiteSpace(newTask))
        {
            tasks.Add(newTask);
            Console.WriteLine($"Task added: '{newTask}'");
        }
        else
        {
            Console.WriteLine("Task cannot be empty.");
        }
    }

    private static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Your to-do list is empty!");
            return;
        }

        Console.WriteLine("\n--- Your Tasks ---");
        // Use a 'for' loop to display the index (number) of the task
        for (int i = 0; i < tasks.Count; i++)
        {
            // i + 1 gives us the user-friendly number starting at 1
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
        Console.WriteLine("------------------");
    }

    private static void RemoveTask()
    {
        ViewTasks(); // Show the user the list so they know what number to remove
        if (tasks.Count == 0)
        {
            return; // Exit if the list is empty
        }

        Console.Write("Enter the number of the task to remove: ");
        
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            // Convert user input (1-based index) to list index (0-based index)
            int indexToRemove = taskNumber - 1; 

            // Input validation: Check if the index is valid
            if (indexToRemove >= 0 && indexToRemove < tasks.Count)
            {
                string removedTask = tasks[indexToRemove];
                tasks.RemoveAt(indexToRemove);
                Console.WriteLine($"Task removed: '{removedTask}'");
            }
            else
            {
                Console.WriteLine("Error: That task number does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
