//declares variable for user input
string userinputString;

//decalres variable for reversed user input
string userReverse;

//decalres variable for palindrome user input
string userpalindrome;

//decalres varible for vowel count
int vowelcount;

//declares variable for what operation the user wants
int userinputOperation;

//declares variable for an array for reverser operation
char[] userArrayReverse;

//declares variable for an array for reverser operation
char[] userArrayPalindrome;

//promts askign for user for a string variable
Console.WriteLine("please input a string variable ");

//collects user input for the string variable
userinputString = Console.ReadLine();

//promts user to select which opertaiton they want
Console.WriteLine(" please select what operation do you want ");
Console.WriteLine(" ReverseString enter 1 ");
Console.WriteLine(" CountVowels enter 2 ");
Console.WriteLine(" IsPalindrome enter 3 ");

//collects user input for the operation
userinputOperation = Convert.ToInt32(Console.ReadLine());

//calutes opertaion for reversestring
if (userinputOperation == 1)
{
    //converts user input form string into a array
    userArrayReverse = userinputString.ToCharArray();

    //reverees the array
    Array.Reverse(userArrayReverse);

    //converts the array back into string
    userReverse = new string(userArrayReverse);

    //outputs the results of reveresing the user input
    Console.WriteLine(" the reversed of the user input " + userReverse);
    Console.ReadLine();

}
//calutes opertaion for countvowels
else if (userinputOperation == 2)
{
    //
}
//calutes opertaion for palindrome
else if (userinputOperation == 3)
{
    //converts user input form string into a array
    userArrayPalindrome = userinputString.ToCharArray();

    //reverees the array
    Array.Reverse(userArrayPalindrome);

    //converts the array back into string
    userpalindrome = new string(userArrayPalindrome);

    if (userpalindrome == userinputString)
    {
        //prints out the results if user input is a palindrome
        Console.WriteLine(" user input was a palindrome ");
        Console.WriteLine(userpalindrome + " = " + userinputString);

    }
    else if (userpalindrome != userinputString)
    {
        //prints out the results if the user input is not a palindrome
        Console.WriteLine(" user input was not a palindrome ");
        Console.WriteLine(userinputString + " revesred is  " + userpalindrome);
    }

    
}
