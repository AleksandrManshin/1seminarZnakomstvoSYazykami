int number = -4; //-4 -3 -2 -1 0 1 2 3 4 
number = Math.Abs(number);
int count = -number;
while (count <= number)
{
    Console.Write(count + "  ");
    count ++;
}
Console.WriteLine();
