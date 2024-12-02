using AMP12_1633_StockTakipProgram.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMP12_1633_StockTakipProgram.Model
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        public int KategoriAdi { get; set; }

        //İlişki : Bir Kategorinin Birden Fazla Ürüne Sahip Olabilir.

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();

    }
}
