
namespace Jotter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitle = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.buttonaddnote = new System.Windows.Forms.Button();
            this.lblnote = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.lblnotes = new System.Windows.Forms.Label();
            this.listBoxnotes = new System.Windows.Forms.ListBox();
            this.lblnount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(86, 63);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(29, 15);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Title";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(206, 63);
            this.txttitle.Multiline = true;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(195, 23);
            this.txttitle.TabIndex = 1;
            this.txttitle.TextChanged += new System.EventHandler(this.txttitle_TextChanged);
            // 
            // buttonaddnote
            // 
            this.buttonaddnote.Location = new System.Drawing.Point(86, 310);
            this.buttonaddnote.Name = "buttonaddnote";
            this.buttonaddnote.Size = new System.Drawing.Size(75, 23);
            this.buttonaddnote.TabIndex = 2;
            this.buttonaddnote.Text = "Add Note";
            this.buttonaddnote.UseVisualStyleBackColor = true;
            this.buttonaddnote.Click += new System.EventHandler(this.buttonaddnote_Click);
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Location = new System.Drawing.Point(86, 125);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(33, 15);
            this.lblnote.TabIndex = 3;
            this.lblnote.Text = "Note";
            this.lblnote.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(206, 122);
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(195, 147);
            this.txtnote.TabIndex = 4;
            // 
            // lblnotes
            // 
            this.lblnotes.AutoSize = true;
            this.lblnotes.Location = new System.Drawing.Point(467, 63);
            this.lblnotes.Name = "lblnotes";
            this.lblnotes.Size = new System.Drawing.Size(63, 15);
            this.lblnotes.TabIndex = 5;
            this.lblnotes.Text = "Your notes";
            // 
            // listBoxnotes
            // 
            this.listBoxnotes.FormattingEnabled = true;
            this.listBoxnotes.ItemHeight = 15;
            this.listBoxnotes.Location = new System.Drawing.Point(467, 111);
            this.listBoxnotes.Name = "listBoxnotes";
            this.listBoxnotes.Size = new System.Drawing.Size(197, 184);
            this.listBoxnotes.TabIndex = 6;
            // 
            // lblnount
            // 
            this.lblnount.AutoSize = true;
            this.lblnount.Location = new System.Drawing.Point(122, 13);
            this.lblnount.Name = "lblnount";
            this.lblnount.Size = new System.Drawing.Size(0, 15);
            this.lblnount.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnount);
            this.Controls.Add(this.listBoxnotes);
            this.Controls.Add(this.lblnotes);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.buttonaddnote);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lbltitle);
            this.Name = "MainForm";
            this.Text = "Jotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button buttonaddnote;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label lblnotes;
        private System.Windows.Forms.ListBox listBoxnotes;
        private System.Windows.Forms.Label lblnount;
    }
}

