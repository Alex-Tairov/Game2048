using System;
using System.Drawing;
using System.Windows.Forms;
using _2048_Common;
using System.Collections.Generic;

namespace _2048WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private const int margin = 6;

        public int mapSizeX = 5;//размерность карты по X
        public int mapSizeY = 5;//размерность карты по Y

        private Label[,] map;//двумерный массив лейблов
        public int score = 0;
        public int result = 0;

        private bool flag = false;

        private List<int> numbers = new List<int> { 4, 4, 2, 2, 2, 2, 2, 2, 2, 2 };

        internal void ClearMap()
        {
            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    var index = Controls.IndexOf(map[i, j]);
                    Controls.RemoveAt(index);
                }
            }
        }

        public UserName user;

        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.userNameTextBox.Text;//Записываем имя пользователя
                user = new UserName(userName);
                game = new Game(user);


                InitMap();
                GenerateNumber();
                ShowScore();
            }
            else
            {
                Close();
            }

        }

        private void ShowScore()
        {
            scoreLabel.Text = user.score.ToString();

        }

        private void GenerateNumber()
        {
            var random = new Random();
            while (true)
            {
                if (numbers.Count == 0)
                {
                    numbers = new List<int> { 4, 4, 2, 2, 2, 2, 2, 2, 2, 2 };
                }

                var len = numbers.Count;
                var randIndex = random.Next(0, len);
                var randNumber = numbers[randIndex];

                var rowIndex = random.Next(mapSizeX);
                var columnIndex = random.Next(mapSizeY);
                //Если ячейка пустая вставляем новое число 
                if (map[rowIndex, columnIndex].Text == string.Empty)
                {
                    map[rowIndex, columnIndex].Text = randNumber.ToString();
                    ColorLabel(map[rowIndex, columnIndex]);
                    numbers.RemoveAt(randIndex);
                    break;
                }
            }
        }

        public void InitMap()
        {
            map = new Label[mapSizeX, mapSizeY];//двумерный массив лейблов

            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    var newLabel = CreateLabel(i, j);//Ставим лейблы
                    Controls.Add(newLabel);
                    map[i, j] = newLabel;

                    
                }
            }
        }
                

        //Рестарт
        public void Restart()
        {
            user.score = 0;
            GenerateNumber();
            ShowScore();

            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    map[i, j].Text = string.Empty;
                    map[i, j].BackColor = Color.Gray;
                }
            }
         
        }




        //Функция отображения лейбла
        private Label CreateLabel(int rowIndex, int columnIndex)
        {
            var label = new Label();
            label.BackColor = Color.Gray;

            label.Font = new Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Size = new Size(70, 70);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            var x = 10 + columnIndex * (70 + margin);
            var y = 70 + rowIndex * (70 + margin);
            label.Location = new Point(x, y);
            return label;
        }

        //Вызывается при нажатии на клавишу
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                
                for (int i = 0; i < mapSizeX; i++)
                {
                    for (int j = mapSizeY - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        flag = true;
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[i, k].Text = string.Empty;
                                        user.score += number * 2;

                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                
                for (int i = 0; i < mapSizeX; i++)
                {
                    for (int j = mapSizeY - 1; j >= 0; j--)
                    {
                        
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {

                                if (map[i, k].Text != string.Empty)
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = string.Empty;
                                   
                                }

                            }
                        }

                    }
                }
                SetColor();
                
                IsWin();
                IsLose();

            }




            if (e.KeyCode == Keys.Left)
            {
                //Слияние
                for (int i = 0; i < mapSizeX; i++)
                {
                    for (int j = 0; j < mapSizeY; j++)
                    {
                        //Если ячейка не пуста,то ищеем первую слева не пустую ячейку
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSizeX; k++)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        flag = true;
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[i, k].Text = string.Empty;
                                        user.score += number * 2;
                                    }
                                    break;
                                }

                            }
                        }
                    }
                }

                //Упорядочивание
                for (int i = 0; i < mapSizeX; i++)
                {
                    for (int j = 0; j < mapSizeY; j++)
                    {
                        //Если ячейка не пуста,то ищеем первую слева не пустую ячейку
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSizeX; k++)
                            {
                                
                                if (map[i, k].Text != string.Empty)
                                {

                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = string.Empty;
                                    
                                }

                            }
                        }

                    }
                }
                SetColor();
                IsWin();
                IsLose();
            }



            if (e.KeyCode == Keys.Up)
            {
                

                for (int j = 0; j < mapSizeY; j++)
                {
                    for (int i = 0; i < mapSizeX; i++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < mapSizeX; k++)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        flag = true;
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[k, j].Text = string.Empty;
                                        user.score += number * 2;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }


                for (int j = 0; j < mapSizeY; j++)
                {
                    for (int i = 0; i < mapSizeX; i++)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < mapSizeX; k++)
                            {

                                if (map[k, j].Text != string.Empty)
                                {
                                    map[i, j].Text = map[k, j].Text;
                                    map[k, j].Text = string.Empty;
                                }
                            }
                        }

                    }
                }


                SetColor();
                IsWin();
                IsLose();
            }


            if (e.KeyCode == Keys.Down)
            {
                //Слияние
                for (int j = 0; j < mapSizeY; j++)
                {
                    for (int i = mapSizeX - 1; i >= 0; i--)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        flag = true;
                                        var number = Convert.ToInt32(map[i, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[k, j].Text = string.Empty;
                                        user.score += number * 2;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                //Упорядочивание
                for (int j = 0; j < mapSizeY; j++)
                {
                    for (int i = mapSizeX - 1; i >= 0; i--)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    map[i, j].Text = map[k, j].Text;
                                    map[k, j].Text = string.Empty;

                                }
                            }
                        }

                    }
                }
                SetColor();
                IsWin();
                IsLose();
            }
            GenerateNumber();
                
            
            ShowScore();
                        
        }

        //Задаем размеры поля
        private void SetSizeFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SetSizeForm = new SetSizeField(this);
            SetSizeForm.Show();
        }

        //Отображаем результаты
        private void ShowResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(UserResults.GetResultsFromFile());
            userResultsForm.Show();
        }

        //Отображаем правила
        private void ShowGameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameRules = new GameRules();
            gameRules.Show();
        }

        //Задаем цвет
        private void ColorLabel(Label label)
        {

            if (label.Text == "2")
            {
                label.BackColor = Color.LightGray;
            }
            else if (label.Text == "4")
            {
                label.BackColor = Color.LightYellow;
            }
            else if (label.Text == "8")
            {
                label.BackColor = Color.Orange;
            }
            else if (label.Text == "16")
            {
                label.BackColor = Color.MediumVioletRed;
            }
            else if (label.Text == "32")
            {
                label.BackColor = Color.Red;
            }
            else if (label.Text == "64")
            {
                label.BackColor = Color.DarkRed;
            }
            else if (label.Text == "128")
            {
                label.BackColor = Color.DarkRed;
            }
            else if (label.Text == "256")
            {
                label.BackColor = Color.DarkRed;
            }
            else if (label.Text == "512")
            {
                label.BackColor = Color.DarkRed;
            }
            else if (label.Text == "1024")
            {
                label.BackColor = Color.DarkRed;
            }
            else if (label.Text == "2048")
            {
                label.BackColor = Color.DarkRed;
            }
            else if (label.Text == string.Empty)
            {
                label.BackColor = Color.Gray;
            }

        }


        private void IsWin()
        {

            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    if (map[i, j].Text == "2048")
                    {

                        var winForm = new WinnerForm(this);
                        winForm.Show();

                    }


                }

            }
            
        }

        private void IsLose()
        {
            int counter = 0;

            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    if (map[i, j].Text != string.Empty)
                    {
                        counter++;
                    }


                }

            }
            if (counter == mapSizeX * mapSizeY)
            {
                game.SaveResult();
                var loseForm = new LoseForm(this);
                loseForm.ShowDialog();

            }
            
        }

        private void SetColor()
        {
            for (int i = 0; i < mapSizeX; i++)
            {
                for (int j = 0; j < mapSizeY; j++)
                {
                    ColorLabel(map[i, j]);
                }
            }
        }
        //Кнопка Выход
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Кнопка Рестарт
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.userNameTextBox.Text;//Записываем имя пользователя
                user = new UserName(userName);
                game = new Game(user);
                Restart();
                GenerateNumber();
            }
            else
            {
                Close();
            }
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
