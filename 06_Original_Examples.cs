using System;
using System.Diagnostics;

/// ============================================
/// 📝 הקובץ המקורי שלך - כל הדוגמאות על מספרים שלמים
/// ============================================

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        RecNTo1(num);
    }
    
    // n =4
    //  ****
    //  ***
    //  **
    //  *
    // רקורסית הלוך - קודם מבצע פעולה לאחר מכן קריאה רקורסיבית
    public static void StarsDown(int num)
    {
        if (num!=0)// תנאי לביצוע פעולה
        {
            // תדפיס כוכביות
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();// תזמן רקורסיה
            StarsDown(num - 1);
        }

    }
    // 3
    public static void RecNTo1(int num)
    {
        if(num!=0) // תדפיס את עצמך ולאחר מכן תפחית אחד ותמשיך להדפיס
        {
            Console.WriteLine(num);
            RecNTo1(num - 1);
            Console.WriteLine(num);

        }
    }
    // חתימת הפעולה
    //  טענת כניסה - מה הערכים שמקבלת
    // טענת יציאה - מה הפעולה מחזירה ואיזה טיפוס
    // חתימת הפעולה - חוזה! 
    public static void Example()
    {
        Console.WriteLine("Before");
        Console.WriteLine("After");
    }

    public static int CountDigits(int n)
    {
        if (n == 0)
            return 0;
        return 1 + CountDigits(n / 10);
    }

    public static int SumDigits(int num)
    {
        if (num == 0)
            return 0;
        //  מסקנה - יש לנו לפחות ספרה אחת
        return num % 10 + SumDigits(num / 10);

    }

    public static int Mult2Numbers(int num1, int num2)
    {
        // num1 * num2 = num1 + num1 + ... + num1 (num2 times)
        int sum = 0;
        for(int i=num2;i>0;i--) // num2 times!!!
        {
            sum = sum + num1;
        }
        return sum;
    }
    public static int Mult2NumbersRec(int num1,int num2)
    {
        //  תנאי עצירה
        if (num2 == 0)
            return 0;
        //  מסקנה - סופרים את המספר הראשון לפחות פעם אחת;
        return num1 + Mult2NumbersRec(num1, num2 - 1);
    }


    public static int Factorial(int num)
    {
        // תנאי עצירה
        if (num == 1)
            return 1;
        // מסקנה - עוד לא סיימנו 
        return num* Factorial(num - 1);
    }

    // num1*num1*num1____   (num2 times)
    public static int Exponent(int num1,int num2)
    {
        // תנאי עצירה
        if (num2 == 0)
            return 1;
        // מסקנה ובעיה פשוטה
        // המספר השני שונה מאפס
        return num1*Exponent(num1,num2-1);
       
    }
    public static int MultDigits(int num1)
    {
        // תנאי עצירה
        if (num1 == 0)
            return 1;
        /*
         * אפשרות נוספת - תנאי עצירה נוסף
        if(num1/10==0)
            return num1;
        */

        return num1 % 10 * MultDigits(num1 / 10);
        // num1%10 * MultDigits(num1/10)
    }


    // m1<=m2
    public static int SumRange(int m1,int m2)
    {
        // תנאי עצירה - מתי יש לנו ודאות כשהם שווים
        if (m1 == m2)
            return m1;
        // בכל מקרה אחר מחזירים את הערך של הראשון
        // ואליו סוכמים את סכום שאר המספרים בתחום
        return m2+ SumRange(m1,m2-1);
    }
    public static int Divide(int num1,int num2)
    {
        if (num1 < num2) // הגענו לשארית אין יותר חלוקה שלמה
            return 0;
        // מסקנה שלי - נכנס לפחות פעם 1 
       // אחד ועוד תוצאת החלוקה אחרי שמחסירים את
        // 11,3  ->    1 + (8,3) -> 1 + (5,3) -> 1 + (2,3) -> 1 + (0,3) -> 0
        return 1+ Divide(num1-num2,num2);
    }

    public static bool AllEven(int num)
    {
        // תנאי עצירה - מתי יודעים שבטוח כולן זוגיות?
        // אם עברנו על כולן ואין אף אחת אי זוגית
        if(num==0)
            return true;
        // בעבור כל ספרה בדרך בודקים אם היא איזוגית
        // ניתן להחזיר שקר - כי לא כולן מקיימות
        // וככה לא נגיע לתנאי העצירה , המספר לא יגיע לאפס
        //  אנחנו עוצרים כאן
         if(num%2!=0)
           return false;
        // בכל מקרה אחר תמשיך לבדוק הלאה
        return   AllEven(num / 10);
    }
}
