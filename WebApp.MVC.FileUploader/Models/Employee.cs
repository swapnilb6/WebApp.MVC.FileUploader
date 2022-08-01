using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.MVC.FileUploader.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public HttpPostedFileBase file { get; set; }

    }
}