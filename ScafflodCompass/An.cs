using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class An
    {
        public int Anid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public string? Ansul { get; set; }
        public decimal? Anydis { get; set; }
        public int? AndropNo { get; set; }
        public decimal? AndropDis1 { get; set; }
        public decimal? AndropDis2 { get; set; }
        public decimal? AndropDis3 { get; set; }
        public decimal? AndropDis4 { get; set; }
        public decimal? AndropDis5 { get; set; }
        public int? AndetectorNo { get; set; }
        public string? AndetectorEnd { get; set; }
        public decimal? AndetectorDis1 { get; set; }
        public decimal? AndetectorDis2 { get; set; }
        public decimal? AndetectorDis3 { get; set; }
        public decimal? AndetectorDis4 { get; set; }
        public decimal? AndetectorDis5 { get; set; }
        public string? Marvel { get; set; }
        public int? Irno { get; set; }
        public decimal? Irdis1 { get; set; }
        public decimal? Irdis2 { get; set; }
        public decimal? Irdis3 { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
