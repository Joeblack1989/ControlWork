/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо
равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string [] ArrayBegin = new string [3];
string [] ArrayResult = new string [3];
CompletionArray (ArrayBegin);

void CompletionArray (string [] ArrayBegin)
{
    for (int i = 0; i < ArrayBegin.Length; i++)
    {
    Console.WriteLine("Введите элемент массива и нажмите клавишу Enter: ");
    ArrayBegin[i] = Console.ReadLine();   
    }
    Console.WriteLine();
    Console.WriteLine("Введенный массив строк: "); 
    for (int i = 0; i < ArrayBegin.Length; i++)
    { 
    Console.WriteLine($"{i} элемент массива = {ArrayBegin[i]}");
    }
}