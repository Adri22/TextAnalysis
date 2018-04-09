using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis.Components {
    class Dictionary {
        private List<String> articleList;
        private List<String> verbList;

        public Dictionary() {
            articleList = new List<string>();
            verbList = new List<string>();
        }

        public void AddArticle(String article) {
            articleList.Add(article);
        }

        public void AddVerb(String verb) {
            verbList.Add(verb);
        }

        public void ClearAll() {
            articleList.Clear();
            verbList.Clear();
        }

        public bool ContainsArticle(String article) {
            return articleList.Contains(article) ? true : false;
        }

        public bool ContainsVerb(String verb) {
            return verbList.Contains(verb) ? true : false;
        }
    }
}