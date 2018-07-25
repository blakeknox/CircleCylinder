namespace SquareCube
{
    partial class Form
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
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.rdoCylinder = new System.Windows.Forms.RadioButton();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtCircumference = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDispose = new System.Windows.Forms.Button();
            this.btnDefinition = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnCircumference = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(174, 27);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(64, 21);
            this.rdoCircle.TabIndex = 2;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = true;
            this.rdoCircle.CheckedChanged += new System.EventHandler(this.rdoCircle_CheckedChanged);
            // 
            // rdoCylinder
            // 
            this.rdoCylinder.AutoSize = true;
            this.rdoCylinder.Location = new System.Drawing.Point(283, 27);
            this.rdoCylinder.Name = "rdoCylinder";
            this.rdoCylinder.Size = new System.Drawing.Size(80, 21);
            this.rdoCylinder.TabIndex = 3;
            this.rdoCylinder.TabStop = true;
            this.rdoCylinder.Text = "Cylinder";
            this.rdoCylinder.UseVisualStyleBackColor = true;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(68, 197);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(52, 17);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(68, 266);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(154, 197);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 4;
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(154, 263);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Location = new System.Drawing.Point(303, 197);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(99, 17);
            this.lblCircumference.TabIndex = 1;
            this.lblCircumference.Text = "Circumference";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(364, 232);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(347, 266);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(55, 17);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume";
            // 
            // txtCircumference
            // 
            this.txtCircumference.Location = new System.Drawing.Point(435, 197);
            this.txtCircumference.Name = "txtCircumference";
            this.txtCircumference.ReadOnly = true;
            this.txtCircumference.Size = new System.Drawing.Size(100, 22);
            this.txtCircumference.TabIndex = 0;
            this.txtCircumference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(435, 232);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 0;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(435, 263);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(100, 22);
            this.txtVolume.TabIndex = 0;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(106, 320);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDispose
            // 
            this.btnDispose.Location = new System.Drawing.Point(217, 320);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(75, 23);
            this.btnDispose.TabIndex = 7;
            this.btnDispose.Text = "Dispose";
            this.btnDispose.UseVisualStyleBackColor = true;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // btnDefinition
            // 
            this.btnDefinition.Location = new System.Drawing.Point(327, 320);
            this.btnDefinition.Name = "btnDefinition";
            this.btnDefinition.Size = new System.Drawing.Size(90, 23);
            this.btnDefinition.TabIndex = 8;
            this.btnDefinition.Text = "Definition";
            this.btnDefinition.UseVisualStyleBackColor = true;
            this.btnDefinition.Click += new System.EventHandler(this.btnDefinition_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(106, 368);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 9;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnCircumference
            // 
            this.btnCircumference.Location = new System.Drawing.Point(198, 368);
            this.btnCircumference.Name = "btnCircumference";
            this.btnCircumference.Size = new System.Drawing.Size(111, 23);
            this.btnCircumference.TabIndex = 10;
            this.btnCircumference.Text = "Circumference";
            this.btnCircumference.UseVisualStyleBackColor = true;
            this.btnCircumference.Click += new System.EventHandler(this.btnCircumference_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(327, 368);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(75, 23);
            this.btnVolume.TabIndex = 11;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.Menu;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(34, 473);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(525, 15);
            this.txtError.TabIndex = 20;
            this.txtError.Text = "(error)";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 518);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnCircumference);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnDefinition);
            this.Controls.Add(this.btnDispose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCircumference);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.rdoCylinder);
            this.Controls.Add(this.rdoCircle);
            this.Name = "Form";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Circle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.RadioButton rdoCylinder;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtCircumference;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Button btnDefinition;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnCircumference;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TextBox txtError;
    }
}

