using System;

namespace WorkDaysCalendar
{

    public class WorkCalendar2012 : WorkCalendarTemplate
    {
        public new const int Year = 2012;
        
        public WorkCalendar2012()
        {
            Rules.Add(new WorkCalendarRuleDayType(DayOfWeek.Saturday));
            Rules.Add(new WorkCalendarRuleDayType(DayOfWeek.Sunday));

            // Список исключений
            // Новогодние праздники
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 02)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 03)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 04)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 05)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 06)));
            
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 09)));

            // 23 февраля
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 02, 23)));

            // 8 марта
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 08)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 09)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 11)));

            //1 и 9 мая
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 04, 28)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 04, 30)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 01)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 09)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 06, 09)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 06, 11)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 06, 12)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 11, 05)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 12, 29)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 12, 31)));
        }

    }
}
