using System;

/// ============================================
/// 🏋️ שלב 2: פעולות בסיסיות על מערכים
/// (ללא Wrapper Functions)
/// ============================================
/// בשלב זה אנחנו עובדים ישירות עם אינדקס
/// התלמיד צריך לזכור להעביר 0 בקריאה הראשונה

class Program
{
    static void Main()
    {
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("🏋️ 02_Arrays_Basic.cs - פעולות בסיסיות על מערכים");
        Console.WriteLine("═══════════════════════════════════════════════════\n");

        Console.WriteLine("💡 בקובץ זה יש 12 דוגמאות של פעולות רקורסיביות:");
        Console.WriteLine("  ✅ הדפסה, ספירה, סכום, מקסימום, מינימום");
        Console.WriteLine("  ✅ חיפוש, מציאת אינדקס, הפוכה");
        Console.WriteLine("  ✅ ספירת אלמנטים שמקיימים תנאי");
        Console.WriteLine("  ✅ בדיקות: All (כולם) ו-Exists (לפחות אחד)\n");

        Console.WriteLine("📊 טבלה השוואתית: All vs Exists");
        Console.WriteLine("┌─────────────────┬──────────────────┬──────────────────┐");
        Console.WriteLine("│ מאפיין          │ All (כולם)       │ Exists (אחד)     │");
        Console.WriteLine("├─────────────────┼──────────────────┼──────────────────┤");
        Console.WriteLine("│ מטרה            │ חפש כשל          │ חפש הצלחה        │");
        Console.WriteLine("│ עצירה מוקדמת    │ false ברגע מיד   │ true ברגע מיד    │");
        Console.WriteLine("│ בסוף מערך       │ return true      │ return false     │");
        Console.WriteLine("│ דוגמה           │ כל זוגיים?       │ קיים זוגי?       │");
        Console.WriteLine("└─────────────────┴──────────────────┴──────────────────┘\n");

        Console.WriteLine("👉 קרא את הקוד בעיון - כל פונקציה מוסברת!");
        Console.WriteLine("👉 לצעד הבא: 03_Arrays_Advanced.cs (Wrapper Functions)");
    }

    // ============================================
    // 📊 טבלה השוואתית: "כולם" vs "לפחות אחד"
    // ============================================
    // 
    // מאפיין              | "כולם" (All)        | "לפחות אחד" (Exists)
    // -------------------|-------------------|-------------------
    // מטרת הסריקה        | חפש כשל            | חפש הצלחה
    // עצירה מוקדמת       | אם נמצא כשל → false| אם נמצא הצלחה → true
    // הגעה ל-Length      | return true        | return false
    // דוגמה              | כל איברים זוגיים? | קיים מספר שלילי?
    //
    // להסבר: בתבנית "כולם", אנחנו מחפשים איבר שלא מקיים.
    // ברגע שנמצא אחד - אפשר להחזיר false.
    // בתבנית "לפחות אחד", אנחנו מחפשים איבר שכן מקיים.
    // ברגע שנמצא אחד - אפשר להחזיר true.

    // ============================================
    // 1️⃣ הדפסת מערך - מיד לסוף
    // ============================================
    public static void PrintArray(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine();
            return;
        }
        Console.Write(arr[index] + " ");
        PrintArray(arr, index + 1);
    }

    // ============================================
    // 2️⃣ ספירת אלמנטים במערך
    // ============================================
    public static int CountElements(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        return 1 + CountElements(arr, index + 1);
    }

    // ============================================
    // 3️⃣ סכום כל האלמנטים
    // ============================================
    public static int SumArray(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        return arr[index] + SumArray(arr, index + 1);
    }

    // ============================================
    // 4️⃣ מציאת הערך המקסימלי
    // ============================================
    public static int FindMax(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return arr[index];
        int maxOfRest = FindMax(arr, index + 1);
        return arr[index] > maxOfRest ? arr[index] : maxOfRest;
    }

    // ============================================
    // 5️⃣ מציאת הערך המינימלי
    // ============================================
    public static int FindMin(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return arr[index];
        int minOfRest = FindMin(arr, index + 1);
        return arr[index] < minOfRest ? arr[index] : minOfRest;
    }

    // ============================================
    // 6️⃣ חיפוש אלמנט במערך
    // ============================================
    public static bool Contains(int[] arr, int index, int target)
    {
        if (index == arr.Length)
            return false;
        if (arr[index] == target)
            return true;
        return Contains(arr, index + 1, target);
    }

    // ============================================
    // 7️⃣ מציאת אינדקס של אלמנט
    // ============================================
    public static int IndexOf(int[] arr, int index, int target)
    {
        if (index == arr.Length)
            return -1;
        if (arr[index] == target)
            return index;
        return IndexOf(arr, index + 1, target);
    }

    // ============================================
    // 8️⃣ ספירת אלמנטים שמקיימים תנאי
    // ============================================
    public static int CountGreaterThan5(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        if (arr[index] > 5)
            return 1 + CountGreaterThan5(arr, index + 1);
        else
            return CountGreaterThan5(arr, index + 1);
    }

    // ============================================
    // 9️⃣ סכום אלמנטים שמקיימים תנאי
    // ============================================
    public static int SumEvenNumbers(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        if (arr[index] % 2 == 0)
            return arr[index] + SumEvenNumbers(arr, index + 1);
        else
            return SumEvenNumbers(arr, index + 1);
    }

    // ============================================
    // 🔟 הפיכת מערך (מ-סוף להתחלה)
    // ============================================
    public static void ReverseArray(int[] arr, int index)
    {
        if (index < 0)
        {
            Console.WriteLine();
            return;
        }
        Console.Write(arr[index] + " ");
        ReverseArray(arr, index - 1);
    }

    // ============================================
    // 1️⃣1️⃣ בדיקה - האם כל אלמנטים זוגיים? (תבנית ALL)
    // ============================================
    public static bool AllEven(int[] arr, int index)
    {
        if (index == arr.Length)
            return true;
        if (arr[index] % 2 != 0)
            return false;
        return AllEven(arr, index + 1);
    }

    // ============================================
    // 1️⃣2️⃣ בדיקה - האם קיים אלמנט גדול מ-10? (תבנית EXISTS)
    // ============================================
    public static bool ExistsGreaterThan10(int[] arr, int index)
    {
        if (index == arr.Length)
            return false;
        if (arr[index] > 10)
            return true;
        return ExistsGreaterThan10(arr, index + 1);
    }
}
