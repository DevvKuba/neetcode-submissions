public class Solution {
     public bool IsPalindrome(string s)
    {

     var stringList = s.Where(x => char.IsLetterOrDigit(x))
         .ToList();

     int pointerOne = 0;
     int pointerTwo = stringList.Count - 1;

     while ( pointerOne < pointerTwo)
     {
         if (stringList[pointerOne].ToString().ToLower() == stringList[pointerTwo].ToString().ToLower())
         {
             pointerOne++;
             pointerTwo--;
             continue;
         }
         else
         {
             return false;
         }
     }

     return true;
 }
}
