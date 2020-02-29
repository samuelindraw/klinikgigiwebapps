using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Beli
    {
        [Key]
        public int IdBeli { get; set; }
        public DateTime Tanggal { get; set; }
        public int IdBarang { get; set; }
        public short Qty { get; set; }
        public int Harga { get; set; }
        public string Keterangan { get; set; }
        public string TenantID { get; set; }

        public Tenant Tenant { get; set; }
        public Barang Barang { get; set; }
    }
}
