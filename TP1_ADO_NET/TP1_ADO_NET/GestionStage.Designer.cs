namespace TP1_ADO_NET
{
   partial class GestionStage
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.TB_ID = new System.Windows.Forms.TextBox();
         this.TB_Desc = new System.Windows.Forms.TextBox();
         this.BTN_Cancel = new System.Windows.Forms.Button();
         this.BTN_OK = new System.Windows.Forms.Button();
         this.CB_Type = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.TB_Entreprise = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(11, 61);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(80, 13);
         this.label4.TabIndex = 19;
         this.label4.Text = "Type Stage :";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(12, 35);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(79, 13);
         this.label3.TabIndex = 18;
         this.label3.Text = "Description :";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(26, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 13);
         this.label2.TabIndex = 17;
         this.label2.Text = "Stage ID :";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // TB_ID
         // 
         this.TB_ID.Location = new System.Drawing.Point(97, 6);
         this.TB_ID.Name = "TB_ID";
         this.TB_ID.Size = new System.Drawing.Size(100, 20);
         this.TB_ID.TabIndex = 1;
         this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
         // 
         // TB_Desc
         // 
         this.TB_Desc.Location = new System.Drawing.Point(97, 32);
         this.TB_Desc.Name = "TB_Desc";
         this.TB_Desc.Size = new System.Drawing.Size(100, 20);
         this.TB_Desc.TabIndex = 2;
         this.TB_Desc.TextChanged += new System.EventHandler(this.TB_Desc_TextChanged);
         // 
         // BTN_Cancel
         // 
         this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.BTN_Cancel.Location = new System.Drawing.Point(123, 112);
         this.BTN_Cancel.Name = "BTN_Cancel";
         this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
         this.BTN_Cancel.TabIndex = 6;
         this.BTN_Cancel.Text = "Annuler";
         this.BTN_Cancel.UseVisualStyleBackColor = true;
         this.BTN_Cancel.Click += new System.EventHandler(this.button1_Click);
         // 
         // BTN_OK
         // 
         this.BTN_OK.Location = new System.Drawing.Point(42, 112);
         this.BTN_OK.Name = "BTN_OK";
         this.BTN_OK.Size = new System.Drawing.Size(75, 23);
         this.BTN_OK.TabIndex = 5;
         this.BTN_OK.Text = "OK";
         this.BTN_OK.UseVisualStyleBackColor = true;
         this.BTN_OK.Click += new System.EventHandler(this.button2_Click);
         // 
         // CB_Type
         // 
         this.CB_Type.FormattingEnabled = true;
         this.CB_Type.Items.AddRange(new object[] {
            "Gestion",
            "Industrielle"});
         this.CB_Type.Location = new System.Drawing.Point(98, 59);
         this.CB_Type.Name = "CB_Type";
         this.CB_Type.Size = new System.Drawing.Size(98, 21);
         this.CB_Type.TabIndex = 3;
         this.CB_Type.Text = "Gestion";
         this.CB_Type.SelectedIndexChanged += new System.EventHandler(this.CB_Type_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(20, 89);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 13);
         this.label1.TabIndex = 26;
         this.label1.Text = "Entreprise :";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // TB_Entreprise
         // 
         this.TB_Entreprise.Location = new System.Drawing.Point(98, 86);
         this.TB_Entreprise.Name = "TB_Entreprise";
         this.TB_Entreprise.Size = new System.Drawing.Size(100, 20);
         this.TB_Entreprise.TabIndex = 4;
         this.TB_Entreprise.TextChanged += new System.EventHandler(this.TB_Entreprise_TextChanged);
         // 
         // GestionStage
         // 
         this.AcceptButton = this.BTN_OK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.BTN_Cancel;
         this.ClientSize = new System.Drawing.Size(208, 142);
         this.Controls.Add(this.TB_Entreprise);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.CB_Type);
         this.Controls.Add(this.BTN_OK);
         this.Controls.Add(this.BTN_Cancel);
         this.Controls.Add(this.TB_Desc);
         this.Controls.Add(this.TB_ID);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "GestionStage";
         this.Text = "GestionStage";
         this.Load += new System.EventHandler(this.GestionStage_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox TB_ID;
      private System.Windows.Forms.TextBox TB_Desc;
      private System.Windows.Forms.Button BTN_Cancel;
      private System.Windows.Forms.Button BTN_OK;
      private System.Windows.Forms.ComboBox CB_Type;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox TB_Entreprise;
   }
}