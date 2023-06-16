using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ithomework
{
    public partial class Alarm : Form
    {
        private Timer countdownTimer;
        private int totalTimeInSeconds;
        private int remainingTimeInSeconds;
        private bool isCountdownFinished = false;
        public Alarm()
        {
            InitializeComponent();
            InitializeTimer();
            checkBoxStart.CheckedChanged += checkBoxStart_CheckedChanged;




        }
        private void InitializeTimer()
        {
            countdownTime = new Timer();
            countdownTime.Interval = 1000; // 每隔1秒触发一次计时器事件
            countdownTime.Tick += countdownTime_Tick;
        }




        private void UpdateDisplay()
        {
            int minutes = remainingTimeInSeconds / 60;
            int seconds = remainingTimeInSeconds % 60;
            lbl_time.Text = $"{minutes:D2}:{seconds:D2}";
        }


        private void countdownTime_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss", new System.Globalization.CultureInfo("zh-TW"));

            if (!checkBoxStart.Checked) // 检查倒计时是否已经启动
                return;

            remainingTimeInSeconds--;
            if (remainingTimeInSeconds >= 0)
            {
                UpdateDisplay();
            }
            else
            {
                countdownTime.Enabled = false;
                countdownTime.Stop();
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\ithome\your_image.png");

                if (!isCountdownFinished) // 检查是否已显示过消息框
                {
                    isCountdownFinished = true; // 设置标志为 true，表示已显示消息框

                    DialogResult result = MessageBox.Show("倒计时结束！", "你醒了嗎", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("好咖");
                    }
                    else if (result == DialogResult.No)
                    {
                        DialogResult result1 = MessageBox.Show("趕快醒喔");
                    }
                }

                checkBoxStart.Checked = false; // 倒计时结束后重置复选框状态
                lbl_time.Text = DateTime.Now.ToString("HH:mm:ss", new System.Globalization.CultureInfo("zh-TW"));
            }
        }

        private void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStart.Checked)
            {
                if (!int.TryParse(txtTotalTime.Text, out totalTimeInSeconds) || totalTimeInSeconds <= 0)
                {
                    MessageBox.Show("请输入有效的总时间（以秒为单位）！");
                    checkBoxStart.Checked = false; // 输入无效时重置复选框状态
                    return;
                }

                countdownTime.Stop(); // 先停止计时器
                remainingTimeInSeconds = totalTimeInSeconds;
                UpdateDisplay();
                countdownTime.Start();
            }
            else
            {
                countdownTime.Stop();
                remainingTimeInSeconds = 0; // 重置剩余时间为零
                UpdateDisplay();
            }
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss", new System.Globalization.CultureInfo("zh-TW"));

        }
    }
}
