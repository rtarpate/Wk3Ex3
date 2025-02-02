//declares variable for user input
string userinputString;

//decalres variable for reversed user input
string userReverse;



//declares variable for what operation the user wants
int userinputOperation;

//declares variable for an array
char[] userArray;

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
    userArray = userinputString.ToCharArray();

    //reverees the array
    Array.Reverse(userArray);

    //converts the array back into string
    userReverse = new string(userArray);

    Console.WriteLine(" the reversed of the user input " + userReverse);

}
//calutes opertaion for countvowels
else if (userinputOperation == 2)
{
    //
}
//calutes opertaion for palindrome
else if (userinputOperation == 3)
{
    //
}
