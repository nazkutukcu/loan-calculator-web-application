using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Staj.Models;
using BusinessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Staj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rest : ControllerBase
    {
        public object httpClient { get; private set; }

        // GET: api/Demo
        [HttpPost]
        public int Post(int id)
        {
            return id;
            //  DataList dt = new DataList();
            //  return dt.Class11;
        }

       
       

    }
}
