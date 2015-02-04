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
      String TypeElement;
      public GestionStage(OracleConnection oraconn, String Typez)
      {
         InitializeComponent();
         oraconnGestion = oraconn;
         TypeElement = Typez;
      }

      private void GestionStage_Load(object sender, EventArgs e)
      {
         if (TypeElement == "ADD")
         {
            TB_ID.Enabled = true;
            //TB_Desc.Enabled = true;
            CB_Type.Enabled = true;
            TB_Entreprise.Enabled = true;
            Refresh_BTN_OK();
         }
         else if (TypeElement == "MOD")
         {
            TB_ID.Enabled = false;
            //TB_Desc.Enabled = true;
            CB_Type.Enabled = false;
            TB_Entreprise.Enabled = false;            
         }
      }

      //refresh le boutton OK de la form
      private void Refresh_BTN_OK()
      {
         if ( TB_ID.Text == "" ||
            TB_Desc.Text == "" ||
            TB_Entreprise.Text == "")
         {
            BTN_OK.Enabled = false;
         }
         else
         {
            BTN_OK.Enabled = true;
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void TB_ID_TextChanged(object sender, EventArgs e)
      {
         Refresh_BTN_OK();
      }

      private void TB_Desc_TextChanged(object sender, EventArgs e)
      {
         if (TypeElement == "ADD")
         {
            Refresh_BTN_OK();
         }
      }

      private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
      {
         Refresh_BTN_OK();
      }

      private void TB_Entreprise_TextChanged(object sender, EventArgs e)
      {
         Refresh_BTN_OK();
      }
   }
}
