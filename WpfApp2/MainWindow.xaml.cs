using System;
using System.Windows;
using LibraryChess;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            queenColorComboBox.Items.Add("Чёрный");
            queenColorComboBox.Items.Add("Белый");

            rookColorComboBox.Items.Add("Чёрный");
            rookColorComboBox.Items.Add("Белый");

            bishopColorComboBox.Items.Add("Чёрный");
            bishopColorComboBox.Items.Add("Белый");
        }

        private void queenMakeMoveButton_Click(object sender, EventArgs e)
        {
            string color;

            if (queenColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Укажите цвет ферзя");
                return;
            }
            else
            {
                color = queenColorComboBox.SelectedItem.ToString();
            }
            char currentColumn = queenCurrentColumnTextBox.Text[0];
            int currentRow = int.Parse(queenCurrentRowTextBox.Text);
            char newColumn = queenNewColumnTextBox.Text[0];
            int newRow = int.Parse(queenNewRowTextBox.Text);

            Queen queen = new Queen(color, currentColumn, currentRow);

            queen.MakeMove(newColumn, newRow);

            queenCurrentColumnTextBox.Text = queen.Column.ToString();
            queenCurrentRowTextBox.Text = queen.Row.ToString();
        }

        private void rookMakeMoveButton_Click(object sender, EventArgs e)
        {
            string color;

            if (rookColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Укажите цвет ферзя");
                return;
            }
            else
            {
                color = rookColorComboBox.SelectedItem.ToString();
            }

            char currentColumn = rookCurrentColumnTextBox.Text[0];
            int currentRow = int.Parse(rookCurrentRowTextBox.Text);
            char newColumn = rookNewColumnTextBox.Text[0];
            int newRow = int.Parse(rookNewRowTextBox.Text);

            Rook rook = new Rook(color, currentColumn, currentRow);

            rook.MakeMove(newColumn, newRow);

            rookCurrentColumnTextBox.Text = rook.Column.ToString();
            rookCurrentRowTextBox.Text = rook.Row.ToString();
        }

        private void bishopMakeMoveButton_Click(object sender, EventArgs e)
        {
            string color;

            if (bishopColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Укажите цвет ферзя");
                return;
            }
            else
            {
                color = bishopColorComboBox.SelectedItem.ToString();
            }

            char currentColumn = bishopCurrentColumnTextBox.Text[0];
            int currentRow = int.Parse(bishopCurrentRowTextBox.Text);
            char newColumn = bishopNewColumnTextBox.Text[0];
            int newRow = int.Parse(bishopNewRowTextBox.Text);

            Bishop bishop = new Bishop(color, currentColumn, currentRow);

            bishop.MakeMove(newColumn, newRow);

            bishopCurrentColumnTextBox.Text = bishop.Column.ToString();
            bishopCurrentRowTextBox.Text = bishop.Row.ToString();
        }

    }
}
