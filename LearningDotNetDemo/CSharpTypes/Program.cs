// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char ch = 'a';

bool isChar = char.IsLetter(ch);

char upper = 'A';
bool isUpper = char.IsUpper(upper);
bool isLower = char.IsLower(ch);

char punct = ';'; 
bool isPunct = char.IsPunctuation(punct);

char wh = ' '; 
bool isWh = char.IsWhiteSpace(wh);

string t = "false"; 

bool x = (bool)Convert.ChangeType(t, typeof(bool));

string abba = "abBA"; 

var result = abba.Replace("a", "c").Replace("b", "d"); // This is case sensitive.

int a = 3;
int b = a;

b++;
Console.WriteLine( b);
Console.WriteLine( a);

var sum = AddNumbers(1, 3);

int AddNumbers(int v1, int v2)=>  v1 + v2; // No return keyword.
Console.WriteLine( sum.ToString() );

//ValueType

Console.ReadLine();
