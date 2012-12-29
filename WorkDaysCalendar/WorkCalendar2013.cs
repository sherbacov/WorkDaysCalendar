using System;

namespace WorkDaysCalendar
{
    public class WorkCalendar2013 : WorkCalendarTemplate
    {
        public new const int Year = 2013;

        public WorkCalendar2013()
        {
            Rules.Add(new WorkCalendarRuleDayType(DayOfWeek.Saturday));
            Rules.Add(new WorkCalendarRuleDayType(DayOfWeek.Sunday));

            // Список исключений
            // Новогодние праздники
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 01)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 02)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 03)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 04)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 07)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 01, 08)));

            // 8 марта
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 03, 08)));

            //1 и 9 мая
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 01)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 02)));
            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 05, 09)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 06, 12)));

            ExeptionRules.Add(new WorkCalendarSingleDay(new DateTime(Year, 11, 04)));
        }

    }
}
