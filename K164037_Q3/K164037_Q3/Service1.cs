using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.Net.Configuration;


namespace K164037_Q3
{
    public partial class Service1 : ServiceBase
    {
        private readonly Timer _timer;
        public Service1()
        {
            InitializeComponent();
            _timer = new Timer(900000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;

        }
        public void set_time()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(EmailMessage));
            EmailMessage sender = new EmailMessage();

            string path = ConfigurationManager.AppSettings["path"];
            string FileName="";
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo fi in di.GetFiles())
            {
                var firstFileName = di.EnumerateFiles()
                      .Select(f => f.Name)
                      .FirstOrDefault();
                Console.WriteLine(firstFileName);
                FileName = firstFileName.ToString();
            }
            FileStream senderFile = new FileStream(path+FileName, FileMode.Open, FileAccess.Read);
            sender = (EmailMessage)deserializer.Deserialize(senderFile);
            Console.WriteLine(sender.To);
            Console.WriteLine(sender.MessageBody);
            senderFile.Close();
            File.Delete(path + FileName);


        }
         public void TimerElapsed(object sender, ElapsedEventArgs e)
         {
             IFormatter formatter = new BinaryFormatter();
             XmlSerializer deserializer = new XmlSerializer(typeof(EmailMessage));
             EmailMessage senderDetail = new EmailMessage();
            // Email emailsender;
             var user = ConfigurationManager.AppSettings["smtpUser"];
             var password = ConfigurationManager.AppSettings["smtpPass"];
             var path = ConfigurationManager.AppSettings["path"];

            DirectoryInfo di = new DirectoryInfo(path);
            string FileName = "";
            foreach (FileInfo fi in di.GetFiles())
            {
                var firstFileName = di.EnumerateFiles()
                      .Select(f => f.Name)
                      .FirstOrDefault();
                Console.WriteLine(firstFileName);
                FileName = firstFileName.ToString();
            }
            FileStream senderFile = new FileStream(path + FileName, FileMode.Open, FileAccess.Read);
            senderDetail = (EmailMessage)deserializer.Deserialize(senderFile);

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com",587);
             SmtpServer.Credentials = new System.Net.NetworkCredential(user,password);
             SmtpServer.EnableSsl = true;
             SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
             SmtpServer.Timeout = 10000;
             SmtpServer.UseDefaultCredentials = false;
 
             MailMessage mail = new MailMessage();
             mail.From = new MailAddress(user);
             mail.To.Add(senderDetail.To);
             mail.Subject = senderDetail.Subject;
             mail.Body = senderDetail.MessageBody;


             try
             {
                 SmtpServer.Send(mail);
             }
             catch(Exception exp)
             {
                 string error = exp.ToString();
                 using (StreamWriter file = File.AppendText(path+"error.txt"))
                 {
                     file.WriteLine(error);
                 }

             }
            senderFile.Close();
            File.Delete(path + FileName);


        }

        protected override void OnStart(string[] args)
        {
            _timer.Start();

        }

        protected override void OnStop()
        {
            _timer.Stop();
        }
    }

    public class EmailMessage
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
    }
}
