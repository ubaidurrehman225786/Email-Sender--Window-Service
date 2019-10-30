namespace K164037_Q2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.to = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.subject = new System.Windows.Forms.GroupBox();
            this.subjecttext = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.GroupBox();
            this.messagetext = new System.Windows.Forms.RichTextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.to.SuspendLayout();
            this.subject.SuspendLayout();
            this.message.SuspendLayout();
            this.SuspendLayout();
            // 
            // to
            // 
            this.to.Controls.Add(this.email);
            this.to.Location = new System.Drawing.Point(12, 12);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(554, 50);
            this.to.TabIndex = 0;
            this.to.TabStop = false;
            this.to.Text = "To";
            this.to.Enter += new System.EventHandler(this.to_Enter);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(6, 16);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(542, 20);
            this.email.TabIndex = 0;
            // 
            // subject
            // 
            this.subject.Controls.Add(this.subjecttext);
            this.subject.Location = new System.Drawing.Point(12, 80);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(554, 74);
            this.subject.TabIndex = 1;
            this.subject.TabStop = false;
            this.subject.Text = "Subject";
            // 
            // subjecttext
            // 
            this.subjecttext.Location = new System.Drawing.Point(6, 16);
            this.subjecttext.Name = "subjecttext";
            this.subjecttext.Size = new System.Drawing.Size(542, 52);
            this.subjecttext.TabIndex = 0;
            this.subjecttext.Text = "";
            // 
            // message
            // 
            this.message.Controls.Add(this.messagetext);
            this.message.Location = new System.Drawing.Point(12, 174);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(554, 266);
            this.message.TabIndex = 2;
            this.message.TabStop = false;
            this.message.Text = "Message";
            // 
            // messagetext
            // 
            this.messagetext.Location = new System.Drawing.Point(6, 19);
            this.messagetext.Name = "messagetext";
            this.messagetext.Size = new System.Drawing.Size(542, 231);
            this.messagetext.TabIndex = 0;
            this.messagetext.Text = "";
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(233, 487);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "SEND";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 522);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.message);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.to);
            this.Name = "Form1";
            this.Text = "Email Composer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.to.ResumeLayout(false);
            this.to.PerformLayout();
            this.subject.ResumeLayout(false);
            this.message.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox to;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.GroupBox subject;
        private System.Windows.Forms.RichTextBox subjecttext;
        private System.Windows.Forms.GroupBox message;
        private System.Windows.Forms.RichTextBox messagetext;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

