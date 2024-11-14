using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kien.Models
{
    public class nhanvien
    {
        public nhanvien()
        {
        }

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gioitinh { get; set; }
        public double namsinh { get; set; }

        public int thangsinh { get; set; }
        public string sothich { get; set; }
        public double salary { get; set; }
        public int ngaylv { get; set; }

        public nhanvien(string firstname, string lastname, string gioitinh, double namsinh, int thangsinh, string sothich, double salary, int ngaylv)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.thangsinh = thangsinh;
            this.sothich = sothich;
            this.salary = salary;
            this.ngaylv = ngaylv;
        }

        public double luongthuc()
        {   
            if(ngaylv >= 25)
            {
                return salary * 1.1;
            }
           else if (ngaylv >= 20)
            {
                return salary * 1.05;
            }
             else if (ngaylv < 20)
            {
                return salary;
            }
            else
            {
                return 0;
            }
            
        }
    }
}