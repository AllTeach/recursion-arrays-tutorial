using System;

/// ============================================
/// 📚 שלב 1: הסבר תאורטי - עם שתי הגישות
/// ============================================
/// 
/// מה ההבדל בין רקורסיה על מספר שלם לבין רקורסיה על מערך?
/// 
/// רקורסיה על מספר:
///    - קבלנו מספר אחד
///    - בכל צעד - חילקנו אותו ב-10, או הורדנו 1
///    - תנאי עצירה - כשהמספר = 0
/// 
/// רקורסיה על מערך:
///    - קבלנו מערך ואינדקס
///    - בכל צעד - עושים משהו עם האלמנט הנוכחי
///    - וקוראים רקורסיבית לשאר המערך
///    - תנאי עצירה - כשהאינדקס יצא מהמערך
/// 

class Theory
{
    // ============================================
    // 🎯 החוזה הרקורסיבי על מערך:
    // ============================================
    // arr[i]: התא הנוכחי עליו מוטלת האחריות של הזימון הנוכחי
    // הקריאה הרקורסיבית (i + 1): פתרון אותה הבעיה בדיוק עבור שאר המערך

    // ============================================
    // ⭐ שתי גישות לתנאי עצירה בפעולות VOID:
    // ============================================

    // ============================================
    // גישה א': יציאה יזומה עם return; ריק
    // ============================================
    // בדיקה מפורשת: "האם חרגנו מהמערך?"
    // אם כן - יוצאים מיידית
    // אם לא - ממשיכים

    public static void PrintArrayV1_ReturnEmpty(int[] arr, int index)
    {
        // תנאי עצירה מפורש
        if (index == arr.Length)
        {
            return; // יצאנו מהרקורסיה
        }

        Console.Write(arr[index] + " ");
        PrintArrayV1_ReturnEmpty(arr, index + 1);
    }

    // ============================================
    // גישה ב': תנאי לביצוע (ללא return)
    // ============================================
    // עוטפים את כל גוף הפעולה ב-if (i < arr.Length)
    // כל עוד התנאי מתקיים - עושים עבודה
    // כשמגיעים לקצה - התנאי נכשל וחוזרים למעלה

    public static void PrintArrayV2_IfCondition(int[] arr, int index)
    {
        // תנאי לקיום העבודה
        if (index < arr.Length)
        {
            Console.Write(arr[index] + " ");
            PrintArrayV2_IfCondition(arr, index + 1);
        }
        // כשהתנאי לא מתקיים - הפעולה מסתיימת מאליה
    }

    // שימוש לשתי הגישות:
    // int[] myArray = { 1, 2, 3, 4, 5 };
    // PrintArrayV1_ReturnEmpty(myArray, 0);
    // PrintArrayV2_IfCondition(myArray, 0);
    // שתיהן מדפיסות: 1 2 3 4 5


    // ============================================
    // דוגמה 1: הדפסת מערך מהתחלה לסוף (הלוך)
    // ============================================

    public static void PrintForwardV1(int[] arr, int index)
    {
        if (index == arr.Length)
            return;

        Console.Write(arr[index] + " ");
        PrintForwardV1(arr, index + 1);
    }

    public static void PrintForwardV2(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            Console.Write(arr[index] + " ");
            PrintForwardV2(arr, index + 1);
        }
    }

    // דוגמה שימוש:
    // int[] myArray = { 1, 2, 3, 4, 5 };
    // PrintForwardV1(myArray, 0);
    // PrintForwardV2(myArray, 0);
    // פלט: 1 2 3 4 5


    // ============================================
    // דוגמה 2: הדפסת מערך מסוף להתחלה (חזור)
    // ============================================

    public static void PrintBackwardV1(int[] arr, int index)
    {
        if (index == arr.Length)
            return;

        PrintBackwardV1(arr, index + 1);
        Console.Write(arr[index] + " ");
    }

    public static void PrintBackwardV2(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            PrintBackwardV2(arr, index + 1);
            Console.Write(arr[index] + " ");
        }
    }

    // דוגמה שימוש:
    // int[] myArray = { 1, 2, 3, 4, 5 };
    // PrintBackwardV1(myArray, 0);
    // PrintBackwardV2(myArray, 0);
    // פלט: 5 4 3 2 1


    // ============================================
    // דוגמה 3: הדפסה בשתי הכיוונים (הלוך וחזור - "מראה")
    // ============================================

    public static void PrintMirrorV1(int[] arr, int index)
    {
        if (index == arr.Length)
            return;

        Console.Write(arr[index] + " "); // בהלוך
        PrintMirrorV1(arr, index + 1);
        Console.Write(arr[index] + " "); // בחזור
    }

    public static void PrintMirrorV2(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            Console.Write(arr[index] + " "); // בהלוך
            PrintMirrorV2(arr, index + 1);
            Console.Write(arr[index] + " "); // בחזור
        }
    }

    // דוגמה שימוש:
    // int[] myArray = { 1, 2, 3 };
    // PrintMirrorV1(myArray, 0);
    // PrintMirrorV2(myArray, 0);
    // פלט: 1 2 3 3 2 1


    // ============================================
    // דוגמה 4: סכום כל האלמנטים במערך
    // ============================================

    public static int SumArray(int[] arr, int index)
    {
        // תנאי עצירה - סיימנו את כל המערך
        if (index == arr.Length)
        {
            return 0;
        }

        // צעד רקורסיבי: אלמנט נוכחי + סכום השאר
        return arr[index] + SumArray(arr, index + 1);
    }

    // דוגמה שימוש:
    // int[] myArray = { 1, 2, 3, 4, 5 };
    // int sum = SumArray(myArray, 0); // החזר 15


    // ============================================
    // דוגמה 5: מציאת המקסימום במערך
    // ============================================

    public static int FindMax(int[] arr, int index)
    {
        // תנאי עצירה - הגענו לאלמנט האחרון
        if (index == arr.Length - 1)
        {
            return arr[index];
        }

        // צעד רקורסיבי: קח את המקסימום בין:
        // האלמנט הנוכחי ל-מקסימום של השאר
        int maxOfRest = FindMax(arr, index + 1);
        return arr[index] > maxOfRest ? arr[index] : maxOfRest;
    }

    // דוגמה שימוש:
    // int[] myArray = { 3, 7, 2, 9, 1 };
    // int max = FindMax(myArray, 0); // החזר 9


    // ============================================
    // 🎯 סיכום - המבנה הכללי
    // ============================================
    // 
    // כל פונקציה רקורסיבית על מערך צריכה:
    // 
    // 1. קבלת פרמטרים: מערך + אינדקס (+ פרמטרים נוספים)
    // 
    // 2. תנאי עצירה (Base Case) - בחרו אחת מ-2 גישות:
    //    גישה א': if (condition) return [value];
    //    גישה ב': if (condition) { [body] }
    // 
    // 3. צעד רקורסיבי (Recursive Step):
    //    - עשו משהו עם האלמנט הנוכחי
    //    - קראו לעצמכם עם index ש"קדם אל העצירה"
    //    - ממשיכים עד שנגיעו לתנאי עצירה
    // 
    // 4. חשוב! - הנחה רקורסיבית:
    //    - אנחנו לא בודקים את כל המערך בראש
    //    - אנחנו מניחים שהפונקציה עובדת בחלק "הנותר"
    //    - ואנחנו מטפלים רק בחלק הנוכחי בלבד
}
