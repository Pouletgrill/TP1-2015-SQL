namespace TP1_ADO_NET
{
   partial class FormPrincip
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
         this.BTN_Next = new System.Windows.Forms.Button();
         this.BTN_Past = new System.Windows.Forms.Button();
         this.BTN_Add = new System.Windows.Forms.Button();
         this.BTN_Delete = new System.Windows.Forms.Button();
         this.BTN_ModDesc = new System.Windows.Forms.Button();
         this.LISTB_Entreprise = new System.Windows.Forms.ListBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.LB_StageID = new System.Windows.Forms.Label();
         this.LB_StageDesc = new System.Windows.Forms.Label();
         this.LB_StageType = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // BTN_Next
         // 
         this.BTN_Next.Location = new System.Drawing.Point(219, 96);
         this.BTN_Next.Name = "BTN_Next";
         this.BTN_Next.Size = new System.Drawing.Size(26, 23);
         this.BTN_Next.TabIndex = 0;
         this.BTN_Next.Text = "->";
         this.BTN_Next.UseVisualStyleBackColor = true;
         // 
         // BTN_Past
         // 
         this.BTN_Past.Location = new System.Drawing.Point(184, 96);
         this.BTN_Past.Name = "BTN_Past";
         this.BTN_Past.Size = new System.Drawing.Size(26, 23);
         this.BTN_Past.TabIndex = 1;
         this.BTN_Past.Text = "<-";
         this.BTN_Past.UseVisualStyleBackColor = true;
         // 
         // BTN_Add
         // 
         this.BTN_Add.Location = new System.Drawing.Point(11, 33);
         this.BTN_Add.Name = "BTN_Add";
         this.BTN_Add.Size = new System.Drawing.Size(106, 23);
         this.BTN_Add.TabIndex = 2;
         this.BTN_Add.Text = "Ajouter stage";
         this.BTN_Add.UseVisualStyleBackColor = true;
         this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
         // 
         // BTN_Delete
         // 
         this.BTN_Delete.Location = new System.Drawing.Point(11, 62);
         this.BTN_Delete.Name = "BTN_Delete";
         this.BTN_Delete.Size = new System.Drawing.Size(106, 23);
         this.BTN_Delete.TabIndex = 3;
         this.BTN_Delete.Text = "Suprimer stage";
         this.BTN_Delete.UseVisualStyleBackColor = true;
         this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
         // 
         // BTN_ModDesc
         // 
         this.BTN_ModDesc.Location = new System.Drawing.Point(11, 91);
         this.BTN_ModDesc.Name = "BTN_ModDesc";
         this.BTN_ModDesc.Size = new System.Drawing.Size(106, 23);
         this.BTN_ModDesc.TabIndex = 4;
         this.BTN_ModDesc.Text = "Modifier stage";
         this.BTN_ModDesc.UseVisualStyleBackColor = true;
         this.BTN_ModDesc.Click += new System.EventHandler(this.BTN_ModDesc_Click);
         // 
         // LISTB_Entreprise
         // 
         this.LISTB_Entreprise.FormattingEnabled = true;
         this.LISTB_Entreprise.Location = new System.Drawing.Point(132, 6);
         this.LISTB_Entreprise.Name = "LISTB_Entreprise";
         this.LISTB_Entreprise.Size = new System.Drawing.Size(97, 43);
         this.LISTB_Entreprise.TabIndex = 6;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.panel1.Location = new System.Drawing.Point(123, 6);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(2, 108);
         this.panel1.TabIndex = 7;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(63, 13);
         this.label1.TabIndex = 9;
         this.label1.Text = "Num Stage:";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(75, 6);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(42, 20);
         this.textBox1.TabIndex = 10;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(145, 54);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "Stage ID :";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(131, 67);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(79, 13);
         this.label3.TabIndex = 12;
         this.label3.Text = "Description :";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(130, 80);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(80, 13);
         this.label4.TabIndex = 13;
         this.label4.Text = "Type Stage :";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // LB_StageID
         // 
         this.LB_StageID.AutoSize = true;
         this.LB_StageID.Location = new System.Drawing.Point(216, 54);
         this.LB_StageID.Name = "LB_StageID";
         this.LB_StageID.Size = new System.Drawing.Size(35, 13);
         this.LB_StageID.TabIndex = 14;
         this.LB_StageID.Text = "label5";
         // 
         // LB_StageDesc
         // 
         this.LB_StageDesc.AutoSize = true;
         this.LB_StageDesc.Location = new System.Drawing.Point(216, 67);
         this.LB_StageDesc.Name = "LB_StageDesc";
         this.LB_StageDesc.Size = new System.Drawing.Size(35, 13);
         this.LB_StageDesc.TabIndex = 15;
         this.LB_StageDesc.Text = "label6";
         // 
         // LB_StageType
         // 
         this.LB_StageType.AutoSize = true;
         this.LB_StageType.Location = new System.Drawing.Point(216, 80);
         this.LB_StageType.Name = "LB_StageType";
         this.LB_StageType.Size = new System.Drawing.Size(35, 13);
         this.LB_StageType.TabIndex = 16;
         this.LB_StageType.Text = "label7";
         // 
         // FormPrincip
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(501, 347);
         this.Controls.Add(this.LB_StageType);
         this.Controls.Add(this.LB_StageDesc);
         this.Controls.Add(this.LB_StageID);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.LISTB_Entreprise);
         this.Controls.Add(this.BTN_ModDesc);
         this.Controls.Add(this.BTN_Delete);
         this.Controls.Add(this.BTN_Add);
         this.Controls.Add(this.BTN_Past);
         this.Controls.Add(this.BTN_Next);
         this.Name = "FormPrincip";
         this.Text = "Gestion";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Next;
      private System.Windows.Forms.Button BTN_Past;
      private System.Windows.Forms.Button BTN_Add;
      private System.Windows.Forms.Button BTN_Delete;
      private System.Windows.Forms.Button BTN_ModDesc;
      private System.Windows.Forms.ListBox LISTB_Entreprise;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label LB_StageID;
      private System.Windows.Forms.Label LB_StageDesc;
      private System.Windows.Forms.Label LB_StageType;
   }
}

