using System;

namespace LoginPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            String userId = id.Text;
            String userPassword = password.Text;
            if (userId.Equals("재이리") && userPassword.Equals("패스워드"))
            {
                MessageBox.Show("로그인에 성공했습니다", "로그인");

            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다", "로그인");
            }
        }


    }
}