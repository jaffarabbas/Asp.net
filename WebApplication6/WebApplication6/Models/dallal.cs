﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class dallal:DbContext
    {
        public DbSet<table>Imad{ get; set; }
    }
}