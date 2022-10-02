/*Задача: Н
На основе исходного массива из строк необходимо сформировать новый массив, 
который будет состоять из элементов исходного, которые имеют длину 3 и менее.*/


Console.Write("Введите количество элементов, которые добавим в массив: ");
int number = Convert.ToInt32(Console.ReadLine());


string[] GetMatrix(int number)
{
    string[] matrix = new string[number];
    for (int i = 0; i < number; i++) 
    { 
            Console.Write($"Введите элемент {i}: ");  
            matrix[i] = Console.ReadLine();
    }
    return matrix;
}

void PrintMatrix(string[] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {

        Console.Write(inputMatrix[i] + "\t"); 
        
    }
}

// Заполняем исходный массив

string[] fillMatrix = GetMatrix(number);

// Выводим на экран исходный массив

Console.WriteLine("Исходный массив: ");


PrintMatrix(fillMatrix);

// Определяем размер для нового массива и создаем

int count = 0;

for (int i = 0; i < number; i++) 
    { 
        if (fillMatrix[i].Length <=3)
        {
            count++;
        }

    }

string[] resultMatrix = new string[count];

//Заполняем новый массив

int j = 0; // Счетчик для заполнения нового массива

for (int i = 0; i < number; i++) 
    { 
        if (fillMatrix[i].Length <=3)
        {
            resultMatrix[j] = fillMatrix[i];
            j++;
        }

    }
Console.WriteLine();

Console.WriteLine("Новый массив: ");

PrintMatrix(resultMatrix);