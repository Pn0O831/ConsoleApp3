// See https://aka.ms/new-console-template for more information

//①
int num1 = 1;
if (num1 % 2  == 0)
{
    Console.WriteLine("偶数です");
}
else
{
    Console.WriteLine("奇数です");
}

//②
int num2 = 1;
switch (num2) {
    case 1:
        Console.WriteLine("月曜日");
        break;
    case 2:
        Console.WriteLine("火曜日");
        break;
    case 3:
        Console.WriteLine("水曜日");
        break;
    case 4:
        Console.WriteLine("木曜日");
        break;
    case 5:
        Console.WriteLine("金曜日");
        break;
    case 6:
        Console.WriteLine("土曜日");
        break;
    case 7:
        Console.WriteLine("日曜日");
        break;
    default:
        Console.WriteLine("不正な入力です");
        break;
}

//③
int age = 20;
bool student = true;
if ((age >= 18) && (student))
{
    Console.WriteLine("学生割引が適用されます");
}