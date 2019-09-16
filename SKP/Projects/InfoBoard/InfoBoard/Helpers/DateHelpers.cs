using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace InfoBoard.Helpers
{
    public static class DateHelpers
    {
        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1,DateTime.DaysInMonth(year, month)) //Days: 1,2 ... 31 etc
                                            .Select(day => new DateTime(year, month, day)) //map each day to a date
                                            .ToList(); // Load dates into a list
        }
    }
}
