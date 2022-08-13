using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ModuleTree
    {
        public ModuleTree()
        {
            Abd200s = new HashSet<Abd200>();
            Abd300s = new HashSet<Abd300>();
            Ans = new HashSet<An>();
            Bcj300s = new HashSet<Bcj300>();
            Bcj330s = new HashSet<Bcj330>();
            Bf200s = new HashSet<Bf200>();
            Ch610s = new HashSet<Ch610>();
            Cj300s = new HashSet<Cj300>();
            Cj330s = new HashSet<Cj330>();
            Cmodf555400s = new HashSet<Cmodf555400>();
            Cmodf555s = new HashSet<Cmodf555>();
            Cmodf700ts = new HashSet<Cmodf700t>();
            Cmodi555s = new HashSet<Cmodi555>();
            Cmodi700ts = new HashSet<Cmodi700t>();
            Dp330s = new HashSet<Dp330>();
            Dp340s = new HashSet<Dp340>();
            Dpcj330s = new HashSet<Dpcj330>();
            Frkvf555s = new HashSet<Frkvf555>();
            Fruvf555s = new HashSet<Fruvf555>();
            HoodCutLists = new HashSet<HoodCutList>();
            Hoodbcjs = new HashSet<Hoodbcj>();
            Hwuvf555400s = new HashSet<Hwuvf555400>();
            Hwuvf650s = new HashSet<Hwuvf650>();
            Hwuvi650s = new HashSet<Hwuvi650>();
            Hwuwf555400s = new HashSet<Hwuwf555400>();
            Hwuwf555s = new HashSet<Hwuwf555>();
            Hwuwf650s = new HashSet<Hwuwf650>();
            Infs = new HashSet<Inf>();
            Kchf555s = new HashSet<Kchf555>();
            Kchi555s = new HashSet<Kchi555>();
            Kcjdb800s = new HashSet<Kcjdb800>();
            Kcjsb265s = new HashSet<Kcjsb265>();
            Kcjsb290s = new HashSet<Kcjsb290>();
            Kcjsb535s = new HashSet<Kcjsb535>();
            Kcwdb800s = new HashSet<Kcwdb800>();
            Kcwsb265s = new HashSet<Kcwsb265>();
            Kcwsb535s = new HashSet<Kcwsb535>();
            Kvf400s = new HashSet<Kvf400>();
            Kvf450400s = new HashSet<Kvf450400>();
            Kvf555400s = new HashSet<Kvf555400>();
            Kvf555s = new HashSet<Kvf555>();
            Kvi400s = new HashSet<Kvi400>();
            Kvi555s = new HashSet<Kvi555>();
            Kvimr555s = new HashSet<Kvimr555>();
            Kvir555s = new HashSet<Kvir555>();
            Kvs = new HashSet<Kv>();
            Kvv555s = new HashSet<Kvv555>();
            Kwf555s = new HashSet<Kwf555>();
            Kwi555s = new HashSet<Kwi555>();
            Lfumc150dxfs = new HashSet<Lfumc150dxf>();
            Lfumc150susdxfs = new HashSet<Lfumc150susdxf>();
            Lfumc200dxfs = new HashSet<Lfumc200dxf>();
            Lfumc200susdxfs = new HashSet<Lfumc200susdxf>();
            Lfumc250dxfs = new HashSet<Lfumc250dxf>();
            Lfumc250susdxfs = new HashSet<Lfumc250susdxf>();
            Lfups = new HashSet<Lfup>();
            Lfusas = new HashSet<Lfusa>();
            Lfuscs = new HashSet<Lfusc>();
            Lfusses = new HashSet<Lfuss>();
            Lka258s = new HashSet<Lka258>();
            Lkaspecs = new HashSet<Lkaspec>();
            Lks258hcls = new HashSet<Lks258hcl>();
            Lks270hcls = new HashSet<Lks270hcl>();
            Lks270s = new HashSet<Lks270>();
            Lksspecs = new HashSet<Lksspec>();
            Lkst270s = new HashSet<Lkst270>();
            Lleda = new HashSet<Lledum>();
            Lleds = new HashSet<Lled>();
            Llkajs = new HashSet<Llkaj>();
            Llkas = new HashSet<Llka>();
            Llks = new HashSet<Llk>();
            Llksjs = new HashSet<Llksj>();
            Lpzs = new HashSet<Lpz>();
            Lsdosts = new HashSet<Lsdost>();
            Mcpdxfs = new HashSet<Mcpdxf>();
            Mu1boxdxfs = new HashSet<Mu1boxdxf>();
            Nocj300s = new HashSet<Nocj300>();
            Nocj330s = new HashSet<Nocj330>();
            Nocj340s = new HashSet<Nocj340>();
            Nocjspecs = new HashSet<Nocjspec>();
            Sspdomes = new HashSet<Sspdome>();
            Sspflats = new HashSet<Sspflat>();
            Ssphfds = new HashSet<Ssphfd>();
            Ssptbds = new HashSet<Ssptbd>();
            Ssptsds = new HashSet<Ssptsd>();
            Tcsboxdxfs = new HashSet<Tcsboxdxf>();
            Ucjdb800s = new HashSet<Ucjdb800>();
            Ucjfccombidxfs = new HashSet<Ucjfccombidxf>();
            Ucjsb385s = new HashSet<Ucjsb385>();
            Ucjsb535s = new HashSet<Ucjsb535>();
            Ucpdxfs = new HashSet<Ucpdxf>();
            Ucwdb800s = new HashSet<Ucwdb800>();
            Ucwsb535s = new HashSet<Ucwsb535>();
            Ucwuvr4ldxfs = new HashSet<Ucwuvr4ldxf>();
            Ucwuvr4sdxfs = new HashSet<Ucwuvr4sdxf>();
            Uvf450400s = new HashSet<Uvf450400>();
            Uvf450s = new HashSet<Uvf450>();
            Uvf555400s = new HashSet<Uvf555400>();
            Uvf555s = new HashSet<Uvf555>();
            Uvi555400s = new HashSet<Uvi555400>();
            Uvi555s = new HashSet<Uvi555>();
            Uvimr555s = new HashSet<Uvimr555>();
            Uvimt555s = new HashSet<Uvimt555>();
            Uvir555s = new HashSet<Uvir555>();
            Uwf555400s = new HashSet<Uwf555400>();
            Uwf555s = new HashSet<Uwf555>();
            Uwi555s = new HashSet<Uwi555>();
        }

        public int ModuleTreeId { get; set; }
        public int DrawingPlanId { get; set; }
        public int CategoryId { get; set; }
        public string Module { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
        public virtual DrawingPlan DrawingPlan { get; set; } = null!;
        public virtual ICollection<Abd200> Abd200s { get; set; }
        public virtual ICollection<Abd300> Abd300s { get; set; }
        public virtual ICollection<An> Ans { get; set; }
        public virtual ICollection<Bcj300> Bcj300s { get; set; }
        public virtual ICollection<Bcj330> Bcj330s { get; set; }
        public virtual ICollection<Bf200> Bf200s { get; set; }
        public virtual ICollection<Ch610> Ch610s { get; set; }
        public virtual ICollection<Cj300> Cj300s { get; set; }
        public virtual ICollection<Cj330> Cj330s { get; set; }
        public virtual ICollection<Cmodf555400> Cmodf555400s { get; set; }
        public virtual ICollection<Cmodf555> Cmodf555s { get; set; }
        public virtual ICollection<Cmodf700t> Cmodf700ts { get; set; }
        public virtual ICollection<Cmodi555> Cmodi555s { get; set; }
        public virtual ICollection<Cmodi700t> Cmodi700ts { get; set; }
        public virtual ICollection<Dp330> Dp330s { get; set; }
        public virtual ICollection<Dp340> Dp340s { get; set; }
        public virtual ICollection<Dpcj330> Dpcj330s { get; set; }
        public virtual ICollection<Frkvf555> Frkvf555s { get; set; }
        public virtual ICollection<Fruvf555> Fruvf555s { get; set; }
        public virtual ICollection<HoodCutList> HoodCutLists { get; set; }
        public virtual ICollection<Hoodbcj> Hoodbcjs { get; set; }
        public virtual ICollection<Hwuvf555400> Hwuvf555400s { get; set; }
        public virtual ICollection<Hwuvf650> Hwuvf650s { get; set; }
        public virtual ICollection<Hwuvi650> Hwuvi650s { get; set; }
        public virtual ICollection<Hwuwf555400> Hwuwf555400s { get; set; }
        public virtual ICollection<Hwuwf555> Hwuwf555s { get; set; }
        public virtual ICollection<Hwuwf650> Hwuwf650s { get; set; }
        public virtual ICollection<Inf> Infs { get; set; }
        public virtual ICollection<Kchf555> Kchf555s { get; set; }
        public virtual ICollection<Kchi555> Kchi555s { get; set; }
        public virtual ICollection<Kcjdb800> Kcjdb800s { get; set; }
        public virtual ICollection<Kcjsb265> Kcjsb265s { get; set; }
        public virtual ICollection<Kcjsb290> Kcjsb290s { get; set; }
        public virtual ICollection<Kcjsb535> Kcjsb535s { get; set; }
        public virtual ICollection<Kcwdb800> Kcwdb800s { get; set; }
        public virtual ICollection<Kcwsb265> Kcwsb265s { get; set; }
        public virtual ICollection<Kcwsb535> Kcwsb535s { get; set; }
        public virtual ICollection<Kvf400> Kvf400s { get; set; }
        public virtual ICollection<Kvf450400> Kvf450400s { get; set; }
        public virtual ICollection<Kvf555400> Kvf555400s { get; set; }
        public virtual ICollection<Kvf555> Kvf555s { get; set; }
        public virtual ICollection<Kvi400> Kvi400s { get; set; }
        public virtual ICollection<Kvi555> Kvi555s { get; set; }
        public virtual ICollection<Kvimr555> Kvimr555s { get; set; }
        public virtual ICollection<Kvir555> Kvir555s { get; set; }
        public virtual ICollection<Kv> Kvs { get; set; }
        public virtual ICollection<Kvv555> Kvv555s { get; set; }
        public virtual ICollection<Kwf555> Kwf555s { get; set; }
        public virtual ICollection<Kwi555> Kwi555s { get; set; }
        public virtual ICollection<Lfumc150dxf> Lfumc150dxfs { get; set; }
        public virtual ICollection<Lfumc150susdxf> Lfumc150susdxfs { get; set; }
        public virtual ICollection<Lfumc200dxf> Lfumc200dxfs { get; set; }
        public virtual ICollection<Lfumc200susdxf> Lfumc200susdxfs { get; set; }
        public virtual ICollection<Lfumc250dxf> Lfumc250dxfs { get; set; }
        public virtual ICollection<Lfumc250susdxf> Lfumc250susdxfs { get; set; }
        public virtual ICollection<Lfup> Lfups { get; set; }
        public virtual ICollection<Lfusa> Lfusas { get; set; }
        public virtual ICollection<Lfusc> Lfuscs { get; set; }
        public virtual ICollection<Lfuss> Lfusses { get; set; }
        public virtual ICollection<Lka258> Lka258s { get; set; }
        public virtual ICollection<Lkaspec> Lkaspecs { get; set; }
        public virtual ICollection<Lks258hcl> Lks258hcls { get; set; }
        public virtual ICollection<Lks270hcl> Lks270hcls { get; set; }
        public virtual ICollection<Lks270> Lks270s { get; set; }
        public virtual ICollection<Lksspec> Lksspecs { get; set; }
        public virtual ICollection<Lkst270> Lkst270s { get; set; }
        public virtual ICollection<Lledum> Lleda { get; set; }
        public virtual ICollection<Lled> Lleds { get; set; }
        public virtual ICollection<Llkaj> Llkajs { get; set; }
        public virtual ICollection<Llka> Llkas { get; set; }
        public virtual ICollection<Llk> Llks { get; set; }
        public virtual ICollection<Llksj> Llksjs { get; set; }
        public virtual ICollection<Lpz> Lpzs { get; set; }
        public virtual ICollection<Lsdost> Lsdosts { get; set; }
        public virtual ICollection<Mcpdxf> Mcpdxfs { get; set; }
        public virtual ICollection<Mu1boxdxf> Mu1boxdxfs { get; set; }
        public virtual ICollection<Nocj300> Nocj300s { get; set; }
        public virtual ICollection<Nocj330> Nocj330s { get; set; }
        public virtual ICollection<Nocj340> Nocj340s { get; set; }
        public virtual ICollection<Nocjspec> Nocjspecs { get; set; }
        public virtual ICollection<Sspdome> Sspdomes { get; set; }
        public virtual ICollection<Sspflat> Sspflats { get; set; }
        public virtual ICollection<Ssphfd> Ssphfds { get; set; }
        public virtual ICollection<Ssptbd> Ssptbds { get; set; }
        public virtual ICollection<Ssptsd> Ssptsds { get; set; }
        public virtual ICollection<Tcsboxdxf> Tcsboxdxfs { get; set; }
        public virtual ICollection<Ucjdb800> Ucjdb800s { get; set; }
        public virtual ICollection<Ucjfccombidxf> Ucjfccombidxfs { get; set; }
        public virtual ICollection<Ucjsb385> Ucjsb385s { get; set; }
        public virtual ICollection<Ucjsb535> Ucjsb535s { get; set; }
        public virtual ICollection<Ucpdxf> Ucpdxfs { get; set; }
        public virtual ICollection<Ucwdb800> Ucwdb800s { get; set; }
        public virtual ICollection<Ucwsb535> Ucwsb535s { get; set; }
        public virtual ICollection<Ucwuvr4ldxf> Ucwuvr4ldxfs { get; set; }
        public virtual ICollection<Ucwuvr4sdxf> Ucwuvr4sdxfs { get; set; }
        public virtual ICollection<Uvf450400> Uvf450400s { get; set; }
        public virtual ICollection<Uvf450> Uvf450s { get; set; }
        public virtual ICollection<Uvf555400> Uvf555400s { get; set; }
        public virtual ICollection<Uvf555> Uvf555s { get; set; }
        public virtual ICollection<Uvi555400> Uvi555400s { get; set; }
        public virtual ICollection<Uvi555> Uvi555s { get; set; }
        public virtual ICollection<Uvimr555> Uvimr555s { get; set; }
        public virtual ICollection<Uvimt555> Uvimt555s { get; set; }
        public virtual ICollection<Uvir555> Uvir555s { get; set; }
        public virtual ICollection<Uwf555400> Uwf555400s { get; set; }
        public virtual ICollection<Uwf555> Uwf555s { get; set; }
        public virtual ICollection<Uwi555> Uwi555s { get; set; }
    }
}
