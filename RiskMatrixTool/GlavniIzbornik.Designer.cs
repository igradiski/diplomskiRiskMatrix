
namespace RiskMatrixTool
{
    partial class GlavniIzbornik
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavniIzbornik));
            this.panel1 = new System.Windows.Forms.Panel();
            this.vjerojatnostPanel1 = new RiskMatrixTool.FormItems.VjerojatnostPanel.VjerojatnostPanel();
            this.ozbiljnostPanel1 = new RiskMatrixTool.FormItems.OzbiljnostPanel.OzbiljnostPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.VjerojatnostButton = new System.Windows.Forms.Button();
            this.OzbiljnostButton = new System.Windows.Forms.Button();
            this.matrix1 = new RiskMatrixTool.Forms.Matrix.Matrix();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.vjerojatnostPanel1);
            this.panel1.Controls.Add(this.ozbiljnostPanel1);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.matrix1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 961);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vjerojatnostPanel1
            // 
            this.vjerojatnostPanel1.Location = new System.Drawing.Point(136, 146);
            this.vjerojatnostPanel1.Name = "vjerojatnostPanel1";
            this.vjerojatnostPanel1.Size = new System.Drawing.Size(171, 672);
            this.vjerojatnostPanel1.TabIndex = 13;
            // 
            // ozbiljnostPanel1
            // 
            this.ozbiljnostPanel1.Location = new System.Drawing.Point(306, 10);
            this.ozbiljnostPanel1.Name = "ozbiljnostPanel1";
            this.ozbiljnostPanel1.Size = new System.Drawing.Size(836, 136);
            this.ozbiljnostPanel1.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.VjerojatnostButton);
            this.panel10.Controls.Add(this.OzbiljnostButton);
            this.panel10.Location = new System.Drawing.Point(141, 11);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(166, 135);
            this.panel10.TabIndex = 11;
            // 
            // VjerojatnostButton
            // 
            this.VjerojatnostButton.Location = new System.Drawing.Point(0, 90);
            this.VjerojatnostButton.Name = "VjerojatnostButton";
            this.VjerojatnostButton.Size = new System.Drawing.Size(100, 45);
            this.VjerojatnostButton.TabIndex = 15;
            this.VjerojatnostButton.Text = "Vjerojatnost";
            this.VjerojatnostButton.UseVisualStyleBackColor = true;
            this.VjerojatnostButton.Click += new System.EventHandler(this.VjerojatnostButton_Click);
            // 
            // OzbiljnostButton
            // 
            this.OzbiljnostButton.Location = new System.Drawing.Point(66, 1);
            this.OzbiljnostButton.Name = "OzbiljnostButton";
            this.OzbiljnostButton.Size = new System.Drawing.Size(100, 45);
            this.OzbiljnostButton.TabIndex = 14;
            this.OzbiljnostButton.Text = "Ozbiljnost";
            this.OzbiljnostButton.UseVisualStyleBackColor = true;
            this.OzbiljnostButton.Click += new System.EventHandler(this.OzbiljnostButton_Click);
            // 
            // matrix1
            // 
            this.matrix1.Location = new System.Drawing.Point(307, 146);
            this.matrix1.Margin = new System.Windows.Forms.Padding(0);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(835, 678);
            this.matrix1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.panel1);
            this.Name = "GlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GlavniIzbornik_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Forms.Matrix.Matrix matrix1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button VjerojatnostButton;
        private System.Windows.Forms.Button OzbiljnostButton;
        private FormItems.OzbiljnostPanel.OzbiljnostPanel ozbiljnostPanel1;
        private FormItems.VjerojatnostPanel.VjerojatnostPanel vjerojatnostPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

