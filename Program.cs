namespace Oppgave_uke_1;

/*Oppgavetekst:

Oppgave 2
o	Lag en variabel av datatypen integer og tildel den et vilkårlig heltall V
o	Lag en variabel av datatypen string og tilden en vilkårlig tekst V
o	Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen V
o	Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav) V
o	Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke V
o	Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke V
o	Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"

myExampleList.Add("min string");
o	Legg til flere strings i listen deres
o	Skriv ut verdiene i listen ved hjelp av en foreach-løkke


Oppgave 3: Ekstraoppgaver
Ekstraoppgave(valgfritt)
Disse oppgavene er valgfrie, men kan være lurt å forsøke å gjøre om man ønsker å begynne litt tidligere på de neste temaene i faget.
o	Lag en Dictionary med integer-nøkkel og string-verdi slik
o	Dictionary<int, string> myDictionary = new Dictionary<int, string>();
o	Skriv ut verdiene i Dictionary ved å anvende en foreach-løkke ved hjelp av datatypen var
o	Lag en metode av typen integer som legger sammen to tall, int a og int b
o	Lag en metode av typen string som skrive ut en liten hilsen til brukeren ved å bruke en parametervariabel.

NB merk at begge metdoene må være static dersom de ikke kalles direkte i Main sitt scope

static void Main(string[] args)
 
Utenfor Main scope
static public int MyIntMethod(int a, int b)
*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Selection of constructed variables and arrays
int integerOppgave = 104;
string stringOppgave = "This string solves the write string assignment";
double doubleValue = 77.77;
bool boolStatement = true;
char h = 'H';
int[] arrayIntegerOppgave = {10, 25, 40, 55, 70, 85, 100};
string[] arrayScript1 = {"JavaScript", "CSS", "HTML", "C#", "Python", "Swift", "C++", "Java", "Ajax" };

// for list, and print, integer array
for (int listing = 0; listing < arrayIntegerOppgave.Length; listing ++)
{
    Console.WriteLine(listing);
}
// foreach list, and print, string array
foreach (string scriptNameList in arrayScript1)
{
    Console.WriteLine(scriptNameList);
}

static void MyMethod()
{
string[] arrayScript2 = {"JavaScript", "CSS", "HTML", "C#", "Python" };
List<string> addToMyScriptList = new List<string>();

foreach (string moreNames in arrayScript2)
{
    addToMyScriptList.Add(moreNames);
}
addToMyScriptList.Add("TypeScript");
addToMyScriptList.Add("Ruby");
addToMyScriptList.Add("Ajax");
addToMyScriptList.Add("PhP");

foreach (string script in addToMyScriptList)
{
Console.WriteLine(script);
}}

MyMethod();

// Print execution
Console.WriteLine(integerOppgave);
Console.WriteLine(stringOppgave);
Console.WriteLine(doubleValue);
Console.WriteLine(boolStatement);
Console.WriteLine(h);




    }}