using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_ADO_NET
{
   public partial class GestionStage : Form
   {
      public OracleConnection oraconnGestion = new OracleConnection();
      public GestionStage(OracleConnection oraconn, String Type)
      {
         InitializeComponent();
         oraconnGestion = oraconn;
      }
   }
}
