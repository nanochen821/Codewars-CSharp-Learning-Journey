/*
 * [題目] Rock Paper Scissors! (8 kyu)
 * [連結] https://www.codewars.com/kata/5672a98bdbdd995fad00000f
 * ---------------------------------------------------
 * 【初始思路】：先判斷平手的，再用 if、else 判斷其他勝負
 * 【遇到障礙】：好像要寫很多 if else，有點卡住
 * 【最終方案】：先判斷平手，再來 if 用 || 連接判斷條件，最後 else 出剩下的
 * 【個人心得】：學到了多個 if 條件的寫法
 * ---------------------------------------------------
 */

public class Kata
{
  public string Rps(string p1, string p2)
  {
    if (p1 == p2){
      return "Draw!";
    }
    
    if ((p1 == "scissors" && p2 == "paper") || 
        (p1 == "rock" && p2 == "scissors") ||
        (p1 == "paper" && p2 == "rock")){
          return "Player 1 won!";
        }else{
          return "Player 2 won!";
        }
  }
}
