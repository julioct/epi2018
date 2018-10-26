using System;
using System.Collections.Generic;
using System.Linq;

namespace EPI2018.Solutions
{
    public static class MaxConcurrentEventsSolution
    {
        public static int MaxConcurrentEvents(CalendarEvent[] events){
            var sorted = events.OrderBy(e => e.End);
            var maxEventCount = 0;
            var queue = new Queue<CalendarEvent>();

            foreach(var calendarEvent in events){
                while(queue.Count != 0 && queue.Peek().End < calendarEvent.Start){
                    queue.Dequeue();
                }

                queue.Enqueue(calendarEvent);
                maxEventCount = Math.Max(maxEventCount, queue.Count);
            }

            return maxEventCount;
        }

        public class CalendarEvent{
            public int Start;
            public int End;

            public CalendarEvent(int start, int end){
                Start = start;
                End = end;
            }
        }
    }    
}
