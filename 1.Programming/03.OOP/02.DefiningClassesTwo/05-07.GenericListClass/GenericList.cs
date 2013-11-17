using System;
using System.Text;
public class GenericList<T> where T : IComparable
{
    private const int CAPACITY = 4;
    private T[] list;
    private int currentLength = -1;
    
    public GenericList()
    {
        this.list = new T[CAPACITY];
    }

    public T this[int index]
    {        
        get { return this.list[index]; }
        set { this.list[index] = value; }
    }

    public void Add(T item)
    {
        this.currentLength++;

        if (this.currentLength == this.list.Length)
        {
            T[] newList = new T[this.list.Length * 2];

            for (int i = 0; i < this.list.Length; i++)
            {
                newList[i] = this.list[i];
            }

            this.list = newList;
        }
            
        this.list[currentLength] = item;
    }

    public void RemoveAt(int index)
    {
        try
        {
            this.list[index] = default(T);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0 || index > this.list.Length)
        {
            throw new ArgumentOutOfRangeException();
        }

        this.currentLength++;
        T[] newList;

        if (currentLength == this.list.Length)
        {
            newList = new T[this.list.Length * 2]; 
        }
        else
        {
            newList = new T[this.list.Length];
        }

        int currentIndex = 0;

        while (currentIndex < index)
        {
            newList[currentIndex] = this.list[currentIndex];
            currentIndex++;
        }

        newList[currentIndex] = item;

        for (int i = index; i < this.list.Length; i++)
        {
            newList[i + 1] = this.list[i];
        }

        this.list = newList;         
    }

    public int Find(T item)
    {
        for (int i = 0; i < this.list.Length; i++)
        {
            if (this.list[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public T Min<T>() where T : IComparable<T>
    {
        dynamic min = list[0];
        for (int i = 1; i < this.list.Length; i++)
        {
            if (this.list[i].CompareTo(min) >= 0)
            {
                min = this.list[i];
            }
        }
        return min;
    }

    public T Max<T>() where T : IComparable<T>
    {
        dynamic max = list[0];
        for (int i = 1; i < this.list.Length; i++)
        {
            if (this.list[i].CompareTo(max) <= 0)
            {
                max = this.list[i];
            }
        }
        return max;
    }
    public void Clear()
    {
        this.list = new T[this.list.Length];
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        foreach (var item in this.list)
        {
            result.Append(item).Append(" ");
        }

        return result.ToString();
    }
}

    