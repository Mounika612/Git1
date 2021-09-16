using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testing.Models
{
    public class output
    {
        public int p1 { get; set; }
        public string p2 { get; set; }
        public List<SampleData> p3 { get; set; }
    }

    public class SampleData
    {
        public int p1p1 { get; set; }
        public string p1p2 { get; set; }
    }
}