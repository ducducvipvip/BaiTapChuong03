namespace BaiTapChuong03
{
    partial class TurnOnForm
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
            clientBtn = new Button();
            serverBtn = new Button();
            SuspendLayout();
            // 
            // clientBtn
            // 
            clientBtn.Location = new Point(162, 147);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(146, 66);
            clientBtn.TabIndex = 0;
            clientBtn.Text = "Client";
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click_1;
            // 
            // serverBtn
            // 
            serverBtn.Location = new Point(470, 146);
            serverBtn.Name = "serverBtn";
            serverBtn.Size = new Size(146, 67);
            serverBtn.TabIndex = 1;
            serverBtn.Text = "Server";
            serverBtn.UseVisualStyleBackColor = true;
            serverBtn.Click += serverBtn_Click_1;
            // 
            // TurnOnForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(serverBtn);
            Controls.Add(clientBtn);
            Name = "TurnOnForm";
            Text = "TurnOnForm";
           
            ResumeLayout(false);
        }

        #endregion

        private Button clientBtn;
        private Button serverBtn;
    }
}