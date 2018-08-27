using Student.Business.Logi.BusinessLogic;
using Student.Business.Logic.Contracts;
using Student.Common.Logic.Log4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student.Business.Facade.Controllers
{
    public class FacturaController : ApiController
    {
        private readonly ILogger Log;
        private readonly IBusinessGeneric<Factura> facturaBL;

        public FacturaController(ILogger Log, IBusinessGeneric<Factura> facturaBL)
        {
            this.Log = Log;
            this.facturaBL = facturaBL;
        }

        // GET: api/Factura/GetAll
        [HttpGet]
        public int GetAll()
        {
            throw new NotImplementedException();
        }

        // GET: api/Factura/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Factura
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Factura/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Factura/5
        public void Delete(int id)
        {
        }
    }
}
