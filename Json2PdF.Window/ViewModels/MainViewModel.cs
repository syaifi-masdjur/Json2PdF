using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace Json2PdF.Window.ViewModels
{
    public class MainViewModel: BaseViewModel
    {

        public MainViewModel()
        {
            _fonts = new List<FontFamily>();
            _fontStyle = new Dictionary<int, string>();
            _fontSize = new List<int>();

            initialFonts();
            _selectedFont = _fonts.FirstOrDefault();

            initialStyle();
            _selectedFontStyle = _fontStyle.First();

            initializeFontSize();
            _editorVM = new RichTextViewModel();
            _editorVM.ActiveFontFamily = _selectedFont;
            _editorVM.ActiveFontSize = 12;
            _editorVM.ActiveFontStyle = _selectedFontStyle;
        }


        private void initialFonts()
        {

            InstalledFontCollection  installedFont = new InstalledFontCollection();

            foreach (var font in installedFont.Families)
            {
                _fonts.Add(font);
            }
        }


        private IList<FontFamily> _fonts;

        public IList<FontFamily> Fonts
        {
            get { return _fonts; }
            set { _fonts = value; }
        }

        private FontFamily? _selectedFont;

        public FontFamily? SelectedFont
        {
            get { return _selectedFont; }
            set { _selectedFont = value;
                EditorVM.ActiveFontFamily = _selectedFont;
                OnPropertyChanged("SelectedFont");
            }
        }

        private void initialStyle()
        {
            _fontStyle.Add(Convert.ToInt16(FontStyle.Regular), FontStyle.Regular.ToString());
            _fontStyle.Add(Convert.ToInt16(FontStyle.Bold), FontStyle.Bold.ToString());
            _fontStyle.Add(Convert.ToInt16(FontStyle.Italic), FontStyle.Italic.ToString());
            _fontStyle.Add(Convert.ToInt16(FontStyle.Underline), FontStyle.Underline.ToString());
            _fontStyle.Add(Convert.ToInt16(FontStyle.Strikeout), FontStyle.Strikeout.ToString());
        }

        private Dictionary<int, string> _fontStyle;
        public Dictionary<int, string> FontStyles
        {
           get { return _fontStyle; }
            set { _fontStyle = value;
            }
        }

        private KeyValuePair<int,string> _selectedFontStyle;

        public KeyValuePair<int, string> SelectedFontStyle
        {
            get { return _selectedFontStyle; }
            set { 
                _selectedFontStyle = value;
                EditorVM.ActiveFontStyle = _selectedFontStyle;
                OnPropertyChanged("SelectedFont");
            }
        }

        private void initializeFontSize()
        {
            _fontSize.Add(8);
            _fontSize.Add(9);
            _fontSize.Add(10);
            _fontSize.Add(11);
            _fontSize.Add(12);
            _fontSize.Add(14);
            _fontSize.Add(16);
            _fontSize.Add(18);
            _fontSize.Add(20);
            _fontSize.Add(22);
            _fontSize.Add(24);
            _fontSize.Add(26);
            _fontSize.Add(28);
            _fontSize.Add(36);
            _fontSize.Add(72);
        }

        private IList<int> _fontSize;

        public IList<int> FontSize
        {
            get { return _fontSize; }
            set { 
                _fontSize = value;
                OnPropertyChanged("FontSize");
            }
        }

        private RichTextViewModel _editorVM;

        public RichTextViewModel EditorVM
        {
            get { return _editorVM; }
            set { _editorVM = value; }
        }

    }
}
