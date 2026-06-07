using System;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    public class OutOfStockDrugList
    {
        public Guid OutOfStockDrugListID { get; set; }

        public int DrugDescriptionID { get; set; }

        [ForeignKey("DrugDescriptionID")]
        public virtual DrugDescription DrugDescription { get; set; }

        public Guid OutOfStockDrugsID { get; set; }

        [ForeignKey("OutOfStockDrugsID")]
        public virtual OutOfStockDrugs OutOfStockDrugs { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

    }
}
