using System;
//contains classes that define generic collections
//which allow users to create strongly typed collections
//that provide better type safety and performance
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Ask the Magic Moose a question...");
    Console.WriteLine("----------------------------------");
    Console.WriteLine();

    //Speak moose
    MooseSays("Ask me a question");

    UserQuestion();

}

void UserQuestion()
{
    Dictionary<int, string> MooseAnswers = new Dictionary<int,string>()
    {
        {0, "As I see it, yes"},
        {1, "Ask again later"},
        {2, "Cannot predict now"},
        {3, "It is certain"},
        {4, "Most likely"},
        {5, "Outlook not so good"},
        {6, "My source says yes"},
        {7, "Without a doubt"},
        {8, "Outlook good"},
    };
    
    
    
    string answer = Console.ReadLine();

    while (answer != "")
    {
        if (answer.Contains("?"))
        {
            int number = GetRandomNumber();
            Console.WriteLine(MooseAnswers[number]);
            Console.WriteLine(number);
            answer = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("ask a question with a '?' or press 'enter' to exit");
            answer = Console.ReadLine();
        }
    }
}

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

//Function to get a random number 
static int GetRandomNumber() {
      Random r = new Random();
      int genRand= r.Next(0,8);
      return genRand;
   }


