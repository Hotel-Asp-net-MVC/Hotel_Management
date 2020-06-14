using HotelManagement.DaTa_Access_Object;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.Controllers
{
    public class BaoCaoController : Controller
    {
        // GET: BaoCao
        public ActionResult BaoCao()
        {
            string ngayden = Request.Form["ngayden"];
            string ngaydi = Request.Form["ngaydi"];
            if(ngayden!=null&& ngaydi!=null)
            {
                string[] arrngayden = ngayden.Split('-');
                string[] arrngaydi = ngaydi.Split('-');
                BaoCaoDAO baocao_dao = new BaoCaoDAO();
                List<BaoCao> bc = new List<BaoCao>();
                bc = baocao_dao.GetAllBaoCao(arrngayden[0], arrngayden[1], arrngaydi[1], arrngayden[2], arrngaydi[2]);
                ViewBag.baocao = bc;
            }
            

            
            return View();
        }
        public ActionResult CT_BaoCao()
        {
            string ngayden = Request.Form["ngayden"];
            string ngaydi = Request.Form["ngaydi"];
            string[] arrngayden = ngayden.Split('-');
            string[] arrngaydi = ngaydi.Split('-');

            BaoCaoDAO baocao_dao = new BaoCaoDAO();
            List<BaoCao> bc = new List<BaoCao>();
            bc = baocao_dao.GetAllBaoCao(arrngayden[0], arrngayden[1], arrngaydi[1], arrngayden[2], arrngaydi[2]);
            ViewBag.baocao = bc;
            ViewBag.ngayden = ngayden;
            ViewBag.ngaydi = ngaydi;
            return View("BaoCao");
        }
    }
}