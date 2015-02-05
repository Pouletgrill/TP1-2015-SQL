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
        String NumStagePrince;
        public GestionStage(OracleConnection oraconn, String Typez, String NumStage)
        {
            InitializeComponent();
            oraconnGestion = oraconn;
            TypeElement = Typez;
            NumStagePrince = NumStage;
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
                RemplirGrilleTB();
            }
        }

        private void RemplirGrilleTB()
        {
            TB_ID.Text = NumStagePrince;
            OracleCommand oraComand = new OracleCommand("select DESCRIPTION, TYPESTG, NUMENT from Stages", oraconnGestion);
            OracleDataReader oraRead = oraComand.ExecuteReader();
            if (oraRead.Read())
            {
                TB_Desc.Text = oraRead.GetString(0);
                if (oraRead.GetString(1)=="ges")
                {
                    CB_Type.Text = "Gestion";
                }
                else
                {
                    CB_Type.Text = "Industrielle"
                }
            }
            else
            {
                MessageBox.Show("Erreur Remplissage de grille");
            }
        }

        //refresh le boutton OK de la form
        private void Refresh_BTN_OK()
        {
            if (TB_ID.Text == "" ||
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

        private void OK_Click(object sender, EventArgs e)
        {
            if (!StageIDExist(TB_ID.Text) && EntrepriseExist(TB_Entreprise.Text.ToLower()) )
            {
                AjouterStage();
                this.Close();
            }
            else
            {
                MessageBox.Show("Des données sont éronnés, mal orthographiées, ou deja existente");
            }
        }

        private bool EntrepriseExist(String Entreprise)
        {
            bool Trouver = false;
            String sqlcommande = "select NOMENT from ENTREPRISES";
            try
            {
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();
                while (!Trouver && oraRead.Read())
                {
                    if (oraRead.GetString(0).ToLower() == Entreprise)
                    { Trouver = true; }
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("ERREUR REMPLIR MATCHING ID\n" + ex.ToString());
            }
            return Trouver;
        }

        private bool StageIDExist(String ID)
        {
            bool Trouver = false;
            String sqlcommande = "select NUMSTAGE from STAGES";
            try
            {
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();
                while (!Trouver && oraRead.Read())
                {
                    if(oraRead.GetInt32(0).ToString() == ID)
                    { Trouver = true; }
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("ERREUR REMPLIR MATCHING ID\n" + ex.ToString());
            }
            return Trouver;
        }

        private void AjouterStage()
        {
            String commandesql = " insert into Stages " +
            "(NUMSTAGE, DESCRIPTION, TYPESTG, NUMENT ) values " +
            "(:NumStage,:Description,:TypeStg,:NumEnt)";

            try
            {
                // on affecte les valeurs aux paramètres.
                OracleParameter oranumstage = new OracleParameter(":NumStage", OracleDbType.Int32);
                OracleParameter oradescription = new OracleParameter(":Description", OracleDbType.Varchar2);
                OracleParameter oratypestg = new OracleParameter(":TypeStg", OracleDbType.Varchar2);
                OracleParameter oranument = new OracleParameter(":NumEnt", OracleDbType.Varchar2);

                // lalblablabla
                OracleCommand oraModif = new OracleCommand(commandesql, oraconnGestion);
                oraModif.CommandType = CommandType.Text;

                oranumstage.Value = Int32.Parse(TB_ID.Text);
                oradescription.Value = TB_Desc.Text;
                if (CB_Type.Text == "Gestion")
                {
                    oratypestg.Value = "ges";
                }
                else
                {
                    oratypestg.Value = "ind";
                }
                oranument.Value = GetNUMENT(TB_Entreprise.Text.ToLower());

                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les paramètres de la requête SQL.
                oraModif.Parameters.Add(oranumstage);
                oraModif.Parameters.Add(oradescription);
                oraModif.Parameters.Add(oratypestg);
                oraModif.Parameters.Add(oranument);
                // on exécute la requête
                oraModif.ExecuteNonQuery();
                // on appelle la fonction dissocier pour pouvoir insérer une deuxième fois.
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        public string GetNUMENT(string NOMENT)
        {
            OracleCommand oraComand = new OracleCommand("select nument from " +
                "entreprises where noment = :nomEnt", oraconnGestion);
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
    }
}
