using System;

/// ============================================
/// 🏋️ שלב 4B: תרגילים ללא Wrapper (רמה 1)
/// ============================================
/// אותם תרגילים כמו 04_Exercises_Guided
/// אבל ללא Wrapper Functions
/// 
/// זה למי שעדיין לא בטוח בהנחה הרקורסיבית
/// קבלו את האינדקס כפרמטר ופתרו!
/// 

class Program
{
    static void Main()
    {
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("🏋️ 04B_Exercises_No_Wrapper.cs - רמה 1");
        Console.WriteLine("═══════════════════════════════════════════════════\n");

        Console.WriteLine("🎯 8 תרגילים - ללא Wrapper Functions\n");
        Console.WriteLine("רמה זו מתאימה אם:");
        Console.WriteLine("  ✅ אתה בטוח בהנחה הרקורסיבית");
        Console.WriteLine("  ✅ אתה מוכן להעביר index כפרמטר");
        Console.WriteLine("  ✅ אתה רוצה להתחזק בטכניקה הבסיסית\n");

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
    // תרגיל 1: הדפסת מערך בהפוכה סדר (ללא wrapper)
    // ============================================
    public static void PrintArrayReverse(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 2: ספירת אלמנטים גדולים מ-X (ללא wrapper)
    // ============================================
    public static int CountGreaterThan(int[] arr, int index, int target)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 3: סכום רק אלמנטים שמקיימים תנאי (ללא wrapper)
    // ============================================
    public static int SumGreaterThan5(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 4: בדיקה - האם קיים אלמנט חיובי? (ללא wrapper)
    // ============================================
    public static bool HasPositive(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 5: חיפוש כל המיקומים של value (ללא wrapper)
    // ============================================
    public static void FindAllOccurrences(int[] arr, int index, int value)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 6: בדיקה - האם המערך ממויין (עולה)? (ללא wrapper)
    // ============================================
    public static bool IsSorted(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 7: הדפסת אלמנטים זוגיים בלבד (ללא wrapper)
    // ============================================
    public static void PrintEvenNumbers(int[] arr, int index)
    {
        // TODO: כתבו את קוד הרקורסיה כאן
    }

    // ============================================
    // תרגיל 8: מציאת הממוצע של מערך (ללא wrapper)
    // ============================================
    public static double AverageArray(int[] arr, int index)
    {
        // TODO: קודם כל, חשבו סכום עם רקורסיה
        // אחרי זה, חשבו ממוצע
        return 0;
    }

    private static int SumHelper(int[] arr, int index)
    {
        // TODO: כתבו סכום רקורסיבי כאן
        return 0;
    }
}
