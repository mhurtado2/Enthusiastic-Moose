using System;
using System.Linq;
using System.Collections.Generic;


Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();


    void MooseSays(string message)
    {
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }

    bool MooseAsks(string question)
    {
        Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();

        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        if (answer == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    void questions()
    {
        // void CanadaQuestion()
        {
            bool isTrue = MooseAsks("Is Canada real?");
            if (isTrue)
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else
            {
                MooseSays("I  K N E W  I T !!!");
            }
        }

        // void EnthusiasticQuestion()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSays("Yay!");
            }
            else
            {
                MooseSays("You should try it!");
            }
        }

        // void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
        }

        // void SecretQuestion()
        {
            bool wantsSecret = MooseAsks("Do you want to know a secret?");
            if (wantsSecret)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
        }


        // LoveCSharpQuestion();
        // EnthusiasticQuestion();
        // CanadaQuestion();
        // SecretQuestion();
    }
    questions();  //refactor by wrapping all question in question container
}


// when app starts magic moose should ask question
//console.write
//after user asks a question
//console.readline
//magic moose should reply with one of these responses 

Magic();

void Magic()
{
    Console.WriteLine("What would you like to know ? :");
    string question = Console.ReadLine();
    while (question.Length > 0)
    {
        MooseSays();
        Console.WriteLine("What would you like to know ? :");
        question = Console.ReadLine();
    }

    void MooseSays()
    {
        string[] responses = {
                "As I see it, yes.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don’t count on it.",
                "It is certain.",
                "It is decidedly so.",
                "Most likely.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Outlook good.",
                "Reply hazy, try again.",
                "Signs point to yes.",
                "Very doubtful.",
                "Without a doubt.",
                "Yes.",
                "Yes – definitely.",
                "You may rely on it."
        };
        Random r = new Random();
        int answer = r.Next(0, 19);

        Console.WriteLine(responses[answer]);

    }


}


RockPaperScissors();

void RockPaperScissors()
{
    Console.WriteLine("What would you like to throw ? :");
    string answer = Console.ReadLine();
    string[] play = { "rock", "paper", "scissors" };
    Random r = new Random();
    int pick = r.Next(0, 2);

    if (answer == "rock")
    {
        Console.WriteLine(@"""
        _______
    ---'   ____)
          (_____)
          (_____)
          (____)
    ---.__(___)
    """);
    }

    if (answer == "paper")
    {
        Console.WriteLine(@"""
         _______
    ---'    ____)____
               ______)
              _______)
             _______)
    ---.__________)
    """);
    }

    if (answer == "scissors")
    {
        Console.WriteLine(@"""
        _______
    ---'   ____)____
              ______)
           __________)
          (____)
    ---.__(___)
    """);
    }

    Console.WriteLine(play[pick]);
    if (play[pick] == "rock")
    {
        Console.WriteLine(
            @"""
        _______
    ---'   ____)
          (_____)
          (_____)
          (____)
    ---.__(___)
    """
        );
    }
    if (play[pick] == "paper")
    {
        Console.WriteLine(@"""
         _______
    ---'    ____)____
               ______)
              _______)
             _______)
    ---.__________)
    """);
    }
    if (play[pick] == "scissors")
    {
        Console.WriteLine(@"""
        _______
    ---'   ____)____
              ______)
           __________)
          (____)
    ---.__(___)
    """);
    }
}