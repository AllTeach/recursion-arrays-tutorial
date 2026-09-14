using System;

/// ============================================
/// ✅ שלב 5: פתרונות מלאים לתרגילים
/// ============================================
/// כאן יש את כל הפתרונות המלאים
/// קראו אחרי שניסיתם לעצמכם!
/// 

class Program
{
    static void Main()
    {
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("✅ 05_Exercises_Full.cs - פתרונות מלאים");
        Console.WriteLine("═══════════════════════════════════════════════════\n");

        Console.WriteLine("🎓 בקובץ זה יש 8 פתרונות מלאים\n");

        Console.WriteLine("🔍 איך להשתמש בקובץ זה:");
        Console.WriteLine("  1. נסו לפתור לבד קודם");
        Console.WriteLine("  2. אם טעיתם - קראו את הפתרון כאן");
        Console.WriteLine("  3. הבינו למה זה נכון");
        Console.WriteLine("  4. נסו שוב בלי להסתכל\n");

        Console.WriteLine("💡 טיפ: כל פתרון יש הערות מפורטות");
        Console.WriteLine("👉 קרא בעיון ולמד מהדוגמאות!");
    }

    // ============================================
    // פתרון 1: הדפסת מערך בהפוכה סדר
    // ============================================
    public static void PrintArrayReverse(int[] arr)
    {
        PrintArrayReverseHelper(arr, arr.Length - 1);
    }

    private static void PrintArrayReverseHelper(int[] arr, int index)
    {
        if (index < 0)
        {
            Console.WriteLine();
            return;
        }
        Console.Write(arr[index] + " ");
        PrintArrayReverseHelper(arr, index - 1);
    }

    // ============================================
    // פתרון 2: ספירת אלמנטים גדולים מ-X
    // ============================================
    public static int CountGreaterThan(int[] arr, int target)
    {
        return CountGreaterThanHelper(arr, 0, target);
    }

    private static int CountGreaterThanHelper(int[] arr, int index, int target)
    {
        if (index == arr.Length)
            return 0;
        if (arr[index] > target)
            return 1 + CountGreaterThanHelper(arr, index + 1, target);
        else
            return CountGreaterThanHelper(arr, index + 1, target);
    }

    // ============================================
    // פתרון 3: סכום אלמנטים שגדולים מ-5
    // ============================================
    public static int SumGreaterThan5(int[] arr)
    {
        return SumGreaterThan5Helper(arr, 0);
    }

    private static int SumGreaterThan5Helper(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        if (arr[index] > 5)
            return arr[index] + SumGreaterThan5Helper(arr, index + 1);
        else
            return SumGreaterThan5Helper(arr, index + 1);
    }

    // ============================================
    // פתרון 4: האם יש למעט אלמנט חיובי?
    // ============================================
    public static bool HasPositive(int[] arr)
    {
        return HasPositiveHelper(arr, 0);
    }

    private static bool HasPositiveHelper(int[] arr, int index)
    {
        if (index == arr.Length)
            return false;
        if (arr[index] > 0)
            return true;
        return HasPositiveHelper(arr, index + 1);
    }

    // ============================================
    // פתרון 5: מצא את כל המיקומים של value
    // ============================================
    public static void FindAllOccurrences(int[] arr, int value)
    {
        FindAllOccurrencesHelper(arr, 0, value);
    }

    private static void FindAllOccurrencesHelper(int[] arr, int index, int value)
    {
        if (index == arr.Length)
        {
            Console.WriteLine();
            return;
        }
        if (arr[index] == value)
            Console.Write(index + " ");
        FindAllOccurrencesHelper(arr, index + 1, value);
    }

    // ============================================
    // פתרון 6: האם המערך ממויין (עולה)?
    // ============================================
    public static bool IsSorted(int[] arr)
    {
        return IsSortedHelper(arr, 0);
    }

    private static bool IsSortedHelper(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return true;
        if (arr[index] > arr[index + 1])
            return false;
        return IsSortedHelper(arr, index + 1);
    }

    // ============================================
    // פתרון 7: הדפסת אלמנטים זוגיים בלבד
    // ============================================
    public static void PrintEvenNumbers(int[] arr)
    {
        PrintEvenNumbersHelper(arr, 0);
    }

    private static void PrintEvenNumbersHelper(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine();
            return;
        }
        if (arr[index] % 2 == 0)
            Console.Write(arr[index] + " ");
        PrintEvenNumbersHelper(arr, index + 1);
    }

    // ============================================
    // פתרון 8: מציאת ממוצע של מערך
    // ============================================
    public static double AverageArray(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        int sum = SumArrayHelper(arr, 0);
        return (double)sum / arr.Length;
    }

    private static int SumArrayHelper(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        return arr[index] + SumArrayHelper(arr, index + 1);
    }
}
