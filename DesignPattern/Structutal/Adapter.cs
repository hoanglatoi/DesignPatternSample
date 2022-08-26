using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structutal
{
    public interface IVietnameseTarget
    {
        void Send(string word);
    }

    public class JapaneseAdaptee
    {
        public void Receive(string word)
        {
            Console.WriteLine("Retrieving words from Adapter ...");
            Console.WriteLine(word);
        }
    }

    public class TranslatorAdapter : IVietnameseTarget
    {
        private JapaneseAdaptee adaptee;

        public TranslatorAdapter(JapaneseAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Send(string words)
        {
            Console.Write("Reading Words ...");
            Console.WriteLine(words);
            String vietnameseWords = this.Tranlate(words);
            Console.Write("Sending Words ...");
            this.adaptee.Receive(vietnameseWords);
        }

        private string Tranlate(string vietnameseWords)
        {
            Console.WriteLine("Tranlated!");
            return "こんにちは";
        }
    }
}
