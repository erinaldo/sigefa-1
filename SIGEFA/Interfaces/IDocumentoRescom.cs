using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DevComponents.DotNetBar.Controls;
using System.Text;
using SIGEFA.Entidades;

namespace SIGEFA.Interfaces
{
    interface IDocumentoRescom
    {
        Boolean InsertRescom(clsDocumentorescom rescom);
        Boolean InsertDetRescom(clsDetalleDocumentoRescom detrescom);
    }
}
