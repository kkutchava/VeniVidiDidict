
namespace VeniVidiDidict
{
    partial class QuestionView
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
            this.topicNameLbl = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topicNameLbl
            // 
            this.topicNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicNameLbl.AutoSize = true;
            this.topicNameLbl.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicNameLbl.Location = new System.Drawing.Point(117, 9);
            this.topicNameLbl.Name = "topicNameLbl";
            this.topicNameLbl.Size = new System.Drawing.Size(167, 32);
            this.topicNameLbl.TabIndex = 0;
            this.topicNameLbl.Text = "Topic Name";
            this.topicNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(181, 405);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(230, 55);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.answerBox.Location = new System.Drawing.Point(114, 330);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(364, 28);
            this.answerBox.TabIndex = 3;
            this.answerBox.Text = "Enter answer here...";
            this.answerBox.Enter += new System.EventHandler(this.answerBox_Enter);
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLbl.Location = new System.Drawing.Point(119, 371);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(39, 20);
            this.ResultLbl.TabIndex = 4;
            this.ResultLbl.Text = "text";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(12, 66);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(102, 28);
            this.questionLbl.TabIndex = 5;
            this.questionLbl.Text = "question";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(62, 159);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(473, 165);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 472);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.topicNameLbl);
            this.Name = "QuestionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionView";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topicNameLbl;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Label questionLbl;
    }
}