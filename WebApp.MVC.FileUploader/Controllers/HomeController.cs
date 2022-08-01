using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using WebApp.MVC.FileUploader.Models;

namespace WebApp.MVC.FileUploader.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult FileUpload()
        {
            ViewBag.ActionMsg = "null";
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(Employee emp)
        {
            string path = null;
            string filename =null;
            string fullPath = null;
            ViewBag.ActionMsg = "null";
            try
            {
                if (emp.file != null)
                {
                    path = Server.MapPath("~/App_Data/Uploaded Files");
                    filename = Path.GetFileName(emp.file.FileName);
                    fullPath = Path.Combine(path, filename);

                    emp.file.SaveAs(fullPath);

                    ViewBag.ActionMsg = "File Uploaded Successfully";
                }
                else
                {
                    ViewBag.ActionMsg = "Please Select a file.";
                }
            }
            catch(Exception ex)
            {

            }
            return View();
        }
    }
}