using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Net.Mail;
using System.Net;
using System.Net.Configuration;

namespace K164037_Q2
{
    public partial class Form1 : Form
    {
        string sub,mail,msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void to_Enter(object sender, EventArgs e)
        {
             mail = email.Text;
            
        }
        private void subject_Enter(object sender, EventArgs e)
        {
             sub = subjecttext.Text;
            
        }
        private void message_Enter(object sender, EventArgs e)
        {
            msg = messagetext.Text;
            
        }


        private void btnsend_Click(object sender, EventArgs e)
        {
            EmailMessage mailDetail = new EmailMessage();
            mailDetail.To = email.Text;
            mailDetail.Subject = subjecttext.Text;
            mailDetail.MessageBody = messagetext.Text;
            string filename = mailDetail.To + mailDetail.Subject + mailDetail.MessageBody;
            XmlSerializer serializer = new XmlSerializer(typeof(EmailMessage));
            string path = ConfigurationManager.AppSettings["path"];
            using (FileStream fs = new FileStream(path+filename+".xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, mailDetail);
                MessageBox.Show("File Created Successfully");
                
            }
            string[] lines = File.ReadAllLines(path+"log_file.txt");
            int check = 0;
            
            for (int i = 0; i < lines.Count(); i++)
            {
                
                if (string.Equals(filename,lines[i])==true)
                {
                    check++;
                    
                }
            }
            if (check == 0)
            {
                using (StreamWriter log_file = File.AppendText(path+"log_file.txt"))
                {

                    log_file.WriteLine(filename);

                }
            }

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        
    }
}
