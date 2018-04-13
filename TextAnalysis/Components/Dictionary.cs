using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Dictionary {
        private static Dictionary instance;
        private List<String> articleList;
        private List<String> verbList;
        private List<String> nounList;

        public enum WordType {
            ARTICLE,
            VERB,
            NOUN,
            UNKNOWN
        }

        private Dictionary() {
            articleList = new List<string>();
            verbList = new List<string>();
            nounList = new List<string>();
        }

        public static Dictionary GetInstance() {
            if(instance == null) {
                instance = new Dictionary();
            }
            return instance;
        }

        public void AddArticle(String article) {
            articleList.Add(article);
        }

        public void AddVerb(String verb) {
            verbList.Add(verb);
        }

        public void AddNoun(String noun) {
            nounList.Add(noun);
        }

        public void ClearAll() {
            articleList.Clear();
            verbList.Clear();
            nounList.Clear();
        }

        public WordType GetTypeOfWord(String word) {
            if(articleList.Contains(word)) {
                return WordType.ARTICLE;
            } else if(verbList.Contains(word)) {
                return WordType.VERB;
            } else if(nounList.Contains(word)) {
                return WordType.NOUN;
            } else {
                return WordType.UNKNOWN;
            }
        }
    }
}