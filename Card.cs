using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace FormatieveOpdracht1
{
    public class Card
    {
        private string suit;
        private int rank;
        private int deck;
        private string player;


        public Card(string givenSuit, int givenRank)
        {
            suit = givenSuit;
            rank = givenRank;
            deck = 0;
            player = "a";
        }
       public void setPlayer(string inputplayer)
        {
            player = inputplayer;
        }

        public string getSuit()
        {
            return suit;
        }
        public int getRank()
        {
            return rank;
        }
        public int getDeck()
        {
            return deck;
        }
        public string getPlayer()
        {
            return player;
        }




    }
}
