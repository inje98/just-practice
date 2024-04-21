using System;
using System.Windows.Forms;

namespace change_screen
{
    public partial class Form1 : Form
    {
        private StartGame gameScreen; // ���� ȭ���� ��Ÿ���� ����� ���� ��Ʈ�� ����

        public Form1()
        {
            InitializeComponent();
            gameScreen = new StartGame(); // ���� ȭ�� ��Ʈ�� �ʱ�ȭ
            gameScreen.Dock = DockStyle.Fill; // ��Ʈ���� ���� �� ������ ����
            gameScreen.Visible = false; // �ϴ��� ���ܵ�
            this.Controls.Add(gameScreen); // ���� ���� ȭ�� ��Ʈ�� �߰�
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // �ݱ� ��ư Ŭ�� �� �� �ݱ�
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // ���� ��ư Ŭ�� �� ���� ȭ�� ���̵��� ����
            gameScreen.Visible = true;
            this.Controls.Remove(BtnStart); // ���� ��ư �����
            this.Controls.Remove(BtnClose); // �ݱ� ��ư �����
            this.Controls.Remove(label1); // ����� ����� �� �����
        }
    }
}

