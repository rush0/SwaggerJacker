﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SwaggerJacker.BusinessObjects;
using SwaggerJacker.DAL;

namespace SwaggerJacker.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields - Private
        private const string _dbConnectionStringName
            = "SwaggerJackerDbConnection";

        private ITagDAL _dal;
        #endregion

        #region CTOR
        public HomeController()
        {
            string connectionString
                = ConfigurationManager.ConnectionStrings[_dbConnectionStringName].ConnectionString;

            _dal = new SwaggerJackerSqlDal( connectionString );
        }
        #endregion

        public ActionResult Index()
        {
            var tags = _dal.GetTags( "" );
            return View( tags );
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        protected override void Dispose( bool disposing )
        {
                base.Dispose( disposing );
        }
    }

    
}
