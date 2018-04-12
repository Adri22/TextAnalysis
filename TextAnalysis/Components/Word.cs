using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Word {
        public String content { get; }
        private Char punctuationChar;
        private WordType type;

        private enum WordType {
            ARTICLE,
            VERB,
            NOUN,
            UNKNOWN
        }

        public Word(String content) {
            this.content = content;
            CheckType();
        }

        public Word(String content, Char punctuationChar) {
            this.content = content;
            this.punctuationChar = punctuationChar;
            CheckType();
        }

        private void CheckType() {

        }

        public override String ToString() {
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

            stringBuilder.Append(" | " + content + ">");
            return stringBuilder.ToString();
        }
    }
}