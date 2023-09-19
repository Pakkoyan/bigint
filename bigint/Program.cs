using System.Text;

//1 Задание
//Вы бы знали как этот ужас я дебажил долго!!!!!!!!
//Ушло, 5часов 12 минут 53 секунды
char[] firstNum = Console.ReadLine().ToCharArray(); 
char[] secondNum = Console.ReadLine().ToCharArray(); 
LinkedList<int> result = new LinkedList<int>();


int inBrain = 0;
for (int i = firstNum.Length-1, j = secondNum.Length-1, l = 0; Math.Max(firstNum.Length, secondNum.Length) == firstNum.Length ? i > -1 : j > -1; --i, --j, ++l) //3
{
    if (firstNum.Length > secondNum.Length && secondNum.Length-1 < l) //995  4 first
    {                                                                    //9999 4 second
        result.AddFirst(Int32.Parse(firstNum[i].ToString()));
        continue;
    } 
    if (secondNum.Length > firstNum.Length && firstNum.Length-1 < l) //9
    {
        result.AddFirst(Int32.Parse(secondNum[j].ToString()));
        continue;
    }
 
    int addingTwoNum = Int32.Parse(firstNum[i].ToString()) + Int32.Parse(secondNum[j].ToString()) + inBrain; //10
    inBrain = 0;
    if (addingTwoNum > 9) //vhod
    {
        inBrain = addingTwoNum / 10; //10
        result.AddFirst(addingTwoNum % 10); //0
        continue;
    }
    result.AddFirst(addingTwoNum % 10);
}
if (inBrain != 0)
{
    result.AddFirst(inBrain);
}

foreach (int item in result)
{
    Console.Write(item);
}
