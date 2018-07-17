using System;
using Xunit;
using RepeatedWords;
using RepeatedWords.Classes;

namespace RepeatedWordsTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindADuplicateWordInALengthyPhrase()
        {
            string phrase = "This is my phrase. I am going to have a duplicate because " +
                            "I need to prove that this method works so that is cool";
            Assert.Equal("i", Program.RepeatedWord(phrase));
        }
        [Fact]
        public void ThisWontReturnADuplicateWord()
        {
            string phrase = "This is my phrase. No duplicates exist in the string. Can you " +
                            "find if there are any?";
            Assert.Equal("no duplicates", Program.RepeatedWord(phrase));
        }
        [Fact]
        public void PhraseIsPutToLowerCaseToAccountForduplicates()
        {
            string phrase = "It was the best of times, it was the worst of times, it was the age of wisdom, " +
                             "it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, " +
                             "it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the" +
                             " winter of despair, we had everything before us, we had nothing before us, we were all going direct to " +
                             "Heaven, we were all going direct the other way – in short, the period was so far like the present period, " +
                             "that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative " +
                             "degree of comparison only...";
            Assert.Equal("it", Program.RepeatedWord(phrase));
        }
    }
}
