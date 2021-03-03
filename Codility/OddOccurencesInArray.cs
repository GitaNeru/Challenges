using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
       
        return A.Aggregate(0,(prev,next)=>prev^=next);
    }
}
