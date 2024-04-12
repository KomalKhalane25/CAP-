using ApplyLoanApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplyLoanApplication.Controllers
{
    public class UerRegController : Controller
    {
        // GET: UerReg
        public ActionResult Index()
        {
            return View();
        }
            [HttpPost]
            public ActionResult Index(UserMVC userClas, HttpPostedFileBase file)

            {
                string mainconn = ConfigurationManager.ConnectionStrings["LoanApplicationContext"].ConnectionString;

                SqlConnection conn = new SqlConnection(mainconn);
                string sqlquery = "insert in to [loaninfo].[UserMVC] ( Id,name,EmailID,Gender,DOB,City,Password,RePassword) value (@Id,@name,@EmailID,@Gender,@DOB,@City,@Password,@RePassword)";
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", userClas.Id);
                cmd.Parameters.AddWithValue("@name", userClas.Name);
                cmd.Parameters.AddWithValue("@EmailID", userClas.EmailId);
                cmd.Parameters.AddWithValue("@Gender", userClas.Gender);
                cmd.Parameters.AddWithValue("@DOB", userClas.DOB);
                cmd.Parameters.AddWithValue("@City", userClas.City);
                cmd.Parameters.AddWithValue("@Password", userClas.Password);
                cmd.Parameters.AddWithValue("@RePassword", userClas.RePassword);
                conn.Close();
                ViewData["Massage"] = "User Record" + userClas.Id + "Is Saved Successfully:";

                return View();
                
        }
    }
}