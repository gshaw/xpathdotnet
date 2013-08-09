namespace XPathDesigner {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Xml = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.HomePageLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.XPathHelpLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageLink,
            this.XPathHelpLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(482, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 11);
            this.label1.TabIndex = 2;
            this.label1.Text = "foreach (XmlElement element in root.SelectNodes(xpath))";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "XPath:";
            // 
            // XPath
            // 
            this.XPath.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.XPath.Location = new System.Drawing.Point(57, 9);
            this.XPath.Name = "XPath";
            this.XPath.Size = new System.Drawing.Size(413, 21);
            this.XPath.TabIndex = 4;
            this.XPath.TextChanged += new System.EventHandler(this.XPath_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.XPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 68);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Xml);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Results);
            this.splitContainer1.Size = new System.Drawing.Size(482, 305);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 7;
            // 
            // Xml
            // 
            this.Xml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Xml.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Xml.Location = new System.Drawing.Point(0, 0);
            this.Xml.Multiline = true;
            this.Xml.Name = "Xml";
            this.Xml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Xml.Size = new System.Drawing.Size(482, 112);
            this.Xml.TabIndex = 0;
            this.Xml.TextChanged += new System.EventHandler(this.Xml_TextChanged);
            // 
            // Results
            // 
            this.Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Results.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Results.Location = new System.Drawing.Point(0, 0);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Results.Size = new System.Drawing.Size(482, 189);
            this.Results.TabIndex = 0;
            // 
            // HomePageLink
            // 
            this.HomePageLink.IsLink = true;
            this.HomePageLink.Name = "HomePageLink";
            this.HomePageLink.Size = new System.Drawing.Size(109, 17);
            this.HomePageLink.Text = "http://organicbit.com";
            this.HomePageLink.Click += new System.EventHandler(this.HomePageLink_Click);
            // 
            // XPathHelpLink
            // 
            this.XPathHelpLink.IsLink = true;
            this.XPathHelpLink.Name = "XPathHelpLink";
            this.XPathHelpLink.Size = new System.Drawing.Size(295, 17);
            this.XPathHelpLink.Spring = true;
            this.XPathHelpLink.Text = "XPath Help";
            this.XPathHelpLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XPathHelpLink.Click += new System.EventHandler(this.XPathHelpLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 395);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MinimumSize = new System.Drawing.Size(424, 296);
            this.Name = "MainForm";
            this.Text = "XPath Designer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel HomePageLink;
        private System.Windows.Forms.ToolStripStatusLabel XPathHelpLink;
        private System.Windows.Forms.TextBox Xml;
        private System.Windows.Forms.TextBox Results;
    }
}

