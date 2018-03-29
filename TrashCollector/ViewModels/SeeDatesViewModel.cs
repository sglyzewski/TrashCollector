using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;
using TrashCollector.Controllers;

namespace TrashCollector.ViewModels
{
    public class SeeDatesViewModel
    {

        
     
        DateTime startdate = new DateTime(2018, 1, 5);
        IList<DateTime> GetDaysForYearFromStartDate(DateTime startDate)
        {
            DateTime currentDay = startDate;
            List<DateTime> results = new List<DateTime>();


            int currentYear = startDate.Year;
            while (currentDay.Year == currentYear)
            {
                currentDay = currentDay.AddDays(7);
                results.Add(currentDay);

            }

            return results;
        }

        public SeeDatesViewModel()
        {
            IList<DateTime> result = GetDaysForYearFromStartDate(startdate);
        }

        
    }
}