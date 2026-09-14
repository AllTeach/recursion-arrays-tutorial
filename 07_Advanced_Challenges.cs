using System;

/// ============================================
/// 🏆 שלב 7: אתגרים מתקדמים (Advanced Challenges)
/// ============================================
/// לתלמידים שרוצים עוד אתגר!
/// בעיות יותר מורכבות שדורשות חשיבה עמוקה
/// 

class Program
{
    static void Main()
    {
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("🏆 07_Advanced_Challenges.cs - אתגרים מתקדמים");
        Console.WriteLine("═══════════════════════════════════════════════════\n");

        Console.WriteLine("🎯 בעיות מתקדמות ומורכבות:\n");
        Console.WriteLine("  1. בדיקת פלינדרום - האם מערך קורא אותו בשתי כיוונים?");
        Console.WriteLine("  2. סדרה חשבונית - מהו הפרש קבוע?");
        Console.WriteLine("  3. חיפוש בינארי רקורסיבי - חיפוש יעיל במערך ממויין");
        Console.WriteLine("  4. סוכן מקסימלי בחלון - מצא מקס בתת-מערך");
        Console.WriteLine("  5. רקורסיה דוכנית - תרגום לאיטרציה\n");

        Console.WriteLine("💡 אלו בעיות שדורשות:");
        Console.WriteLine("  ✅ הבנה עמוקה של הנחה רקורסיבית");
        Console.WriteLine("  ✅ חשיבה על אינדקסים וגבולות");
        Console.WriteLine("  ✅ הוכחה מתמטית של הנכונות\n");

        Console.WriteLine("⚠️  רמז: תרגילים אלו דורשים זמן! אל תמהרו.");
        Console.WriteLine("👉 קראו את ההערות בקוד בעיון!");
    }

    // ============================================
    // אתגר 1: בדיקת פלינדרום
    // ============================================
    // מערך פלינדרום נקרא אותו דבר מההתחלה לסוף ומהסוף להתחלה
    // דוגמה: { 1, 5, 8, 5, 1 } -> true
    // דוגמה: { 1, 2, 3 } -> false
    
    public static bool IsPalindrome(int[] arr)
    {
        return IsPalindromeHelper(arr, 0, arr.Length - 1);
    }

    private static bool IsPalindromeHelper(int[] arr, int left, int right)
    {
        // תנאי עצירה: המינו של שני המצביעים התגעגעו או חצו
        if (left >= right)
            return true;
        
        // בדוק שהאלמנטים בשני הצדדים זהים
        if (arr[left] != arr[right])
            return false;
        
        // תמשיכו לבדוק את הפנים
        return IsPalindromeHelper(arr, left + 1, right - 1);
    }

    // שימוש:
    // int[] nums = { 1, 5, 8, 5, 1 };
    // bool result = IsPalindrome(nums); // החזר true


    // ============================================
    // אתגר 2: בדיקת סדרה חשבונית
    // ============================================
    // סדרה חשבונית היא סדרה שבה ההפרש בין כל שני אלמנטים עוקבים קבוע
    // דוגמה: { 2, 5, 8, 11, 14 } -> true (הפרש = 3)
    // דוגמה: { 1, 2, 4, 8 } -> false (הפרשים שונים)
    
    public static bool IsArithmeticProgression(int[] arr)
    {
        if (arr.Length <= 2)
            return true; // כל מערך בגודל 0-2 הוא סדרה חשבונית
        
        int diff = arr[1] - arr[0];
        return IsArithmeticProgressionHelper(arr, 0, diff);
    }

    private static bool IsArithmeticProgressionHelper(int[] arr, int index, int diff)
    {
        // תנאי עצירה: הגענו לאלמנט אחרון
        if (index == arr.Length - 1)
            return true;
        
        // בדוק שההפרש שווה לכל זוג עוקב
        if (arr[index + 1] - arr[index] != diff)
            return false;
        
        // המשך עם האלמנט הבא
        return IsArithmeticProgressionHelper(arr, index + 1, diff);
    }

    // שימוש:
    // int[] nums1 = { 2, 5, 8, 11, 14 };
    // bool result1 = IsArithmeticProgression(nums1); // החזר true
    // 
    // int[] nums2 = { 1, 2, 4, 8 };
    // bool result2 = IsArithmeticProgression(nums2); // החזר false


    // ============================================
    // אתגר 3: חיפוש בינארי רקורסיבי
    // ============================================
    // חיפוש יעיל בתוך מערך ממויין - O(log n)
    // הנחה: המערך ממויין בסדר עולה
    // דוגמה: { 1, 3, 5, 7, 9 }, target=7 -> החזר true
    
    public static bool BinarySearch(int[] arr, int target)
    {
        return BinarySearchHelper(arr, 0, arr.Length - 1, target);
    }

    private static bool BinarySearchHelper(int[] arr, int left, int right, int target)
    {
        // תנאי עצירה: טווח ריק
        if (left > right)
            return false;
        
        int mid = left + (right - left) / 2;
        
        // מצאנו!
        if (arr[mid] == target)
            return true;
        
        // חיפוש בחצי הימנה
        if (arr[mid] < target)
            return BinarySearchHelper(arr, mid + 1, right, target);
        
        // חיפוש בחצי השמאלה
        return BinarySearchHelper(arr, left, mid - 1, target);
    }

    // שימוש:
    // int[] nums = { 1, 3, 5, 7, 9 };
    // bool found = BinarySearch(nums, 7); // החזר true
    // bool notFound = BinarySearch(nums, 6); // החזר false


    // ============================================
    // אתגר 4: מקסימום בחלון (sliding window)
    // ============================================
    // מצא את הערך המקסימלי בתוך מערך, מ-left ל-right
    // זה יותר כללי מ-FindMax כי אתה בוחר את הטווח
    
    public static int MaxInRange(int[] arr, int left, int right)
    {
        // בדוק גבולות
        if (left < 0 || right >= arr.Length || left > right)
            throw new ArgumentException("טווח לא תקין!");
        
        return MaxInRangeHelper(arr, left, right);
    }

    private static int MaxInRangeHelper(int[] arr, int left, int right)
    {
        // תנאי עצירה: אלמנט יחיד בטווח
        if (left == right)
            return arr[left];
        
        // מצא מקס של השאר
        int maxOfRest = MaxInRangeHelper(arr, left + 1, right);
        
        // החזר את הגדול
        return arr[left] > maxOfRest ? arr[left] : maxOfRest;
    }

    // שימוש:
    // int[] nums = { 5, 2, 9, 1, 7, 3 };
    // int max = MaxInRange(nums, 2, 5); // טווח [2,5] -> {9, 1, 7, 3} -> החזר 9


    // ============================================
    // אתגר 5: תרגום רקורסיה לאיטרציה (tail recursion)
    // ============================================
    // תמיד אפשר להמיר רקורסיה סיום-זנב לאיטרציה
    // זה לא שונה רקורסיבית, אבל חשוב להבין את הקשר
    
    // גרסה רקורסיבית:
    public static int SumRecursive(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        return arr[index] + SumRecursive(arr, index + 1);
    }

    // גרסה איטרטיבית (בלי רקורסיה):
    public static int SumIterative(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    // שימוש:
    // int[] nums = { 1, 2, 3, 4, 5 };
    // int resultRec = SumRecursive(nums, 0);  // החזר 15
    // int resultIter = SumIterative(nums);     // החזר 15
    // שתיהן זהות!

}
