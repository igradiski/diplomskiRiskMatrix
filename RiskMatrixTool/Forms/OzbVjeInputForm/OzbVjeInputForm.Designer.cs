
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OzbVjeInputForm));
            this.MagnitudaLabel = new System.Windows.Forms.Label();
            this.TrosakPojavaLabel = new System.Windows.Forms.Label();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.TrosakPojavaTextBox = new System.Windows.Forms.RichTextBox();
            this.OpisTextBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.VjerojatnostOzbiljnostData = new System.Windows.Forms.DataGridView();
            this.BrisiButton = new System.Windows.Forms.Button();
            this.MagnitudaCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VjerojatnostOzbiljnostData)).BeginInit();
            this.SuspendLayout();
            // 
            // MagnitudaLabel
            // 
            this.MagnitudaLabel.AutoSize = true;
            this.MagnitudaLabel.BackColor = System.Drawing.Color.Transparent;
            this.MagnitudaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MagnitudaLabel.Location = new System.Drawing.Point(12, 17);
            this.MagnitudaLabel.Name = "MagnitudaLabel";
            this.MagnitudaLabel.Size = new System.Drawing.Size(127, 30);
            this.MagnitudaLabel.TabIndex = 0;
            this.MagnitudaLabel.Text = "Magnituda:";
            // 
            // TrosakPojavaLabel
            // 
            this.TrosakPojavaLabel.AutoSize = true;
            this.TrosakPojavaLabel.BackColor = System.Drawing.Color.Transparent;
            this.TrosakPojavaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrosakPojavaLabel.Location = new System.Drawing.Point(12, 74);
            this.TrosakPojavaLabel.Name = "TrosakPojavaLabel";
            this.TrosakPojavaLabel.Size = new System.Drawing.Size(198, 30);
            this.TrosakPojavaLabel.TabIndex = 2;
            this.TrosakPojavaLabel.Text = "TrosakPojavaLabel:";
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpisLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpisLabel.Location = new System.Drawing.Point(12, 131);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(63, 30);
            this.OpisLabel.TabIndex = 3;
            this.OpisLabel.Text = "Opis:";
            // 
            // TrosakPojavaTextBox
            // 
            this.TrosakPojavaTextBox.BackColor = System.Drawing.Color.Silver;
            this.TrosakPojavaTextBox.Location = new System.Drawing.Point(267, 83);
            this.TrosakPojavaTextBox.Name = "TrosakPojavaTextBox";
            this.TrosakPojavaTextBox.Size = new System.Drawing.Size(347, 31);
            this.TrosakPojavaTextBox.TabIndex = 4;
            this.TrosakPojavaTextBox.Text = "";
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.BackColor = System.Drawing.Color.Silver;
            this.OpisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpisTextBox.Location = new System.Drawing.Point(267, 140);
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(347, 96);
            this.OpisTextBox.TabIndex = 5;
            this.OpisTextBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(267, 252);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 45);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Resetiraj";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputButton.Location = new System.Drawing.Point(514, 252);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(100, 45);
            this.InputButton.TabIndex = 16;
            this.InputButton.Text = "Unesi";
            this.InputButton.UseVisualStyleBackColor = false;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // VjerojatnostOzbiljnostData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VjerojatnostOzbiljnostData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VjerojatnostOzbiljnostData.BackgroundColor = System.Drawing.Color.Silver;
            this.VjerojatnostOzbiljnostData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VjerojatnostOzbiljnostData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VjerojatnostOzbiljnostData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VjerojatnostOzbiljnostData.DefaultCellStyle = dataGridViewCellStyle3;
            this.VjerojatnostOzbiljnostData.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.VjerojatnostOzbiljnostData.Location = new System.Drawing.Point(16, 303);
            this.VjerojatnostOzbiljnostData.Name = "VjerojatnostOzbiljnostData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VjerojatnostOzbiljnostData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.VjerojatnostOzbiljnostData.RowHeadersWidth = 10;
            this.VjerojatnostOzbiljnostData.RowTemplate.Height = 25;
            this.VjerojatnostOzbiljnostData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VjerojatnostOzbiljnostData.Size = new System.Drawing.Size(602, 180);
            this.VjerojatnostOzbiljnostData.TabIndex = 17;
            // 
            // BrisiButton
            // 
            this.BrisiButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BrisiButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BrisiButton.Location = new System.Drawing.Point(518, 489);
            this.BrisiButton.Name = "BrisiButton";
            this.BrisiButton.Size = new System.Drawing.Size(100, 45);
            this.BrisiButton.TabIndex = 18;
            this.BrisiButton.Text = "Obrisi";
            this.BrisiButton.UseVisualStyleBackColor = false;
            this.BrisiButton.Click += new System.EventHandler(this.BrisiButton_Click);
            // 
            // MagnitudaCombo
            // 
            this.MagnitudaCombo.BackColor = System.Drawing.Color.Silver;
            this.MagnitudaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MagnitudaCombo.FormattingEnabled = true;
            this.MagnitudaCombo.Location = new System.Drawing.Point(267, 18);
            this.MagnitudaCombo.Name = "MagnitudaCombo";
            this.MagnitudaCombo.Size = new System.Drawing.Size(121, 29);
            this.MagnitudaCombo.TabIndex = 19;
            // 
            // OzbVjeInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 547);
            this.Controls.Add(this.MagnitudaCombo);
            this.Controls.Add(this.BrisiButton);
            this.Controls.Add(this.VjerojatnostOzbiljnostData);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.TrosakPojavaTextBox);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.TrosakPojavaLabel);
            this.Controls.Add(this.MagnitudaLabel);
            this.Name = "OzbVjeInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos magnituda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OzbVjeInputForm_FormClosing);
            this.Load += new System.EventHandler(this.OzbVjeInputForm_Load);
            this.Leave += new System.EventHandler(this.OzbVjeInputForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.VjerojatnostOzbiljnostData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MagnitudaLabel;
        private System.Windows.Forms.Label TrosakPojavaLabel;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.RichTextBox TrosakPojavaTextBox;
        private System.Windows.Forms.RichTextBox OpisTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.DataGridView VjerojatnostOzbiljnostData;
        private System.Windows.Forms.Button BrisiButton;
        private System.Windows.Forms.ComboBox MagnitudaCombo;
    }
}