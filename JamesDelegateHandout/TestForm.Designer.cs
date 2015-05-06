namespace JamesDelegateHandout
{
    partial class TestForm
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
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDelegate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAnonymous = new System.Windows.Forms.Label();
            this.labelLambda = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(800, 9);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(65, 22);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "label1";
            // 
            // labelDelegate
            // 
            this.labelDelegate.AutoSize = true;
            this.labelDelegate.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelegate.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelDelegate.Location = new System.Drawing.Point(12, 9);
            this.labelDelegate.Name = "labelDelegate";
            this.labelDelegate.Size = new System.Drawing.Size(118, 27);
            this.labelDelegate.TabIndex = 1;
            this.labelDelegate.Text = "Delegate: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            // 
            // labelAnonymous
            // 
            this.labelAnonymous.AutoSize = true;
            this.labelAnonymous.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnonymous.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelAnonymous.Location = new System.Drawing.Point(12, 36);
            this.labelAnonymous.Name = "labelAnonymous";
            this.labelAnonymous.Size = new System.Drawing.Size(147, 27);
            this.labelAnonymous.TabIndex = 2;
            this.labelAnonymous.Text = "Anonymous: ";
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLambda.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLambda.Location = new System.Drawing.Point(12, 63);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(108, 27);
            this.labelLambda.TabIndex = 3;
            this.labelLambda.Text = "Lambda: ";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(819, 454);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 34);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 500);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.labelAnonymous);
            this.Controls.Add(this.labelDelegate);
            this.Controls.Add(this.labelLocation);
            this.Name = "TestForm";
            this.Text = "James\' Delegate Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDelegate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelAnonymous;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.Button buttonReset;
    }
}

