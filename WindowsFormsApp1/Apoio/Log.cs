﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Apoio
{
    public struct Log
    {
        public DateTime dayLog;


        public void OpenNewTransferLog()
        {
            StringBuilder headerTransfer = new StringBuilder();
            headerTransfer.Append("\n\n\n========== Hora início: ");
            headerTransfer.AppendLine(ReturnCurrentTime());


            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"C:\Users\FelipeN\Desktop\TestFolder\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n\n{headerTransfer.ToString()}");
            }
        }

        public void CloseTransfer(int totalTransf)
        {
            StringBuilder footerTransfer = new StringBuilder();
            footerTransfer.Append("Hora término: ");
            footerTransfer.AppendLine(ReturnCurrentTime());
            footerTransfer.Append("Total transferidos: ");
            footerTransfer.AppendLine(totalTransf.ToString());

            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"C:\Users\FelipeN\Desktop\TestFolder\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n\n{footerTransfer.ToString()}");
            }

        }

        public void RegisterTransfInLog(FileInfo fileTransfer)
        {
            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"C:\Users\FelipeN\Desktop\TestFolder\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n {fileTransfer.Name} - {fileTransfer.Length} bytes :: {ReturnCurrentTime()}");
            }
        }

        public string ReturnDayLog()
        {
            dayLog = DateTime.Now;
            return dayLog.ToString("yyyy-MM-dd");           
        }

        public string ReturnCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}