using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    class QueenBee
    {
        private WorkerBee[] mWorkerBee;
        private int mCurrentShiftNumber;

        public QueenBee(WorkerBee[] pWorkers)
        {
            mWorkerBee = (WorkerBee[])pWorkers.Clone();
        }
        public void AssignWork(string pJob, int pShifts)
        {
            bool wasAbleToWork = false;

            for (int i = 0; i < mWorkerBee.Length; i++)
            {
                wasAbleToWork = mWorkerBee[i].DoJob(pJob, pShifts);
                if (wasAbleToWork == true)
                {
                    MessageBox.Show("Found Bee " + (i + 1).ToString() + " To do the " + pJob + " job!");
                    break;
                }
                else
                    if (i == 4 && wasAbleToWork == false) MessageBox.Show("No bees are avilable to do the work!");
            }
        }

        public string StartShift()
        {
            string workReport = "";

            for (int i = 0; i < mWorkerBee.Length; i++)
            {
                if (mWorkerBee[i].WorkShift()) workReport += "Worker Bee " + (i + 1).ToString() + " finished the task " + mWorkerBee[i].CurrentJob.ToString() + "\r\n";
                if (string.IsNullOrEmpty(mWorkerBee[i].CurrentJob)) workReport += "Worker Bee " + (i + 1).ToString() + " isn't working! \r\n";
                else
                if (mWorkerBee[i].ShiftsLeft > 0) workReport += "Worker Bee " + (i + 1).ToString() + " is doing " + mWorkerBee[i].CurrentJob + " for " + mWorkerBee[i].ShiftsLeft.ToString() + " more shifts\r\n";
                else
                workReport += " Worker Bee " + (i + 1).ToString() + " will be done with " + mWorkerBee[i].CurrentJob + " after this shift\r\n";       
            }
            mCurrentShiftNumber++;
            return "Shift # " + mCurrentShiftNumber.ToString() + " \r\n" + workReport;
        }
    }
}
