using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkDaysCalendar
{
    
    public enum WorkCalendarDayType
    {
        WorkingDay,
        Holiday
    }

    public abstract class WorkCalendarRule
    {
        public WorkCalendarDayType Type;
        public bool Procesed { get; set; }
        public abstract WorkCalendarDayType GetDayType(DateTime day);
    }

    public class WorkCalendarRuleDayType : WorkCalendarRule
    {
        public WorkCalendarRuleDayType(){}
        public WorkCalendarRuleDayType(DayOfWeek day)
        {
            Day = day;
        }

        public DayOfWeek Day;
        public override WorkCalendarDayType GetDayType(DateTime day)
        {
            if (day.DayOfWeek == Day)
                Procesed = true;
            
            return day.DayOfWeek == Day ? WorkCalendarDayType.Holiday : WorkCalendarDayType.WorkingDay;
        }
    }

    public class WorkCalendarSingleDay : WorkCalendarRule
    {
        public WorkCalendarSingleDay() { }
        public WorkCalendarSingleDay(DateTime day)
        {
            Day = day;
        }

        public DateTime Day;
        public override WorkCalendarDayType GetDayType(DateTime day)
        {
            if (day.Date == Day.Date)
                Procesed = true;
            
            return day.Date == Day.Date ? WorkCalendarDayType.Holiday : WorkCalendarDayType.WorkingDay;
        }
    }

    public class WorkCalendarTemplate
    {
        public List<WorkCalendarRule> Rules = new List<WorkCalendarRule>();
        public List<WorkCalendarRule> ExeptionRules = new List<WorkCalendarRule>();
        public int Year;
    }

    public static class WorkCalendar
    {

        private static WorkCalendarDayType _defaultRule = WorkCalendarDayType.WorkingDay;
        private static Dictionary<int, WorkCalendarTemplate> _yearsRules = new Dictionary<int, WorkCalendarTemplate>();

        static WorkCalendar()
        {
            _yearsRules.Add(2011, new WorkCalendar2011());
        }

        public static bool IsWorkingDay(DateTime day)
        {
            // Получаем значение по умолчанию. Если года нет в справочнике
            if (!_yearsRules.ContainsKey(day.Year))
                return _defaultRule == WorkCalendarDayType.WorkingDay;

            return ParceCalendar(_yearsRules[day.Year].ExeptionRules, _yearsRules[day.Year].Rules, day) == WorkCalendarDayType.WorkingDay;
        }

        public static WorkCalendarDayType GetDayType(DateTime day)
        {
            return IsWorkingDay(day) ? WorkCalendarDayType.WorkingDay : WorkCalendarDayType.Holiday;
        }

        private static WorkCalendarDayType ParceCalendar(IEnumerable<WorkCalendarRule> rules, IEnumerable<WorkCalendarRule> defaultRules, DateTime day)
        {

            var defaultRule = _defaultRule;
            foreach (var rule in defaultRules.Where(rule => rule.GetDayType(day) != _defaultRule))
                defaultRule = rule.GetDayType(day);

            foreach (var rule in rules)
            {
                    var exeptionRule = rule.GetDayType(day);

                    if (rule.Procesed)
                    {
                        rule.Procesed = false;
                        if (exeptionRule == defaultRule)
                            return exeptionRule == WorkCalendarDayType.Holiday ? WorkCalendarDayType.WorkingDay : WorkCalendarDayType.Holiday;
                       
                        return exeptionRule;
                    }
            }

            return defaultRule;
        }

        public static WorkCalendarDayType ParceRule(WorkCalendarRule rule, DateTime day)
        {
            var result = rule.GetDayType(day);

            switch (result)
            {
                case WorkCalendarDayType.WorkingDay:
                    if (_defaultRule == WorkCalendarDayType.WorkingDay)
                        return WorkCalendarDayType.Holiday;
                    break;
                case WorkCalendarDayType.Holiday:
                    if (_defaultRule == WorkCalendarDayType.Holiday)
                        return WorkCalendarDayType.WorkingDay;
                    break;
            }

            return result;
        }

    }

}
