/*
 * [題目] DNA to RNA Conversion (8 kyu)
 * [連結] https://www.codewars.com/kata/5556282156230d0e5e000089
 * ---------------------------------------------------
 * 【初始思路】：一開始想用 if else 判斷取代。
 * 【遇到障礙】：寫了 "T" 報錯，字元不能和字串比較。
 * 【最終方案】：修改後成功運行，在我詢問 AI 後也發現有更快的 dna.Replace('T', 'U') 一行就能解決。
 * 【個人心得】：讓我發現 .Replace() 方法，也有自己思考出解法。
 * ---------------------------------------------------
 */

namespace Converter {
  public class Converter
  {
    public string dnaToRna(string dna)
    {
      // Have fun! ^_^
      string result = "";
      for(int i = 0; i < dna.Length; i++){
        if (dna[i] == 'T'){
          result = result + 'U';
        }
        else{
          result = result + dna[i];
        }
      }
      return result;
//       return dna.Replace('T', 'U');
    }
  }
}
