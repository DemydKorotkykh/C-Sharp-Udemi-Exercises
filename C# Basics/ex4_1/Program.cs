using System;

Console.Write("Enter numbers separated by a hyphen: ");
string userInput = Console.ReadLine();

string result = AreNumbersConsecutive(userInput);
Console.WriteLine(result);

string AreNumbersConsecutive(string numbers)
{

    string[] numbersArray = numbers.Split('-');
    int[] numbersList = Array.ConvertAll(numbersArray, int.Parse);

    for (int i = 1; i < numbersList.Length; i++)
    {
        if (!(numbersList[i] == numbersList[i - 1] + 1 || numbersList[i] == numbersList[i - 1] - 1))
        {
            return "Not Consecutive";
        }
    }

    return "Consecutive";
}

