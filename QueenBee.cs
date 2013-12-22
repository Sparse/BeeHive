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
                if (wasAbleToWork)
                    break;
            }

            if (wasAbleToWork)
            {
                MessageBox.Show("BINGO!!");
            }
            else MessageBox.Show("FUCK");

            //send pJob and pShifts to bee
            //search for a bee to work, return true if found, false if not
        }

        private void StartShift()
        {

        }
    }
}
