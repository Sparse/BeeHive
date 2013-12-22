using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
    class WorkerBee
    {
        private string mCurrentJob;
        public string CurrentJob { get { return mCurrentJob; } }

        private int mShiftsLeft;
        public int ShiftsLeft { get { return mShiftsLeft; } }
        
        private int mShiftsToWork;
        private int mShiftsWorked;
        private string[] mCapableJobs;

        public WorkerBee(string[] pCapableJobs)
        {
            mCapableJobs = (string[])pCapableJobs.Clone();
        }

        public bool DoJob(string pJob, int pShifts)
        {
            bool canWorkJob = false;
            for (int i = 0; i < mCapableJobs.Length; i++)
			{
			    if (mCapableJobs[i].Contains(pJob))
	            {
                    mCurrentJob = pJob;
		            mShiftsToWork = pShifts;
                    canWorkJob = true;
                    break;
	            }
                else canWorkJob = false;   
			}
            return canWorkJob;
                    
        }
       
    }
}
