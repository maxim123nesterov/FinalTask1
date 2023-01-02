
//написать программу которая из имеющегося массива строк формирует массив строк длина которых меньше 3 символов
string[] arr = {"hello", "on", "12", "123", "Moskow"};

void ArrEnter(string[] arr)
{
for (int i = 0; i < arr.Length; i ++)
{
    
    if (arr[i].Length < 3)
    {
        Console.Write($" {arr[i]}");
    }
    else Console.Write("");
    
}
}

void ArrInit(string[] arr)
{
    for (int i = 0; i < arr.Length; i ++)
{
    
    Console.Write($" {arr[i]}");
}
}

ArrInit(arr);
Console.WriteLine();
ArrEnter(arr);



//Console.Write($" {arr[i]}");