using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Altran.NarrowCaster.Controllers
{
  public class ValuesController : ApiController
  {
    public IHttpActionResult Get()
    {
      return Ok(new[] { "a", "b" });
    }
  }
}
