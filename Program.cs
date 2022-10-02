// VID1 -void method

/*void Method1()//знак ;  в конце строки не нужен 
{
    Console.WriteLine("какое-то сообщение");
}

Method1();//так вызывается скобки обязательно() иначе ошибка */

//VID2 -void Metod

/*void Method2(string msg)
{
    Console.WriteLine("текст ссобщение");
}
Method2("");//варианты вызова 
Method2(msg:"");//применяется когда нужно вызвать
//именно именнованный аргумент,когда в методе много аргументов*/

/*void Method21(string msg ,int count)
{
    int i = 0;
    while (i<count)
    {
    Console.WriteLine("text");
    i++;//называют инкриментом,когда 
    //count-- называют дикриментом
    }
}
//Method21(msg: " ", count: 5);
//Method21( "text",  5);
Method21(count: 5 , msg:" ");
//варианты вызова цифра 5указвает сколько раз вызвать*/

/*VID3 что то возвращае 
обязательно указать тип 
данных которые ожидаем*/

/*int Method3()
{
    return DateTime.Now.Year;//Возвращает текущий год.
}
int year = Method3();
Console.WriteLine(year);*/


//VID4 что-то принимают что-то возвращают
//обязательно указать тип 
//данных которые ожидаем
string Method4( int count,string text)
{
    int i = 0;//начало в данном случае с "0"
    string result = String.Empty;//вначале пустая строка

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
  Console.WriteLine(res);//результат 10 раз"z"


