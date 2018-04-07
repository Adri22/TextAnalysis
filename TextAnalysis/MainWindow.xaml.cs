using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextAnalysis.Components;

namespace TextAnalysis {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // test test test
            String s = "Debuggen ist der Vorgang, ein Programm zu schreiben. Deshalb ist Programmierung der Vorgang, Fehler in ein Programm einzubauen. Es ist besser, weniger Fehler in ein Programm einzubauen. Das braucht nur Zeit, diese wieder zu entfernen";
            Text text = new Text(s); // test

            Word[] words = text.GetAllWords();

            for(int i = 0; i < words.Length; i++) {
                // Console.WriteLine(words[i]);
            }

            // Console.WriteLine(text);

            DictionaryHandler dh = new DictionaryHandler();

            foreach(String article in dh.articleList) {
                Console.WriteLine(article);
            }

            foreach(String verb in dh.verbList) {
                Console.WriteLine(verb);
            }

        }
    }
}