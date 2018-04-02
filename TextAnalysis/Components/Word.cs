using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Word {
        public String word { get; }
        private Char punctuationChar;
        private WordType type;

        private enum WordType {
            ARTICLE,
            VERB,
            NOUN,
            UNKNOWN
        }

        public Word(String word) {
            this.word = word;
            CheckType();
        }

        public Word(String word, Char punctuationChar) {
            this.word = word;
            this.punctuationChar = punctuationChar;
            CheckType();
        }

        private void CheckType() {
            // placeholder
        }

        public String ToString() {
            StringBuilder stringBuilder = new StringBuilder("<");

            switch(type) {
                case WordType.ARTICLE:
                    stringBuilder.Append("Article");
                    break;
                case WordType.VERB:
                    stringBuilder.Append("Verb");
                    break;
                case WordType.NOUN:
                    stringBuilder.Append("Noun");
                    break;
                case WordType.UNKNOWN:
                default:
                    stringBuilder.Append("Unknown");
                    break;
            }

            stringBuilder.Append(" | " + word + ">");
            return stringBuilder.ToString();
        }
    }
}