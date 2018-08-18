﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using CodeFirstDemo.Models;

namespace CodeFirstDemo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDBContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeDBContext>());
        }
    }
}