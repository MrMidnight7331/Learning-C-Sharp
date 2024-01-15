/*
 * @Project: Rock Paper Scissors C# Edition
 * @Author: MrMidnight
 * @Version: 1.0
 */
using System.Windows;

namespace RockPaperScissors;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RockButton_Click(object sender, RoutedEventArgs e)
    {
        PlayGame(1);
    }

    private void PaperButton_Click(object sender, RoutedEventArgs e)
    {
        PlayGame(2);
    }

    private void ScissorsButton_Click(object sender, RoutedEventArgs e)
    {
        PlayGame(3);
    }

    private void PlayGame(int userChoice)
    {
        int computerChoice = GetComputerChoice();

        string result = DetermineWinner(userChoice, computerChoice);

        ResultText.Text = $"Computer chose: {GetChoiceName(computerChoice)}\n{result}";
    }

    private int GetComputerChoice()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }

    private string GetChoiceName(int choice)
    {
        if (choice == 1)
        {
            return "Rock";
        }
        else if (choice == 2)
        {
            return "Paper";
        }
        else
        {
            return "Scissors";
        }
    }

    private string DetermineWinner(int userChoice, int computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return "It's a tie!";
        }
        else if ((userChoice == 1 && computerChoice == 3) ||
                 (userChoice == 2 && computerChoice == 1) ||
                 (userChoice == 3 && computerChoice == 2))
        {
            return "Player Wins!";
        }
        else
        {
            return "Computer Wins!";
        }
    }
}