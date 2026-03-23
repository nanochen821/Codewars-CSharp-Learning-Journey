/*
 * [題目] Convert a Boolean to a String (8 kyu)
 * [連結] https://www.codewars.com/kata/551b4501ac0447318f0009cd
 * ---------------------------------------------------
 * 【初始思路】：一開始想用 if else 寫死的來解決。
 * 【遇到障礙】：覺得太呆了，不對勁。
 * 【最終方案】：直接用 C# 的 .ToString() 方法，轉成字串。
 * 【個人心得】：讓我發現 .ToString() 方法連布林也能轉成字串
 * ---------------------------------------------------
 */

using System;

public class kata
{
    public static string BooleanToString(bool b)
    {
        return b.ToString();
    }
}
