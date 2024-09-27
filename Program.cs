//Переименование Заголовка
Console.Title = ("Калькулятор");
//Инциализация переменных и обьяснение пользователю как использовать данное приложение
Console.WriteLine("Введите первое число:");
string first_number = Console.ReadLine();
int Convert_First_Number = Convert.ToInt32(first_number);
Console.WriteLine("Введите второе число:");

string second_number = Console.ReadLine();
int Convert_Second_Number = Convert.ToInt32(second_number);

Console.WriteLine("Введите действие:");
string action = Console.ReadLine();

int result;

//Создание условий
if (action == "+"){

    result = Convert_First_Number + Convert_Second_Number;
    Console.WriteLine("Результат равен:" + result);
}
else if (action == "-")
{
    result = Convert_Second_Number - Convert_First_Number;
    Console.WriteLine("Результат равен:" + result);
}
else if (action == "*")
{

    result = Convert_Second_Number - Convert_First_Number;
    Console.WriteLine("Результат равен:" + result);

}
else if (action == "/")
{
    result = Convert_Second_Number - Convert_First_Number;
    Console.WriteLine("Результат равен:" + result);
}