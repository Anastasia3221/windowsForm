namespace University
{
    partial class TeachersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateDefaultTeacher = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.humanListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.createElementForm = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDefaultTeacher
            // 
            this.CreateDefaultTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDefaultTeacher.Location = new System.Drawing.Point(185, 15);
            this.CreateDefaultTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateDefaultTeacher.Name = "CreateDefaultTeacher";
            this.CreateDefaultTeacher.Size = new System.Drawing.Size(167, 28);
            this.CreateDefaultTeacher.TabIndex = 1;
            this.CreateDefaultTeacher.Text = "Add Default Teacher";
            this.CreateDefaultTeacher.UseVisualStyleBackColor = true;
            this.CreateDefaultTeacher.Click += new System.EventHandler(this.CreateDefaultTeacher_Click);
            // 
            // AddElement
            // 
            this.AddElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElement.Location = new System.Drawing.Point(24, 15);
            this.AddElement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(153, 28);
            this.AddElement.TabIndex = 0;
            this.AddElement.Text = "Add new Teacher";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.CreateDefaultTeacher);
            this.panel3.Controls.Add(this.AddElement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 57);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // humanListBox
            // 
            this.humanListBox.AutoScroll = true;
            this.humanListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(219)))));
            this.humanListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humanListBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.humanListBox.Location = new System.Drawing.Point(0, 57);
            this.humanListBox.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.humanListBox.Name = "humanListBox";
            this.humanListBox.Padding = new System.Windows.Forms.Padding(0, 6, 329, 0);
            this.humanListBox.Size = new System.Drawing.Size(657, 435);
            this.humanListBox.TabIndex = 7;
            this.humanListBox.WrapContents = false;
            this.humanListBox.Paint += new System.Windows.Forms.PaintEventHandler(this.humanListBox_Paint);
            // 
            // createElementForm
            // 
            this.createElementForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.createElementForm.Location = new System.Drawing.Point(657, 57);
            this.createElementForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createElementForm.Name = "createElementForm";
            this.createElementForm.Size = new System.Drawing.Size(276, 435);
            this.createElementForm.TabIndex = 0;
            this.createElementForm.Paint += new System.Windows.Forms.PaintEventHandler(this.createElementForm_Paint);
            // 
            // TeachersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.humanListBox);
            this.Controls.Add(this.createElementForm);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeachersTab";
            this.Size = new System.Drawing.Size(933, 492);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDefaultTeacher;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel humanListBox;
        private System.Windows.Forms.Panel createElementForm;
    }
}
