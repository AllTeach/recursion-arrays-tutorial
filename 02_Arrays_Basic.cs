using System;

/// ============================================
/// 🔧 שלב 2: פעולות בסיסיות על מערכים
/// (ללא Wrapper Functions)
/// ============================================
/// בשלב זה אנחנו עובדים ישירות עם אינדקס
/// התלמיד צריך לזכור להעביר 0 בקריאה הראשונה

class ArraysBasic
{
    // ============================================
    // 1️⃣ הדפסת מערך - מיד לסוף
    // ============================================
    // מטרה: להדפיס כל אלמנט בשורה אחת
    // קלט: מערך של מספרים ואינדקס התחלה
    // פלט: ההדפסה (void)
    
    public static void PrintArray(int[] arr, int index)
    {
        // שלב 1: בדוק אם סיימנו את המערך
        if (index == arr.Length)
        {
            Console.WriteLine(); // סוף השורה
            return;
        }

        // שלב 2: הדפס את האלמנט הנוכחי
        Console.Write(arr[index] + " ");

        // שלב 3: קרא רקורסיבית לאלמנט הבא
        PrintArray(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 10, 20, 30 };
    // PrintArray(nums, 0);
    // פלט: 10 20 30


    // ============================================
    // 2️⃣ ספירת אלמנטים במערך
    // ============================================
    // מטרה: לספור כמה אלמנטים יש
    // קלט: מערך ואינדקס
    // פלט: מספר האלמנטים
    
    public static int CountElements(int[] arr, int index)
    {
        // תנאי עצירה: הגענו לסוף
        if (index == arr.Length)
        {
            return 0;
        }

        // צעד רקורסיבי: 1 (הנוכחי) + ספירת השאר
        return 1 + CountElements(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 10, 20, 30, 40 };
    // int count = CountElements(nums, 0); // החזר 4


    // ============================================
    // 3️⃣ סכום כל האלמנטים
    // ============================================
    // מטרה: חישוב הסכום של כל המערך
    // קלט: מערך ואינדקס
    // פלט: הסכום
    
    public static int SumArray(int[] arr, int index)
    {
        // תנאי עצירה: הגענו לסוף - סכום 0
        if (index == arr.Length)
        {
            return 0;
        }

        // צעד רקורסיבי: אלמנט נוכחי + סכום השאר
        return arr[index] + SumArray(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 1, 2, 3, 4 };
    // int sum = SumArray(nums, 0); // החזר 10


    // ============================================
    // 4️⃣ מציאת הערך המקסימלי
    // ============================================
    // מטרה: למצוא את המספר הגדול ביותר
    // קלט: מערך ואינדקס
    // פלט: המקסימום
    
    public static int FindMax(int[] arr, int index)
    {
        // תנאי עצירה: אלמנט אחרון בלבד
        if (index == arr.Length - 1)
        {
            return arr[index];
        }

        // צעד רקורסיבי:
        // קח את המקסימום בין: הנוכחי ל- המקסימום של השאר
        int maxOfRest = FindMax(arr, index + 1);
        return arr[index] > maxOfRest ? arr[index] : maxOfRest;
    }

    // שימוש:
    // int[] nums = { 5, 2, 9, 1, 7 };
    // int max = FindMax(nums, 0); // החזר 9


    // ============================================
    // 5️⃣ מציאת הערך המינימלי
    // ============================================
    // מטרה: למצוא את המספר הקטן ביותר
    // קלט: מערך ואינדקס
    // פלט: המינימום
    
    public static int FindMin(int[] arr, int index)
    {
        // תנאי עצירה: אלמנט אחרון בלבד
        if (index == arr.Length - 1)
        {
            return arr[index];
        }

        // צעד רקורסיבי:
        // קח את המינימום בין: הנוכחי ל- המינימום של השאר
        int minOfRest = FindMin(arr, index + 1);
        return arr[index] < minOfRest ? arr[index] : minOfRest;
    }

    // שימוש:
    // int[] nums = { 5, 2, 9, 1, 7 };
    // int min = FindMin(nums, 0); // החזר 1


    // ============================================
    // 6️⃣ חיפוש אלמנט במערך
    // ============================================
    // מטרה: לבדוק האם אלמנט מסוים קיים
    // קלט: מערך, אינדקס, ערך לחיפוש
    // פלט: true אם קיים, false אחרת
    
    public static bool Contains(int[] arr, int index, int target)
    {
        // תנאי עצירה 1: סיימנו את המערך ולא מצאנו
        if (index == arr.Length)
        {
            return false;
        }

        // תנאי עצירה 2: מצאנו את הערך!
        if (arr[index] == target)
        {
            return true;
        }

        // צעד רקורסיבי: בדוק את השאר
        return Contains(arr, index + 1, target);
    }

    // שימוש:
    // int[] nums = { 3, 7, 2, 9, 1 };
    // bool found = Contains(nums, 0, 7); // החזר true
    // bool notFound = Contains(nums, 0, 10); // החזר false


    // ============================================
    // 7️⃣ מציאת אינדקס של אלמנט
    // ============================================
    // מטרה: להחזיר את המיקום של אלמנט
    // קלט: מערך, אינדקס, ערך לחיפוש
    // פלט: האינדקס של האלמנט (או -1 אם לא קיים)
    
    public static int IndexOf(int[] arr, int index, int target)
    {
        // תנאי עצירה 1: סיימנו את המערך ולא מצאנו
        if (index == arr.Length)
        {
            return -1;
        }

        // תנאי עצירה 2: מצאנו את הערך!
        if (arr[index] == target)
        {
            return index;
        }

        // צעד רקורסיבי: בדוק את השאר
        return IndexOf(arr, index + 1, target);
    }

    // שימוש:
    // int[] nums = { 3, 7, 2, 9, 1 };
    // int idx = IndexOf(nums, 0, 9); // החזר 3
    // int notFound = IndexOf(nums, 0, 10); // החזר -1


    // ============================================
    // 8️⃣ ספירת אלמנטים שמקיימים תנאי
    // ============================================
    // מטרה: לספור כמה אלמנטים גדולים מ-5
    // קלט: מערך ואינדקס
    // פלט: הספירה
    
    public static int CountGreaterThan5(int[] arr, int index)
    {
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
        {
            return 0;
        }

        // צעד רקורסיבי:
        // אם הנוכחי מקיים - ספור אותו + ספור את השאר
        // אחרת - רק ספור את השאר
        if (arr[index] > 5)
        {
            return 1 + CountGreaterThan5(arr, index + 1);
        }
        else
        {
            return CountGreaterThan5(arr, index + 1);
        }
    }

    // שימוש:
    // int[] nums = { 2, 7, 3, 9, 4, 8 };
    // int count = CountGreaterThan5(nums, 0); // החזר 3 (7, 9, 8)


    // ============================================
    // 9️⃣ סכום אלמנטים שמקיימים תנאי
    // ============================================
    // מטרה: לסכום רק אלמנטים זוגיים
    // קלט: מערך ואינדקס
    // פלט: הסכום
    
    public static int SumEvenNumbers(int[] arr, int index)
    {
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
        {
            return 0;
        }

        // צעד רקורסיבי:
        // אם הנוכחי זוגי - כלול אותו בסכום
        if (arr[index] % 2 == 0)
        {
            return arr[index] + SumEvenNumbers(arr, index + 1);
        }
        else
        {
            return SumEvenNumbers(arr, index + 1);
        }
    }

    // שימוש:
    // int[] nums = { 1, 2, 3, 4, 5, 6 };
    // int sum = SumEvenNumbers(nums, 0); // החזר 12 (2+4+6)


    // ============================================
    // 🔟 הפיכת מערך (מ-סוף להתחלה)
    // ============================================
    // מטרה: להדפיס את המערך בסדר הפוך
    // קלט: מערך ואינדקס התחלה מהסוף
    // פלט: ההדפסה בסדר הפוך
    
    public static void ReverseArray(int[] arr, int index)
    {
        // תנאי עצירה: יצאנו מהשמאל
        if (index < 0)
        {
            Console.WriteLine();
            return;
        }

        // הדפס את האלמנט הנוכחי
        Console.Write(arr[index] + " ");

        // קרא רקורסיבית לאלמנט הקודם (משמאל)
        ReverseArray(arr, index - 1);
    }

    // שימוש:
    // int[] nums = { 10, 20, 30, 40 };
    // ReverseArray(nums, nums.Length - 1);
    // פלט: 40 30 20 10


    // ============================================
    // 1️⃣1️⃣ בדיקה - האם כל אלמנטים זוגיים?
    // ============================================
    // מטרה: להחזיר true רק אם כל המערך זוגי
    // קלט: מערך ואינדקס
    // פלט: true/false
    
    public static bool AllEven(int[] arr, int index)
    {
        // תנאי עצירה 1: סיימנו את המערך וכולם זוגיים
        if (index == arr.Length)
        {
            return true;
        }

        // תנאי עצירה 2: מצאנו אלמנט אי-זוגי - כלום לא צריך לבדוק עוד!
        if (arr[index] % 2 != 0)
        {
            return false;
        }

        // צעד רקורסיבי: בדוק את השאר
        return AllEven(arr, index + 1);
    }

    // שימוש:
    // int[] nums1 = { 2, 4, 6, 8 };
    // bool result1 = AllEven(nums1, 0); // החזר true
    // 
    // int[] nums2 = { 2, 4, 5, 8 };
    // bool result2 = AllEven(nums2, 0); // החזר false


    // ============================================
    // 1️⃣2️⃣ בדיקה - האם קיים אלמנט גדול מ-10?
    // ============================================
    // מטרה: להחזיר true אם יש לפחות אחד שמקיים
    // קלט: מערך ואינדקס
    // פלט: true/false
    
    public static bool ExistsGreaterThan10(int[] arr, int index)
    {
        // תנאי עצירה 1: סיימנו את המערך ולא מצאנו
        if (index == arr.Length)
        {
            return false;
        }

        // תנאי עצירה 2: מצאנו אלמנט שמקיים - כלום לא צריך לבדוק עוד!
        if (arr[index] > 10)
        {
            return true;
        }

        // צעד רקורסיבי: בדוק את השאר
        return ExistsGreaterThan10(arr, index + 1);
    }

    // שימוש:
    // int[] nums1 = { 1, 2, 3 };
    // bool result1 = ExistsGreaterThan10(nums1, 0); // החזר false
    // 
    // int[] nums2 = { 1, 2, 15 };
    // bool result2 = ExistsGreaterThan10(nums2, 0); // החזר true

}
