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
            if (userId.Equals("���̸�") && userPassword.Equals("�н�����"))
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�", "�α���");

            }
            else
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�", "�α���");
            }
        }


    }
}