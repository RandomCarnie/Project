namespace RSATerm
{
    partial class fSerialConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFlowControlNone = new System.Windows.Forms.RadioButton();
            this.rbFlowControlHardware = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSerialConfigOK = new System.Windows.Forms.Button();
            this.btnSerialConfigCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Device:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Properties:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(6, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 52);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Bits:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(168, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Two Stop Bits";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One Stop Bit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFlowControlNone);
            this.groupBox2.Controls.Add(this.rbFlowControlHardware);
            this.groupBox2.Location = new System.Drawing.Point(6, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flow Control:";
            // 
            // rbFlowControlNone
            // 
            this.rbFlowControlNone.AutoSize = true;
            this.rbFlowControlNone.Checked = true;
            this.rbFlowControlNone.Location = new System.Drawing.Point(168, 19);
            this.rbFlowControlNone.Name = "rbFlowControlNone";
            this.rbFlowControlNone.Size = new System.Drawing.Size(51, 17);
            this.rbFlowControlNone.TabIndex = 1;
            this.rbFlowControlNone.TabStop = true;
            this.rbFlowControlNone.Text = "None";
            this.rbFlowControlNone.UseVisualStyleBackColor = true;
            // 
            // rbFlowControlHardware
            // 
            this.rbFlowControlHardware.AutoSize = true;
            this.rbFlowControlHardware.Location = new System.Drawing.Point(22, 19);
            this.rbFlowControlHardware.Name = "rbFlowControlHardware";
            this.rbFlowControlHardware.Size = new System.Drawing.Size(71, 17);
            this.rbFlowControlHardware.TabIndex = 0;
            this.rbFlowControlHardware.TabStop = true;
            this.rbFlowControlHardware.Text = "Hardware";
            this.rbFlowControlHardware.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Symbol Rate:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(81, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // btnSerialConfigOK
            // 
            this.btnSerialConfigOK.Location = new System.Drawing.Point(12, 227);
            this.btnSerialConfigOK.Name = "btnSerialConfigOK";
            this.btnSerialConfigOK.Size = new System.Drawing.Size(75, 23);
            this.btnSerialConfigOK.TabIndex = 3;
            this.btnSerialConfigOK.Text = "Connect";
            this.btnSerialConfigOK.UseVisualStyleBackColor = true;
            // 
            // btnSerialConfigCancel
            // 
            this.btnSerialConfigCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialConfigCancel.Location = new System.Drawing.Point(222, 227);
            this.btnSerialConfigCancel.Name = "btnSerialConfigCancel";
            this.btnSerialConfigCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSerialConfigCancel.TabIndex = 4;
            this.btnSerialConfigCancel.Text = "Cancel";
            this.btnSerialConfigCancel.UseVisualStyleBackColor = true;
            // 
            // fSerialConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSerialConfigCancel;
            this.ClientSize = new System.Drawing.Size(309, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnSerialConfigCancel);
            this.Controls.Add(this.btnSerialConfigOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 300);
            this.Name = "fSerialConfig";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Serial Configuration...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFlowControlNone;
        private System.Windows.Forms.RadioButton rbFlowControlHardware;
        private System.Windows.Forms.Button btnSerialConfigOK;
        private System.Windows.Forms.Button btnSerialConfigCancel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}