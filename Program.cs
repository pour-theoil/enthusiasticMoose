using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

void MooseSays(string messagage)
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
                       |   / \   |    {messagage}
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


string[] responsearray = { "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it." };
// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");
MagicMoose();

void MagicMoose()
{

    Console.Write("Eh, You have a question for the enthusiatic moose? ");
    string question = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(question))
    {
        System.Console.WriteLine("Fine, don't ask a question!");
    }
    else
    {
        Random i = new Random();
        int genRand = i.Next(0, responsearray.Length - 1);
        System.Console.WriteLine(responsearray[genRand]);
        MagicMoose();
    }
}
// MoooseQuestion("Is Canada real?","Really? It seems very unlikely.", "I  K N E W  I T !!!");
// MoooseQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
// MoooseQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
// MoooseQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");

// // Ask a question

// void MoooseQuestion(string question, string trueanswer, string falseanswer)
// {

//     bool isTrue = MooseAsks(question);
//     if (isTrue)
//     {
//         MooseSays(trueanswer);
//     }
//     else
//     {
//         MooseSays(falseanswer);
//     }
// }

