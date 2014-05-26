namespace Instant_Messenger
{
    partial class Connections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connections));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_IPHost = new System.Windows.Forms.TextBox();
            this.textbox_PortHost = new System.Windows.Forms.TextBox();
            this.textbox_IPDest = new System.Windows.Forms.TextBox();
            this.textbox_PortDest = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbox_PortHost);
            this.groupBox1.Controls.Add(this.textbox_IPHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textbox_PortDest);
            this.groupBox2.Controls.Add(this.textbox_IPDest);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP";
            // 
            // textbox_IPHost
            // 
            this.textbox_IPHost.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textbox_IPHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_IPHost.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_IPHost.ForeColor = System.Drawing.Color.White;
            this.textbox_IPHost.Location = new System.Drawing.Point(93, 41);
            this.textbox_IPHost.Name = "textbox_IPHost";
            this.textbox_IPHost.Size = new System.Drawing.Size(308, 23);
            this.textbox_IPHost.TabIndex = 2;
            // 
            // textbox_PortHost
            // 
            this.textbox_PortHost.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textbox_PortHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PortHost.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_PortHost.ForeColor = System.Drawing.Color.White;
            this.textbox_PortHost.Location = new System.Drawing.Point(93, 85);
            this.textbox_PortHost.Name = "textbox_PortHost";
            this.textbox_PortHost.Size = new System.Drawing.Size(308, 23);
            this.textbox_PortHost.TabIndex = 3;
            // 
            // textbox_IPDest
            // 
            this.textbox_IPDest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textbox_IPDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_IPDest.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_IPDest.ForeColor = System.Drawing.Color.White;
            this.textbox_IPDest.Location = new System.Drawing.Point(93, 41);
            this.textbox_IPDest.Name = "textbox_IPDest";
            this.textbox_IPDest.Size = new System.Drawing.Size(308, 23);
            this.textbox_IPDest.TabIndex = 4;
            // 
            // textbox_PortDest
            // 
            this.textbox_PortDest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textbox_PortDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PortDest.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_PortDest.ForeColor = System.Drawing.Color.White;
            this.textbox_PortDest.Location = new System.Drawing.Point(93, 85);
            this.textbox_PortDest.Name = "textbox_PortDest";
            this.textbox_PortDest.Size = new System.Drawing.Size(308, 23);
            this.textbox_PortDest.TabIndex = 5;
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_set.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.Location = new System.Drawing.Point(268, 322);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(118, 37);
            this.btn_set.TabIndex = 2;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(65, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 37);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(451, 376);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connections";
            this.Text = "Connections";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_PortHost;
        private System.Windows.Forms.TextBox textbox_IPHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textbox_PortDest;
        private System.Windows.Forms.TextBox textbox_IPDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_cancel;
    }
}