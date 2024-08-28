//declaring a method
void WritingSomething()
{
    Console.WriteLine("I'm writing something");
}
Console.WriteLine("This is outside the method");

//calling method
WritingSomething();

//A method that has a parameter string mystring
void WriteSomethingSpecific(string mystring)
{
    Console.WriteLine(mystring);
}


WriteSomethingSpecific("benjamin");

Console.ReadKey();