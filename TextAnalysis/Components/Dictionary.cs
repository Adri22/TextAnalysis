using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Dictionary {
        private List<String> articleList;
        private List<String> verbList;
        private List<String> nounList;

        public Dictionary() {
            articleList = new List<string>();
            verbList = new List<string>();
            nounList = new List<string>();
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

        public bool ContainsArticle(String article) {
            return articleList.Contains(article) ? true : false;
        }

        public bool ContainsVerb(String verb) {
            return verbList.Contains(verb) ? true : false;
        }

        public bool ContainsNoun(String noun) {
            return nounList.Contains(noun) ? true : false;
        }
    }
}