using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public enum CardSuit
    {
        Hearts = 1,
        Diamonds = 2,
        Clubs = 3,
        Spades = 4,
    }

    public enum CardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    public class Card
    {
        public CardSuit Suit { get; }
        public CardValue Value { get; }

        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }
    }

}
