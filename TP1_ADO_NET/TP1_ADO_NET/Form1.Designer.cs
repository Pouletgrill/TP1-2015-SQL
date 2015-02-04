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
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 329);
         this.Controls.Add(this.BTN_Past);
         this.Controls.Add(this.BTN_Next);
         this.Name = "Form1";
         this.Text = "Gestion";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button BTN_Next;
      private System.Windows.Forms.Button BTN_Past;
   }
}

