namespace Lab_8
{
    partial class Form2
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
            this.panelForms2 = new System.Windows.Forms.Panel();
            this.richTextBoxConTodosLosLocales = new System.Windows.Forms.RichTextBox();
            this.labelFull_Info = new System.Windows.Forms.Label();
            this.panelForms2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForms2
            // 
            this.panelForms2.Controls.Add(this.richTextBoxConTodosLosLocales);
            this.panelForms2.Controls.Add(this.labelFull_Info);
            this.panelForms2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms2.Location = new System.Drawing.Point(0, 0);
            this.panelForms2.Name = "panelForms2";
            this.panelForms2.Size = new System.Drawing.Size(800, 450);
            this.panelForms2.TabIndex = 0;
            // 
            // richTextBoxConTodosLosLocales
            // 
            this.richTextBoxConTodosLosLocales.Location = new System.Drawing.Point(17, 71);
            this.richTextBoxConTodosLosLocales.Name = "richTextBoxConTodosLosLocales";
            this.richTextBoxConTodosLosLocales.ReadOnly = true;
            this.richTextBoxConTodosLosLocales.Size = new System.Drawing.Size(730, 338);
            this.richTextBoxConTodosLosLocales.TabIndex = 1;
            this.richTextBoxConTodosLosLocales.Text = "";
            this.richTextBoxConTodosLosLocales.TextChanged += new System.EventHandler(this.richTextBoxConTodosLosLocales_TextChanged);
            // 
            // labelFull_Info
            // 
            this.labelFull_Info.AutoSize = true;
            this.labelFull_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelFull_Info.Location = new System.Drawing.Point(12, 9);
            this.labelFull_Info.Name = "labelFull_Info";
            this.labelFull_Info.Size = new System.Drawing.Size(376, 29);
            this.labelFull_Info.TabIndex = 0;
            this.labelFull_Info.Text = "Informacion de todos los locales";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelForms2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelForms2.ResumeLayout(false);
            this.panelForms2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForms2;
        private System.Windows.Forms.Label labelFull_Info;
        private System.Windows.Forms.RichTextBox richTextBoxConTodosLosLocales;
    }
}