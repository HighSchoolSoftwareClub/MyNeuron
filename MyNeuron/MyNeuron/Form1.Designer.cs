﻿namespace MyNeuron
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.ckA = new System.Windows.Forms.CheckBox();
            this.ckB = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Neural Network Training for X-OR";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(12, 43);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(126, 23);
            this.btnTrain.TabIndex = 7;
            this.btnTrain.Text = "Perform X-OR Training";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // ckA
            // 
            this.ckA.AutoSize = true;
            this.ckA.Location = new System.Drawing.Point(15, 72);
            this.ckA.Name = "ckA";
            this.ckA.Size = new System.Drawing.Size(33, 17);
            this.ckA.TabIndex = 8;
            this.ckA.Text = "A";
            this.ckA.UseVisualStyleBackColor = true;
            // 
            // ckB
            // 
            this.ckB.AutoSize = true;
            this.ckB.Location = new System.Drawing.Point(15, 95);
            this.ckB.Name = "ckB";
            this.ckB.Size = new System.Drawing.Size(33, 17);
            this.ckB.TabIndex = 9;
            this.ckB.Text = "B";
            this.ckB.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 115);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Test Result";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(15, 143);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(126, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.ckB);
            this.Controls.Add(this.ckA);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "My Neuron Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.CheckBox ckA;
        private System.Windows.Forms.CheckBox ckB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTest;
    }
}

