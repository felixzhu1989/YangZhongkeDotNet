using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Kcjdb800
    {
        public int Kcjdb800id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? ExRightDis { get; set; }
        public decimal? ExLength { get; set; }
        public decimal? ExWidth { get; set; }
        public decimal? ExHeight { get; set; }
        public decimal? FcsideLeft { get; set; }
        public decimal? FcsideRight { get; set; }
        public string? Fcside { get; set; }
        public string? Fctype { get; set; }
        public int? FcblindNo { get; set; }
        public string? LightType { get; set; }
        public string? LightCable { get; set; }
        public string? Ssptype { get; set; }
        public string? Gutter { get; set; }
        public decimal? GutterWidth { get; set; }
        public string? Ansul { get; set; }
        public string? Anside { get; set; }
        public string? AndetectorEnd { get; set; }
        public int? AndetectorNo { get; set; }
        public decimal? AndetectorDis1 { get; set; }
        public decimal? AndetectorDis2 { get; set; }
        public decimal? AndetectorDis3 { get; set; }
        public decimal? AndetectorDis4 { get; set; }
        public decimal? AndetectorDis5 { get; set; }
        public string? Marvel { get; set; }
        public string? Japan { get; set; }
        public string? LightPanelSide { get; set; }
        public decimal? LightPanelLeft { get; set; }
        public decimal? LightPanelRight { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
