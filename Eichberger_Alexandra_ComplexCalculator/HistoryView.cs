using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eichberger_Alexandra_ComplexCalculator
{
    public partial class HistoryView : Form
    {
        public HistoryView()
        {
            InitializeComponent();
        }

        private List<ComplexNumber> _listOfResults = new List<ComplexNumber>();
        private int _count = 1;

        public event EventHandler<ComplexNumber> Restore;

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txb_Index, "Please enter the Indexnumber of the result you want restore");
        }

        private void HistoryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void AddCalulation(ComplexNumber numberA, ComplexNumber numberB, 
                                    string calculationOperator, ComplexNumber result)
        {
            tbx_historyList.Multiline = true;
            string newLine = _count + "::" + " (" + numberA.ToString() + ") " + calculationOperator +
                                    " (" + numberB.ToString() + ") " + "= " + result.ToString();
            tbx_historyList.AppendText(newLine);
            tbx_historyList.AppendText(Environment.NewLine);
            _count++;
            _listOfResults.Add(result);
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                // Indexeingabe prüfen
                int index = int.Parse(txb_Index.Text);

                // Prüfen ob Eintrag in Liste
                if (index <= _listOfResults.Count)
                {
                    // Event schicken
                    ComplexNumber numberToRestore = _listOfResults[(index - 1)];
                    Restore?.Invoke(this, numberToRestore);
                }
                else
                {
                    MessageBox.Show("Ausgewählter Datensatz befindet sich nicht in Liste!", "Falscher Datensatz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
               MessageBox.Show("Bitte gib eine Ganzzahl ein.", "Falscher Datentyp!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
