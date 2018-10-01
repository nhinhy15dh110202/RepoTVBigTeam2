using System.Collections.Generic;
using Model.EF;
using PagedList;
using System.Linq;
using System;

namespace Model.DAO
{
    public class SellerDAO
    {
        TVBigTeam2DbContext db = null;

        public SellerDAO()
        {
            db = new TVBigTeam2DbContext();
        }

        // Page:
        public IEnumerable<Seller> ListAllPaging(int page, int pageSize)
        {
            return db.Sellers.OrderByDescending(x => x.SellerID).ToPagedList(page, pageSize);
        }

        //View Details:
        public Seller ViewDetails(int sellerID)
        {
            return db.Sellers.Find(sellerID);
        }

        //Edit:
        public bool EditDetails(Seller entity)
        {
            try
            {
                var seller = db.Sellers.Find(entity.SellerID);
                seller.SellerName = entity.SellerName;
                seller.SellerAdress = entity.SellerAdress;
                seller.SellerLimit = entity.SellerLimit;
                seller.SellerStatus = entity.SellerStatus;
                seller.SellerNote = entity.SellerNote;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Create:
        public long CreateSeller(Seller seller)
        {
            db.Sellers.Add(seller);
            db.SaveChanges();
            return seller.SellerID;
        }

        //Delete:
        public bool DeleteSeller(int sellerID)
        {
            try
            {
                var seller = db.Sellers.Find(sellerID); //Tìm SellerID cần xóa
                db.Sellers.Remove(seller);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
