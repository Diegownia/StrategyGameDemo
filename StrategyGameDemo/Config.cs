using Spectre.Console;

namespace StrategyGameDemo;

public class Config
{
    public void RunConsole()
    {
        //LoadData();
        GreetingScreen();
        PrintMenu();
    }

    private void GreetingScreen()
    {
        AnsiConsole.Write(new FigletText("Strategy Game")
            .Color(Color.Blue));
    }

    private void PrintMenu()
    {
        var menu = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[blue]Main Menu[/]")
                .PageSize(3)
                .AddChoices(new[]
                {
                    "Start Game",
                    "Options",
                    "Quit",
                }));
        
        AnsiConsole.WriteLine($"You've picked {menu}!");
    }
}