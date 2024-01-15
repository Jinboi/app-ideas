/*
 Binary to Decimal 
 User can enter up to 8 binary digits in one input field
 User must be notified if anything other than a 0 or 1 was entered
 User views the results in a single output field containing the decimal (base 10) equivalent of the binary number that was entered
*/

Console.WriteLine("Input binary digits");
string? input = Console.ReadLine();

if (input != null)
{
    bool validInput = ValidInputTest(input); 

    if (validInput)
    {
        ProceedToConvert();
    }
    else
    {
        Console.WriteLine("Input not valid");
    }
}
else
{
    throw new ArgumentNullException("Wrong - Input Null");
}

bool ValidInputTest(string input)
{
    bool validLength = InputLengthTest(input);
    bool validBinary = InputBinaryTest(input);

    return (validLength && validBinary) == true ? true : false;
}

bool InputLengthTest(string input)
{
    return (input.Length <= 8) ? true : false;
}

bool InputBinaryTest(string input)
{
    char[] array = input.ToCharArray();
    int binaryCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == '1' || array[i] == '0') 
        {
            binaryCounter += 1;
        }
        else
        {
            // Console.WriteLine($"Wrong - not {i + 1} digit is '0' or '1'");
            break;
        }
    }
    return (binaryCounter == array.Length) ? true : false;
}

void ProceedToConvert()
{
    int output = Convert.ToInt32(input, 2);
    Console.WriteLine(output);
}