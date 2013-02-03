﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegExpose.Web.Services
{
    public class ParseStepsRequest
    {
        public string Pattern { get; set; }
        public bool IgnoreCase { get; set; }
        public bool SingleLine { get; set; }
        public bool MultiLine { get; set; }
        public string Input { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; }
    }
}