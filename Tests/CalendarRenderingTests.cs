using System.Collections.Generic;
using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class CalendarRenderingTests
    {
        [Fact]
        public void CanFindMaxEvents()
        {
            CalendarRenderingSolution.CalendarEvent[] events = {
                new CalendarRenderingSolution.CalendarEvent(1, 5),
                new CalendarRenderingSolution.CalendarEvent(6, 10),
                new CalendarRenderingSolution.CalendarEvent(11, 13),
                new CalendarRenderingSolution.CalendarEvent(14, 15),
                new CalendarRenderingSolution.CalendarEvent(2, 7),
                new CalendarRenderingSolution.CalendarEvent(8, 9),
                new CalendarRenderingSolution.CalendarEvent(12, 15),
                new CalendarRenderingSolution.CalendarEvent(4, 5),
                new CalendarRenderingSolution.CalendarEvent(9, 17),
                new CalendarRenderingSolution.CalendarEvent(9, 10)
            };

            var expected = 4;
            var actual = CalendarRenderingSolution.FindMaxSimultaneousEvents(events);

            Assert.Equal(expected, actual);
        }      
    }
}
