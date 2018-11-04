using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class RefuelingScheduleSolution
    {
        private const int MPG = 20;

        public static int FindAmpleCity(int[] gallons, int[] distances){
            int gasDeficit = 0, tank = 0;
            int start = 0; // Starting with city 0 as an initial candidate

            for(int i = 0; i < gallons.Length; i++) {
                var cost = distances[i] / MPG;
                tank += gallons[i] - cost;
                if (tank < 0) {
                    // We ran out of gas
                    start = i + 1; // Start from next city
                    gasDeficit += tank; // Keep track of the gas deficit
                    tank = 0; // Reset the tank
                }
            }
            
            // If the current tank can compensate for any gas deficit, 
            // we can do a round trip and return to start
            return (gasDeficit + tank < 0) ? -1 : start;
        }
    }    
}
