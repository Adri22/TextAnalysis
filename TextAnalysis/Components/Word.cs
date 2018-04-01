using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Word {
        private String word;
        private WordType type;
        // private Char punctuationChar;
        // private bool hasSuffix;

        public enum WordType {
            ARTICLE,
            VERB,
            NOUN,
            UNKNOWN
        }

        public Word(String word) {
            this.word = word;
        }



    }
}