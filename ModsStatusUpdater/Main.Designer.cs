namespace ModsStatusUpdater
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbdis = new System.Windows.Forms.CheckBox();
            this.lkjson = new System.Windows.Forms.CheckBox();
            this.delmods = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mod Operations";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbdis);
            this.flowLayoutPanel1.Controls.Add(this.lkjson);
            this.flowLayoutPanel1.Controls.Add(this.delmods);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 90);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(80, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(341, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/gregstein/ModsStatusUpdater";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Github:";
            // 
            // cbdis
            // 
            this.cbdis.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.cbdis, true);
            this.cbdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdis.Location = new System.Drawing.Point(3, 3);
            this.cbdis.Name = "cbdis";
            this.cbdis.Size = new System.Drawing.Size(145, 24);
            this.cbdis.TabIndex = 4;
            this.cbdis.Text = "Disable All Mods";
            this.cbdis.UseVisualStyleBackColor = true;
            this.cbdis.CheckedChanged += new System.EventHandler(this.cbdis_CheckedChanged);
            // 
            // lkjson
            // 
            this.lkjson.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lkjson, true);
            this.lkjson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkjson.Location = new System.Drawing.Point(3, 33);
            this.lkjson.Name = "lkjson";
            this.lkjson.Size = new System.Drawing.Size(191, 24);
            this.lkjson.TabIndex = 5;
            this.lkjson.Text = "Lock \"mod-status.json\"";
            this.lkjson.UseVisualStyleBackColor = true;
            this.lkjson.CheckedChanged += new System.EventHandler(this.lkjson_CheckedChanged);
            // 
            // delmods
            // 
            this.delmods.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.delmods, true);
            this.delmods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delmods.Location = new System.Drawing.Point(3, 63);
            this.delmods.Name = "delmods";
            this.delmods.Size = new System.Drawing.Size(205, 24);
            this.delmods.TabIndex = 6;
            this.delmods.Text = "Delete Mods (All Profiles)";
            this.delmods.UseVisualStyleBackColor = true;
            this.delmods.CheckedChanged += new System.EventHandler(this.delmods_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(376, 59);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "This tool will help you debug Age of Empires 2 DE that fails to launch by disabli" +
    "ng/locking all mods. Or Deleting all mods across different profiles.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 232);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(465, 271);
            this.MinimumSize = new System.Drawing.Size(465, 271);
            this.Name = "Main";
            this.Text = "Mods Status Updater (By GregStein)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbdis;
        private System.Windows.Forms.CheckBox lkjson;
        private System.Windows.Forms.CheckBox delmods;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

