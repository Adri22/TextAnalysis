using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Sentence {
        private String content;
        public Word[] words { get; }
        private Char[] punctuations = new Char[] {
            ',', ':', ';', '?', '!' // TODO: add more?
        };

        public Sentence(String content) {
            this.content = content;
            String[] words = this.content.Split(' ');
            this.words = new Word[words.Length];

            for(int i = 0; i < words.Length; i++) {
                this.words[i] = new Word(words[i]);

                for(int j = 0; j < punctuations.Length; j++) { // Punctuation-Handling
                    if(words[i].EndsWith(punctuations[j].ToString())) { // TODO: include prefix-handling?
                        words[i] = words[i].Remove(words[i].Length - 1, 1);
                        this.words[i] = new Word(words[i], punctuations[j]);
                        break;
                    }
                }
            }
        }

        public override String ToString() {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < words.Length; i++) {
                stringBuilder.Append(words[i].ToString());
            }

            return stringBuilder.ToString();
        }
    }
}