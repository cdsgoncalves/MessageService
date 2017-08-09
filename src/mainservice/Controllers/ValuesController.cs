using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mainservice.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        /// <summary>
        /// Get all avaliable Values
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Get just a value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Creates a value
        /// </summary>
        /// <remarks>
        /// Note that it is a fake method.
        /// </remarks>
        /// <param name="value">The Value to be created</param>
        /// <response code="201">The Value that just created</response>
        /// <response code="400">The Value sent is invalid or malformed</response>
        /// <response code="500">Bad bad, Dr. App. We`ve experiencing some troble</response>
        [HttpPost]
        [ProducesResponseType(typeof(string),201)]
        [ProducesResponseType(typeof(string),400)]
        [ProducesResponseType(typeof(string),500)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
