//declaring a method
void WritingSomething()
{
    Console.WriteLine("I'm writing something");
}
Console.WriteLine("This is outside the method");

//A method that has a parameter string mystring
void WriteSomethingSpecific(string mystring)
{
    Console.WriteLine(mystring);
}

int AddIntegers(int num1, int num2)
{
    return num1 + num2;
}


// calling method
int result = AddIntegers(2, 2);
Console.WriteLine(result);


Console.ReadKey();