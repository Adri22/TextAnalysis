using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Text {
        private String text;
        private Sentence[] sentences { get; }
        // private Word[] words { get; }

        public Text(String text) {
            this.text = text;
            String[] sentences = this.text.Split('.');
            this.sentences = new Sentence[sentences.Length];

            for(int i = 0; i < sentences.Length; i++) {
                if(sentences[i].StartsWith(" ")) {
                    sentences[i] = sentences[i].Remove(0, 1);
                }

                this.sentences[i] = new Sentence(sentences[i]);

                // Console.WriteLine(sentences[i]);
            }
        }



    }
}