// 
//  Задание: Создать массив из 3-хсимволов, который определяется из заранее введенного массива.(to 10/08/2022)

string[]CreateArray()
{
    string[]newArray=new string[10];
    
    Console.WriteLine("Введите массив");
    for( int i=0;i<newArray.Length; i++)
    {
    Console.WriteLine($"Введите элемент {i+1}");
    newArray[i]=Console.ReadLine();
    }
    
Console.WriteLine();
return newArray;
}

void ShowArray(string[]array)
{
    for(int i=0; i < array.Length;i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();
}
string ThreeArray(string[]newArray)
{
    string result=String.Empty;
    int length=newArray.Length;

   for (int i=0;i<length;i++)
   {
    if (newArray[i].Length <=3) result=result+$"{newArray[i]+" "}" ;
    /*else result=result +$"{"0"+" "}";*/
   }
    Console.WriteLine(result);
return result;
}

string[]array1=CreateArray();
ShowArray(array1);

string array2=ThreeArray(array1);