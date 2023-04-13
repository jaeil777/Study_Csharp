namespace LoginPractice
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
            label1 = new Label();
            id = new TextBox();
            password = new TextBox();
            SignInBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 54);
            label1.Name = "label1";
            label1.Size = new Size(444, 86);
            label1.TabIndex = 0;
            label1.Text = "재이리 연구소";
            // 
            // id
            // 
            id.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(308, 202);
            id.Name = "id";
            id.Size = new Size(309, 43);
            id.TabIndex = 1;
            // 
            // password
            // 
            password.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(308, 266);
            password.Name = "password";
            password.PasswordChar = 'ㅋ';
            password.Size = new Size(309, 43);
            password.TabIndex = 2;
            // 
            // SignInBtn
            // 
            SignInBtn.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBtn.Location = new Point(240, 329);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(290, 70);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "로그인";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 200);
            label2.Name = "label2";
            label2.Size = new Size(63, 45);
            label2.TabIndex = 4;
            label2.Text = "I D";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(121, 266);
            label3.Name = "label3";
            label3.Size = new Size(192, 45);
            label3.TabIndex = 5;
            label3.Text = "PASSWORD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SignInBtn);
            Controls.Add(password);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "Form1";
            Text = "재이리 연구소";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id;
        private TextBox password;
        private Button SignInBtn;
        private Label label2;
        private Label label3;
    }
}