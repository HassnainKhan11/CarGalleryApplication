﻿using System;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.CustomAttributes
{
    public class YearRangeAttribute : RangeAttribute
    {
        public YearRangeAttribute() : base(typeof(int), DateTime.Now.AddYears(-50).Year.ToString(), DateTime.Now.AddYears(1).Year.ToString())
        { }
    }
}