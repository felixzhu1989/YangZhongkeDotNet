using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Hmm
    {
        public int Hmmid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? InletDia { get; set; }
        public decimal? OutletDia { get; set; }
        public decimal? OutletHeight { get; set; }
        public string? HangPosition { get; set; }
        public string? PowerPlug { get; set; }
        public decimal? PowerPlugDis { get; set; }
        public string? NetPlug { get; set; }
        public string? PlugPosition { get; set; }
        public string? Heater { get; set; }
        public string? TemperatureSwitch { get; set; }
        public string? NamePlate { get; set; }
        public string? WindPressure { get; set; }

        public virtual ModuleTreeMarine? ModuleTree { get; set; }
    }
}
