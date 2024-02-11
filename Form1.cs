using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {
 
        // VARIABLES 

        // This determines the turn that the players are on - maximum can be 9
        int turns = 0;
        // Random varibale can be used to determinhe CPU's moves
        Random rand = new Random();
        // This is the user and will be given a value of "x" or "o" based on their turn
        String player;
        // This is the CPU and will be given a value of "x" or "o" based on their turn
        String CPU;
        // List to store which buttons are filled and which are not
        List<Button> boxes;
        // this var is to store the random number which will decide who goes first
        bool playerTurn;



        // random variable needed to determine the first player to go
        // random var to determine computer moves 

        // computers moves are random

        //what happens when a button has already been clicked
        // can't click in it again 

        // first player is x
        // second is o

        // some what to figure out who won if they are chosen at random?

        // need to take turns - cant go at the same time

        // register which boxes are filled and which are not so players can choose from the remaining


        // reset button makes everything go back to empty and data srtucture is wiped


        // max number of turns is 9
        // if max number is reached and no one has one then display tie



        // how is the computer going to move


        public Form1()
        {
            InitializeComponent();
            // As the game starts everything is wiped to the original settings and list is remade
            RestartGame();
        }




        // this class determined the CPU's moves at random based on unfilled boxes
        private void CPUMove()
        {

        }

        // checks if someone has won
        // this class checks if there are any 3 in a row's
        private void CheckWin()
        {

        }




        private void BtnClick(object sender, EventArgs e)
        {
            // when button is clicked display players sign
            if (!playerTurn) return;
            // grabs the current displayed text in the button clicked and stores in button var
            Button button = (Button)sender;

            }
            // check if it is avaliabe
            // if not then return

            // if it is avaliable then put player sign in display box 


 
        }



        private void StartNewGame()
        {
            RestartGame();
            // going to determine first player and assign signs
            // use random class to 

            

            // if player turn is a 1 set player to O and CPU to X
            // if player turn is 0 do opposite
            // gives 2 optins, 0 for player, 1 for CPU
            playerTurn = rand.Next(2) == 0;

            // player turn is a bool value, so if it is true then player is X if not player is O

            if (playerTurn)
            {
                player = "X";
                CPU = "O";
            }
            else
            {
                player = "O";
                CPU = "X";
            }
        }

        private void RestartGame()
        {
            // intialized List of buttons with clickable boxes
            boxes = new List<Button> {button1, button2, button3, button4,
                button5, button6, button7, button8, button9 };

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            // Had to create Restart separately because it is also used in the initialization of the program and i cant use the _Clikck version there.
            // it also makes it easier to impliment in 
            RestartGame();
        }

        // Exit button that ends the program
        private void Exit_Click(object sender, EventArgs e)
        {
            // This ends all operations and closes the code
            this.Close();
        }
    }
}
