using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstApi.Models
{
    [Table("qaid")]
    public class Qaid
    {
        public long QaidID { get; set; }
        public long QaidRef { get; set; }
        public int QaidAccID { get; set; }
        public double QaidM1 { get; set; }
        public double QaidD1 { get; set; }
        public double QaidCurrPrice { get; set; }
        public double QaidM2 { get; set; }
        public double QaidD2 { get; set; }
        public string OrderDetails { get; set; } = string.Empty;
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string QaidType { get; set; } = string.Empty;
        public int QaidCode { get; set; }
        public string QaidDetails { get; set; } = string.Empty;
        public int BranchNo { get; set; }
        public int DocNo { get; set; }
        public bool Review { get; set; }
        public bool Sign { get; set; }
    }
}
