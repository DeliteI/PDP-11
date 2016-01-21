namespace WindowsFormsApplication1
{
    partial class Emulator
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
            this.commandList = new System.Windows.Forms.ListView();
            this.registerState = new System.Windows.Forms.ListView();
            this.Dislpay = new System.Windows.Forms.PictureBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dislpay)).BeginInit();
            this.SuspendLayout();
            // 
            // commandList
            // 
            this.commandList.Location = new System.Drawing.Point(552, 22);
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(435, 256);
            this.commandList.TabIndex = 0;
            this.commandList.UseCompatibleStateImageBehavior = false;
            // 
            // registerState
            // 
            this.registerState.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.registerState.Location = new System.Drawing.Point(552, 298);
            this.registerState.Name = "registerState";
            this.registerState.Size = new System.Drawing.Size(435, 225);
            this.registerState.TabIndex = 1;
            this.registerState.UseCompatibleStateImageBehavior = false;
            // 
            // Dislpay
            // 
            this.Dislpay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dislpay.Location = new System.Drawing.Point(23, 22);
            this.Dislpay.Name = "Dislpay";
            this.Dislpay.Size = new System.Drawing.Size(512, 256);
            this.Dislpay.TabIndex = 2;
            this.Dislpay.TabStop = false;
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(315, 344);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(108, 46);
            this.stepButton.TabIndex = 5;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(129, 424);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 46);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(129, 344);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(108, 46);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(315, 424);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(108, 46);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 543);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.Dislpay);
            this.Controls.Add(this.registerState);
            this.Controls.Add(this.commandList);
            this.Name = "Emulator";
            this.Text = "PDP-11 Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.Dislpay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView commandList;
        private System.Windows.Forms.ListView registerState;
        private System.Windows.Forms.PictureBox Dislpay;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button Stop;
    }
}

