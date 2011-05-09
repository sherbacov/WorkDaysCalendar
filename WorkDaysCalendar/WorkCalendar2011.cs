using System;

namespace WorkDaysCalendar
{
    public class WorkCalendar2011 : WorkCalendarTemplate
    {
        public new const int Year = 2011;
        
        public WorkCalendar2011()
        {
            Rules.Add(new WorkCalendarRuleDayType(DayOfWeek.Saturday));
            Rules.Add(new WorkCalendarRuleDayType(DayOfWeek.Sunday));

            // Список исключений
            // Новогодние праздники
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 03)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 04)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 05)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 06)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 07)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 10)));

            // 23 февраля
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 02, 23)));

            // 8 марта
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 05)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 07)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 08)));

            //1 и 9 мая
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 02)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 09)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 06, 13)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 11, 04)));
        }

    }
}