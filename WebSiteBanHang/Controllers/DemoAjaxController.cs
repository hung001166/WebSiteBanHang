﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;

namespace WebSiteBanHang.Controllers
{
    public class DemoAjaxController : Controller
    {
        // GET: DemoAjax
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult DemoAjax()
        {

            return View();
        }
        //Xử lý ajax ActionLink
        public ActionResult LoadAjaxActionLink()
        {
            System.Threading.Thread.Sleep(2000);
            return Content("Hello Ajax");
        }

        //Xử lý ajax BeginForm
        public ActionResult LoadAjaxBeginForm(FormCollection f)
        {
            System.Threading.Thread.Sleep(2000);
            string KQ = f["txt1"].ToString();
            return Content(KQ);
        }

        // Xử lý Ajax Jquery
        public ActionResult LoadAjaxJQuery(int a, int b)
        {
            System.Threading.Thread.Sleep(2000);
            return Content((a + b).ToString());
        }

        //Sử dụng load Ajax trả về là 1 partialView
        
        public ActionResult LoadSanPhamAjax()
        {
            var lstSanPham = db.SanPhams;
            return PartialView(lstSanPham);
        }
    }
}