using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadSales.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public int Records { get; set; }
    }
}
