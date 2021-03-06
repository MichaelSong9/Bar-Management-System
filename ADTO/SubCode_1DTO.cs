﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADTO
{
    public class SubCode_1DTO
    {

        public int SubCode_1Id { get; set; }
        public string SubCode_1Num { get; set; }
        public string SubCode_1Name { get; set; }
        public int? AID { get; set; }
        public string Description { get; set; }
        public int? MainHeadId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AssetType { get; set; }
        public double? Balance { get; set; }

        // load main head name
        public string MainHeadName { get; set; }
        public string MainheadNum { get; set; }

        // for load name and num
        public string SubCode1Name_Num { get; set; }
    }
}
