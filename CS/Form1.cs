using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;

namespace RichHeaderTable {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Section section = richEditControl1.Document.Sections[0];
            SubDocument subdoc = section.BeginUpdateHeader();
            subdoc.Tables.Add(subdoc.Range.End, 2, 3, AutoFitBehaviorType.AutoFitToWindow);
            section.EndUpdateHeader(subdoc);
        }
    }
}