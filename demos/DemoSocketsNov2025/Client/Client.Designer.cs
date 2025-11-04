namespace Client
{
    partial class Client
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
            UI_B_COnnect = new Button();
            UI_B_Disco = new Button();
            SuspendLayout();
            // 
            // UI_B_COnnect
            // 
            UI_B_COnnect.Location = new Point(397, 102);
            UI_B_COnnect.Name = "UI_B_COnnect";
            UI_B_COnnect.Size = new Size(75, 23);
            UI_B_COnnect.TabIndex = 0;
            UI_B_COnnect.Text = "Connect";
            UI_B_COnnect.UseVisualStyleBackColor = true;
            UI_B_COnnect.Click += UI_B_COnnect_Click;
            // 
            // UI_B_Disco
            // 
            UI_B_Disco.Location = new Point(363, 214);
            UI_B_Disco.Name = "UI_B_Disco";
            UI_B_Disco.Size = new Size(75, 23);
            UI_B_Disco.TabIndex = 1;
            UI_B_Disco.Text = "Disco";
            UI_B_Disco.UseVisualStyleBackColor = true;
            UI_B_Disco.Click += UI_B_Disco_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UI_B_Disco);
            Controls.Add(UI_B_COnnect);
            Name = "Client";
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button UI_B_COnnect;
        private Button UI_B_Disco;
    }
}
