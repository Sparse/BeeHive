using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    public partial class Form1 : Form
    {
        private QueenBee mQueenBee;
        private WorkerBee[] mWorkerBees;

        public Form1()
        {
            InitializeComponent();
            mWorkerBees = new WorkerBee[] 
            { 
                new WorkerBee( new string[] { "Nectar collector", "Honey manufacturing" } ),
                new WorkerBee( new string[] { "Egg care", "Baby bee tutoring" } ),
                new WorkerBee( new string[] { "Hive maintenance", "Sting patrol" } ),
                new WorkerBee( new string[] { "Nectar collector", "Honey manufacturing" } ),
                new WorkerBee( new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" } )
            };
            mQueenBee = new QueenBee(mWorkerBees);
        }

        private void m_AssignJobButton_Click(object sender, EventArgs e)
        {
            mQueenBee.AssignWork(m_JobComboBox.SelectedItem.ToString(), (int)m_ShiftNumberBox.Value);
        }

        private void m_ShiftStartButton_Click(object sender, EventArgs e)
        {
            m_ReportTextBox.Text = mQueenBee.StartShift();
        }
    }
}
