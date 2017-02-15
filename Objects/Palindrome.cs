using System;
using System.Collections.Generic;
using System.IO;

namespace PalindromesApp.Objects
{
    public class Palindromes
    {
        private string _userString;
        private string _reverseString;

        public Palindromes(string newUserString)
        {
            _userString = newUserString;
        }

        public void SetReverseString()
        {
            string backwards = "";
            for (int i = _userString.Length; i > 0; i--)
            {
                backwards += _userString[i-1];
            }
            Console.WriteLine(backwards);
            _reverseString = backwards;
        }

        public bool CompareStrings()
        {
            return _userString == _reverseString;
        }


        // public bool LocateFindWord()
        // {
        //     if (_userString.Contains(_findWord))
        //     {
        //         return true;
        //     }
        //     return false;
        // }
        //
        // public string ReplaceFindWord()
        // {
        //     List<char> WholeStringList = StringSplitter(_userString);
        //     List<char> FindWordList = StringSplitter(_findWord);
        //     List<char> ReplaceWordList = StringSplitter(_replaceWord);
        //
        //     string finalResult = "";
        //
        //     for (int index = 0; index < WholeStringList.Count; index++)
        //     {
        //         if (WholeStringList[index] == FindWordList[0])
        //         {
        //             bool foundWord = true;
        //             for (int jdex = 0; jdex < FindWordList.Count; jdex++)
        //             {
        //                 if (FindWordList[jdex] != WholeStringList[index+jdex])
        //                 {
        //                     foundWord = false;
        //                     break;
        //                 }
        //             }
        //             if (foundWord == true)
        //             {
        //                 for (int kdex = 0; kdex < FindWordList.Count; kdex++)
        //                 {
        //                     WholeStringList.RemoveAt(index);
        //                 }
        //                 for (int mdex = ReplaceWordList.Count; mdex > 0; mdex--)
        //                 {
        //                     WholeStringList.Insert(index, ReplaceWordList[mdex-1]);
        //                 }
        //             }
        //         }
        //     }
        //     for (int ndex = 0; ndex < WholeStringList.Count; ndex++)
        //     {
        //         finalResult += WholeStringList[ndex];
        //     }
        //     Console.WriteLine(finalResult);
        //     return finalResult;
        //
        // }
        //
        // public static List<char> StringSplitter(string wholeWord)
        // {
        //     List<char> newList = new List<char> {};
        //     for (int index = 0; index < wholeWord.Length; index++)
        //     {
        //         newList.Add(wholeWord[index]);
        //     }
        //     return newList;
        // }
        //
        public string GetUserString()
        {
            return _userString;
        }
        public string GetReverseString()
        {
            return _reverseString;
        }
    }
}
