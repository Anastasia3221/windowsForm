namespace University
{
    partial class TeacherBox
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teacherName = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherName.Location = new System.Drawing.Point(138, 15);
            this.teacherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(248, 37);
            this.teacherName.TabIndex = 1;
            this.teacherName.Text = "Name Surname";
            this.teacherName.Click += new System.EventHandler(this.teacherName_Click);
            // 
            // showList
            // 
            this.showList.FlatAppearance.BorderSize = 0;
            this.showList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showList.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showList.ForeColor = System.Drawing.Color.Transparent;
            this.showList.Location = new System.Drawing.Point(134, 88);
            this.showList.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(248, 41);
            this.showList.TabIndex = 2;
            this.showList.Text = "Show Student List";
            this.showList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showList.UseVisualStyleBackColor = true;
            this.showList.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudent
            // 
            this.addStudent.FlatAppearance.BorderSize = 0;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudent.ForeColor = System.Drawing.Color.Transparent;
            this.addStudent.Location = new System.Drawing.Point(134, 52);
            this.addStudent.Margin = new System.Windows.Forms.Padding(0);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(248, 36);
            this.addStudent.TabIndex = 3;
            this.addStudent.Text = "Add Student";
            this.addStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TeacherBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.Name = "TeacherBox";
            this.Size = new System.Drawing.Size(473, 133);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Button showList;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
