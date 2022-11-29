// Из имеющегося массива строк формируется массив строк с длиной меньше, либо равной 3 символа.
// Первоначальный массив вводится с клавиатуры.
// При решении использованы только массивы

Console.WriteLine("Выведу на экран только те элементы из перечня, длина которых меньше или равна 3.");
Console.WriteLine("Сколько элементов будете вводить?");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Вводите элементы: ");
string [] SOURSE = new string[size];
for (int index = 0; index < size; index++)
{
    SOURSE[index] = Console.ReadLine()!;
}

int compare = 3;
string[] RESULT = new string[size];

for (int index = 0; index < size; index++)
{
    if (SOURSE[index].Length <= compare)
    {
        RESULT[index] = SOURSE[index];
    }
}

Console.WriteLine("Из исходного перечня остались следующие элементы: ");

for (int index = 0; index < size; index++)
{
    if (RESULT[index] is not null)
    {
        Console.WriteLine($"{RESULT[index]} ");
    }
}