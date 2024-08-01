namespace Osiloskop
{
    partial class Form1
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
            table = new PictureBox();
            portsBox = new ComboBox();
            connectBtn = new Button();
            disconnectBtn = new Button();
            resultBox = new TextBox();
            pauseBtn = new Button();
            continueBtn = new Button();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // table
            // 
            table.Location = new Point(12, 12);
            table.Name = "table";
            table.Size = new Size(1200, 510);
            table.TabIndex = 0;
            table.TabStop = false;
            // 
            // portsBox
            // 
            portsBox.FormattingEnabled = true;
            portsBox.Location = new Point(1218, 12);
            portsBox.Name = "portsBox";
            portsBox.Size = new Size(196, 28);
            portsBox.TabIndex = 1;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(1218, 46);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(196, 29);
            connectBtn.TabIndex = 2;
            connectBtn.Text = "Bağlan";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Enabled = false;
            disconnectBtn.Location = new Point(1218, 81);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(196, 29);
            disconnectBtn.TabIndex = 3;
            disconnectBtn.Text = "Bağlantıyı Kes";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Location = new Point(1218, 166);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(196, 27);
            resultBox.TabIndex = 4;
            // 
            // pauseBtn
            // 
            pauseBtn.Enabled = false;
            pauseBtn.Location = new Point(1218, 199);
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(196, 29);
            pauseBtn.TabIndex = 5;
            pauseBtn.Text = "Durdur";
            pauseBtn.UseVisualStyleBackColor = true;
            pauseBtn.Click += pauseBtn_Click;
            // 
            // continueBtn
            // 
            continueBtn.Enabled = false;
            continueBtn.Location = new Point(1218, 234);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(196, 29);
            continueBtn.TabIndex = 6;
            continueBtn.Text = "Devam Ettir";
            continueBtn.UseVisualStyleBackColor = true;
            continueBtn.Click += continueBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Enabled = false;
            resetBtn.Location = new Point(1218, 269);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(196, 29);
            resetBtn.TabIndex = 7;
            resetBtn.Text = "Sıfırla";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 533);
            Controls.Add(resetBtn);
            Controls.Add(continueBtn);
            Controls.Add(pauseBtn);
            Controls.Add(resultBox);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Controls.Add(portsBox);
            Controls.Add(table);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox table;
        private ComboBox portsBox;
        private Button connectBtn;
        private Button disconnectBtn;
        private TextBox resultBox;
        private Button pauseBtn;
        private Button continueBtn;
        private Button resetBtn;
    }
}
