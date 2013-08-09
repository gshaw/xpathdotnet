using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Xml;

namespace XPathDesigner {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void XPath_TextChanged(object sender, EventArgs e) {
            UpdateResults();
        }

        private void Xml_TextChanged(object sender, EventArgs e) {
            UpdateResults();
        }

        private void UpdateResults() {
            try {
                StringBuilder s = new StringBuilder();

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Xml.Text);

                XmlElement root = doc.DocumentElement;
                foreach (XmlNode node in root.SelectNodes(XPath.Text)) {
                    s.AppendFormat("<{0}", node.Name);
                    if (node.Attributes != null) {
                        foreach (XmlAttribute attribute in node.Attributes) {
                            s.AppendFormat(" {0}=\"{1}\"", attribute.Name, attribute.Value);
                        }
                    }
                    if (node.InnerText.Length > 0) {
                        s.AppendFormat(">");
                        s.AppendFormat(node.InnerText);
                        s.AppendFormat("</{0}>", node.Name);
                    } else {
                        s.AppendFormat("/>");
                    }

                    s.AppendLine();
                }

                Results.Text = s.ToString();

            } catch (Exception e) {
                Results.Text = String.Format("ERROR: {0}", e.Message);
            }
        }

        private void XPathHelpLink_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.w3schools.com/xpath/xpath_syntax.asp");

        }

        private void HomePageLink_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://organicbit.com");
        }
    }
}