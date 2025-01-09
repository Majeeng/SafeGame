using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeGame
{
    public partial class MainForm : Form
    {
        // Elements
        int N;
        int[,] HandleMatrix;
        int rotateCounter;
        int counterOfWinsMatrix = 0, restartMatrixCounter = 0;

        // sound
        SoundPlayer PlaySound = new SoundPlayer(Properties.Resources.skrip);

        // To create picture boxes
        int x, y;
        PictureBox pBox;

        public MainForm()
        {
            InitializeComponent();

            CenterControlInParent(PanelTopic);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(tbN.Value.ToString()) <= 0)
                    MessageBox.Show("Размер матрицы не может быть 0 или меньше.");
                else
                {
                    btnRestart.Text = "Restart";

                    // Clear picture boxes
                    MainPanel.Controls.OfType<PictureBox>().ToList().ForEach(pb => pb.Dispose());

                    // Get values
                    N = Int32.Parse(tbN.Value.ToString());
                    HandleMatrix = new int[N, N];
                    rotateCounter = 0;
                    #region null matrix
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            HandleMatrix[i, j] = 0;
                        }
                    }
                    #endregion
                    CreateHandles(N);
                    RandomRun();

                    restartMatrixCounter++;
                    if (restartMatrixCounter > 0)
                    {
                        counterOfWinsMatrix = 0;
                        labelWins.Text = $"Пройдено: {counterOfWinsMatrix}";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ScanSafeHandles(int[,] matrix)
        {
            int WinCounter = 0;
            foreach (int el in matrix)
                if (el == 1)
                    WinCounter++;
            if (WinCounter == 0 || WinCounter == N * N)
                return true;
            else
                return false;
        }

        private void SafeHandles_Click(object sender, EventArgs e)
        {
            N = Int32.Parse(tbN.Value.ToString());

            PictureBox clickedPb = sender as PictureBox;
            string str = clickedPb.Name;
            int f, s;
            f = Int32.Parse(str.Substring(str.Length - 2, 1));
            s = Int32.Parse(str.Substring(str.Length - 1));

            #region rotate in matrix
            for (int i = 0; i < N; i++)
            {
                if (HandleMatrix[f, i] == 0)
                    HandleMatrix[f, i] = 1;
                else
                    HandleMatrix[f, i] = 0;

                if (HandleMatrix[i, s] == 0)
                    HandleMatrix[i, s] = 1;
                else
                    HandleMatrix[i, s] = 0;
            }
            if (HandleMatrix[f, s] == 0)
                HandleMatrix[f, s] = 1;
            else
                HandleMatrix[f, s] = 0;
            #endregion

            #region row & column visual rotate
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (HandleMatrix[i,j] == 0)
                    {
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage = Properties.Resources.LineHor;
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage.Tag = "LineHor";
                    }
                    else
                    {
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage = Properties.Resources.LineVer;
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage.Tag = "LineVer";
                    }
                }
            }
            #endregion

            #region win scan
            if (ScanSafeHandles(HandleMatrix))
            {
                PlaySound.Play();
                RandomRun();
                rotateCounter = 0;
                labelRotates.Text = $"Проворотов: {rotateCounter}";
                counterOfWinsMatrix++;
                labelWins.Text = $"Пройдено: {counterOfWinsMatrix}";
                restartMatrixCounter = 0;
            }
            else
            {
                rotateCounter++;
                labelRotates.Text = $"Проворотов: {rotateCounter}";
            }
            #endregion
        }

        private void RandomRun()
        {
            N = Int32.Parse(tbN.Value.ToString());
            Random rng = new Random();
            int f, s;
            for (int o = 0; o < 7; o++)
            {
                f = rng.Next(N);
                s = rng.Next(N);

                #region rotate in matrix
                for (int i = 0; i < N; i++)
                {
                    if (HandleMatrix[f, i] == 0)
                        HandleMatrix[f, i] = 1;
                    else
                        HandleMatrix[f, i] = 0;

                    if (HandleMatrix[i, s] == 0)
                        HandleMatrix[i, s] = 1;
                    else
                        HandleMatrix[i, s] = 0;
                }
                if (HandleMatrix[f, s] == 0)
                    HandleMatrix[f, s] = 1;
                else
                    HandleMatrix[f, s] = 0;
                #endregion
            }

            #region row & column visual rotate
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (HandleMatrix[i, j] == 0)
                    {
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage = Properties.Resources.LineHor;
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage.Tag = "LineHor";
                    }
                    else
                    {
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage = Properties.Resources.LineVer;
                        MainPanel.Controls[$"SafeHandle{i}{j}"].BackgroundImage.Tag = "LineVer";
                    }
                }
            }
            #endregion
        }

        private void CreateHandles(int n)
        {
            int f = 0, s = 0;
            x = 10; y = 75;
            for (int i = 1; i <= n * n; i++)
            {
                // create pb
                x += 60;
                pBox = new PictureBox();
                pBox.Name = "SafeHandle" + f + s;
                pBox.Left = x;
                pBox.Top = y;
                pBox.Height = 50;
                pBox.Width = 50;
                pBox.BackgroundImageLayout = ImageLayout.Stretch;
                pBox.BackgroundImage = Properties.Resources.LineHor;
                pBox.BackgroundImage.Tag = "LineHor";

                // putn in panel
                MainPanel.Controls.Add(pBox);

                // add click event
                pBox.Click += new EventHandler(SafeHandles_Click);

                // edit name & position
                if (i % n == 0)
                {
                    x = 10;
                    y += 60;
                    f++;
                    s = 0;
                }
                else
                    s++;
            }
        }

        #region change Align
        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterControlInParent(PanelTopic);
        }

        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = 5;
        }
        #endregion
    }
}
