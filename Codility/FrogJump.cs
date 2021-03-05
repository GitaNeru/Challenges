class Solution {
    public int solution(int X, int Y, int D) {
       
         var Distance = Y - X;
        if (Distance % D == 0)
        {
            return Distance / D;
        }
        else
        {
            return Distance / D + 1;
        }
    }
}