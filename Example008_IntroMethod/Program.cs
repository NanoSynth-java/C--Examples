// int[] array = {1, 12, 31, 4, 15, 16, 17, 18};

// int n = array.Length;
// Console.WriteLine("Укажите номер ячейки памяти для отображения содержимого: ");
// int find = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(array[find]);

int[] array = {0,1,2,3,4,5,6,7,8};
int n = array.Length;
int find = 4;
int index = 0;

while(index < n) 
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
}