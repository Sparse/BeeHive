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
			    if (mCapableJobs[i].Contains(pJob) && string.IsNullOrEmpty(mCurrentJob))
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

        public bool WorkShift()
        {
            if (string.IsNullOrEmpty(mCurrentJob)) { return false; }
            else
            {
                mShiftsWorked++;
                mShiftsLeft = (mShiftsToWork - mShiftsWorked);
                if (mShiftsWorked > mShiftsToWork)
                {
                    mShiftsWorked = 0;
                    mShiftsToWork = 0;
                    mCurrentJob = "";
                    return true;
                }
            }
            return false;
        }
       
    }
}
