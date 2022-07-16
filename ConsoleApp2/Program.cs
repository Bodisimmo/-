class Program
{
 public static void Main ()
    {
        string glass = "аоэеиыуёюяУЕЫАОЭЯИЮЁ";
        string soglass = "йцкнгшщзхфвпрлджчсмтбЙЦКНГШЩЗХФВПРЛДЖЧСМТБЮ";
        string znak = "ьъЬЪ";
        Console.WriteLine ("Введите слово");
        string? word = Console.ReadLine ();
        for (int i = 0; i < word.Length; i++)
        {
            if (glass.Contains(word[i]))
                Console.WriteLine($"{word[i]} Гласная на позиции {i + 1}");
            else if (soglass.Contains(word[i]))
                Console.WriteLine($"{word[i]} Согласная на позиции {i + 1}");
            else
                Console.WriteLine($"{word[i]} Знак на позиции {i + 1}");
        }
    }
}