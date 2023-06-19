using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        List<Button> freeFields;
        string whoseTurn = "Make your move ";
        private string turn;

        public string Turn
        {
            get { return turn; }
            set { turn = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Turn = "X";
            freeFields = new List<Button>() { field1, field2, field3, field4, field5, field6, field7, field8, field9 };
            label1.Text = whoseTurn + Turn;
        }

        public void fieldClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (Turn == "X")
                {
                    button.Text = "X";
                    Turn = "O";
                }
                else
                {
                    button.Text = "O";
                    Turn = "X";
                }

                label1.Text = whoseTurn + Turn;
                button.Cursor = Cursors.Default;
                freeFields.Remove(button);
                checkForWin();
            }
        }

        public void checkForWin()
        {
            if (
                (field1.Text != "" && field1.Text == field2.Text && field1.Text == field3.Text) ||
                (field4.Text != "" && field4.Text == field5.Text && field4.Text == field6.Text) ||
                (field7.Text != "" && field7.Text == field8.Text && field7.Text == field9.Text) ||
                (field1.Text != "" && field1.Text == field4.Text && field1.Text == field7.Text) ||
                (field2.Text != "" && field2.Text == field5.Text && field2.Text == field8.Text) ||
                (field3.Text != "" && field3.Text == field6.Text && field3.Text == field9.Text) ||
                (field1.Text != "" && field1.Text == field5.Text && field1.Text == field9.Text) ||
                (field3.Text != "" && field3.Text == field5.Text && field3.Text == field7.Text)
                )
            {
                string winner = Turn == "X" ? "O" : "X";
                MessageBox.Show($"The winner is {winner}!", "Game is over!");
                clearBoard();
            }
            else if (freeFields.Count == 0)
            {
                MessageBox.Show($"Draw!", "Game is over!");
                clearBoard();
            }
        }

        public void clearBoard()
        {
            field1.Text = "";
            field1.Cursor = Cursors.Hand;
            field2.Text = "";
            field2.Cursor = Cursors.Hand;
            field3.Text = "";
            field3.Cursor = Cursors.Hand;
            field4.Text = "";
            field4.Cursor = Cursors.Hand;
            field5.Text = "";
            field5.Cursor = Cursors.Hand;
            field6.Text = "";
            field6.Cursor = Cursors.Hand;
            field7.Text = "";
            field7.Cursor = Cursors.Hand;
            field8.Text = "";
            field8.Cursor = Cursors.Hand;
            field9.Text = "";
            field9.Cursor = Cursors.Hand;
            Turn = "X";
            freeFields = new List<Button>() { field1, field2, field3, field4, field5, field6, field7, field8, field9 };
            label1.Text = whoseTurn + Turn;
        }
    }
}