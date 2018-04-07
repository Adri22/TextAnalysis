using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TextAnalysis.Components {
    class DictionaryHandler {
        private String dictionaryPath;
        private XmlDocument xmlDocument;
        private Language language;
        public List<String> articleList { get; }
        public List<String> verbList { get; }

        public enum Language {
            DE, EN
        }

        public DictionaryHandler() : this(Language.DE) { }

        public DictionaryHandler(Language language) {
            articleList = new List<String>();
            verbList = new List<String>();
            dictionaryPath = @"..\..\Resources\Dictionary_"; // TODO: create path with Directory-Class?
            ChangeLanguage(language);
        }

        private void LoadDictionary() {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(dictionaryPath + ".xml");
            articleList.Clear();
            verbList.Clear();

            foreach(XmlNode node in xmlDocument.DocumentElement.GetElementsByTagName("Article")) {
                articleList.Add(node.InnerText);
            }

            foreach(XmlNode node in xmlDocument.DocumentElement.GetElementsByTagName("Verb")) {
                verbList.Add(node.InnerText);
            }
        }

        public void ChangeLanguage(Language language) {
            this.language = language;

            switch(this.language) {
                case Language.EN:
                    dictionaryPath += "EN";
                    break;
                case Language.DE:
                default:
                    dictionaryPath += "DE";
                    break;
            }

            LoadDictionary();
        }
    }
}