using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfCustomControlLibrary1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Document doc = Document();
            doc.LoadFromFile(@"C:/Users/Andre/OneDrive/Рабочий стол/ворд.docx");
            doc.SaveFile("конвертировали.rtf", FileFormat.Rtf);

            var range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            var fs = new FileStream("конвертировали.rtf", FileMode.OpenOrCreate);
            range.Load(fs, DataFormats.Rtf);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            var fs = new FileStream("конвертировали.rtf", FileMode.OpenOrCreate);
            range.Save(fs, DataFormats.Rtf);
            fs.Close();

            Document d = new Document();
            d.LoadFromFile("конвертировать.rtf");
            d.SaveToFile(@"D:/Рабочий стол/ворд.docx", FileFormat.Docx);
        }
    }
}
