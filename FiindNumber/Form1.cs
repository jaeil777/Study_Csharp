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
            answer.Text = "랜덤숫자가 생성 되었습니다";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                inputNumber = Int32.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("숫자를 입력해주세요", "숫자 맞추기");
            }


            if (inputNumber == randomValue)
            {
                answer.Text = "정답입니다!";

            }
            else
            {
                answer.Text = "틀렸습니다";
            }
        }
    }
}