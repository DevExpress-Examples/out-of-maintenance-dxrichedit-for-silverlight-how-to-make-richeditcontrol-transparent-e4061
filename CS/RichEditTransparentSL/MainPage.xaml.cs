using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditTransparentSL {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void richEditControl1_Loaded(object sender, RoutedEventArgs e) {
            richEditControl1.ApplyTemplate();
            richEditControl1.Views.SimpleView.BackColor = Colors.Transparent;
            richEditControl1.Views.DraftView.BackColor = Colors.Transparent;
            richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
            richEditControl1.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden;

            Section firstSection = richEditControl1.Document.Sections[0];
            firstSection.Margins.Left = 0;
            firstSection.Margins.Top = 0;
            firstSection.Margins.Right = 0;
            firstSection.Margins.Bottom = 0;
            firstSection.Page.Width = Units.InchesToDocumentsF(2.3f);
            firstSection.Page.Height = Units.InchesToDocumentsF(3f);
        }
    }
}