// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] array = new string [5] {"1005","568","456","11111","Coo"};
string [] newArray = new string[array.Length];

void RemakeArray (string[] array,string[] newArray)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    {
        newArray[count] = array[i];
        count++;
    
    }
}

}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
RemakeArray(array,newArray);
PrintArray(newArray);
