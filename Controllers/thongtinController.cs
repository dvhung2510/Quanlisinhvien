using kien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kien.Controllers
{
    public class thongtinController : Controller
    {
          List<nhanvien> li = new List<nhanvien>();
        List<nhanvien> li1 = new List<nhanvien>();
        List<nhanvien> li2 = new List<nhanvien>();
        // GET: thongtin
        public ActionResult Index()
        {
            return View();
        }
        public thongtinController()
        {
            li.Add(new nhanvien("hoàng" ,"kiên","Nam",2003,1,"music",200,25));
            li.Add(new nhanvien("hoàng", "văn", "Nam", 2003, 1, "music", 200, 25));
            li.Add(new nhanvien("nguyễn", "linh", "Nữ", 2003, 1, "touris", 150, 20));
            li.Add(new nhanvien("hoàng", "hồng", "Nam", 2003, 1, "music", 170, 25));
            li.Add(new nhanvien("hoàng", "kiên", "Nam", 2003, 1, "music", 400, 25));
            li.Add(new nhanvien("ly", "nam", "Nữ", 2003, 1, "music", 500, 25));
            li.Add(new nhanvien("hoàng", "trân", "Nam", 2005, 1, "music", 200, 15));

            li.Add(new nhanvien("bui", "huan", "Nam", 2003, 1, "music", 300, 20));
        }

        public ActionResult nhap( nhanvien nv)
        {      ViewBag.firstname = nv.firstname;
            ViewBag.firstname = nv.firstname;
            ViewBag.lastname = nv.lastname;
            ViewBag.gioitinh = nv.gioitinh;
            ViewBag.namsinh = nv.namsinh;
            ViewBag.thangsinh = nv.thangsinh;
            ViewBag.sothich = nv.sothich;
            ViewBag.salary = nv.salary;
            ViewBag.ngaylv = nv.ngaylv;
            ViewBag.luongthuc = nv.luongthuc();
            return View();
        }
        public ActionResult xuat(nhanvien nv)
        {
            ViewBag.firstname = nv.firstname;
            ViewBag.firstname = nv.firstname;
            ViewBag.lastname = nv.lastname;
            ViewBag.gioitinh = nv.gioitinh;
            ViewBag.namsinh = nv.namsinh;
            ViewBag.thangsinh = nv.thangsinh;
            ViewBag.sothich = nv.sothich;
            ViewBag.salary = nv.salary;
            ViewBag.ngaylv = nv.ngaylv;
            ViewBag.luongthuc = nv.luongthuc();
            return View();
        }
        public ActionResult xuatlist(nhanvien nv)
        {
            foreach( var item in li)
            {
                if(item.salary >300)
                {
                    li1.Add(item);
                }
            }
            foreach (var item in li)
            {
                if (item.gioitinh =="Nam")
                {
                    li2.Add(item);
                }
            }
            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            ViewBag.li = li;
            return View();
        }
    }
}