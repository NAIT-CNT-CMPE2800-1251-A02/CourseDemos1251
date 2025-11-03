namespace Server
{
    partial class Server
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
            UI_B_SendData = new Button();
            SuspendLayout();
            // 
            // UI_B_SendData
            // 
            UI_B_SendData.Location = new Point(453, 92);
            UI_B_SendData.Name = "UI_B_SendData";
            UI_B_SendData.Size = new Size(75, 23);
            UI_B_SendData.TabIndex = 0;
            UI_B_SendData.Text = "Send Data";
            UI_B_SendData.UseVisualStyleBackColor = true;
            UI_B_SendData.Click += UI_B_SendData_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UI_B_SendData);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button UI_B_SendData;
    }
}
