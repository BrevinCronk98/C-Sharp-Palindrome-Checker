using System;

namespace Chicken
{
    public class Wordy
    {
        private string _inputWord;
        private string _newWord;
        public Wordy(string inputWord, string newWord)
        {
            _inputWord = inputWord;
            _newWord = newWord;
        }
        public string getWord()
        {
            return _inputWord;
        }
    }
}
