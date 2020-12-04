using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReviewCheckList
{
    public class ItemProperties
    {
        public string DocumentId { get; set; }
        public string TaskId { get; set; }
        public string CollaborativeSpace { get; set; }
        public string TransferType { get; set; }
        public string Latest { get; set; }
        public string Version { get; set; }
        public string DrawingOpening { get; set; }
        public string EngineeringConnections { get; set; }
        public string CheckRepresentation { get; set; }
        public string Other { get; set; }
        public string CbCollaborativeSpace { get; set; }
        public string CbTransferType { get; set; }
        public string CbLatest { get; set; }
        public string CbVersion { get; set; }
        public string CbDrawingOpening { get; set; }
        public string CbEngineeringConnectionst { get; set; }
        public string CbCheckRepresentation { get; set; }
        public string CbOther { get; set; }



        public void save()
        {

        }
    }


}
