using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testing.Models;

namespace testing.Controllers
{
    [RoutePrefix("hi")]
    public class TestController : ApiController
    {
        // creating  list in sublist
        [Route("hello")]
        [HttpPost]
        public output testfunction(input j)
        {
           
            output temp = new output();
            SampleData data = new SampleData();

                if (j.inlet == "Hi")
                {
                temp.p1 = 123;
                temp.p2 = "Abc";
                List<SampleData> sampleList = new List<SampleData>();
                sampleList.Add(new SampleData { p1p1=123, p1p2= "AbC" });
                sampleList.Add(new SampleData { p1p1 =123, p1p2 ="xyz" });
                temp.p3 = sampleList;
               }
           
            return temp;
              
        }
       


    }
}
