using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        List<Button> freeFields;
        Random rnd = new Random();
        private string turn;

        public string Turn
        {
            get { return turn; }
            set { turn = value; }
        }

        public Form3()
        {
            InitializeComponent();
            Turn = "X";
            label1.Text = "!Player moves first";
            freeFields = new List<Button>() { field1, field2, field3, field4, field5, field6, field7, field8, field9 };
        }

        public void fieldClick(object sender, MouseEventArgs e)
        {
            label1.Text = "";
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (Turn == "X")
                {
                    button.Text = "X";
                    button.Cursor = Cursors.Default;
                    freeFields.Remove(button);
                    Turn = "O";
                    if (!checkForWin())
                    {
                        Button aiButton = selectButtonForAI();
                        fieldClick(aiButton, null);
                    }
                }
                else
                {
                    // Ruch AI
                    button.Text = "O";
                    button.Cursor = Cursors.Default;
                    Turn = "X";
                    checkForWin();
                }
            }
        }

        public Button selectButtonForAI()
        {
            Button btn = canBlock();
            if (btn != null)
            {
                freeFields.Remove(btn);
                string ButtonName = btn.Name;
                return btn;
            }
            else
            {
                int index = rnd.Next(freeFields.Count);
                btn = freeFields[index];
                string ButtonName = btn.Name;
                
                freeFields.RemoveAt(index);
                return btn;
            }
        }

        public Button canBlock()
        {
            if (((field2.Text == "X" && field3.Text == "X") || (field4.Text == "X" && field7.Text == "X") || (field5.Text == "X" && field9.Text == "X")) && field1.Text=="")
            {
                return field1;
            }
            else if (((field1.Text == "X" && field3.Text == "X") || (field5.Text == "X" && field8.Text == "X")) && field2.Text == "")
            {
                return field2;
            }
            else if (((field1.Text == "X" && field2.Text == "X") || (field6.Text == "X" && field9.Text == "X") || (field7.Text == "X" && field5.Text == "X")) && field3.Text == "")
            {
                return field3;
            }
            else if (((field1.Text == "X" && field7.Text == "X") || (field5.Text == "X" && field6.Text == "X")) && field4.Text == "")
            {
                return field4;
            }
            else if (((field1.Text == "X" && field9.Text == "X") || (field3.Text == "X" && field7.Text == "X") || (field2.Text == "X" && field8.Text == "X") || (field4.Text == "X" && field6.Text == "X")) && field5.Text == "")
            {
                return field5;
            }
            else if (((field4.Text == "X" && field5.Text == "X") || (field3.Text == "X" && field9.Text == "X")) && field6.Text == "")
            {
                return field6;
            }
            else if (((field1.Text == "X" && field4.Text == "X") || (field8.Text == "X" && field9.Text == "X") || (field3.Text == "X" && field5.Text == "X")) && field7.Text == "")
            {
                return field7;
            }
            else if (((field2.Text == "X" && field5.Text == "X") || (field7.Text == "X" && field9.Text == "X")) && field8.Text == "")
            {
                return field8;
            }
            else if (((field3.Text == "X" && field6.Text == "X") || (field7.Text == "X" && field8.Text == "X") || (field1.Text == "X" && field5.Text == "X")) && field9.Text == "")
            {
                return field9;
            }
            else return null;
        }

        public bool checkForWin()
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
                if(Turn == "X")
                {
                    MessageBox.Show($"Computer won!", "Game is over!");
                }
                else
                {
                    MessageBox.Show($"Player won!", "Game is over!");
                }
                clearBoard();
                return true;
            }
            else if(freeFields.Count == 0)
            {
                MessageBox.Show($"Draw!", "Game is over!");
                clearBoard();
                return true;
            }
            return false;
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
        }
    }
}