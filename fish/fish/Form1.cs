namespace fish
{
    public partial class Form1 : Form
    {
        private DateTime startTime;  // ���α׷� ���� �ð��� ������ ����
        private int level = 1;  // ���� ����

        private int progressBarMaxValue = 100; // ���α׷��� ���� �ִ� ��
        private int progressBarCurrentValue = 0; // ���α׷��� ���� ���� ��

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10; // Ÿ�̸� ������ 10�и��ʷ� ����
            timer1.Tick += Timer_Tick; // Ÿ�̸� �̺�Ʈ �ڵ鷯 ����

            progressBar.Maximum = progressBarMaxValue; // ���α׷��� ���� �ִ� �� ����
            progressBar.Minimum = 0; // ���α׷��� ���� �ּ� �� ����
            progressBar.Value = progressBarCurrentValue; // ���α׷��� �� �ʱ� �� ����
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;  // �� �ε� �� ���� �ð��� ���� �ð����� ����
            timer1.Start(); // Ÿ�̸� ����
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;  // ���ۺ��� ���ݱ����� ��� �ð��� ���
            double totalSeconds = elapsed.TotalMilliseconds / 1000; // ��� �ð��� �� ������ ��ȯ

            // 10�� ���ݸ��� ���α׷��� �ٰ� 10�� �����ϵ��� ����
            int newValue = (int)(totalSeconds % 10 * 10);
            progressBarCurrentValue = Math.Min(newValue, progressBarMaxValue);
            progressBar.Value = progressBarCurrentValue;

            // 10�� ���ݸ��� ������ �����ϰ�, �ִ� ������ �����ϸ� Ÿ�̸Ӹ� �����ϰ� ������ ����
            if (totalSeconds / 10 >= level)
            {
                level++;  // ���� ����
                if (level > 5)
                {
                    timer1.Stop();  // Ÿ�̸� ����
                    MessageBox.Show("�����մϴ�! ���� 5�� �����߽��ϴ�.");
                    var result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "���� ����", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        RestartGame();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

            // ���̺� ������Ʈ
            label1.Text = $"{totalSeconds}��";
            label2.Text = $"level : {level}";
        }

        private void RestartGame() 
        {
            startTime = DateTime.Now;  // ���� �ð� ����
            level = 1;  // ���� ����
            progressBarCurrentValue = 0; // ���α׷��� �� ����
            progressBar.Value = 0;
            timer1.Start();  // Ÿ�̸� �ٽ� ����
        }
    }
}
