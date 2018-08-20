namespace CGM208___Lesson_1
{
    partial class MainForm
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
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMaxNumResult = new System.Windows.Forms.Button();
            this.txtMaxNumA = new System.Windows.Forms.TextBox();
            this.txtMaxNumB = new System.Windows.Forms.TextBox();
            this.txtMaxNumC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(7, 53);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(105, 41);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(129, 53);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 41);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(7, 12);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(100, 20);
            this.txtNumA.TabIndex = 2;
            this.txtNumA.Text = "0";
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(134, 12);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(100, 20);
            this.txtNumB.TabIndex = 3;
            this.txtNumB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            // 
            // btnMaxNumResult
            // 
            this.btnMaxNumResult.Location = new System.Drawing.Point(55, 205);
            this.btnMaxNumResult.Name = "btnMaxNumResult";
            this.btnMaxNumResult.Size = new System.Drawing.Size(142, 47);
            this.btnMaxNumResult.TabIndex = 7;
            this.btnMaxNumResult.Text = "Max Number";
            this.btnMaxNumResult.UseVisualStyleBackColor = true;
            this.btnMaxNumResult.Click += new System.EventHandler(this.btnMaxNumResult_Click);
            // 
            // txtMaxNumA
            // 
            this.txtMaxNumA.Location = new System.Drawing.Point(76, 129);
            this.txtMaxNumA.Name = "txtMaxNumA";
            this.txtMaxNumA.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNumA.TabIndex = 8;
            this.txtMaxNumA.Text = "0";
            // 
            // txtMaxNumB
            // 
            this.txtMaxNumB.Location = new System.Drawing.Point(76, 155);
            this.txtMaxNumB.Name = "txtMaxNumB";
            this.txtMaxNumB.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNumB.TabIndex = 9;
            this.txtMaxNumB.Text = "0";
            // 
            // txtMaxNumC
            // 
            this.txtMaxNumC.Location = new System.Drawing.Point(76, 179);
            this.txtMaxNumC.Name = "txtMaxNumC";
            this.txtMaxNumC.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNumC.TabIndex = 10;
            this.txtMaxNumC.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 279);
            this.Controls.Add(this.txtMaxNumC);
            this.Controls.Add(this.txtMaxNumB);
            this.Controls.Add(this.txtMaxNumA);
            this.Controls.Add(this.btnMaxNumResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaxNumResult;
        private System.Windows.Forms.TextBox txtMaxNumA;
        private System.Windows.Forms.TextBox txtMaxNumB;
        private System.Windows.Forms.TextBox txtMaxNumC;
    }
}

