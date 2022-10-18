//Griffin Parker
//Mini Challenge 1 Remastered - Say Hello
//October 17, 2022
//Peer reviewed by:

string name = "";
int loop = 1;
int talk = 0;
int eyes = 0;
int jaw = 0;
string end = "o";
string mouthSmile = "   :  \\_____/  :   ";
string mouthOpen =  "   :  _______  :";
string eyesOpen =   ":(:  (O)   (O)  :):";
string eyesClosed = ":(:  (_)   (_)  :):";
string eyesWink =   ":(:  <0>   <0>  :):";
string greetings = "Hello";
string sentence = "I hope you have a good day today!";
bool choice = false;
Console.Clear();

while (loop == 1)
{
while (name.Length <= 0)
{ 
Console.WriteLine("Hello there! Please give me your name so that I can properly greet you!");
name = Console.ReadLine();
}
while (talk <= 5)
{
Console.Clear();
jaw = 1;
Face(mouthOpen, name, greetings, sentence, eyesOpen, jaw);
Thread.Sleep(1000);
Console.Clear();
if (eyes % 3 == 1)
{
    jaw = 0;
    Face(mouthSmile, name, greetings, sentence, eyesClosed, jaw);
}
else
{
    jaw = 0;
    Face(mouthSmile, name, greetings, sentence, eyesOpen, jaw);
}
Thread.Sleep(1000);
talk++;
eyes++;
}

choice = false;

while (choice == false)
{
Console.WriteLine();
Console.WriteLine("Would you like to me to greet you again? Type \"yes\" to play again or \"no\" to end the program");
end = Console.ReadLine();
end = end.ToLower();
if (end == "yes" || end == "no"){
    choice = true;
    talk = 0;
    eyes = 0;
    jaw = 0;
}
}

if (end == "no")
{
    loop++;
}
name = "";
Console.Clear();
}

name = "for now";
greetings = "Goodbye";
sentence = "Thanks for letting me greet you! It's the reason I was created!";
Face(mouthSmile, name, greetings, sentence, eyesWink, jaw);

static void Face(string mouth, string name, string greetings, string sentence, string eyes, int jaw)
{
    int open = 1;
Console.WriteLine("      .......");
Console.WriteLine("  .:::::::::::::.  ");
Console.WriteLine(" .::'  '''''  '::. ");
Console.WriteLine(" :::           ::: ");
Console.WriteLine(" :::           ::: ");
Console.WriteLine(" ::'           ':: ");
Console.WriteLine(": : /~~~' '~~~\\ : :");
Console.WriteLine(eyes);   
Console.WriteLine("'.:     / \\     :.'");
Console.WriteLine(" ':    (. .)    :' ");
Console.WriteLine($"  '.  .:::::.  .'        {greetings} {name}!");
Console.WriteLine(mouth);
if (jaw == 1)
{
Console.WriteLine("   :  \\_____/  :");
}
Console.WriteLine($"   '.  ~:::~  .' {sentence}");
Console.WriteLine("     '.  '  .'     ");
Console.WriteLine("       '''''");
}