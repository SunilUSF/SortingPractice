// See https://aka.ms/new-console-template for more information
using System;

//Team - 8 - Gayathri

// input array
int[] bubble_sort_numbers = { 3, 62, 5, 16, 4, 10 };


Console.WriteLine("Original Array: ");
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}

Console.WriteLine("");
Console.WriteLine("Array after sorting: ");

// Calling the function created for bubble sort
Bubble_Sort(bubble_sort_numbers);
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Press any key to exit the program ...");
Console.ReadKey(true);


// Creating a function for bubble sort
static void Bubble_Sort(int[] input_array)
{

    for (int i = 0; i < input_array.Length - 1; i++)
    {
        for (int x = 0; x < input_array.Length - i - 1; x++)
        {

            if (input_array[x] > input_array[x + 1])
            {

                int temp = input_array[x];
                input_array[x] = input_array[x + 1];
                input_array[x + 1] = temp;
            } 
        } 
    } 
}