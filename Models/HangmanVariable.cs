using System;
using System.Collections.Generic;
using Hangman.Controllers;
using Hangman.WordList;
using System.Linq;

namespace Hangman.Models
{
    public class HangmanGame
    {
        private int _badGuesses = 0;
        private static string _secretWord;
        private static string[] _wordList;
        private static string _hiddenWord = "";
        private static char[] _hiddenWordArray;
        private static Random _random = new Random();

        private static void SetWordList()
        {
            _wordList = HangManWords.GetWordList();
        }
        public static string GetRandomWord()
        {
            SetWordList();
            _secretWord = (_wordList[_random.Next(99)]);
            for (int i = 0; i < _secretWord.Length; i++)
            {
                _hiddenWord += "_";
            }
            char[] _hiddenWordArray = _hiddenWord.ToCharArray();
            return _hiddenWord;
        }
        public int GetBadGuesses() 
        {
            return _badGuesses;
        }
        public int SetBadGuesses(int newBadGuesses)
        {
            _badGuesses = newBadGuesses;
            return _badGuesses;
        }
        public string CheckWord(char userLetter)
        {
            for(int i = 0; i < _secretWord.Length; i++)
            {
                if(_secretWord[i] == userLetter)
                {
                    _hiddenWordArray[i] = userLetter;
                }
            }
            _hiddenWord = new string(_hiddenWordArray);
            return _hiddenWord;
        }
    }
}
//Elephant