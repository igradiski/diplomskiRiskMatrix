
namespace RiskMatrixTool.Forms.OzbVjeInputForm
{
    partial class OzbVjeInputForm
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
            this.MagnitudaLabel = new System.Windows.Forms.Label();
            this.MagnitudaText = new System.Windows.Forms.TextBox();
            this.TrosakPojavaLabel = new System.Windows.Forms.Label();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.TrosakPojavaTextBox = new System.Windows.Forms.RichTextBox();
            this.OpisTextBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MagnitudaLabel
            // 
            this.MagnitudaLabel.AutoSize = true;
            this.MagnitudaLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MagnitudaLabel.Location = new System.Drawing.Point(12, 48);
            this.MagnitudaLabel.Name = "MagnitudaLabel";
            this.MagnitudaLabel.Size = new System.Drawing.Size(122, 30);
            this.MagnitudaLabel.TabIndex = 0;
            this.MagnitudaLabel.Text = "Magnituda:";
            // 
            // MagnitudaText
            // 
            this.MagnitudaText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MagnitudaText.Location = new System.Drawing.Point(267, 45);
            this.MagnitudaText.Name = "MagnitudaText";
            this.MagnitudaText.Size = new System.Drawing.Size(100, 36);
            this.MagnitudaText.TabIndex = 1;
            // 
            // TrosakPojavaLabel
            // 
            this.TrosakPojavaLabel.AutoSize = true;
            this.TrosakPojavaLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrosakPojavaLabel.Location = new System.Drawing.Point(12, 105);
            this.TrosakPojavaLabel.Name = "TrosakPojavaLabel";
            this.TrosakPojavaLabel.Size = new System.Drawing.Size(193, 30);
            this.TrosakPojavaLabel.TabIndex = 2;
            this.TrosakPojavaLabel.Text = "TrosakPojavaLabel:";
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpisLabel.Location = new System.Drawing.Point(12, 232);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(62, 30);
            this.OpisLabel.TabIndex = 3;
            this.OpisLabel.Text = "Opis:";
            // 
            // TrosakPojavaTextBox
            // 
            this.TrosakPojavaTextBox.Location = new System.Drawing.Point(267, 114);
            this.TrosakPojavaTextBox.Name = "TrosakPojavaTextBox";
            this.TrosakPojavaTextBox.Size = new System.Drawing.Size(347, 96);
            this.TrosakPojavaTextBox.TabIndex = 4;
            this.TrosakPojavaTextBox.Text = "";
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(267, 241);
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(347, 96);
            this.OpisTextBox.TabIndex = 5;
            this.OpisTextBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(267, 377);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 45);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Resetiraj";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(514, 377);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(100, 45);
            this.InputButton.TabIndex = 16;
            this.InputButton.Text = "Unesi";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(602, 210);
            this.dataGridView1.TabIndex = 17;
            // 
            // OzbVjeInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 658);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.TrosakPojavaTextBox);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.TrosakPojavaLabel);
            this.Controls.Add(this.MagnitudaText);
            this.Controls.Add(this.MagnitudaLabel);
            this.Name = "OzbVjeInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos ";
            this.Load += new System.EventHandler(this.OzbVjeInputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MagnitudaLabel;
        private System.Windows.Forms.TextBox MagnitudaText;
        private System.Windows.Forms.Label TrosakPojavaLabel;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.RichTextBox TrosakPojavaTextBox;
        private System.Windows.Forms.RichTextBox OpisTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}