using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StavluNaKonDushuMatery
{
    public partial class Form1 : Form
    {
        double GolsH, PropH, GolsG, PropG, MinTotal, MaxTotal, srymM;
        double VerOz = 0;
        double H1, H2, H3, H4, H5, G1, G2, G3, G4, G5;

        //Создание отдельной формы для работы по ссылкам (Анализ матчей по ссылке).
        private void btn_ProverkaNewForm_Click(object sender, EventArgs e)
        {
            
            frmAdt = new Form();
            frmAdt.Text = "Анализ по ссылке";
            frmAdt.Width = 1000;
            frmAdt.Height = 1000;
            frmAdt.Show();
            //WindowState = frmAdtWindowState.Maximized;
            // WindowState = frmAdtWindowState.Maximized;
            //frmAdt.Size = new Size(1920, 1000);
        }

        double totalH, totalG, IndtotalH, IndtotalG, totalMatcha;
        double[] GoalH = new double[10], GoalG = new double[10];
        int[] number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int pudding = 0;
        bool Logic;

        Form frmAdt;
        MenuStrip Menu = new MenuStrip();
        ToolStripMenuItem mnuFile = new ToolStripMenuItem(), mnuHelp = new ToolStripMenuItem(), mnuStart = new ToolStripMenuItem();
        public Form1()
        {
            InitializeComponent();
        }
        private void StartScreen(object sender, EventArgs e)
        {
            Vid.Height = 400;
            Vid.Width = 400;
            AccountH.Width = 300;
            AccountG.Width = 300;
            Home.Location = new Point(this.Width/4 - Home.Width/2, 0);
            AccountH.Location = new Point(this.Width/4 - AccountH.Width/2, 30);
            Goest.Location = new Point(this.Width * 3 / 4 - Goest.Width / 2, 0);
            AccountG.Location = new Point(this.Width * 3 / 4 - AccountG.Width / 2, 30);
            Money.Width = 775;
            Money.Height = 75;
            Money.Location = new Point(this.Width / 2 - Money.Width / 2, this.Height * 3 / 4);
            Vivod.Width = 775;
            Vivod.Height = 211;
            Vivod.Location = new Point(this.Width / 2 - Vivod.Width / 2, this.Height * 3 / 4 - Vivod.Height);
            Vid.Location = new Point(this.Width / 2 - Vid.Width / 2, this.Height * 3 / 4 - Vivod.Height - Vid.Height);
            ColonaA.Location = new Point(0, 0);
            ColonaA.Width = this.Width;
            ColonaA.Height = this.Height;
            Home.Parent = ColonaA;
            Home.BackColor = Color.Transparent;
            Goest.Parent = ColonaA;
            Goest.BackColor = Color.Transparent;
            ColonaA.Image = Properties.Resources.Человек_Нпс_пробник_1; //Через Resources добавили Картинку после чего записали данную строку 

            //Menu.Parent = this;  //Настройка меню
            //Menu.Items.Add(mnuFile);
            //Menu.Items.Add(mnuHelp);

            //mnuFile.Text = "Файл";
            //mnuFile.DropDownItems.Add(mnuStart);

            //mnuStart.Text = "Старт";
            //mnuStart.DropDownItems.Add("Анализ стандартный");
            //mnuStart.DropDownItems.Add("Анализ по ссылкам");
            //mnuStart.DropDownItems[1].Enabled = false;
            //// mnuStart.DropDownItems[0].Click += mnuStartWorkmenu_Click;
            //mnuStart.DropDownItems[0].Click += mnuStartWorkmenuStandart_Click;
            //mnuStart.DropDownItems[1].Click += mnuStartpoSilkam_Click1; ;
            Account();
        }

        private void mnuStartpoSilkam_Click1(object sender, EventArgs e)
        {
        }

        private void mnuStartWorkmenuStandart_Click(object sender, EventArgs e)
        {
        }

        private void ControlG(object sender, EventArgs e)
        {
            Account();
        }

        private void DelatDengiBlyatVotTak(object sender, EventArgs e)
        {

            for (int i = 0; i < GoalH.Length / 2; i++)
            {
                if (GoalH[i * 2] != 0)
                {
                    VerOz += 0.5;
                }
                if (GoalH[1 + i * 2] != 0)
                {
                    VerOz += 0.5;
                }
            }


            H1 = GoalH[0] + GoalH[1];
            H2 = GoalH[2] + GoalH[3];
            H3 = GoalH[4] + GoalH[5];
            H4 = GoalH[6] + GoalH[7];
            H5 = GoalH[8] +GoalH[9];

            GolsH = GoalH[0] + GoalH[2] + GoalH[4] + GoalH[6] + GoalH[8];
            PropH = GoalH[1] + GoalH[3] + GoalH[5] + GoalH[7] + GoalH[9];

            totalH = (H1 + H2 + H3 + H4 + H5) / 5;
            IndtotalH = (GoalH[0] + GoalH[2] + GoalH[4] + GoalH[6] + GoalH[8]) / 5;

            for (int i = 0; i < GoalG.Length / 2; i++)
            {
                if (GoalG[i * 2] != 0)
                {
                    VerOz += 0.5;
                }
                if (GoalG[1 + i * 2] != 0)
                {
                    VerOz += 0.5;
                }
            }
            G1 = GoalG[0] + GoalG[1];
            G2 = GoalG[2] + GoalG[3];
            G3 = GoalG[4] + GoalG[5];
            G4 = GoalG[6] + GoalG[7];
            G5 = GoalG[8] + GoalG[9];

            GolsG = GoalG[0] + GoalG[2] + GoalG[4] + GoalG[6] + GoalG[8];
            PropG = GoalG[1] + GoalG[3] + GoalG[5] + GoalG[7] + GoalG[9];
            totalG = (G1 + G2 + G3 + G4 + G5) / 5;
            IndtotalG = (GoalG[0] + GoalG[2] + GoalG[4] + GoalG[6] + GoalG[8]) / 5;

            totalMatcha = (totalH + totalG) / 2;


            if (GolsH >= PropH)
            {
                if (GolsG >= PropG)
                {
                    MinTotal = (PropH + PropG) / 5;
                    MaxTotal = (GolsH + GolsG) / 5;
                    srymM = (MinTotal + MaxTotal) / 2;
                }
                else
                {
                    MinTotal = (PropH + GolsG) / 5;
                    MaxTotal = (GolsH + PropG) / 5;
                    srymM = (MinTotal + MaxTotal) / 2;
                }
            }
            else
            {
                if (GolsG >= PropG)
                {
                    MinTotal = (GolsH + PropG) / 5;
                    MaxTotal = (PropH + GolsG) / 5;
                    srymM = (MinTotal + MaxTotal) / 2;
                }
                else
                {
                    MinTotal = (GolsH + GolsG) / 5;
                    MaxTotal = (PropH + PropG) / 5;
                    srymM = (MinTotal + MaxTotal) / 2;
                }
            }
            VerOz /= 10;
            Logic = true;
            Account();
        }

        private void ControlH(object sender, EventArgs e)
        {
            Account();
        }
        void Account()
        {
            Vivod.Text = null;
            for (int i = 0; i < AccountH.Text.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (AccountH.Text[i].ToString() == number[j].ToString() && pudding < 10)
                    {

                        Double.TryParse(AccountH.Text[i].ToString(), out GoalH[pudding]);

                        pudding += 1;
                        break;
                    }
                }
            }
            Vivod.Text = "Счёт предыдущих пять матчей хозяев: ";
            for (int i = 0; i < GoalH.Length; i++)
            {
                Vivod.Text += GoalH[i];
                if (i % 2 == 0)
                {
                    Vivod.Text += "-";
                }
                else if (i != GoalH.Length - 1)
                {

                    Vivod.Text += ", ";
                }
            }
            Vivod.Text += "\n";
            pudding = 0;
            for (int i = 0; i < AccountG.Text.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (AccountG.Text[i].ToString() == number[j].ToString() && pudding < 10)
                    {

                        Double.TryParse(AccountG.Text[i].ToString(), out GoalG[pudding]);

                        pudding += 1;
                        break;
                    }
                }
            }
            Vivod.Text += "Счёт предыдущих пять матчей гостей: ";
            for (int i = 0; i < GoalG.Length; i++)
            {
                Vivod.Text += GoalG[i];
                if (i % 2 == 0)
                {
                    Vivod.Text += "-";
                }
                else if (i != GoalG.Length - 1)
                {

                    Vivod.Text += ", ";
                }
            }
            pudding = 0;
            if (Logic)
            {
                Vivod.Text += $"\nОжидаемый средний индивидуальный тотал Хозяев за 5 игр: {IndtotalH}\nОжидаемый средний индивидуальный тотал Гостей за 5 игр: {IndtotalG}\n";
                Vivod.Text += $"Вероятность ОЗ: {VerOz}\nМинимальный тотал: {MinTotal}\nМаксимальный тотал: {MaxTotal}\nСредний ожидаемый тотал: {srymM}";
                VerOz = 0;
                //Vid.Visible = true;
                //Vid.URL = @"D:\Montage\Готовые видео\London View Remix.mp4";
                //Vid.Ctlcontrols.play();
                Logic = false;
            }
        }
    }
}
