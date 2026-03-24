/*
 * [題目] Square(n) Sum (8 kyu)
 * [連結] https://www.codewars.com/kata/515e271a311df0350d00000f
 * ---------------------------------------------------
 * 【初始思路】：用 for 遍數陣列中的數字在平方加總。
 * 【遇到障礙】：無
 * 【最終方案】：同上
 * 【個人心得】：發現有更好的寫法 foreach  (int i in str)，比原本的 for 更快更簡潔。
 * ---------------------------------------------------
 */

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int result = 0;
    for(int i = 0; i < numbers.Length; i++){
      result += (numbers[i] * numbers[i]);
    }
    return result;
  }
}
