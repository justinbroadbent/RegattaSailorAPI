﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegattaSailorAPI.Models
{
    public class LegResultBodyModel
    {
        public Guid YachtId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}