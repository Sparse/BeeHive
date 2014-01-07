using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    class QueenBee : Bee
    {
        private WorkerBee[] mWorkerBee;
        private int mCurrentShiftNumber;
        

        public QueenBee(WorkerBee[] pWorkers) : base(275)
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
            double totalConsumption = 0;
            for (int i = 0; i < mWorkerBee.Length; i++)
            {
                totalConsumption += mWorkerBee[i].GetHoneyConsumption();
            }
            totalConsumption += GetHoneyConsumption();

            string workReport = "Total Honey Consumption: " + totalConsumption.ToString() + " units\r\n";
            
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

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;
            for (int i = 0; i < mWorkerBee.Length; i++) 
            {
                if (mWorkerBee[i].GetHoneyConsumption() > largestWorkerConsumption) largestWorkerConsumption = mWorkerBee[i].GetHoneyConsumption(); 
                /* Will always assign lWC to the first bee, and then will further assign only if it finds a bigger one. This is an attempt
                 * to find the bee consuming the most honey
                 * 
                 */
                if (mWorkerBee[i].ShiftsLeft > 0) workersDoingJobs++; // Self explanitory
            }

            consumption += largestWorkerConsumption; 
            if (workersDoingJobs >= 3) // supplies more  honey if there are 3 or more bees working than if there were less
                consumption += 30;
            else consumption += 20;

            return consumption; //honestly, this is a fucking BORING example of inheritance...but I got through it alright...
        }
    }
}
