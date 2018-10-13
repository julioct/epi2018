namespace EPI2018.Solutions
{
    public static class PowerXYSolution
    {
        public static double Power(double x, int y){
            var result = 1.0;
            var power = y;

            if (y < 0){
                power = -power;
                x = 1.0/x;
            }

            while(power != 0){
                if ((power & 1) != 0){
                    result *= x;
                }
                x *= x;
                power >>= 1;
            }

            return result;
        }
    }    
}
