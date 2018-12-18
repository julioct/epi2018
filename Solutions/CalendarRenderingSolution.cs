using System;
using System.Collections.Generic;
using System.Linq;

namespace EPI2018.Solutions
{
    public static class CalendarRenderingSolution
    {
        public static int FindMaxSimultaneousEvents(CalendarEvent[] A){
            var endpoints = new List<Endpoint>();

            for(int i = 0; i < A.Length; i++){
                endpoints.Add(new Endpoint(A[i].Start, true));
                endpoints.Add(new Endpoint(A[i].Finish, false));
            }

            var sortedEndpoints = endpoints.OrderBy(e => e.Time)
                                           .ThenByDescending(e => e.IsStart); // Start events go first
            int eventCount = 0, maxEvents = 0;

            foreach (var endpoint in sortedEndpoints)
            {
                eventCount = endpoint.IsStart ? eventCount + 1 : eventCount - 1;
                maxEvents = Math.Max(maxEvents, eventCount);
            }

            return maxEvents;
        }

        public class Endpoint{
            public int Time;
            public bool IsStart;

            public Endpoint(int time, bool isStart){
                Time = time;
                IsStart = isStart;
            }
        }

        public class CalendarEvent{
            public int Start;
            public int Finish;

            public CalendarEvent(int start, int finish){
                Start = start;
                Finish = finish;
            }
        }
    }    
}
