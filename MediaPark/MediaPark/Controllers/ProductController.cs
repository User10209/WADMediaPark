using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaPark.DAL;
using MediaPark.DAO;

namespace MediaPark.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListView()
        {
            return View();
        }

        public ActionResult AddNewProduct()
        {
            return View();
        }

        public ActionResult UpdateProduct(int? MasterId)
        {
            return View();
        }


        //Insert
        ProductDAL aDal = new ProductDAL();
        public JsonResult Save_Info(ProductDAO aDao)
        {
            string Mes = "";

            try
            {
                aDal.AddNewProductDAL(aDao);
                Mes = "Operation Successful!!";
            }
            catch (Exception e)
            {
                Mes = "Operation Failed!!";
            }

            return Json(Mes, JsonRequestBehavior.AllowGet);
        }

        //Load
        public JsonResult LoadData()
        {

            DataSet ds = aDal.LoadAllDataDAL();
            List<ProductDAO> lists = new List<ProductDAO>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lists.Add(new ProductDAO
                {
                    ProductId = Convert.ToInt32(dr["ProductId"]),
                    SL = (dr["SL"].ToString()),
                    ProductName = (dr["ProductName"].ToString()),
                    ProductDescription = (dr["ProductDescription"].ToString()),
                    ProductPrice = (dr["ProductPrice"].ToString()),
                    ProductStock = (dr["ProductStock"].ToString()),
                    ProductCategory = (dr["ProductCategory"].ToString()),
                    ProductWeight = (dr["ProductWeight"].ToString())
                });

            }

            return Json(lists, JsonRequestBehavior.AllowGet);
        }
        //Edit
        public JsonResult GetMAsterDataByID(int MasterId)
        {

            DataSet ds = aDal.LoadDataByMasterIDDAL(MasterId);
            List<ProductDAO> lists = new List<ProductDAO>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lists.Add(new ProductDAO
                {
                    ProductId = Convert.ToInt32(dr["ProductId"]),
                    ProductName = (dr["ProductName"].ToString()),
                    ProductDescription = (dr["ProductDescription"].ToString()),
                    ProductPrice = (dr["ProductPrice"].ToString()),
                    ProductStock = (dr["ProductStock"].ToString()),
                    ProductCategory = (dr["ProductCategory"].ToString()),
                    ProductWeight = (dr["ProductWeight"].ToString())


                });

            }

            return Json(lists, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update_Info(ProductDAO aDao)
        {
            string Mes = "";

            try
            {
                aDal.UpdateProductDAL(aDao);
                Mes = "Operation Successful!!";
            }
            catch (Exception e)
            {
                Mes = "Operation Failed!!";
            }

            return Json(Mes, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ReomveDataByMAsterId(int ProductId)
        {

            string result = string.Empty;

            try
            {
                aDal.DeleteInfoDAL(ProductId);
                result = "Operation Deleted";
            }
            catch (Exception)
            {
                result = "Operation Failed";

                //throw;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}