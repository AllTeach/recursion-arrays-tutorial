using System;

/// ============================================
/// 🎓 שלב 3: Wrapper Functions
/// ============================================
/// עכשיו אנחנו מסתירים את האינדקס מהמשתמש
/// זה הרבה יותר נוח וטבעי
/// 

class Program
{
    static void Main()
    {
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("🎓 03_Arrays_Advanced.cs - Wrapper Functions");
        Console.WriteLine("═══════════════════════════════════════════════════\n");

        Console.WriteLine("💡 Wrapper Functions - מה זה?");
        Console.WriteLine("  פונקציה ציבורית שקל להשתמש בה");
        Console.WriteLine("  היא קוראת לפונקציית עזר (Helper) פנימית\n");

        Console.WriteLine("🎯 יתרונות Wrapper:");
        Console.WriteLine("  ✅ המשתמש לא צריך לדעת על אינדקס");
        Console.WriteLine("  ✅ API נקי וקל לשימוש");
        Console.WriteLine("  ✅ אנחנו יכולים להוסיף בדיקות (validation)");
        Console.WriteLine("  ✅ נוח להשנות את ה-implementation\n");

        Console.WriteLine("📝 דוגמה:");
        Console.WriteLine("  بدון Wrapper: PrintArray(nums, 0);  // צריך להעביר 0");
        Console.WriteLine("  עם Wrapper:   PrintArray(nums);    // קל וטבעי!\n");

        Console.WriteLine("👉 קרא את הקוד - כל דוגמה מוסברת!");
        Console.WriteLine("👉 לצעד הבא: 04_Exercises_* (תרגילים)");
    }

    // ============================================
    // דוגמה 1: Wrapper ל-הדפסת מערך
    // ============================================
    
    public static void PrintArray(int[] arr)
    {
        PrintArrayHelper(arr, 0);
    }

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
}
