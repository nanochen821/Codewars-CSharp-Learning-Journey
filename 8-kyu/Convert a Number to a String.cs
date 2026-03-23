/*
 * [題目] Convert a Number to a String! (8 kyu)
 * [連結] https://www.codewars.com/kata/5265326f5fda8eb1160004c8
 * ---------------------------------------------------
 * 【初始思路】：一開始想得很複雜，想先用取餘數拆開數字，再拚成字串。
 * 【遇到障礙】：發現還需要考慮負號的問題。
 * 【最終方案】：直接用 C# 的 .ToString() 方法，轉成字串。
 * 【個人心得】：讓我發現現成工具的重要性，省去許多麻煩，難怪會是基礎題目。
 * ---------------------------------------------------
 */

using System;

public class Kata
{
  public static string NumberToString(int num)
  {
    return num.ToString();
  }
}
