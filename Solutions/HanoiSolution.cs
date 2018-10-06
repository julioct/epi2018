using System;
using System.Collections.Generic;
using System.Text;

namespace EPI2018.Solutions
{
    public static class HanoiSolution
    {
        public static List<List<int>> ComputeTowerHanoi(int numRings, int numPegs){
            var pegs = new List<Stack<int>>();

            for(int i = 0; i < numPegs; i++){
                pegs.Add(new Stack<int>());
            }

            for (int i = numRings - 1; i >= 0; i--){
                pegs[0].Push(i);
            }

            var results = new List<List<int>>();
            ComputeTowerHanoi(numRings, pegs, 0, 1, 2, results);
            return results;
        }

        private static void ComputeTowerHanoi(int numRings, List<Stack<int>> pegs, int fromPeg, int toPeg, int usePeg, List<List<int>> results){
            if (numRings == 0){
                return;
            }
            ComputeTowerHanoi(numRings - 1, pegs, fromPeg, usePeg, toPeg, results);
            pegs[toPeg].Push(pegs[fromPeg].Pop());
            var move = new List<int>();
            move.Add(fromPeg);
            move.Add(toPeg);
            results.Add(move);
            ComputeTowerHanoi(numRings - 1, pegs, usePeg, toPeg, fromPeg, results);
        }
    }    
}
