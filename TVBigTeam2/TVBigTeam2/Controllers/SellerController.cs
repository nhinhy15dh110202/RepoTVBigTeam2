using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;

namespace TVBigTeam2.Controllers
{
    public class SellerController : Controller
    {
        // Page: Seller list
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var dao = new SellerDAO();
            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }

        //View Details:
        public ActionResult Details(int SellerID)
        {
            var user = new SellerDAO().ViewDetails(SellerID);
            return View(user);
        }

        //Edit:
        public ActionResult Edit(int SellerID) //Hiện thông tin hiện tại của Seller lên View
        {
            var dao = new SellerDAO();
            var seller = dao.ViewDetails(SellerID);
            return View(seller);
        }

        [HttpPost]
        public ActionResult Edit(Seller seller) //Chỉnh sửa thông tin Seller
        {
            if (ModelState.IsValid)
            {
                var dao = new SellerDAO();
                var result = dao.EditDetails(seller);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Edit Fail !!!");
                }
            }
            return View("Index");
        }

        //Create:
        public ActionResult Create() //Hiển thị trang Create
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Seller seller)
        {
            if (ModelState.IsValid)
            {
                var dao = new SellerDAO();
                long newSellerID = dao.CreateSeller(seller);
                if (newSellerID > 0) // SellerID vừa tạo > 0 => Thành công
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Create Fail");
                }
            }
            return View("Index");
        }

        //Delete:
        [HttpDelete]
        public ActionResult Delete(int sellerID)
        {
            var dao = new SellerDAO();
            dao.DeleteSeller(sellerID);
            return View();
        }
    }
}