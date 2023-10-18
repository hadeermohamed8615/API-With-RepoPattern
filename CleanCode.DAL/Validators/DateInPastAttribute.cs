using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.DAL.Validators
{
    public class DateInPastAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime? date = value as DateTime?;
            if (date is null)
            {
                return false;
            }

            if (date.Value.Year < 2000 && date.Value.Year > 1952)
                return true;
            else return false;
        }
    }
}
