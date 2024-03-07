namespace WhatsAppBotProject
{
    partial class MsgLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessagesQuantityLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.QuantityMessagesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(284, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "WHATSAPP SPAM CHAT BOT";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(29, 188);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(162, 31);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "CONTATOs";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(29, 116);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(171, 31);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "MENSAGEM";
            // 
            // MessagesQuantityLabel
            // 
            this.MessagesQuantityLabel.AutoSize = true;
            this.MessagesQuantityLabel.Location = new System.Drawing.Point(29, 383);
            this.MessagesQuantityLabel.Name = "MessagesQuantityLabel";
            this.MessagesQuantityLabel.Size = new System.Drawing.Size(419, 31);
            this.MessagesQuantityLabel.TabIndex = 1;
            this.MessagesQuantityLabel.Text = "QUANTIDADE DE MENSAGENS";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(216, 109);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(462, 38);
            this.MessageTextBox.TabIndex = 2;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(216, 181);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(462, 38);
            this.ContactTextBox.TabIndex = 2;
            this.ContactTextBox.TextChanged += new System.EventHandler(this.ContactTextBox_TextChanged);
            // 
            // QuantityMessagesTextBox
            // 
            this.QuantityMessagesTextBox.Location = new System.Drawing.Point(477, 376);
            this.QuantityMessagesTextBox.Name = "QuantityMessagesTextBox";
            this.QuantityMessagesTextBox.Size = new System.Drawing.Size(201, 38);
            this.QuantityMessagesTextBox.TabIndex = 2;
            this.QuantityMessagesTextBox.TextChanged += new System.EventHandler(this.QuantityMessagesTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(738, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 182);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXECUTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(738, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 182);
            this.button2.TabIndex = 4;
            this.button2.Text = "PARAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(35, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(643, 89);
            this.button3.TabIndex = 5;
            this.button3.Text = "ADICIONAR NA LISTA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MsgLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(992, 635);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityMessagesTextBox);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessagesQuantityLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MsgLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label MessagesQuantityLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox QuantityMessagesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

