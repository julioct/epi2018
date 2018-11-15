using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public class CircularQueueSolution
    {
        private int[] elements;
        private int startIndex = 0, endIndex = 0, numQueueElements = 0;
        
        public CircularQueueSolution(int initialCapacity){
            elements = new int[initialCapacity];
        }

        public void Enqueue(int value){
            if (numQueueElements == elements.Length){
                Resize();
            } 

            elements[endIndex] = value;
            endIndex = (endIndex + 1) % elements.Length;
            numQueueElements++;
        }

        public int Dequeue(){
            numQueueElements--;
            var value = elements[startIndex];
            startIndex = (startIndex + 1) % elements.Length;

            return value;
        }

        public int Size(){
            return numQueueElements;
        }

        private void Resize(){
            var newElements = new int[elements.Length * 2];

            var newIndex = 0;

            if (endIndex > startIndex){
                for (int i = startIndex; i < endIndex; i++){
                    newElements[newIndex++] = elements[i];
                }
            } else {
                for (int i = startIndex; i < elements.Length; i++){
                    newElements[newIndex++] = elements[i];
                }
                for (int i = 0; i < endIndex; i++){
                    newElements[newIndex++] = elements[i];
                }
            }

            startIndex = 0;
            endIndex = numQueueElements;
            elements = newElements; 
        }
    }    
}
