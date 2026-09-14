using System;

/// ============================================
/// ✅ שלב 5: פתרונות מלאים לתרגילים
/// ============================================
/// כאן יש את כל הפתרונות המלאים
/// קראו אחרי שניסיתם לעצמכם!
/// 

class ExercisesSolutions
{
    // ============================================
    // פתרון 1: הדפסת מערך בהפוכה סדר
    // ============================================
    
    public static void PrintArrayReverse(int[] arr)
    {
        PrintArrayReverseHelper(arr, arr.Length - 1);
    }

    private static void PrintArrayReverseHelper(int[] arr, int index)
    {
        // תנאי עצירה: יצאנו מהמערך משמאל
        if (index < 0)
        {
            Console.WriteLine(); // סוף השורה
            return;
        }

        // הדפס את האלמנט הנוכחי
        Console.Write(arr[index] + " ");

        // קרא רקורסיבית לאלמנט הקודם
        PrintArrayReverseHelper(arr, index - 1);
    }

    // דוגמה שימוש:
    // int[] nums = { 1, 2, 3 };
    // PrintArrayReverse(nums);
    // פלט: 3 2 1


    // ============================================
    // פתרון 2: ספירת אלמנטים גדולים מ-X
    // ============================================
    
    public static int CountGreaterThan(int[] arr, int target)
    {
        return CountGreaterThanHelper(arr, 0, target);
    }

    private static int CountGreaterThanHelper(int[] arr, int index, int target)
    {
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
            return 0;

        // אם האלמנט הנוכחי גדול מ-target
        if (arr[index] > target)
        {
            // ספור אותו (1) + ספור את השאר
            return 1 + CountGreaterThanHelper(arr, index + 1, target);
        }
        else
        {
            // אחרת, בדוק את השאר (לא ספור את הנוכחי)
            return CountGreaterThanHelper(arr, index + 1, target);
        }
    }

    // דוגמה שימוש:
    // int[] nums = { 1, 5, 3, 8, 2 };
    // int count = CountGreaterThan(nums, 4); // החזר 2 (5 ו-8)


    // ============================================
    // פתרון 3: סכום אלמנטים שגדולים מ-5
    // ============================================
    
    public static int SumGreaterThan5(int[] arr)
    {
        return SumGreaterThan5Helper(arr, 0);
    }

    private static int SumGreaterThan5Helper(int[] arr, int index)
    {
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
            return 0;

        // אם אלמנט > 5, כלול אותו בסכום
        if (arr[index] > 5)
        {
            return arr[index] + SumGreaterThan5Helper(arr, index + 1);
        }
        else
        {
            // אחרת, דלג עליו
            return SumGreaterThan5Helper(arr, index + 1);
        }
    }

    // דוגמה שימוש:
    // int[] nums = { 2, 7, 3, 9, 4, 8 };
    // int sum = SumGreaterThan5(nums); // החזר 24 (7+9+8)


    // ============================================
    // פתרון 4: האם יש למעט אלמנט חיובי?
    // ============================================
    
    public static bool HasPositive(int[] arr)
    {
        return HasPositiveHelper(arr, 0);
    }

    private static bool HasPositiveHelper(int[] arr, int index)
    {
        // תנאי עצירה: סיימנו את המערך ולא מצאנו חיובי
        if (index == arr.Length)
            return false;

        // אם מצאנו אלמנט חיובי - החזר true מיד!
        if (arr[index] > 0)
            return true;

        // אחרת, בדוק את השאר
        return HasPositiveHelper(arr, index + 1);
    }

    // דוגמה שימוש:
    // int[] nums1 = { -1, -5, 3, -2 };
    // bool result1 = HasPositive(nums1); // החזר true
    // 
    // int[] nums2 = { -1, -5, -3 };
    // bool result2 = HasPositive(nums2); // החזר false


    // ============================================
    // פתרון 5: מצא את כל המיקומים של value
    // ============================================
    
    public static void FindAllOccurrences(int[] arr, int value)
    {
        FindAllOccurrencesHelper(arr, 0, value);
    }

    private static void FindAllOccurrencesHelper(int[] arr, int index, int value)
    {
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
        {
            Console.WriteLine(); // סוף
            return;
        }

        // אם מצאנו את הערך - הדפס את המיקום
        if (arr[index] == value)
        {
            Console.Write(index + " ");
        }

        // המשך תמיד עם השאר
        FindAllOccurrencesHelper(arr, index + 1, value);
    }

    // דוגמה שימוש:
    // int[] nums = { 1, 2, 3, 2, 5 };
    // FindAllOccurrences(nums, 2);
    // פלט: 1 3


    // ============================================
    // פתרון 6: האם המערך ממויין (עולה)?
    // ============================================
    
    public static bool IsSorted(int[] arr)
    {
        return IsSortedHelper(arr, 0);
    }

    private static bool IsSortedHelper(int[] arr, int index)
    {
        // תנאי עצירה: הגענו לאלמנט האחרון (ללא "בא")
        if (index == arr.Length - 1)
            return true;

        // בדוק: האלמנט הנוכחי חייב להיות <= מהבא
        if (arr[index] > arr[index + 1])
            return false; // לא ממויין - החזר false מיד

        // אחרת, בדוק את השאר
        return IsSortedHelper(arr, index + 1);
    }

    // דוגמה שימוש:
    // int[] nums1 = { 1, 3, 5, 7 };
    // bool result1 = IsSorted(nums1); // החזר true
    // 
    // int[] nums2 = { 1, 3, 2, 7 };
    // bool result2 = IsSorted(nums2); // החזר false


    // ============================================
    // פתרון 7: הדפסת אלמנטים זוגיים בלבד
    // ============================================
    
    public static void PrintEvenNumbers(int[] arr)
    {
        PrintEvenNumbersHelper(arr, 0);
    }

    private static void PrintEvenNumbersHelper(int[] arr, int index)
    {
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
        {
            Console.WriteLine(); // סוף
            return;
        }

        // אם אלמנט זוגי - הדפס אותו
        if (arr[index] % 2 == 0)
        {
            Console.Write(arr[index] + " ");
        }

        // בכל מקרה, המשך עם השאר
        PrintEvenNumbersHelper(arr, index + 1);
    }

    // דוגמה שימוש:
    // int[] nums = { 1, 2, 3, 4, 5, 6 };
    // PrintEvenNumbers(nums);
    // פלט: 2 4 6


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
        // תנאי עצירה: סיימנו את המערך
        if (index == arr.Length)
            return 0;

        // סכום: הנוכחי + סכום השאר
        return arr[index] + SumArrayHelper(arr, index + 1);
    }

    // דוגמה שימוש:
    // int[] nums = { 2, 4, 6, 8 };
    // double avg = AverageArray(nums); // החזר 5.0


    // ============================================
    // 🎯 שיעורים חשובים מהפתרונות:
    // ============================================
    // 
    // 1. תנאי עצירה - תמיד קודם!
    //    - בדוק מתי לעצור ו-מה להחזיר
    // 
    // 2. הנחה (Induction Hypothesis):
    //    - אנחנו לא בודקים את כל המערך קודם
    //    - אנחנו מניחים שהפונקציה עובדת על חלק "הנותר"
    // 
    // 3. צעד רקורסיבי:
    //    - עשה משהו על הנוכחי
    //    - קרא על השאר
    //    - חבור את התוצאות
    // 
    // 4. בדקו edge cases:
    //    - מערך ריק
    //    - מערך בגודל 1
    //    - כל האלמנטים זהים
}
