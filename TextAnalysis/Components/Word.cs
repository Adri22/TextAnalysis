using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Word {
        public String content { get; }
        private Dictionary.WordType type;
        private Dictionary dictionary;
        private Char punctuationChar;

        public Word(String content) {
            dictionary = Dictionary.GetInstance();
            this.content = content;
            type = dictionary.GetTypeOfWord(this.content);
        }

        public Word(String content, Char punctuationChar) {
            dictionary = Dictionary.GetInstance();
            this.content = content;
            this.punctuationChar = punctuationChar;
            type = dictionary.GetTypeOfWord(this.content);
        }

        public override String ToString() {
            StringBuilder stringBuilder = new StringBuilder("<");

            switch(type) {
                case Dictionary.WordType.ARTICLE:
                    stringBuilder.Append("Article");
                    break;
                case Dictionary.WordType.VERB:
                    stringBuilder.Append("Verb");
                    break;
                case Dictionary.WordType.NOUN:
                    stringBuilder.Append("Noun");
                    break;
                case Dictionary.WordType.UNKNOWN:
                default:
                    stringBuilder.Append("Unknown");
                    break;
            }

            stringBuilder.Append(" | " + content + ">");
            return stringBuilder.ToString();
        }
    }
}