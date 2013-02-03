﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegExpose.Web.Services
{
    public class ParseStepDto
    {
        public int StepIndex { get; set; }
        public string Type { get; set; }
        public string MatchedText { get; set; }
        public string Message { get; set; }
        public int NodeId { get; set; }
        public int InitialStateIndex { get; set; }
        public int CurrentStateIndex { get; set; }
    }
}