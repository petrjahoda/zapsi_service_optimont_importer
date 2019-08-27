using System;

namespace zapsi_service_optimont_importer {
    public class FisImportOrder {
        public string Id { get; set; }
        public string TerminalInputOrderId { get; set; }
        public DateTime DTS { get; set; }
        public DateTime DTE { get; set; }
        public string IDZ { get; set; }
        public string IDVC { get; set; }
        public string IDS { get; set; }
        public string IDOper { get; set; }
        public string TotalCount { get; set; }
        public string NOK { get; set; }
        public string KgOK { get; set; }
        public string KgNOK { get; set; }
    }
}