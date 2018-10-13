namespace EPI2018.Solutions
{
    public static class SearchFirstKeySolution
    {
        public static int SearchFirstOfK(int[] A, int k){
            var left = 0;
            var right = A.Length - 1;
            var result = -1;

            while (left <= right){
                var mid = (left + right)/2;

                if (k < A[mid]){
                    right = mid - 1;
                } else if (k > A[mid]){
                    left = mid + 1;
                } else {
                    result = mid;
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
