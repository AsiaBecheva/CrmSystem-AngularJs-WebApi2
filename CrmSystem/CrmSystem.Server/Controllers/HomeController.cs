﻿using CrmSystem.Data.Repository;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CrmSystem.Server.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork data) : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            var publicProducts = this.data
                .Products
                .All()
                .ToList();

            return this.Ok(publicProducts);
        }
    }
}
