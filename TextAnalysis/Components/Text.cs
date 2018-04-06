using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Text {
        private String content;
        public Sentence[] sentences { get; }

        public Text(String content) {
            this.content = content;
            String[] sentences = this.content.Split('.');
            this.sentences = new Sentence[sentences.Length];

            for(int i = 0; i < sentences.Length; i++) {
                if(sentences[i].StartsWith(" ")) {
                    sentences[i] = sentences[i].Remove(0, 1);
                }

                this.sentences[i] = new Sentence(sentences[i]);
            }
        }

        public Word[] GetAllWords() {
            Word[] words;
            int wordCounter = 0;

            for(int i = 0; i < sentences.Length; i++) {
                wordCounter += sentences[i].words.Length;
            }

            words = new Word[wordCounter];
            wordCounter = 0;

            for(int i = 0; i < sentences.Length; i++) {
                for(int j = 0; j < sentences[i].words.Length; j++) {
                    words[wordCounter + j] = sentences[i].words[j];
                }
                wordCounter += sentences[i].words.Length;
            }

            return words;
        }

        public override String ToString() {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < sentences.Length; i++) {
                stringBuilder.Append(sentences[i].ToString());
            }

            return stringBuilder.ToString();
        }
    }
}