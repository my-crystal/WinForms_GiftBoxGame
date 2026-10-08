namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            int total=int.Parse(txtTry.Text);
            int Win = 0;
            Random rnd= new Random();
            for (int i = 0;i < total;i++)
            {
                //中奖号
                int ok = rnd.Next(3);
                //选择号
                int pick = rnd.Next(3);
                //主持人
                int hostPick;
                do { hostPick=rnd.Next(3); 
                } while (hostPick == ok || hostPick == pick);
                int playerChange;//换盒子
                do { playerChange=rnd.Next(3);}
                while(playerChange == hostPick || playerChange == pick);
                if (playerChange == ok) Win++;
                

            }
            double pWin =(double) Win / total;
            lblok.Text = $"实验次数{total}\n\r" + $"换盒子中奖概率{pWin}";
        }
    }
}
