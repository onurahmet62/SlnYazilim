﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{
    public class bgKategori :baseEntity
    {
        public string KategoriAdi { get; set; }

        public virtual ICollection<bgUrunGiris> BgUrunGirises { get; set; }

    }
}
