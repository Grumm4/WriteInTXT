using System.IO;

//Путь до файла
StreamWriter sw = new StreamWriter("C:\\Users\\Kirill\\Desktop\\Test.txt");

try
{
    //Запись текста
    for (int i = 0; i < 100; i++)
    {
        //здесь запишется в файл 100 чисел в диапазоне от 0 до 999
        Random rnd = new Random();
        sw.Write($"{rnd.Next(0, 999)},");
    }
}
catch (Exception e) { Console.WriteLine("Exception: " + e.Message); }
finally
{
    //Закрываем файл
    sw.Close();
}