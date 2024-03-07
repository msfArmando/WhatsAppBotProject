using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppBotProject
{
    public partial class MsgLabel : Form
    {
        public static string TextBoxText { get; set; }
        public static string TextBoxContact { get; set; }
        public static List<string> ListContacts { get; set; }
        public static string TextBoxQuantityMessages { get; set; }
        public static WhatsappBot WhatsAppbot => new WhatsappBot();
        public MsgLabel()
        {
            InitializeComponent();
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            string textBoxText = MessageTextBox.Text;
            TextBoxText = textBoxText;
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {
            string textBoxContact = ContactTextBox.Text;
            TextBoxContact = textBoxContact;
        }

        private void QuantityMessagesTextBox_TextChanged(object sender, EventArgs e)
        {
            string textBoxQuantity = QuantityMessagesTextBox.Text;
            TextBoxQuantityMessages = textBoxQuantity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Text = "EXECUTANDO";
            WhatsAppbot.SendMessage(TextBoxText, TextBoxQuantityMessages, ListContacts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            button2.Text = "PAROU";
            WhatsAppbot.StopProcess();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] substrings = TextBoxContact.Split(',');
            ListContacts = new List<string>(substrings);
        }
    }
}
