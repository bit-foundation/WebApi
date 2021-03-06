﻿using System;
using System.Collections.Generic;

namespace WebStack.QA.Test.OData.SxS.ODataV4.Models
{
    public class Part
    {
        public int PartId
        {
            get;
            set;
        }

        public string Store
        {
            get;
            set;
        }

        public DateTimeOffset ReleaseDateTime
        {
            get;
            set;
        }

        public virtual ICollection<Product> Products
        {
            get;
            set;
        }
    }
}