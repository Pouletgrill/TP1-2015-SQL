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
      bool connecter = false;
      private DataSet monDataSet = new DataSet();
      public FormPrincip()
      {
         InitializeComponent();
      }

      //////////////////////
      //CHAINE DE CONEXION//
      //////////////////////
      private void Connection()
      {
         if (!connecter)
         {
            //Remplit le DSource
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=205.237.244.251)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string user = "BROSSEAU";
            string passwd = "ORACLE1";

            string chaineconnection = "Data Source = " + Dsource + ";User Id =" + user + "; Password =" + passwd;
            connecter = true;
            try
            {
               oraconn.ConnectionString = chaineconnection;
               oraconn.Open();
            }
            catch (OracleException ex)
            {
               MessageBox.Show(ex.ToString());
               connecter = false;
            }
         }
      }

      /////////////////////////////////
      //Remplit la liste d'entreprise//
      /////////////////////////////////
      private void RemplirListBox()
      {

         String sqlcommande = "select NOMENT from ENTREPRISES";
         try
         {
            OracleCommand orcd = new OracleCommand(sqlcommande, oraconn);
            orcd.CommandType = CommandType.Text;
            OracleDataReader oraRead = orcd.ExecuteReader();

            while (oraRead.Read())
            {
               LISTB_Entreprise.Items.Add(oraRead.GetString(0));
            }
            oraRead.Close();
         }
         catch (OracleException ex)
         {
            MessageBox.Show("ERREUR REMPLIR LISTB_ENTREPRISE\n" + ex.ToString());
         }
      }

      ////////////////////////////////////////////
      //Remplit les STAGES FLECHES GAUCHE-DROITE//
      ////////////////////////////////////////////
      private void StageBar()
      {
         try
         {
            string sql2 = "select * from "+ LISTB_Entreprise.Text;

            OracleDataAdapter Adapter2 = new OracleDataAdapter(sql2, oraconn);
            if (monDataSet.Tables.Contains(LISTB_Entreprise.Text))
            {
               monDataSet.Tables[LISTB_Entreprise.Text].Clear();
            }

            Adapter2.Fill(monDataSet, LISTB_Entreprise.Text);
            Adapter2.Dispose();
            // on apelle la fonction lier pour faire
            // la liaison des données du DataSet avec les zones de text.
            //LierEquipe();
            //AffichageEquipe();

            if (this.BindingContext[monDataSet, LISTB_Entreprise.Text].Count <= 1)
            {
               
               BTN_Past.Enabled = false;
               BTN_Next.Enabled = false;
            }
         }
         catch (OracleException ex)
         {
            MessageBox.Show("ERREUR LISTE DES STAGES\n" + ex.ToString());
         }
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

      private void FormPrincip_Load(object sender, EventArgs e)
      {
         Connection();
         RemplirListBox();         
      }

      private void FormPrincip_FormClosing(object sender, FormClosingEventArgs e)
      {
         oraconn.Close();
      }

      private void LISTB_Entreprise_SelectedIndexChanged(object sender, EventArgs e)
      {
         StageBar();
      }
   }
}
