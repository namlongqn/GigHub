﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GigHub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "yyyy-MM-dd", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None,
                out dateTime);

            var x = dateTime > DateTime.Now;

            return (isValid && x);
        }
    }
}