using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MediaPark.DAO;

namespace MediaPark.DAL
{
    public class ProductDAL
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString);

        public void AddNewProductDAL(ProductDAO aDao)
        {
            SqlCommand com = new SqlCommand("sp_Insert_Product", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductName", aDao.ProductName);
            com.Parameters.AddWithValue("@ProductDescription", aDao.ProductDescription);
            com.Parameters.AddWithValue("@ProductPrice", aDao.ProductPrice);
            com.Parameters.AddWithValue("@ProductStock", aDao.ProductStock);
            com.Parameters.AddWithValue("@ProductCategory", aDao.ProductCategory);
            com.Parameters.AddWithValue("ProductWeight", aDao.ProductWeight);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet LoadAllDataDAL()
        {
            SqlCommand com = new SqlCommand("sp_LoadAllData_Product", conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet dss = new DataSet();
            da.Fill(dss);
            return dss;
        }

        //Edit
        public DataSet LoadDataByMasterIDDAL(int MasterId)
        {
            SqlCommand com = new SqlCommand("Get_ProductMasterDataById", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MasterId", MasterId);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet dss = new DataSet();
            da.Fill(dss);
            return dss;
        }

        public void UpdateProductDAL(ProductDAO aDao)
        {
            SqlCommand com = new SqlCommand("Update_ProductByMasterId", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductId", aDao.ProductId);
            com.Parameters.AddWithValue("@ProductName", aDao.ProductName);
            com.Parameters.AddWithValue("@ProductDescription", aDao.ProductDescription);
            com.Parameters.AddWithValue("@ProductPrice", aDao.ProductPrice);
            com.Parameters.AddWithValue("@ProductStock", aDao.ProductStock);
            com.Parameters.AddWithValue("@ProductCategory", aDao.ProductCategory);
            com.Parameters.AddWithValue("ProductWeight", aDao.ProductWeight);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteInfoDAL(int ProductId)
        {
            SqlCommand com = new SqlCommand("Delete_ProductByMasterId", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProductId", ProductId);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}