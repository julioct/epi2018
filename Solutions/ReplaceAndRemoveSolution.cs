using System;
using System.Collections.Generic;
using System.Text;

namespace EPI2018.Solutions
{
    public static class ReplaceAndRemoveSolution
    {        
        public static void ReplaceAndRemove(char[] A, int size){
            var targetIndex = 0;
            var aCount = 0;

            for (int i = 0; i < size; i++)  
            {
                if (A[i] != 'b'){
                    //A[targetIndex++] = A[i];
                    targetIndex++;
                } 

                if (A[i] == 'a'){
                    aCount++;
                }
            }

            targetIndex += aCount - 1;

            for (int i = size - 1; i >= 0; i--)
            {
                if (A[i] == 'a'){
                    A[targetIndex--] = 'd';
                    A[targetIndex--] = 'd';
                } else if (A[i] != 'b') {
                    A[targetIndex--] = A[i];
                }
            }
        }
    }    
}
