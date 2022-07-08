using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurHub.Models
{
    public class BASKET_ADRS_CAMPI
    {
        public int CAM_PARAM_ID { get; set; }
        public int CAM_ID_PK { get; set; }
        public int CAM_TIPO_PROGETTO { get; set; }
        public int CAM_TAB_ID_FK { get; set; }

        public string CAM_NOMECAMPO { get; set; }
        public int? CAM_TIPODATO { get; set; }
        public int? CAM_DIMENSIONE { get; set; }
        public bool CAM_ATTIVO { get; set; }
        public bool CAM_SKIPREAD { get; set; }
        public int? CAM_DBCOMPATIBILITY { get; set; }
        public int? CAM_ENABLE_FULL_MENU { get; set; }

    }
}
