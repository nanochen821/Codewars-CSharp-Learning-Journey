/*
 * [題目] Returning Strings (8 kyu)
 * [連結] https://www.codewars.com/kata/55a70521798b14d4750000a4
 * ---------------------------------------------------
 * 【初始思路】：把前後拆開加入 name。
 * 【遇到障礙】：Hello, 後和 how 前的空格忘記了。
 * 【最終方案】：重新加入後成功。
 * 【個人心得】：還有一個比較好的方法是用 $ 和 {} 的。

 * ---------------------------------------------------
 */

using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return "Hello, " + name + " how are you doing today?";
//     return $"Hello, {name} how are you doing today?";
  }
}
