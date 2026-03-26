/*
 * [題目] Will you make it? (8 kyu)
 * [連結] https://www.codewars.com/kata/5861d28f124b35723e00005e
 * ---------------------------------------------------
 * 【初始思路】：用 if 判斷後回傳。
 * 【遇到障礙】：我一開始用 distanceToPump / mpg <= fuelLeft，但是在 C# 中
 *             兩個整數相除會把小數點切掉，所以報錯。
 * 【最終方案】：改成乘法後成功了。
 * 【個人心得】：除了發現了除法的問題外，還有更快的方法，判斷的結果可以直接回傳
 *             return mpg * fuelLeft >= distanceToPump; 。
 * ---------------------------------------------------
 */

using System;

public static class Kata
{
  public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
  {
//     除法會有小數點消失的問題
    if (mpg * fuelLeft >= distanceToPump){
      return true;
    }else{
      return false;
    }
//     return mpg * fuelLeft >= distanceToPump;
  }
}
