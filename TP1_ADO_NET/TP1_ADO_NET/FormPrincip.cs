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
      bool eventy = false;
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
             if (LISTB_Entreprise.Text == "")
             {
                 LISTB_Entreprise.SelectedIndex = 0;
                 eventy = true;
             }
                 string sql = "select NUMSTAGE, DESCRIPTION, TYPESTG from stages where nument = "+
                            "(select nument from ENTREPRISES where noment = '"+
                            LISTB_Entreprise.Text.ToString().ToLower()+"')";
                
                 OracleDataAdapter Adapter = new OracleDataAdapter(sql, oraconn);
                 Adapter.Fill(monDataSet, "stages");
                 Adapter.Dispose();
                 // on apelle la fonction lier pour faire
                 // la liaison des données du DataSet avec les zones de text.
             //}
            LB_StageID.DataBindings.Add("text", monDataSet, "stages.numstage");
            LB_StageDesc.DataBindings.Add("text", monDataSet, "stages.description");
            LB_StageType.DataBindings.Add("text", monDataSet, "stages.typestg");
         }
         catch (OracleException ex)
         {
            MessageBox.Show("ERREUR LISTE DES STAGES\n" + ex.ToString());
         }
      }

       private void RefreshStage()
      {
          LB_StageID.DataBindings.Clear();
          LB_StageDesc.DataBindings.Clear();
          LB_StageType.DataBindings.Clear();         
          //monDataSet.Clear();
          try
          {
              //if (LISTB_Entreprise.SelectedItem != null)
              //{
              //    LISTB_Entreprise.SelectedIndex = 1;
              //    MessageBox.Show(LISTB_Entreprise.Text.ToString());
              //}
              string sql2 = "select NUMSTAGE, DESCRIPTION, TYPESTG from stages where nument = " +
                         "(select nument from ENTREPRISES where noment = '" +
                         LISTB_Entreprise.Text.ToString().ToLower() + "')";

              OracleDataAdapter Adapter = new OracleDataAdapter(sql2, oraconn);

              Adapter.Fill(monDataSet, "stages");
              Adapter.Dispose();
              // on apelle la fonction lier pour faire
              // la liaison des données du DataSet avec les zones de text.
              //}
              LB_StageID.DataBindings.Add("text", monDataSet, "stages.numstage");
              LB_StageDesc.DataBindings.Add("text", monDataSet, "stages.description");
              LB_StageType.DataBindings.Add("text", monDataSet, "stages.typestg");
          }
          catch (OracleException ex)
          {
              MessageBox.Show("ERREUR LISTE DES STAGES\n" + ex.ToString());
          }
      }

       ////////////////////////////////////////
       //Retourne NUMENT par rapport a NOMENT//
       ////////////////////////////////////////
      public string GetNUMENT(string NOMENT)
      {
          OracleCommand oraComand = new OracleCommand("select nument from " + 
              "entreprises where noment = :nomEnt", oraconn);
          OracleParameter oraParam = new OracleParameter(":nomEnt", OracleDbType.NVarchar2);
          
          oraParam.Value = NOMENT;
          oraComand.Parameters.Add(oraParam);
          oraComand.CommandType = CommandType.Text;

          OracleDataReader oraRead = oraComand.ExecuteReader();
          if (oraRead.Read())
          {
              return oraRead.GetString(0); // Return NUMENT(entreprise)
          }
          else
          {              
              MessageBox.Show("Erreur, aucun NUMENT Trouver par rapport a l'entreprise");
              return "*ERROR*";
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
         StageBar();         
      }

      private void FormPrincip_FormClosing(object sender, FormClosingEventArgs e)
      {
         oraconn.Close();
      }

      private void LISTB_Entreprise_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (eventy)
          {
              RefreshStage();
          }
      }

      private void BTN_Next_Click(object sender, EventArgs e)
      {
         LB_StageID.BindingContext[monDataSet, "Stages"].Position += 1;
      }

      private void BTN_Past_Click(object sender, EventArgs e)
      {
          LB_StageID.BindingContext[monDataSet, "Stages"].Position -= 1;
      }
   }
}
