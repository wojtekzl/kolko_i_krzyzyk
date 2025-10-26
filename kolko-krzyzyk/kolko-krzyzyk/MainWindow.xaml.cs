using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace kolko_krzyzyk
{
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int currentPlayer = 0;

        int xWinCount = 0;
        int oWinCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            currentPlayer = rnd.Next(0, 2);
            CheckWinner();
        }

        private void zasady(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gra strategiczna rozgrywana przez dwóch graczy, najczęściej na kartce w kratkę.\n\n Gracze obejmują pola na przemian dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi. Pole może być objęte przez jednego gracza i nie zmienia swego właściciela przez cały przebieg gry.", "Zasady gry", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            P1.IsEnabled = true; P1.Content = "";
            P2.IsEnabled = true; P2.Content = "";
            P3.IsEnabled = true; P3.Content = "";
            P4.IsEnabled = true; P4.Content = "";
            P5.IsEnabled = true; P5.Content = "";
            P6.IsEnabled = true; P6.Content = "";
            P7.IsEnabled = true; P7.Content = "";
            P8.IsEnabled = true; P8.Content = "";
            P9.IsEnabled = true; P9.Content = "";

            currentPlayer = rnd.Next(0, 2);
            CheckWinner();
            img.Source = new BitmapImage(new Uri("buuu_maly.png", UriKind.Relative));
        }

        private void PF1(object sender, RoutedEventArgs e) { MakeMove(P1); }
        private void PF2(object sender, RoutedEventArgs e) { MakeMove(P2); }
        private void PF3(object sender, RoutedEventArgs e) { MakeMove(P3); }
        private void PF4(object sender, RoutedEventArgs e) { MakeMove(P4); }
        private void PF5(object sender, RoutedEventArgs e) { MakeMove(P5); }
        private void PF6(object sender, RoutedEventArgs e) { MakeMove(P6); }
        private void PF7(object sender, RoutedEventArgs e) { MakeMove(P7); }
        private void PF8(object sender, RoutedEventArgs e) { MakeMove(P8); }
        private void PF9(object sender, RoutedEventArgs e) { MakeMove(P9); }

        private void MakeMove(Button button)
        {
            button.IsEnabled = false;
            if (currentPlayer == 1)
            {
                button.Content = "X";
                currentPlayer = 0;
            }
            else
            {
                button.Content = "O";
                currentPlayer = 1;
            }
            CheckWinner();
        }

        private void CheckWinner()
        {
            string[,] board = new string[3, 3]
            {
                { P1.Content.ToString(), P2.Content.ToString(), P3.Content.ToString() },
                { P4.Content.ToString(), P5.Content.ToString(), P6.Content.ToString() },
                { P7.Content.ToString(), P8.Content.ToString(), P9.Content.ToString() }
            };

            string[] players = { "X", "O" };

            foreach (string playerSymbol in players)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == playerSymbol && board[i, 1] == playerSymbol && board[i, 2] == playerSymbol ||
                        board[0, i] == playerSymbol && board[1, i] == playerSymbol && board[2, i] == playerSymbol)
                    {
                        img.Source = new BitmapImage(new Uri("wiktoriusz_maly.png", UriKind.Relative));
                        MessageBox.Show($"Wygrał {playerSymbol}!", "Wygrany", MessageBoxButton.OK, MessageBoxImage.Information);
                        P1.IsEnabled = false; P2.IsEnabled = false; P3.IsEnabled = false;
                        P4.IsEnabled = false; P5.IsEnabled = false; P6.IsEnabled = false;
                        P7.IsEnabled = false; P8.IsEnabled = false; P9.IsEnabled = false;

                        if (playerSymbol == "X") xWinCount++;
                        else oWinCount++;

                        Xwins.Content = "Ilość wygranych X: " + xWinCount;
                        Owins.Content = "Ilość wygranych O: " + oWinCount;
                        return;
                    }
                }

                if ((board[0, 0] == playerSymbol && board[1, 1] == playerSymbol && board[2, 2] == playerSymbol) ||
                    (board[0, 2] == playerSymbol && board[1, 1] == playerSymbol && board[2, 0] == playerSymbol))
                {
                    img.Source = new BitmapImage(new Uri("wiktoriusz_maly.png", UriKind.Relative));
                    MessageBox.Show($"Wygrał {playerSymbol}!", "Wygrany", MessageBoxButton.OK, MessageBoxImage.Information);
                    P1.IsEnabled = false; P2.IsEnabled = false; P3.IsEnabled = false;
                    P4.IsEnabled = false; P5.IsEnabled = false; P6.IsEnabled = false;
                    P7.IsEnabled = false; P8.IsEnabled = false; P9.IsEnabled = false;

                    if (playerSymbol == "X") xWinCount++;
                    else oWinCount++;

                    Xwins.Content = "Ilość wygranych X: " + xWinCount;
                    Owins.Content = "Ilość wygranych O: " + oWinCount;
                    return;
                }
            }

            if (!P1.IsEnabled && !P2.IsEnabled && !P3.IsEnabled &&
                !P4.IsEnabled && !P5.IsEnabled && !P6.IsEnabled &&
                !P7.IsEnabled && !P8.IsEnabled && !P9.IsEnabled)
            {
                img.Source = new BitmapImage(new Uri("buuu_maly.png", UriKind.Relative));
                MessageBox.Show("Nikt nie wygrywa, remis!", "Remis", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            Xwins.Content = "Ilość wygranych X: " + xWinCount;
            Owins.Content = "Ilość wygranych O: " + oWinCount;
        }
    }
}