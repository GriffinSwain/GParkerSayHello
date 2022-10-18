//Griffin Parker
//Mini Challenge 1 Remastered - Say Hello
//October 17, 2022
//Peer reviewed by:


//Initializes the various variables in the main method of the program. 
//This is where the parts of the face that change are stored.
string name = "";
int loop = 1;
int talk = 0;
int eyes = 0;
int jaw = 0;
int second =  0;
int check;
int digit = 0;
string end = "o";
string mouthClosed = "   :  _______  :  ";
string mouthSmile =  "   :  \\_____/  :   ";
string mouthOpen =   "   :  _______  :";
string eyesOpen =   ":(:  (O)   (O)  :):";
string eyesClosed = ":(:  (_)   (_)  :):";
string eyesWink =   ":(:  <0>   <_>~#:):";
string specialEyes =":(:  {0}   {0}  :):";
string greetings = "Hello";
string sentence = "I hope you have a good day today!";
bool choice = false;
bool number;
Console.Clear();

/*This is the beginning of the main body of the program
It starts byy getting an input, then calling upon a method to draw a face
with a while loop animating it to make it look like it's speaking.
*/
while (loop == 1)
{
while (name.Length <= 0)
{ 
Console.WriteLine("Hello there!  ");
Task.Delay(750).Wait();
Console.WriteLine("Please give me your name so that I can properly greet you!");
name = Console.ReadLine();
/* for(int i = name.Length - 1; i >= 0; i--)
{
digit = name[i];
number = Int32.TryParse(digit, out check);
}
number = Int32.TryParse(name, out check);
if (number == true)
{
    Console.WriteLine($"You can't be named {check}! You're a human! Human names have letters!");
}
*/
}
while (talk <= 5)
{
Console.Clear();
jaw = 1;
/*This calls upon the Face method with a host of different variables attached to print the face.
Because we want him to look like he's talking, we send the 'mouthOpen' string*/
Face(mouthOpen, name, greetings, sentence, eyesOpen, jaw, second);
Thread.Sleep(600);
Console.Clear();
if (eyes % 3 == 1)
{
    jaw = 0;
    Face(mouthClosed, name, greetings, sentence, eyesClosed, jaw, second);
}
else
{
    jaw = 0;
    Face(mouthClosed, name, greetings, sentence, eyesOpen, jaw, second);
}
Thread.Sleep(400);
if (talk >= 2)
{
second++;
}
talk++;
eyes++;
}

second--;
choice = false;

while (choice == false)
{
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Would you like to me to greet you again? Type \"yes\" to play again or \"no\" to end the program");
end = Console.ReadLine();
end = end.ToLower();
if (end == "yes" || end == "no"){
    choice = true;
    talk = 0;
    eyes = 0;
    jaw = 0;
    second = 0;
}
}

if (end == "no")
{

    while (talk <= 2)
{
Console.Clear();
sentence = "Thanks for letting me greet you! It's the reason I was created!";
greetings = "Goodbye";
jaw = 1;
Face(mouthOpen, name, greetings, sentence, eyesOpen, jaw, second);
Thread.Sleep(600);
Console.Clear();
if (eyes % 3 == 1)
{
    jaw = 0;
    Face(mouthClosed, name, greetings, sentence, eyesClosed, jaw, second);
}
else
{
    jaw = 0;
    Face(mouthClosed, name, greetings, sentence, eyesOpen, jaw, second);
}
if (jaw >= 1){
    second++;
}
Thread.Sleep(400);
    talk++;
    loop++;
    
}
}
name = "";
Console.Clear();
}

name = "=~for now~=";
greetings = "Goodbye...";
sentence = "Thanks for letting me greet you! It's the reason I was created!";
Face(mouthSmile, name, greetings, sentence, specialEyes, jaw, second);
Thread.Sleep(1750);
Console.Clear();

Face(mouthSmile, name, greetings, sentence, eyesWink, jaw, second);
Thread.Sleep(400);
Console.Clear();
second++;
Face(mouthSmile, name, greetings, sentence, specialEyes, jaw, second);
Console.WriteLine();
Console.WriteLine();

static void Face(string mouth, string name, string greetings, string sentence, string eyes, int jaw, int second)
{
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
Console.WriteLine($"   '.  ~:::~  .' ");
Console.WriteLine("     '.  '  .'     ");
Console.WriteLine("       '''''");;
if (second > 0)
{
Console.SetCursorPosition(0, Console.CursorTop - 3);
Console.WriteLine($"   '.  ~:::~  .' {sentence}");
}
Console.WriteLine();
}