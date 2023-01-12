namespace SlotMachinePayOff
{
    partial class FormSlotMachine
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
            this.BtnDisplayResults = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDisplayResults
            // 
            this.BtnDisplayResults.Location = new System.Drawing.Point(59, 60);
            this.BtnDisplayResults.Name = "BtnDisplayResults";
            this.BtnDisplayResults.Size = new System.Drawing.Size(162, 58);
            this.BtnDisplayResults.TabIndex = 0;
            this.BtnDisplayResults.Text = "Display Results";
            this.BtnDisplayResults.UseVisualStyleBackColor = true;
            this.BtnDisplayResults.Click += new System.EventHandler(this.BtnDisplayResults_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(239, 60);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(490, 355);
            this.TxtResult.TabIndex = 1;
            // 
            // FormSlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnDisplayResults);
            this.Name = "FormSlotMachine";
            this.Text = "Slot Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplayResults;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

