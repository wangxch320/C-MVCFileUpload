using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fileUploadByMVC.Models;
using System.IO;

namespace fileUploadByMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Upload()
        {
            return View();
        }

        private string _directory = @"/File";
        Random rnd = new Random();
        [HttpPost]
        public ActionResult Upload(TestModels tm, HttpPostedFileBase file)
        {
            if(file == null)
            {
                return Content("没有上传任何文件");
            }

            string fileExt = Path.GetExtension(Request.Files[0].FileName).ToLower();
            string fileName = Server.MapPath(_directory) + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + rnd.Next(10, 99).ToString() + fileExt;
            try
            {
                file.SaveAs(fileName);
                tm.AttachmentPath = "../File/" + Path.GetFileName(fileName);
                return RedirectToAction("Show", tm);
            }
            catch
            {
                return Content("上传异常 ！", "text/plain");
            }
        }


        public ActionResult FileUploadTestByajax()
        {
            System.Web.HttpFileCollection _file = System.Web.HttpContext.Current.Request.Files;
            HttpPostedFile file = _file[0];
            if (file == null)
            {
                return Content("没有上传任何文件");
            }

            string fileExt = Path.GetExtension(Request.Files[0].FileName).ToLower();
            string fileName = Server.MapPath(_directory) + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + rnd.Next(10, 99).ToString() + fileExt;
            try
            {
                file.SaveAs(fileName);
                return Json("../File/" + Path.GetFileName(fileName));
            }
            catch
            {
                return Json("error");
            }

        }
        public ActionResult Show(TestModels tm)
        {
            return View(tm);
        }

    }
}