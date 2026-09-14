using System;

/// ============================================
/// 🎓 שלב 3: Wrapper Functions
/// ============================================
/// עכשיו אנחנו מסתירים את האינדקס מהמשתמש
/// זה הרבה יותר נוח וטבעי
/// 

class ArraysAdvanced
{
    // ============================================
    // דוגמה 1: Wrapper ל-הדפסת מערך
    // ============================================
    
    // זו הפונקציה שהמשתמש קורא - קל מאוד!
    public static void PrintArray(int[] arr)
    {
        PrintArrayHelper(arr, 0);
    }

    // זו הפונקציה הפנימית שמכינה את ה-index
    private static void PrintArrayHelper(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine();
            return;
        }
        Console.Write(arr[index] + " ");
        PrintArrayHelper(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 1, 2, 3, 4, 5 };
    // PrintArray(nums); // הרבה יותר קל!


    // ============================================
    // דוגמה 2: Wrapper ל-סכום
    // ============================================
    
    public static int SumArray(int[] arr)
    {
        return SumArrayHelper(arr, 0);
    }

    private static int SumArrayHelper(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        return arr[index] + SumArrayHelper(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 1, 2, 3, 4, 5 };
    // int sum = SumArray(nums); // החזר 15


    // ============================================
    // דוגמה 3: Wrapper ל-מציאת מקסימום
    // ============================================
    
    public static int FindMax(int[] arr)
    {
        if (arr.Length == 0)
            throw new ArgumentException("מערך ריק!");
        
        return FindMaxHelper(arr, 0);
    }

    private static int FindMaxHelper(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return arr[index];
        
        int maxOfRest = FindMaxHelper(arr, index + 1);
        return arr[index] > maxOfRest ? arr[index] : maxOfRest;
    }

    // שימוש:
    // int[] nums = { 5, 2, 9, 1, 7 };
    // int max = FindMax(nums); // החזר 9


    // ============================================
    // דוגמה 4: Wrapper ל-חיפוש
    // ============================================
    
    public static bool Contains(int[] arr, int target)
    {
        return ContainsHelper(arr, 0, target);
    }

    private static bool ContainsHelper(int[] arr, int index, int target)
    {
        if (index == arr.Length)
            return false;
        
        if (arr[index] == target)
            return true;
        
        return ContainsHelper(arr, index + 1, target);
    }

    // שימוש:
    // int[] nums = { 3, 7, 2, 9, 1 };
    // bool found = Contains(nums, 7); // החזר true


    // ============================================
    // דוגמה 5: Wrapper ל-ספירת אלמנטים שמקיימים תנאי
    // ============================================
    
    public static int CountEvenNumbers(int[] arr)
    {
        return CountEvenHelper(arr, 0);
    }

    private static int CountEvenHelper(int[] arr, int index)
    {
        if (index == arr.Length)
            return 0;
        
        if (arr[index] % 2 == 0)
            return 1 + CountEvenHelper(arr, index + 1);
        else
            return CountEvenHelper(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 1, 2, 3, 4, 5, 6 };
    // int count = CountEvenNumbers(nums); // החזר 3


    // ============================================
    // דוגמה 6: Wrapper ל-בדיקה "האם כל אלמנטים מקיימים"
    // ============================================
    
    public static bool AllEven(int[] arr)
    {
        return AllEvenHelper(arr, 0);
    }

    private static bool AllEvenHelper(int[] arr, int index)
    {
        if (index == arr.Length)
            return true;
        
        if (arr[index] % 2 != 0)
            return false;
        
        return AllEvenHelper(arr, index + 1);
    }

    // שימוש:
    // int[] nums1 = { 2, 4, 6, 8 };
    // bool result1 = AllEven(nums1); // החזר true
    // 
    // int[] nums2 = { 2, 4, 5, 8 };
    // bool result2 = AllEven(nums2); // החזר false


    // ============================================
    // דוגמה 7: Wrapper ל-בדיקה "האם קיים אלמנט שמקיים"
    // ============================================
    
    public static bool AnyGreaterThan5(int[] arr)
    {
        return AnyGreaterThan5Helper(arr, 0);
    }

    private static bool AnyGreaterThan5Helper(int[] arr, int index)
    {
        if (index == arr.Length)
            return false;
        
        if (arr[index] > 5)
            return true;
        
        return AnyGreaterThan5Helper(arr, index + 1);
    }

    // שימוש:
    // int[] nums = { 1, 2, 10 };
    // bool result = AnyGreaterThan5(nums); // החזר true


    // ============================================
    // דוגמה 8: Wrapper ל-מציאת אינדקס
    // ============================================
    
    public static int IndexOf(int[] arr, int target)
    {
        return IndexOfHelper(arr, 0, target);
    }

    private static int IndexOfHelper(int[] arr, int index, int target)
    {
        if (index == arr.Length)
            return -1;
        
        if (arr[index] == target)
            return index;
        
        return IndexOfHelper(arr, index + 1, target);
    }

    // שימוש:
    // int[] nums = { 3, 7, 2, 9, 1 };
    // int idx = IndexOf(nums, 9); // החזר 3


    // ============================================
    // 🎯 יתרונות של Wrapper Functions:
    // ============================================
    // 1. המשתמש לא צריך לדעת על אינדקס
    // 2. קל וישר - PublicAPI
    // 3. אנחנו יכולים להוסיף בדיקות ב-Wrapper
    // 4. מסתירה את הפרטים של ה-implementation
    // 5. אם נשנה את ה-implementation לאחר - רק ה-Helper משתנה
}
