using System;

// Base Class
public class Button
{
    public string Name;
    public  void Show()
    {
        Console.WriteLine(Name+ "button is displayed");
    }

    public virtual void Click()
    {
        Console.WriteLine(Name + " button clicked.");
    }
}

// Sub-class 1: Login Button
public class LoginButton : Button
{
    public LoginButton(){
        Name = "Login";

    }

    public override void Click()
    {
        Console.WriteLine("Logging in.....");
    }
}

// Sub-class 2: Print Button
public class PrintButton : Button
{
    public PrintButton() {
        Name = "Print";
    }

    public override void Click()
    {
        Console.WriteLine("Printing Document");
    }
}

public class Program
{
    public static void Main()
    {
        Button login = new LoginButton();
        Button print = new PrintButton();

        // Show buttons
        login.Show();
        login.Click();
     

        // Click buttons
        print.Click();
        print.Show();
    }
}
