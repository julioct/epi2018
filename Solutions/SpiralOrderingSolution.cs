using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class SpiralOrderingSolution
    {
        public static IList<int> GetSpiralOrder(int[,] matrix){            
            var len = matrix.GetLength(0);
            var spiral = new List<int>();
            var offset = 0;

            while (offset <= len/2){
                var max = len - 1 - offset;

                if (offset == max){
                    spiral.Add(matrix[offset, offset]);
                    return spiral;
                }

                for(int c = offset; c < max; c++){
                    spiral.Add(matrix[offset, c]);
                }

                for (int r = offset; r < max; r++){
                    spiral.Add(matrix[r, max]);
                }

                for (int c = max; c > offset; c--){
                    spiral.Add(matrix[max, c]);
                }

                for (int r = max; r > offset; r--){
                    spiral.Add(matrix[r, offset]);
                }

                offset++;
            }

            return spiral;
        }
    }
}
