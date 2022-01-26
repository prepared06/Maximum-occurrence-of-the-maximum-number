using maxAmountOfMaxNumber;

int[] arr =(int[]) GenArray.NewArray(15);


Console.WriteLine("Generated array:");
foreach(var el in arr)
{
    Console.Write(el + " ");
}


int maxNumber = arr[0];
int amountOfMaxNumber=1;

for (int i = 1; i < arr.Length; i++)
{
    if(maxNumber < arr[i] )
    {
        maxNumber = arr[i];
        amountOfMaxNumber = 1;
    }else if(maxNumber == arr[i])
    {
        amountOfMaxNumber++;
    }       
}
Console.WriteLine();
Console.WriteLine(
    $"Max number in this sample is {maxNumber}. The number of occurrences in the sample of the maximum number {amountOfMaxNumber}");