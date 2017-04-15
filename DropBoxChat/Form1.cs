using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DropBoxChat
{
    public partial class Form1 : Form
    {
        delegate void TextForChat(string text);

        public Form1()
        {
            InitializeComponent();
            textChat.ReadOnly = true;
            //ThreadStart readChat = new ThreadStart(ReadChatFile);
            
            Task readChat = Task.Run(() => ReadChatFile());

            
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetChat(string text)
        {
            if (this.textChat.InvokeRequired)
            {
                TextForChat t = new TextForChat(SetChat);
                this.Invoke(t, new object[] { text });
            }
            else
            {
                textChat.Text = text;
            }
        }

        private void textInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) {
                //textChat.Text += textInput.Text + Environment.NewLine;
                using (StreamWriter file = File.AppendText(@"chat.txt"))
                    file.WriteLine(Environment.UserName + ": " + textInput.Text);
                    textInput.Clear();
                }
        }
        
        public void ReadChatFile()
        {

            //this.SetChat("test");
            while (true)
                {
                string text = System.IO.File.ReadAllText(@"chat.txt");
                this.SetChat(text);
                Thread.Sleep(2000);
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
