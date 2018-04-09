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
        private Dictionary dictionary;
        private Language language;

        public enum Language {
            DE, EN
        }

        public DictionaryHandler() : this(Language.DE) { }

        public DictionaryHandler(Language language) {
            dictionary = new Dictionary();
            dictionaryPath = @"..\..\Resources\Dictionary_"; // TODO: create path with Directory-Class?
            ChangeLanguage(language);
        }

        private void LoadDictionary(String path) {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(path + ".xml");
            dictionary.ClearAll();

            foreach(XmlNode node in xmlDocument.DocumentElement.GetElementsByTagName("Article")) {
                dictionary.AddArticle(node.InnerText);
            }

            foreach(XmlNode node in xmlDocument.DocumentElement.GetElementsByTagName("Verb")) {
                dictionary.AddVerb(node.InnerText);
            }
        }

        public void ChangeLanguage(Language language) {
            this.language = language;

            switch(this.language) {
                case Language.EN:
                    LoadDictionary(dictionaryPath + "EN");
                    break;
                case Language.DE:
                default:
                    LoadDictionary(dictionaryPath + "DE");
                    break;
            }
        }

        public Dictionary GetDictionary() {
            return dictionary;
        }
    }
}