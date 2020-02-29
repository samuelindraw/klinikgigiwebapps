using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Pengguna
    {
        public Pengguna()
        {
            this.Penggajian = new List<Penggajian>();
            this.PesananGigiPalsu = new List<PesananGigiPalsu>();
            this.Prosentase = new List<Prosentase>();
            this.Transaksi = new List<Transaksi>();
        }
        [Key]
        public string Username { get; set; }
        //di isi jika hanya pasien
        public string IdPasien { get; set; }
        public string Nama { get; set; }
        public string Gender { get; set; }
        public short Umur { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
        public string NoTelpon { get; set; }
        public string NoHP { get; set; }
        //all user
        public string Email { get; set; }
        //untuk define jabatan dari pegawai
        public string Jabatan { get; set; }
        //pegawai
        public int Gaji { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //untuk Pasien
        public DateTime Registrasi { get; set; }
        //untuk Pegawai ?
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TanggalJoin { get; set; }
        public string RwPenyakit { get; set; }
        public string TenantID { get; set; }

        public Tenant Tenant { get; set; }
        public UserModel User { get; set; }
        public IEnumerable<Penggajian> Penggajian { get; set; }
        public IEnumerable<PesananGigiPalsu> PesananGigiPalsu { get; set; }

        public IEnumerable<Prosentase> Prosentase { get; set; }
        public IEnumerable<Transaksi> Transaksi { get; set; }
    }
}
