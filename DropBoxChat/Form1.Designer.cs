namespace DropBoxChat
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
            this.textChat = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textChat
            // 
            this.textChat.Location = new System.Drawing.Point(12, 12);
            this.textChat.Multiline = true;
            this.textChat.Name = "textChat";
            this.textChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textChat.Size = new System.Drawing.Size(583, 323);
            this.textChat.TabIndex = 0;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(13, 342);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(582, 20);
            this.textInput.TabIndex = 1;
            this.textInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInput_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 369);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.textChat);
            this.Name = "Form1";
            this.Text = "DropBox Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.TextBox textInput;
    }
}

