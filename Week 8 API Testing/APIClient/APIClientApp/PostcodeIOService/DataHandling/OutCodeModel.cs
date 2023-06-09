﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodeIOService.DataHandling
{

    public class OutcodeResponse //: IResponse
    {
        public int status { get; set; }
        public OutcodeResult result { get; set; }
    }

    public class OutcodeResult
    {
        public string outcode { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public int northings { get; set; }
        public int eastings { get; set; }
        public string[] admin_district { get; set; }
        public string[] parish { get; set; }
        public object[] admin_county { get; set; }
        public string[] admin_ward { get; set; }
        public string[] country { get; set; }
        public string[] parliamentary_constituency { get; set; }
    }

}
