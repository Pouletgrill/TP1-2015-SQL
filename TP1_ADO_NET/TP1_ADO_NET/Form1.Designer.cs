namespace TP1_ADO_NET
{
   partial class Form1
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
         this.button1 = new System.Windows.Forms.Button();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // BTN_Next
         // 
         this.BTN_Next.Location = new System.Drawing.Point(396, 255);
         this.BTN_Next.Name = "BTN_Next";
         this.BTN_Next.Size = new System.Drawing.Size(26, 23);
         this.BTN_Next.TabIndex = 0;
         this.BTN_Next.Text = "->";
         this.BTN_Next.UseVisualStyleBackColor = true;
         // 
         // BTN_Past
         // 
         this.BTN_Past.Location = new System.Drawing.Point(364, 255);
         this.BTN_Past.Name = "BTN_Past";
         this.BTN_Past.Size = new System.Drawing.Size(26, 23);
         this.BTN_Past.TabIndex = 1;
         this.BTN_Past.Text = "<-";
         this.BTN_Past.UseVisualStyleBackColor = true;
         // 
         // BTN_Add
         // 
         this.BTN_Add.Location = new System.Drawing.Point(12, 12);
         this.BTN_Add.Name = "BTN_Add";
         this.BTN_Add.Size = new System.Drawing.Size(143, 23);
         this.BTN_Add.TabIndex = 2;
         this.BTN_Add.Text = "Ajouter stage";
         this.BTN_Add.UseVisualStyleBackColor = true;
         this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
         // 
         // BTN_Delete
         // 
         this.BTN_Delete.Location = new System.Drawing.Point(12, 41);
         this.BTN_Delete.Name = "BTN_Delete";
         this.BTN_Delete.Size = new System.Drawing.Size(143, 23);
         this.BTN_Delete.TabIndex = 3;
         this.BTN_Delete.Text = "Suprimer stage";
         this.BTN_Delete.UseVisualStyleBackColor = true;
         this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
         // 
         // BTN_ModDesc
         // 
         this.BTN_ModDesc.Location = new System.Drawing.Point(12, 70);
         this.BTN_ModDesc.Name = "BTN_ModDesc";
         this.BTN_ModDesc.Size = new System.Drawing.Size(143, 23);
         this.BTN_ModDesc.TabIndex = 4;
         this.BTN_ModDesc.Text = "Modifier stage";
         this.BTN_ModDesc.UseVisualStyleBackColor = true;
         this.BTN_ModDesc.Click += new System.EventHandler(this.BTN_ModDesc_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(89, 146);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 5;
         this.button1.UseVisualStyleBackColor = true;
         // 
         // listBox1
         // 
         this.listBox1.FormattingEnabled = true;
         this.listBox1.Location = new System.Drawing.Point(89, 229);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(108, 56);
         this.listBox1.TabIndex = 6;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(501, 347);
         this.Controls.Add(this.listBox1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.BTN_ModDesc);
         this.Controls.Add(this.BTN_Delete);
         this.Controls.Add(this.BTN_Add);
         this.Controls.Add(this.BTN_Past);
         this.Controls.Add(this.BTN_Next);
         this.Name = "Form1";
         this.Text = "Gestion";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button BTN_Next;
      private System.Windows.Forms.Button BTN_Past;
      private System.Windows.Forms.Button BTN_Add;
      private System.Windows.Forms.Button BTN_Delete;
      private System.Windows.Forms.Button BTN_ModDesc;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.ListBox listBox1;
   }
}

