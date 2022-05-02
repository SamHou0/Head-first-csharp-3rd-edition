using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_the_bee
{
    class Worker
    {
        private string currentJob = "";
        public string CurrentJob { get { return currentJob; } }
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }
        string[] jobsICanDo;
        int shiftsToWork;
        int shiftsWorked;
        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }
        public bool DoThisJob(string work, int requireTime)
        {
            if (string.IsNullOrEmpty(CurrentJob))
            {
                for (int i = 0; i < jobsICanDo.Length; i++)
                {
                    if (jobsICanDo[i] == work)
                    {
                        shiftsWorked = 0;
                        currentJob = work;
                        shiftsToWork = requireTime;
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (ShiftsLeft == 0)
            {
                currentJob = "";
                shiftsToWork = 0;
                shiftsWorked = 0;
                return true;
            }
            else return false;
        }
    }
}
