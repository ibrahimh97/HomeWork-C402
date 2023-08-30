int num = 35, num2 = 15;

Console.WriteLine(SumOfTwoNumbers(num, num2));
Console.WriteLine(MultiplyDifferenceBySum(num, num2));

int SumOfTwoNumbers(int num, int num2)
{
    return num + num2;

}

static int MultiplyDifferenceBySum(int a, int b)
{
    int difference = a - b;
    int sum = a + b;

    return difference * sum;

}
string[] words = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };
Console.WriteLine("arrayde 4 herfden az olan sözler");

foreach (string word in words)
{
    if (word.Length < 4)
    {
        Console.WriteLine(word);
    }
}

Console.WriteLine();
string[] wordsTwo = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };

Console.WriteLine("arrayde 4 herfden az olan sözler 'AZE':");
foreach (string word in wordsTwo)
{
    if (word.Length > 4)
    {
        string modifiedWord = word + " AZE";
        Console.WriteLine(modifiedWord);
    }
}

Console.WriteLine();

string[] wordsThree = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };

foreach (var item in wordsThree)
{
    Console.WriteLine(item);
}

Console.WriteLine();

string[] wordsFour = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };
for (int i = 0; i < wordsFour.Length; i++)
{
    Console.Write(wordsFour[i] + " ");
}
Console.WriteLine();


for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i <= 100; i +=2)
{
    {
        Console.WriteLine(i);
    }
}

int sum = 0;
for (int i = 1; i < 100; i += 2)
{
    {
        sum += i;
    }
}

Console.WriteLine(sum);
Console.WriteLine();

for (int number = 10; number < 100; number++)
{
    int tensDigit = number / 10; 
    int onesDigit = number % 10; 

    if (tensDigit == onesDigit)
    {
        Console.WriteLine(number);
    }
}

Console.WriteLine();
int[] arr = { 11, 22, 97, 299 };
FirstElementOfArray(arr);
void FirstElementOfArray(int[] arr)
{
    Console.WriteLine(arr[0]);
}
Console.WriteLine();

LastElemtOfArray(arr);
void LastElemtOfArray(int[] arr)
{
    Console.WriteLine(arr[arr.Length - 1]);
}

