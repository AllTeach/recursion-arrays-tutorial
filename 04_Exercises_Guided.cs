using System;

/// ============================================
/// 🏋️ שלב 4: תרגילים עם הכוונה (Guided Exercises)
/// ============================================
/// כאן יש לכם skeleton code - השלימו את הקוד!
/// הקוד מודגם בצורה בסיסית, אתם צריכים להשלים
/// 

class Program
{
    static void Main()
    {
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("🏋️ 04_Exercises_Guided.cs - תרגילים עם Wrapper");
        Console.WriteLine("═══════════════════════════════════════════════════\n");

        Console.WriteLine("🎯 8 תרגילים - עם Wrapper Functions\n");
        Console.WriteLine("רמה זו מתאימה אם:");
        Console.WriteLine("  ✅ אתה מבין Wrapper Functions");
        Console.WriteLine("  ✅ אתה רוצה API נקי וקל לשימוש");
        Console.WriteLine("  ✅ אתה מוכן אתגר גדול יותר\n");

        Console.WriteLine("תרגילים:");
        Console.WriteLine("  1. הדפסת מערך בהפוכה סדר");
        Console.WriteLine("  2. ספירת אלמנטים גדולים מ-X");
        Console.WriteLine("  3. סכום אלמנטים שמקיימים תנאי");
        Console.WriteLine("  4. בדיקה - האם קיים אלמנט חיובי?");
        Console.WriteLine("  5. חיפוש כל המיקומים של value");
        Console.WriteLine("  6. בדיקה - האם המערך ממויין?");
        Console.WriteLine("  7. הדפסת אלמנטים זוגיים בלבד");
        Console.WriteLine("  8. מציאת הממוצע של מערך\n");

        Console.WriteLine("👉 השלם את ה-TODO בכל פונקציה");
        Console.WriteLine("👉 לסיום: 05_Exercises_Full.cs (פתרונות)");
    }

    // ============================================
    // תרגיל 1: הדפסת מערך בהפוכה סדר
    // ============================================
    public static void PrintArrayReverse(int[] arr)
    {
        PrintArrayReverseHelper(arr, arr.Length - 1);
    }

    private static void PrintArrayReverseHelper(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 2: ספירת אלמנטים גדולים מ-X
    // ============================================
    public static int CountGreaterThan(int[] arr, int target)
    {
        return CountGreaterThanHelper(arr, 0, target);
    }

    private static int CountGreaterThanHelper(int[] arr, int index, int target)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
        return 0;
    }

    // ============================================
    // תרגיל 3: סכום רק של אלמנטים שמקיימים תנאי
    // ============================================
    public static int SumGreaterThan5(int[] arr)
    {
        return SumGreaterThan5Helper(arr, 0);
    }

    private static int SumGreaterThan5Helper(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
        return 0;
    }

    // ============================================
    // תרגיל 4: בדיקה - האם יש למעט אלמנט אחד חיובי?
    // ============================================
    public static bool HasPositive(int[] arr)
    {
        return HasPositiveHelper(arr, 0);
    }

    private static bool HasPositiveHelper(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
        return false;
    }

    // ============================================
    // תרגיל 5: חיפוש בדיוק כל הערך X
    // ============================================
    public static void FindAllOccurrences(int[] arr, int value)
    {
        FindAllOccurrencesHelper(arr, 0, value);
    }

    private static void FindAllOccurrencesHelper(int[] arr, int index, int value)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 6: בדיקה - האם המערך ממויין (עולה)?
    // ============================================
    public static bool IsSorted(int[] arr)
    {
        return IsSortedHelper(arr, 0);
    }

    private static bool IsSortedHelper(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
        return false;
    }

    // ============================================
    // תרגיל 7: הדפסת אלמנטים זוגיים בלבד
    // ============================================
    public static void PrintEvenNumbers(int[] arr)
    {
        PrintEvenNumbersHelper(arr, 0);
    }

    private static void PrintEvenNumbersHelper(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 8: מציאת ממוצע של מערך
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
        // TODO: כתבו סכום רקורסיבי כאן
        return 0;
    }
}
