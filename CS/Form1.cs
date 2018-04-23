using System;
using System.Windows.Forms;
using DevExpress.Utils.Commands;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;

namespace RichHeaderTable {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            richEditControl1.BeginUpdate();

            RichEditCommand command = richEditControl1.CreateCommand(RichEditCommandId.EditPageHeader);
            command.Execute();

            command = new CustomInsertTableCommand(richEditControl1, 2, 3);
            command.ForceExecute(command.CreateDefaultCommandUIState());

            command = richEditControl1.CreateCommand(RichEditCommandId.ClosePageHeaderFooter);
            command.Execute();

            richEditControl1.EndUpdate();
        }
    }

    public class CustomInsertTableCommand : InsertTableCommand {
        private int rowCount;
        private int columnCount;

        public CustomInsertTableCommand(IRichEditControl control, int rowCount, int columnCount)
            : base(control) {
            
            this.rowCount = rowCount;
            this.columnCount = columnCount;
        }

        public override void ForceExecute(ICommandUIState state) {
            ShowInsertTableFormCallback(new CreateTableParameters(this.rowCount, this.columnCount), state);
        }
    }

}