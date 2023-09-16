Array myArray = new Array(new int[] { 42, 11, 32, 42, 23, 74, 5});
myArray.Show();
#region task1

//Console.WriteLine("Enter the value: ");
//int numb;
//Int32.TryParse(Console.ReadLine(),out numb);

//Console.WriteLine($"Count of values less than {numb}: { myArray.Less(numb)}");
//Console.WriteLine();
//Console.WriteLine($"Count of values greater than {numb}: {myArray.Greater(numb)}");
//Console.WriteLine();
#endregion

#region task2
//Console.WriteLine("The even nums: ");
//myArray.ShowEven();
//Console.WriteLine("The odd nums:");
//myArray.ShowOdd();

#endregion

#region task3
Console.WriteLine("Enter the value: ");
int numb;
Int32.TryParse(Console.ReadLine(), out numb);

Console.WriteLine("Unique values:");
Console.WriteLine(myArray.CountDistinct());

Console.WriteLine($"Count of values equal to {numb}: " );
Console.WriteLine(myArray.EqualToValue(numb));

#endregion