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
   public partial class FormPrincip : Form
   {
      private OracleConnection oraconn = new OracleConnection();
      public FormPrincip()
      {
         InitializeComponent();
      }

      private void BTN_Add_Click(object sender, EventArgs e)
      {
         GestionStage dlg = new GestionStage(oraconn, "ADD");
         dlg.ShowDialog();
      }

      private void BTN_Delete_Click(object sender, EventArgs e)
      {
         
      }

      private void BTN_ModDesc_Click(object sender, EventArgs e)
      {
         GestionStage dlg = new GestionStage(oraconn, "MOD");
         dlg.ShowDialog();
      }
   }
}
