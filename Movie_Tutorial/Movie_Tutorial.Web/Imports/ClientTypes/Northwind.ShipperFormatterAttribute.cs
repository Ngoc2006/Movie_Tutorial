using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Movie_Tutorial.Northwind
{
    public partial class ShipperFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Movie_Tutorial.Northwind.ShipperFormatter";

        public ShipperFormatterAttribute()
            : base(Key)
        {
        }
    }
}

