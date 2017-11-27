using System;
using System.IO;

namespace SIT323_Project02
{
    class LogFile
    {

        public static void WriteLogFile(string input)
        {
            //define path
            string fname = Directory.GetCurrentDirectory() + "\\LogFile.txt";

            //define
            FileInfo finfo = new FileInfo(fname);

            if (!finfo.Exists)
            {
                FileStream fs;
                fs = File.Create(fname);
                fs.Close();
                finfo = new FileInfo(fname);
            }

            //check if over 2k
            if (finfo.Length > 1024 * 1024 * 10)
            {
                //rename when over 10mb
                File.Move(Directory.GetCurrentDirectory() + "\\LogFile.txt", Directory.GetCurrentDirectory() + DateTime.Now.TimeOfDay + "\\LogFile.txt");
                //delect file
                //finfo.Delete();
            }
            //finfo.AppendText();
            //create file

            using (FileStream fs = finfo.OpenWrite())
            {
                //write data steam
                StreamWriter w = new StreamWriter(fs);

                //Set the start position
                w.BaseStream.Seek(0, SeekOrigin.End);

                //Log Entry : 
                w.Write("\n\rLog Entry : ");

                //system date
                w.Write("{0} {1} \n\r", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());

                // write log and change line
                w.Write(input + "\n\r");

                //write log and change line
                w.Write("========\n\r");

                ///clean crash
                w.Flush();
                w.Close();
            }

        }

        public static void WriteErrorFile(string input)
        {
            //define path
            string fname = Directory.GetCurrentDirectory() + "\\ErrorFile.txt";

            //define
            FileInfo finfo = new FileInfo(fname);

            if (!finfo.Exists)
            {
                FileStream fs;
                fs = File.Create(fname);
                fs.Close();
                finfo = new FileInfo(fname);
            }

            //check if over 2k
            if (finfo.Length > 1024 * 1024 * 10)
            {
                //rename when over 10mb
                File.Move(Directory.GetCurrentDirectory() + "\\ErrorFile.txt", Directory.GetCurrentDirectory() + DateTime.Now.TimeOfDay + "\\ErrorFile.txt");
                //delect file
                //finfo.Delete();
            }

            //finfo.AppendText();
            //create file
            using (FileStream fs = finfo.OpenWrite())
            {
                //write data steam
                StreamWriter w = new StreamWriter(fs);

                //Set the start position
                w.BaseStream.Seek(0, SeekOrigin.End);

                //Log Entry : 
                w.Write("\n\rErrorFile Entry : ");

                //system date
                w.Write("{0} {1} \n\r", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());

                // write log and change line
                w.Write(input + "\n\r");

                //write log and change line
                w.Write("========\n\r");

                ///clean crash
                w.Flush();
                w.Close();
            }

            //// write in error list 
            //DataLoad.EL.Add(new ErrorList(input, " ======== " + DateTime.Now.ToString()));

        }
    }
}
