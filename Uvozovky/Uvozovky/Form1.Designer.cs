namespace Uvozovky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dolni = new System.Windows.Forms.NotifyIcon(this.components);
            this.horni = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // dolni
            // 
            this.dolni.Icon = ((System.Drawing.Icon)(resources.GetObject("dolni.Icon")));
            this.dolni.Text = "Začátek";
            this.dolni.Visible = true;
            this.dolni.Click += new System.EventHandler(this.dolni_Click);
            this.dolni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dolni_MouseDoubleClick);
            // 
            // horni
            // 
            this.horni.Icon = ((System.Drawing.Icon)(resources.GetObject("horni.Icon")));
            this.horni.Text = "Konec";
            this.horni.Visible = true;
            this.horni.Click += new System.EventHandler(this.horni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon dolni;
        private System.Windows.Forms.NotifyIcon horni;
    }
}

