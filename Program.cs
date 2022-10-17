string name = "";
int loop = 1;
string end = "o";
bool choice = false;
Console.Clear();

while (loop == 1)
{
while (name.Length <= 0)
{ 
Console.WriteLine("Hello there! Please give me your name so that I can properly greet you!");
name = Console.ReadLine();
}
Console.Clear();
Console.WriteLine("_.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"                    Hello {name}!");                    
Console.WriteLine("          I hope you have a día muy fantástico!");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("_.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~._.~\"~");

while (choice == false)
{
Console.WriteLine();
Console.WriteLine("Would you like to me to greet you again? Type \"yes\" to play again or \"no\" to end the program");
end = Console.ReadLine();
end = end.ToLower();
if (end == "yes" || end == "no"){
    choice = true;
}
}

if (end == "no")
{
    loop++;
}
name = "";
Console.Clear();
choice = false;
}

Console.WriteLine("      .......");
Console.WriteLine("  .:::::::::::::.  ");
Console.WriteLine(" .::'  '''''  '::. ");
Console.WriteLine(" :::           ::: ");
Console.WriteLine(" :::           ::: ");
Console.WriteLine(" ::'           ':: ");
Console.WriteLine(": : /~~~' '~~~\\ : :");
Console.WriteLine(":(:  (O)   (O)  :):");   
Console.WriteLine("'.:     / \\     :.'");
Console.WriteLine(" ':    (. .)    :' ");
Console.WriteLine("  '.  .:::::.  .'");
Console.WriteLine("   :  <----->  :   ");
Console.WriteLine("   '.  ~:::~  .'");
Console.WriteLine("     '.  '  .'     ");
Console.WriteLine("       '''''");
Console.WriteLine("Thank you for letting me greet you! It's the reason I was created!");
