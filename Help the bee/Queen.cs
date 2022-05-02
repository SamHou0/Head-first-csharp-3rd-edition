﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_the_bee
{
    class Queen
    {
        private int shiftNumber=1;
        private Worker[] workers;
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job,int shifts)
        {
            foreach (Worker worker in workers)
            {
                bool ok = worker.DoThisJob(job, shifts);
                if (ok)
                {
                    return true;//返回后，将不在执行下一个。
                }
            }
            return false;
        }
        public string WorkTheNextShift()
        {
            string returnstring="Report for shift #"+shiftNumber+"\n";
            shiftNumber += 1;
            for (int i = 0; i < workers.Length; i++)
            {
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    returnstring += $"Worker #{i + 1} is not working!\n";
                }
                else
                {
                   bool completed= workers[i].DidYouFinish();
                    if (completed)
                        returnstring += 
                            $"Worker #{i + 1} finished the job!\n";
                    else
                        returnstring +=
                            $"Worker #{i + 1} is doing {workers[i].CurrentJob} for {workers[i].ShiftsLeft} more shifts!\n";

                }
            }
            return returnstring;
        }
    }
}
