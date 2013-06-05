namespace RSATerm
{
    partial class fRSAConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLocalP = new System.Windows.Forms.TextBox();
            this.tbLocalQ = new System.Windows.Forms.TextBox();
            this.tbLocalPrivate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExchangeKeys = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRemoteQ = new System.Windows.Forms.TextBox();
            this.tbRemoteP = new System.Windows.Forms.TextBox();
            this.btnRSAConfigOK = new System.Windows.Forms.Button();
            this.btnRSAConfigCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateKeys);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLocalPrivate);
            this.groupBox1.Controls.Add(this.tbLocalQ);
            this.groupBox1.Controls.Add(this.tbLocalP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Keys:";
            // 
            // tbLocalP
            // 
            this.tbLocalP.Location = new System.Drawing.Point(62, 25);
            this.tbLocalP.Name = "tbLocalP";
            this.tbLocalP.ReadOnly = true;
            this.tbLocalP.Size = new System.Drawing.Size(447, 20);
            this.tbLocalP.TabIndex = 0;
            // 
            // tbLocalQ
            // 
            this.tbLocalQ.Location = new System.Drawing.Point(62, 51);
            this.tbLocalQ.Name = "tbLocalQ";
            this.tbLocalQ.ReadOnly = true;
            this.tbLocalQ.Size = new System.Drawing.Size(447, 20);
            this.tbLocalQ.TabIndex = 1;
            // 
            // tbLocalPrivate
            // 
            this.tbLocalPrivate.Location = new System.Drawing.Point(62, 93);
            this.tbLocalPrivate.Name = "tbLocalPrivate";
            this.tbLocalPrivate.ReadOnly = true;
            this.tbLocalPrivate.Size = new System.Drawing.Size(447, 20);
            this.tbLocalPrivate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "P:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Private:";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(544, 51);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(96, 23);
            this.btnGenerateKeys.TabIndex = 6;
            this.btnGenerateKeys.Text = "Generate Keys...";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExchangeKeys);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbRemoteQ);
            this.groupBox2.Controls.Add(this.tbRemoteP);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote Keys:";
            // 
            // btnExchangeKeys
            // 
            this.btnExchangeKeys.Location = new System.Drawing.Point(538, 37);
            this.btnExchangeKeys.Name = "btnExchangeKeys";
            this.btnExchangeKeys.Size = new System.Drawing.Size(107, 23);
            this.btnExchangeKeys.TabIndex = 6;
            this.btnExchangeKeys.Text = "Exchange Keys...";
            this.btnExchangeKeys.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Q:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "P:";
            // 
            // tbRemoteQ
            // 
            this.tbRemoteQ.Location = new System.Drawing.Point(62, 51);
            this.tbRemoteQ.Name = "tbRemoteQ";
            this.tbRemoteQ.ReadOnly = true;
            this.tbRemoteQ.Size = new System.Drawing.Size(447, 20);
            this.tbRemoteQ.TabIndex = 1;
            // 
            // tbRemoteP
            // 
            this.tbRemoteP.Location = new System.Drawing.Point(62, 25);
            this.tbRemoteP.Name = "tbRemoteP";
            this.tbRemoteP.ReadOnly = true;
            this.tbRemoteP.Size = new System.Drawing.Size(447, 20);
            this.tbRemoteP.TabIndex = 0;
            // 
            // btnRSAConfigOK
            // 
            this.btnRSAConfigOK.Location = new System.Drawing.Point(521, 239);
            this.btnRSAConfigOK.Name = "btnRSAConfigOK";
            this.btnRSAConfigOK.Size = new System.Drawing.Size(75, 23);
            this.btnRSAConfigOK.TabIndex = 4;
            this.btnRSAConfigOK.Text = "OK";
            this.btnRSAConfigOK.UseVisualStyleBackColor = true;
            // 
            // btnRSAConfigCancel
            // 
            this.btnRSAConfigCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRSAConfigCancel.Location = new System.Drawing.Point(602, 239);
            this.btnRSAConfigCancel.Name = "btnRSAConfigCancel";
            this.btnRSAConfigCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRSAConfigCancel.TabIndex = 5;
            this.btnRSAConfigCancel.Text = "Cancel";
            this.btnRSAConfigCancel.UseVisualStyleBackColor = true;
            // 
            // fRSAConfig
            // 
            this.AcceptButton = this.btnRSAConfigOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRSAConfigCancel;
            this.ClientSize = new System.Drawing.Size(689, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnRSAConfigCancel);
            this.Controls.Add(this.btnRSAConfigOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(705, 312);
            this.MinimumSize = new System.Drawing.Size(705, 312);
            this.Name = "fRSAConfig";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RSA Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLocalPrivate;
        private System.Windows.Forms.TextBox tbLocalQ;
        private System.Windows.Forms.TextBox tbLocalP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExchangeKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRemoteQ;
        private System.Windows.Forms.TextBox tbRemoteP;
        private System.Windows.Forms.Button btnRSAConfigOK;
        private System.Windows.Forms.Button btnRSAConfigCancel;

    }
}