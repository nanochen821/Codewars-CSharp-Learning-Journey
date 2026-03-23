/*
 * [題目] Reversed Strings (8 kyu)
 * [連結] https://www.codewars.com/kata/5168bb5dfe9a00b126000018
 * ---------------------------------------------------
 * 【初始思路】：原本用 result[str.Length - i] = str[i];
 * 【遇到障礙】：C# 的 String 是唯讀的，不能直接修改指定索引。
 * 【最終方案】：用 result = str[i] + result; 將新字元往左邊貼。
 * 【個人心得】：這是我的第一個 codewar c# 練習，重新熟悉了 for 和 string
 * ---------------------------------------------------
 */

using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    string result = "";
    for (int i = 0; i < str.Length; i++){
      result = str[i] + result;
    }
    return result;
  }
}      
