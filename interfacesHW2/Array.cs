
class Array : IOutput, IMath, ISort, ICalc, IOutput2
{


    public int[] data { get; set; }

    public Array(params int[] array)
    {
        data = array;
    }

    #region IOutput, IMath, ISort
    public int Max()
    {
        if (data.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return data.Max();
    }

    public int Min()
    {
        if (data.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return data.Min();
    }

    public float Avg()
    {
        if (data.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return (float)data.Sum() / data.Length;
    }

    public bool Search(int valueToSearch)
    {
        return data.Contains(valueToSearch);
    }

    public void Show(string info)
    {
        {
            foreach (int item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(info);
        }
    }

    public void Show()
    {
        Show("");
    }



    public void SortAsc()
    {
        BubbleSort(true);
    }

    public void SortDesc()
    {
        BubbleSort(false);
    }

    public void SortByParam(bool isAsc)
    {
        BubbleSort(isAsc);
    }

    private void BubbleSort(bool ascending)
    {
        int n = data.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((ascending && data[j] > data[j + 1]) || (!ascending && data[j] < data[j + 1]))
                {

                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }
    #endregion

    #region ICalc realization
    public int Less(int valToCompare)
    {
        int count = 0;
        foreach (int item in data)
        {
            if (item < valToCompare)
                count++;
        }
        return count;
    }

    public int Greater(int valToCompare)
    {
        int count = 0;
        foreach (int item in data)
        {
            if (item > valToCompare)
                count++;
        }
        return count;
    }
    #endregion


    #region IOutput2 realization(2 variants)

    public void ShowEven()
    {
       
        foreach (int i in data)
        {
            if ((i & 1) == 0)
                Console.Write($"{i}  ");
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        foreach(int i in data)
        {
            if ((i & 1) != 0)
                Console.Write($"{i}  ");
        }
        Console.WriteLine();
    }


    //второй вариант


    //public void ShowEven()
    //{
    //    foreach (int i  in data)
    //    {
    //        if (i % 2 == 0)
    //            Console.Write($"{i}  ");
    //    }
    //    Console.WriteLine();
    //}

    //public void ShowOdd()
    //{

    //    foreach (int i in data)
    //    {
    //        if (i % 2 != 0)
    //            Console.Write($"{i}  ");
    //    }
    //    Console.WriteLine();
    //}


    #endregion


    #region ICalc2 realization
    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (int item in data)
        {
            if (item == valueToCompare)
                count++;
        }
        return count;
    }

    public int CountDistinct()
    {
        int count = default;
        for (int i = 0; i < data.Length; i++)
        {
            bool isUnique = true;

            for (int j = 0; j < i; j++)
            {
                if (data[i] == data[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
                count++;
        } return count-1; //чтоб оба повторяющихся значения не считались уникальными
    }


    //второй способ

    //public int CountDistinct()
    //{
    //    int count = 0;

    //    foreach (int i in data)
    //    {
    //        int occurs = EqualToValue(i);


    //        if (occurs == 1)
    //        {
    //            count++;
    //        }
    //    }return count;
    //}
    #endregion
}