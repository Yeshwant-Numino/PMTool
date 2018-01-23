using System;
using System.Collections.Generic;
using System.Text;

namespace NuminoLabs.PMTool.Model.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int ModeifiedBy { get; set; }

    }
}
