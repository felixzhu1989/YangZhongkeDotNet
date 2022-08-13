using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Frkvf555
    {
        public int Frkvf555id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Deepth { get; set; }
        public string? Height { get; set; }
        public decimal? ExRightDis { get; set; }
        public int? ExNo { get; set; }
        public decimal? ExDis { get; set; }
        public decimal? ExLength { get; set; }
        public decimal? ExWidth { get; set; }
        public decimal? ExHeight { get; set; }
        public string? SidePanel { get; set; }
        public string? Outlet { get; set; }
        public string? Ledlogo { get; set; }
        public string? BackToBack { get; set; }
        public string? WaterCollection { get; set; }
        public int? LedspotNo { get; set; }
        public decimal? LedspotDis { get; set; }
        public string? LightType { get; set; }
        public string? Ansul { get; set; }
        public string? Anside { get; set; }
        public string? Andetector { get; set; }
        public decimal? Anydis { get; set; }
        public int? AndropNo { get; set; }
        public decimal? AndropDis1 { get; set; }
        public decimal? AndropDis2 { get; set; }
        public decimal? AndropDis3 { get; set; }
        public decimal? AndropDis4 { get; set; }
        public decimal? AndropDis5 { get; set; }
        public string? Marvel { get; set; }
        public int? Irno { get; set; }
        public decimal? Irdis1 { get; set; }
        public decimal? Irdis2 { get; set; }
        public decimal? Irdis3 { get; set; }
        public int? SuNo { get; set; }
        public decimal? SuDis { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
