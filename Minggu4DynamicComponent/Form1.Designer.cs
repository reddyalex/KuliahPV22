
namespace Minggu4DynamicComponent
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
            this.components = new System.ComponentModel.Container();
            this.bola1 = new Minggu4DynamicComponent.Bola();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.papan = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bola1
            // 
            this.bola1.AutoSize = true;
            this.bola1.Checked = true;
            this.bola1.Enabled = false;
            this.bola1.Location = new System.Drawing.Point(557, 232);
            this.bola1.Name = "bola1";
            this.bola1.Size = new System.Drawing.Size(14, 13);
            this.bola1.TabIndex = 0;
            this.bola1.TabStop = true;
            this.bola1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // papan
            // 
            this.papan.Location = new System.Drawing.Point(235, 393);
            this.papan.Name = "papan";
            this.papan.Size = new System.Drawing.Size(247, 23);
            this.papan.TabIndex = 1;
            this.papan.Value = 100;
            this.papan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 443);
            this.Controls.Add(this.papan);
            this.Controls.Add(this.bola1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bola bola1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar papan;
    }
}

