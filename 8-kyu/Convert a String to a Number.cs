/*
 * [題目] Convert a String to a Number (8 kyu)
 * [連結] https://www.codewars.com/kata/544675c6f971f7399a000e79
 * ---------------------------------------------------
 * 【初始思路】：用某個方法直接轉成 int。
 * 【遇到障礙】：按照之前的推測 .ToInt()，但報錯。
 * 【最終方案】：問 ai 後得到 int.Parse() 和 Convert.ToInt32() 這兩個方法。
 * 【個人心得】：我學到了這兩個方法，其中 Comvert.ToInt32() 更為保險。
 * ---------------------------------------------------
 */

using System;
  public class Kata
  {
    public static int StringToNumber(String str) {
        return int.Parse(str);
//         return Convert.ToInt32(str); //當字串是 Null 時，不會報錯而是回傳0
  }
}
