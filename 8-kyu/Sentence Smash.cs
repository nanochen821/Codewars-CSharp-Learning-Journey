/*
 * [題目] Sentence Smash (8 kyu)
 * [連結] https://www.codewars.com/kata/53dc23c68a0c93699800041d
 * ---------------------------------------------------
 * 【初始思路】：用 foreach 遍歷單字，再補上空格。
 * 【遇到障礙】：C# 字串只能 += 不能 -= 。
 * 【最終方案】：有更好的 string.Join() 方法，直接將來自陣列或集合的個別字串合併成單一字串。
 * 【個人心得】：學到了 string.Join() 方法。
 * ---------------------------------------------------
 */

using System;

public class Kata
{
  public static string Smash(string[] words)
  {
    return string.Join(" ", words);
  }
}
