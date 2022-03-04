//Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты. 

List<List<int>> data = new List<List<int>>();
List<int> list = new List<int>();
list.Add(1);
data.Add(list);

bool Check(int n, List<int> list)
{
    foreach (int i in list)
        if (n % i == 0) return true;
    ////for (int i=0;i<list.Count;i++)
    ////    if (n%list[i]==0) return true;
    return false;

    //return list.Where(i => n % i == 0).Any();
}

System.Diagnostics.Stopwatch stopwatch= new System.Diagnostics.Stopwatch();
stopwatch.Start();
int N = 1000000;
for(int i=2;i<=N;i++)
{
    bool isListFinded = false;
    for(int j=0;j<data.Count && !isListFinded;j++)
        if(!Check(i, data[j]))
        {
            data[j].Add(i);
            isListFinded = true;
            break;
        }
    if (!isListFinded)
    {
        List<int> newList = new List<int>();
        newList.Add(i);
        data.Add(newList);
    }

}
stopwatch.Stop();
Print();
Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

void Print()
{
    int j = 0;
    foreach (List<int> list in data)
    {
        Console.Write((++j) + " ");
        foreach (int i in list) Console.Write(i + " ");
        Console.WriteLine();
    }

}



