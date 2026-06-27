namespace CyberSecurityChatbot
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
            btnDeleteTask = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSend = new Button();
            txtMessage = new TextBox();
            label3 = new Label();
            richTextBoxChat = new RichTextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            dgvTasks = new DataGridView();
            btnRefresh = new Button();
            buttonDeleteTask = new Button();
            btnCompleteTask = new Button();
            btnAddTask = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtTitle = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            btnNextQuestion_Click = new Button();
            btnStartQuiz_Click = new Button();
            lblScore = new Label();
            rbOption4 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption1 = new RadioButton();
            lblQuestion = new Label();
            tabPage4 = new TabPage();
            btnClearLog = new Button();
            btnRefreshLog = new Button();
            richTextBoxLog = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(63, 703);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(79, 29);
            btnDeleteTask.TabIndex = 13;
            btnDeleteTask.Text = "button5";
            btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.MaximumSize = new Size(0, 50);
            label1.MinimumSize = new Size(0, 50);
            label1.Name = "label1";
            label1.Size = new Size(452, 50);
            label1.TabIndex = 14;
            label1.Text = "CYBER SECURITY ASSISTANT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1182, 740);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSend);
            tabPage1.Controls.Add(txtMessage);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(richTextBoxChat);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1174, 707);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chatbot";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Cyan;
            btnSend.Location = new Point(880, 487);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(143, 37);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += button1_Click;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(192, 0, 192);
            txtMessage.Location = new Point(31, 497);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(710, 27);
            txtMessage.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 435);
            label3.Name = "label3";
            label3.Size = new Size(105, 31);
            label3.TabIndex = 2;
            label3.Text = "Message";
            // 
            // richTextBoxChat
            // 
            richTextBoxChat.BackColor = Color.FromArgb(192, 0, 192);
            richTextBoxChat.Location = new Point(26, 100);
            richTextBoxChat.Name = "richTextBoxChat";
            richTextBoxChat.Size = new Size(1086, 260);
            richTextBoxChat.TabIndex = 1;
            richTextBoxChat.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(510, 46);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 0;
            label2.Text = "CHATBOT";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvTasks);
            tabPage2.Controls.Add(btnRefresh);
            tabPage2.Controls.Add(buttonDeleteTask);
            tabPage2.Controls.Add(btnCompleteTask);
            tabPage2.Controls.Add(btnAddTask);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtDescription);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtTitle);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1174, 707);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Task Assistant";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(54, 565);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(317, 126);
            dgvTasks.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Fuchsia;
            btnRefresh.Location = new Point(47, 507);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 28);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnViewTasks_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.BackColor = Color.Fuchsia;
            buttonDeleteTask.Location = new Point(40, 459);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(118, 32);
            buttonDeleteTask.TabIndex = 8;
            buttonDeleteTask.Text = "Delete Task";
            buttonDeleteTask.UseVisualStyleBackColor = false;
            buttonDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.BackColor = Color.Fuchsia;
            btnCompleteTask.Location = new Point(35, 416);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(136, 31);
            btnCompleteTask.TabIndex = 7;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Fuchsia;
            btnAddTask.Location = new Point(35, 368);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(96, 32);
            btnAddTask.TabIndex = 6;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.Location = new Point(27, 323);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cyan;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 267);
            label6.Name = "label6";
            label6.Size = new Size(112, 31);
            label6.TabIndex = 4;
            label6.Text = "Reminder";
            label6.Click += label6_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Fuchsia;
            txtDescription.Location = new Point(26, 176);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(301, 60);
            txtDescription.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Cyan;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 124);
            label5.Name = "label5";
            label5.Size = new Size(131, 31);
            label5.TabIndex = 2;
            label5.Text = "Description";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Fuchsia;
            txtTitle.Location = new Point(26, 77);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(304, 27);
            txtTitle.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Cyan;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 24);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 0;
            label4.Text = "Task Title";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnNextQuestion_Click);
            tabPage3.Controls.Add(btnStartQuiz_Click);
            tabPage3.Controls.Add(lblScore);
            tabPage3.Controls.Add(rbOption4);
            tabPage3.Controls.Add(rbOption3);
            tabPage3.Controls.Add(rbOption2);
            tabPage3.Controls.Add(rbOption1);
            tabPage3.Controls.Add(lblQuestion);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1174, 707);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cybersecurity Quiz";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNextQuestion_Click
            // 
            btnNextQuestion_Click.BackColor = Color.Fuchsia;
            btnNextQuestion_Click.Location = new Point(22, 529);
            btnNextQuestion_Click.Name = "btnNextQuestion_Click";
            btnNextQuestion_Click.Size = new Size(132, 38);
            btnNextQuestion_Click.TabIndex = 7;
            btnNextQuestion_Click.Text = "Next Question";
            btnNextQuestion_Click.UseVisualStyleBackColor = false;
            btnNextQuestion_Click.Visible = false;
            btnNextQuestion_Click.Click += btnNextQuestion;
            // 
            // btnStartQuiz_Click
            // 
            btnStartQuiz_Click.BackColor = Color.Fuchsia;
            btnStartQuiz_Click.Location = new Point(20, 472);
            btnStartQuiz_Click.Name = "btnStartQuiz_Click";
            btnStartQuiz_Click.Size = new Size(137, 38);
            btnStartQuiz_Click.TabIndex = 6;
            btnStartQuiz_Click.Text = "Start Quiz";
            btnStartQuiz_Click.UseVisualStyleBackColor = false;
            btnStartQuiz_Click.Visible = true;
            btnStartQuiz_Click.Click += btnStartQuiz;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Cyan;
            lblScore.Location = new Point(22, 417);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(46, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score";
            lblScore.Visible = false;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.BackColor = Color.Fuchsia;
            rbOption4.Location = new Point(20, 356);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(125, 24);
            rbOption4.TabIndex = 4;
            rbOption4.Text = "RadioButton 4";
            rbOption4.UseVisualStyleBackColor = false;
            rbOption4.Visible = false;
            rbOption4.CheckedChanged += rbOption4_CheckedChanged;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.BackColor = Color.Fuchsia;
            rbOption3.Location = new Point(17, 319);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(125, 24);
            rbOption3.TabIndex = 3;
            rbOption3.Text = "RadioButton 3";
            rbOption3.UseVisualStyleBackColor = false;
            rbOption3.Visible = false;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.BackColor = Color.Fuchsia;
            rbOption2.Location = new Point(14, 276);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(125, 24);
            rbOption2.TabIndex = 2;
            rbOption2.Text = "RadioButton 2";
            rbOption2.UseVisualStyleBackColor = false;
            rbOption2.Visible = false;
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.BackColor = Color.Fuchsia;
            rbOption1.Checked = true;
            rbOption1.Location = new Point(10, 229);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(125, 24);
            rbOption1.TabIndex = 1;
            rbOption1.TabStop = true;
            rbOption1.Text = "RadioButton 1";
            rbOption1.UseVisualStyleBackColor = false;
            rbOption1.Visible = false;
            rbOption1.CheckedChanged += rbOption1_CheckedChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Fuchsia;
            lblQuestion.Location = new Point(289, 57);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(168, 20);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "(Question appears here)";
            lblQuestion.Visible = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnClearLog);
            tabPage4.Controls.Add(btnRefreshLog);
            tabPage4.Controls.Add(richTextBoxLog);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1174, 707);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Activity Log";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = Color.Fuchsia;
            btnClearLog.Location = new Point(26, 469);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(146, 50);
            btnClearLog.TabIndex = 2;
            btnClearLog.Text = "Clear Log";
            btnClearLog.Click += btnClearLog_Click;
            btnClearLog.UseVisualStyleBackColor = false;
            // 
            // btnRefreshLog
            // 
            btnRefreshLog.BackColor = Color.Fuchsia;
            btnRefreshLog.Location = new Point(22, 406);
            btnRefreshLog.Name = "btnRefreshLog";
            btnRefreshLog.Size = new Size(153, 50);
            btnRefreshLog.TabIndex = 1;
            btnRefreshLog.Text = "Refresh Log";
            btnRefreshLog.Click += btnRefreshLog_Click;
            btnRefreshLog.UseVisualStyleBackColor = false;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.BackColor = Color.Cyan;
            richTextBoxLog.Location = new Point(13, 60);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(1044, 310);
            richTextBoxLog.TabIndex = 0;
            richTextBoxLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1182, 790);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(btnDeleteTask);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cyber Security Assistant";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeleteTask;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label2;
        private RichTextBox richTextBoxChat;
        private Label label3;
        private Button btnSend;
        private TextBox txtMessage;
        private TextBox txtTitle;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button buttonDeleteTask;
        private Button btnCompleteTask;
        private Button btnAddTask;
        private DataGridView dgvTasks;
        private Button btnRefresh;
        private RadioButton rbOption1;
        private Label lblQuestion;
        private RadioButton rbOption4;
        private RadioButton rbOption3;
        private RadioButton rbOption2;
        private Button btnStartQuiz_Click;
        private Label lblScore;
        private Button btnNextQuestion_Click;
        private RichTextBox richTextBoxLog;
        private Button btnRefreshLog;
        private Button btnClearLog;
    }
}
