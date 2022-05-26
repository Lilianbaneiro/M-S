
namespace Mes
{
    partial class Form1
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.gbMes = new System.Windows.Forms.GroupBox();
            this.gbMescase = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMescase = new System.Windows.Forms.Label();
            this.cbMescase = new System.Windows.Forms.ComboBox();
            this.gbMes.SuspendLayout();
            this.gbMescase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(59, 42);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 0;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(23, 42);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(30, 13);
            this.lbtitulo.TabIndex = 1;
            this.lbtitulo.Text = "Mês:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elaborar um sistema onde o usuário digita o número do mês e exibir o nome do mês " +
    "correspondente.";
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Location = new System.Drawing.Point(220, 50);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(72, 13);
            this.lbMes.TabIndex = 3;
            this.lbMes.Text = "Nome do mês";
            // 
            // gbMes
            // 
            this.gbMes.Controls.Add(this.lbtitulo);
            this.gbMes.Controls.Add(this.lbMes);
            this.gbMes.Controls.Add(this.cbMes);
            this.gbMes.Location = new System.Drawing.Point(92, 108);
            this.gbMes.Name = "gbMes";
            this.gbMes.Size = new System.Drawing.Size(362, 122);
            this.gbMes.TabIndex = 4;
            this.gbMes.TabStop = false;
            this.gbMes.Text = "MÊS";
            this.gbMes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbMescase
            // 
            this.gbMescase.Controls.Add(this.label2);
            this.gbMescase.Controls.Add(this.lbMescase);
            this.gbMescase.Controls.Add(this.cbMescase);
            this.gbMescase.Location = new System.Drawing.Point(92, 255);
            this.gbMescase.Name = "gbMescase";
            this.gbMescase.Size = new System.Drawing.Size(362, 122);
            this.gbMescase.TabIndex = 5;
            this.gbMescase.TabStop = false;
            this.gbMescase.Text = "MÊSCASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mês:";
            // 
            // lbMescase
            // 
            this.lbMescase.AutoSize = true;
            this.lbMescase.Location = new System.Drawing.Point(220, 50);
            this.lbMescase.Name = "lbMescase";
            this.lbMescase.Size = new System.Drawing.Size(72, 13);
            this.lbMescase.TabIndex = 3;
            this.lbMescase.Text = "Nome do mês";
            // 
            // cbMescase
            // 
            this.cbMescase.FormattingEnabled = true;
            this.cbMescase.Location = new System.Drawing.Point(59, 42);
            this.cbMescase.Name = "cbMescase";
            this.cbMescase.Size = new System.Drawing.Size(121, 21);
            this.cbMescase.TabIndex = 0;
            this.cbMescase.SelectedIndexChanged += new System.EventHandler(this.cbMescase_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMescase);
            this.Controls.Add(this.gbMes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMes.ResumeLayout(false);
            this.gbMes.PerformLayout();
            this.gbMescase.ResumeLayout(false);
            this.gbMescase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.GroupBox gbMes;
        private System.Windows.Forms.GroupBox gbMescase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMescase;
        private System.Windows.Forms.ComboBox cbMescase;
    }
}

