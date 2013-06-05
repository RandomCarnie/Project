

namespace RSATerm
{
    partial class fHome
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbxMsgOut = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbTransmitMsg = new System.Windows.Forms.TextBox();
            this.gbxConfig = new System.Windows.Forms.GroupBox();
            this.btnConfigRSA = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.gbxMsgOut.SuspendLayout();
            this.gbxConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(444, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "Status";
            // 
            // gbxMsgOut
            // 
            this.gbxMsgOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMsgOut.Controls.Add(this.rtbMessages);
            this.gbxMsgOut.Controls.Add(this.btnSend);
            this.gbxMsgOut.Controls.Add(this.tbTransmitMsg);
            this.gbxMsgOut.Location = new System.Drawing.Point(12, 5);
            this.gbxMsgOut.MinimumSize = new System.Drawing.Size(300, 255);
            this.gbxMsgOut.Name = "gbxMsgOut";
            this.gbxMsgOut.Size = new System.Drawing.Size(300, 255);
            this.gbxMsgOut.TabIndex = 2;
            this.gbxMsgOut.TabStop = false;
            this.gbxMsgOut.Text = "Messages:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.CausesValidation = false;
            this.btnSend.Location = new System.Drawing.Point(244, 215);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click +=btnSend_Click;
            // 
            // tbTransmitMsg
            // 
            this.tbTransmitMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTransmitMsg.Location = new System.Drawing.Point(6, 211);
            this.tbTransmitMsg.MaxLength = 256;
            this.tbTransmitMsg.Multiline = true;
            this.tbTransmitMsg.Name = "tbTransmitMsg";
            this.tbTransmitMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTransmitMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTransmitMsg.Size = new System.Drawing.Size(231, 38);
            this.tbTransmitMsg.TabIndex = 1;
            this.tbTransmitMsg.KeyDown +=tbTransmitMsg_KeyDown;
            this.tbTransmitMsg.KeyPress +=tbTransmitMsg_KeyPress;
            // 
            // gbxConfig
            // 
            this.gbxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxConfig.Controls.Add(this.btnConfigRSA);
            this.gbxConfig.Controls.Add(this.btnConnect);
            this.gbxConfig.Location = new System.Drawing.Point(315, 5);
            this.gbxConfig.MinimumSize = new System.Drawing.Size(116, 255);
            this.gbxConfig.Name = "gbxConfig";
            this.gbxConfig.Size = new System.Drawing.Size(116, 255);
            this.gbxConfig.TabIndex = 3;
            this.gbxConfig.TabStop = false;
            this.gbxConfig.Text = "Configuration";
            // 
            // btnConfigRSA
            // 
            this.btnConfigRSA.Enabled = false;
            this.btnConfigRSA.Location = new System.Drawing.Point(9, 79);
            this.btnConfigRSA.Name = "btnConfigRSA";
            this.btnConfigRSA.Size = new System.Drawing.Size(99, 23);
            this.btnConfigRSA.TabIndex = 1;
            this.btnConfigRSA.Text = "Configure RSA...";
            this.btnConfigRSA.UseVisualStyleBackColor = true;
            this.btnConfigRSA.Click += new System.EventHandler(this.btnConfigRSA_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.CausesValidation = false;
            this.btnConnect.Location = new System.Drawing.Point(17, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connection...";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessages.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbMessages.Location = new System.Drawing.Point(7, 20);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMessages.Size = new System.Drawing.Size(288, 186);
            this.rtbMessages.TabIndex = 3;
            this.rtbMessages.Text = "";
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 285);
            this.Controls.Add(this.gbxConfig);
            this.Controls.Add(this.gbxMsgOut);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(460, 323);
            this.Name = "fHome";
            this.Text = "RSATerm";
            this.gbxMsgOut.ResumeLayout(false);
            this.gbxMsgOut.PerformLayout();
            this.gbxConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        bool bLastPostLocalhost = false;
        bool bLastPostRemotehost = false;

        void btnSend_Click(object sender, System.EventArgs e)
        {
            if (tbTransmitMsg.TextLength > 0)
            {
                //lbSentMsgs.Items.Add(tbTransmitMsg.Text);
                //tbMessages.ForeColor = System.Drawing.Color.Blue;   //May change to allow color chooser?
                //tbMessages.Text.Insert(tbMessages.TextLength, "\n\nLocalhost:> ");
                //tbMessages.Text.Insert(tbMessages.TextLength, tbTransmitMsg.Text);
                
                int index = rtbMessages.TextLength;
                if (bLastPostLocalhost)
                {
                    rtbMessages.AppendText("\n\n");
                }
                else
                {
                    if (bLastPostRemotehost)
                    {
                        rtbMessages.AppendText("\n\nLocalhost:> "); //Not the first item posted - need newlines
                    }
                    else
                    {
                        rtbMessages.AppendText("Localhost:> ");     //Must be the first item posted - no need for newlines.
                    }
                    bLastPostRemotehost = false;
                    bLastPostLocalhost = true;
                }
                rtbMessages.AppendText(tbTransmitMsg.Text);
                rtbMessages.Select(index, rtbMessages.TextLength - index);
                rtbMessages.SelectionColor = System.Drawing.Color.Red;
                rtbMessages.Select(rtbMessages.TextLength, 0);      //Clear the selection
                tbTransmitMsg.Clear();
            }
            tbTransmitMsg.Focus();
        }

        private static bool key_isValid = true;

        void tbTransmitMsg_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!key_isValid)
            {
                e.Handled = true;
            }
        }

        void tbTransmitMsg_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            key_isValid = true;
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                key_isValid = false;
                //if (tbTransmitMsg.TextLength > 0)
                //{
                //    lbSentMsgs.Items.Add(tbTransmitMsg.Text);
                //    tbTransmitMsg.Clear();
                //}
                btnSend.PerformClick();
            }
        }


        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbxMsgOut;
        private System.Windows.Forms.GroupBox gbxConfig;
        private System.Windows.Forms.Button btnConfigRSA;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbTransmitMsg;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}

