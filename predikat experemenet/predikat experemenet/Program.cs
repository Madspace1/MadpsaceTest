using System;

public class MyList<T>
{
    private T[] _items;
    private int _count;

    // Конструктор класса
    public MyList(int capacity)
    {
        _items = new T[capacity];
        _count = 0;
    }

    // Метод добавления элемента в список
    public void Add(T item)
    {
        if (_count < _items.Length)
        {
            _items[_count++] = item;
        }
        else
        {
            // Увеличение размера массива (не реализовано здесь для простоты)
            // В реальном коде вам нужно будет реализовать логику увеличения массива
        }
    }

    // Метод поиска первого элемента, удовлетворяющего предикату
    public T Find(Predicate<T> match)
    {
        if (match == null)
            return default(T); // Возвращаем значение по умолчанию, если предикат null

        for (int i = 0; i < _count; i++)
        {
            if (match(_items[i]))
            {
                return _items[i];
            }
        }

        return default(T); // Если элемент не найден, возвращаем значение по умолчанию
    }

    // Метод поиска всех элементов, удовлетворяющих предикату
    public MyList<T> FindAll(Predicate<T> match)
    {
        if (match == null)
            return new MyList<T>(0); // Возвращаем пустой список, если предикат null

        MyList<T> result = new MyList<T>(_count);
        for (int i = 0; i < _count; i++)
        {
            if (match(_items[i]))
            {
                result.Add(_items[i]);
            }
        }

        return result;
    }

    // Свойство для доступа к элементам (только для демонстрации)
    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < _count)
            {
                return _items[index];
            }
            throw new IndexOutOfRangeException();
        }
    }

    // Свойство для получения количества элементов
    public int Count
    {
        get { return _count; }
    }
}

public class Program
{
    public static void Main()
    {
        MyList<int> numbers = new MyList<int>(10);
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        // Найти первый элемент больше 3
        int found = numbers.Find(n => n > 3);
        Console.WriteLine($"Found: {found}");

        // Найти все элементы меньше 4
        MyList<int> smallNumbers = numbers.FindAll(n => n < 4);
        // Вывести все найденные элементы
        Console.Write("Small Numbers: ");
        for (int i = 0; i < smallNumbers.Count; i++)
        {
            Console.Write(smallNumbers[i] + " ");
        }
    }
}