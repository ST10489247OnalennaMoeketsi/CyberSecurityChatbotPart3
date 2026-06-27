using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CyberSecurityChatbot
{

    public partial class Form1 : Form
    {
        ChatBot bot; 


        private List<Question> quizQuestions;
        private int currentQuestion = 0;
        private int score = 0;

        DatabaseHelper db = new DatabaseHelper();

        ActivityLog activityLog = new ActivityLog();

        private void LoadQuestions()
        {
            quizQuestions = new List<Question>()
    {
        new Question
        {
            QuestionText="What is phishing?",
            Options=new string[]
            {
                "A hacking tool",
                "A fake attempt to steal information",
                "An antivirus",
                "A firewall"
            },
            CorrectAnswer=1,
            Explanation="Phishing tricks users into revealing sensitive information."
        },

        new Question
        {
            QuestionText="Which password is strongest?",
            Options=new string[]
            {
                "123456",
                "password",
                "Dog2024",
                "X@7qL#91!m"
            },
            CorrectAnswer=3,
            Explanation="Strong passwords contain letters, numbers and symbols."
        },

        new Question
        {
            QuestionText="HTTPS means...",
            Options=new string[]
            {
                "Website is secure",
                "Website loads faster",
                "Website is free",
                "Website has no ads"
            },
            CorrectAnswer=0,
            Explanation="HTTPS encrypts communication."
        },

        new Question
        {
            QuestionText="What does 2FA stand for?",
            Options=new string[]
            {
                "Two Factor Authentication",
                "Two File Access",
                "Two Fast Accounts",
                "Two Function Access"
            },
            CorrectAnswer=0,
            Explanation="2FA adds another security layer."
        },

        new Question
        {
            QuestionText="Never click...",
            Options=new string[]
            {
                "Trusted websites",
                "Suspicious links",
                "Google",
                "School website"
            },
            CorrectAnswer=1,
            Explanation="Suspicious links may install malware."
        },

        new Question
        {
            QuestionText="Malware is...",
            Options=new string[]
            {
                "Helpful software",
                "Malicious software",
                "Office software",
                "Web browser"
            },
            CorrectAnswer=1,
            Explanation="Malware damages or steals information."
        },

        new Question
        {
            QuestionText="Social engineering attacks target...",
            Options=new string[]
            {
                "People",
                "Printers",
                "WiFi only",
                "USB drives"
            },
            CorrectAnswer=0,
            Explanation="Attackers manipulate people."
        },

        new Question
        {
            QuestionText="You should update software because...",
            Options=new string[]
            {
                "It changes colours",
                "Security patches",
                "More ads",
                "Larger icons"
            },
            CorrectAnswer=1,
            Explanation="Updates fix vulnerabilities."
        },

        new Question
        {
            QuestionText="Before opening an email attachment you should...",
            Options=new string[]
            {
                "Open immediately",
                "Verify the sender",
                "Ignore antivirus",
                "Disable firewall"
            },
            CorrectAnswer=1,
            Explanation="Always verify the sender."
        },

        new Question
        {
            QuestionText="Backing up files helps...",
            Options=new string[]
            {
                "Recover lost data",
                "Increase internet speed",
                "Improve graphics",
                "Charge laptop"
            },
            CorrectAnswer=0,
            Explanation="Backups protect against data loss."
        }
    };
        }

        private void ShowQuestion()
        {
            lblQuestion.Text = quizQuestions[currentQuestion].QuestionText;

            rbOption1.Text = quizQuestions[currentQuestion].Options[0];
            rbOption2.Text = quizQuestions[currentQuestion].Options[1];
            rbOption3.Text = quizQuestions[currentQuestion].Options[2];
            rbOption4.Text = quizQuestions[currentQuestion].Options[3];

            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;
        }

        private void btnStartQuiz(object sender, EventArgs e)
        {
            activityLog.AddLog("Quiz started.");
            LoadQuestions();

            currentQuestion = 0;

            score = 0;

            lblQuestion.Visible = true;
            rbOption1.Visible = true;
            rbOption2.Visible = true;
            rbOption3.Visible = true;
            rbOption4.Visible = true;
            btnNextQuestion_Click.Visible = true;

            ShowQuestion();
        }

        private void btnNextQuestion(object sender, EventArgs e)
        {
            int answer = -1;

            if (rbOption1.Checked) answer = 0;
            if (rbOption2.Checked) answer = 1;
            if (rbOption3.Checked) answer = 2;
            if (rbOption4.Checked) answer = 3;

            if (answer == -1)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            if (answer == quizQuestions[currentQuestion].CorrectAnswer)
            {
                score++;

                MessageBox.Show("Correct!\n\n" +
                    quizQuestions[currentQuestion].Explanation);
            }
            else
            {
                MessageBox.Show("Incorrect.\n\n" +
                    quizQuestions[currentQuestion].Explanation);
            }

            currentQuestion++;

            if (currentQuestion >= quizQuestions.Count)
            {
                // Record the completed quiz in the activity log
                activityLog.AddLog("Quiz completed. Score: "
                    + score + "/" + quizQuestions.Count);
                btnRefreshLog_Click(null, null);

                MessageBox.Show("Quiz Finished!\n\nScore: "
                    + score + " / "
                    + quizQuestions.Count);

                lblScore.Text = "Score: " + score + " / " + quizQuestions.Count;

                return;
            }

            ShowQuestion();
        }
        public Form1()
        {
            InitializeComponent();

            string userName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your name:",
                "Cybersecurity Bot",
                "");

            while (string.IsNullOrWhiteSpace(userName))
            {
                userName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter a valid name:",
                    "Cybersecurity Bot",
                    "");
            }

            bot = new ChatBot(userName);

            // Voice greeting
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Play();
            }
            catch
            {

            }

            richTextBoxChat.AppendText("====================================\n");
            richTextBoxChat.AppendText("      CYBER SECURITY BOT\n");
            richTextBoxChat.AppendText("====================================\n\n");

            richTextBoxChat.AppendText($"Welcome {userName}!\n");
            richTextBoxChat.AppendText("Ask me about passwords, phishing, scams, or safe browsing.\n");
            richTextBoxChat.AppendText("Type 'exit' to quit.\n\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtMessage.Text.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            richTextBoxChat.AppendText("You: " + txtMessage.Text + "\n");

            if (input.Contains("show activity log") ||
    input.Contains("show recent actions") ||
    input.Contains("what have you done for me"))
            {
                richTextBoxChat.AppendText("\nRecent Activity\n");

                foreach (string log in activityLog.GetRecentLogs())
                {
                    richTextBoxChat.AppendText(log + "\n");
                }

                richTextBoxChat.AppendText("\n");

                activityLog.AddLog("Viewed Activity Log");

                txtMessage.Clear();

                return;
            }

            if (input.Contains("start quiz") ||
    input.Contains("play quiz"))
            {
                btnStartQuiz_Click.PerformClick();

                activityLog.AddLog("NLP recognised: Start Quiz");

                txtMessage.Clear();

                return;
            }

            if (input.Contains("add task") ||
    input.Contains("new task") ||
    input.Contains("create task"))
            {
                activityLog.AddLog("NLP recognised: Add Task");
            }

            if (input.Contains("show activity log") ||
    input.Contains("what have you done for me"))
            {
                activityLog.AddLog("NLP recognised: Show Activity Log");
            }

            string response = bot.GetResponse(input);

            richTextBoxChat.AppendText("Bot: " + response + "\n\n");

            if (input == "exit")
            {
                Application.Exit();
            }

            txtMessage.Clear();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskItem task = new TaskItem();
            task.Title = txtTitle.Text;
            task.Description = txtDescription.Text;
            task.Reminder = dateTimePicker1.Value;
            task.Completed = false;
            db.AddTask(task);
            activityLog.AddLog("Task added: " + task.Title);
            btnRefreshLog_Click(null, null);
            MessageBox.Show("Task added successfully.");
            LoadTasks();
        }
        private void LoadTasks()
        {
            dgvTasks.DataSource = null;

            dgvTasks.DataSource = db.GetTasks();
        }
        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
                return;

            int id = Convert.ToInt32(
                dgvTasks.CurrentRow.Cells["Id"].Value);

            db.CompleteTask(id);
            activityLog.AddLog("Task completed.");
            btnRefreshLog_Click(null, null);
            LoadTasks();

            MessageBox.Show("Task completed.");
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
                return;

            int id = Convert.ToInt32(
                dgvTasks.CurrentRow.Cells["Id"].Value);

            db.DeleteTask(id);
            activityLog.AddLog("Task deleted.");
            btnRefreshLog_Click(null, null);
            LoadTasks();

            MessageBox.Show("Task deleted.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();

            btnRefreshLog_Click(sender, e);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void rbOption1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rbOption4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();

            foreach (string log in activityLog.GetRecentLogs(10))
            {
                richTextBoxLog.AppendText(log + Environment.NewLine);
            }
        }


        private void btnClearLog_Click(object sender, EventArgs e)
        {
            activityLog.ClearLogs();

            richTextBoxLog.Clear();

            MessageBox.Show("Activity log cleared.");
        }

    }
}
