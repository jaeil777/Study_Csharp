namespace FiindNumber
{
    public partial class Form1 : Form
    {


        Random randomObj = new Random();
        int randomValue;
        int inputNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomValue = randomObj.Next(1, 10);
            answer.Text = "�������ڰ� ���� �Ǿ����ϴ�";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                inputNumber = Int32.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("���ڸ� �Է����ּ���", "���� ���߱�");
            }


            if (inputNumber == randomValue)
            {
                answer.Text = "�����Դϴ�!";

            }
            else
            {
                answer.Text = "Ʋ�Ƚ��ϴ�";
            }
        }
    }
}