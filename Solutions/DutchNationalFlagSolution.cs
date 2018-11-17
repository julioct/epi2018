using System;
using System.Collections.Generic;
using System.Drawing;

namespace EPI2018.Solutions
{
    public class DutchNationalFlagSolution
    {
        public static void DutchFlagPartition(int pivotIndex, int[] A){
            var pivotValue = A[pivotIndex];
            int lessThan = 0, equal = 0, greaterThan = A.Length;

            while(equal < greaterThan){
                if (A[equal] < pivotValue){
                    var temp = A[lessThan];
                    A[lessThan++] = A[equal];
                    A[equal++] = temp;
                } else if (A[equal] == pivotValue){
                    equal++;
                } else {
                    var temp = A[--greaterThan];
                    A[greaterThan] = A[equal];
                    A[equal] = temp;
                }
            }
        }
    }    
}
