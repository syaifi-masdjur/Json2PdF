using Accessibility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2PdF.Window.ViewModels
{
    public class RichTextViewModel: BaseViewModel
    {
        public RichTextViewModel()
        {

        }

        private FontFamily? _activeFontFamily;

        public FontFamily? ActiveFontFamily
        {
            get { return _activeFontFamily; }
            set { _activeFontFamily = value; 
                OnPropertyChanged("ActiveFontFamily");
            }
        }

        private KeyValuePair<int, string> _activeFontStyle;

        public KeyValuePair<int,string> ActiveFontStyle
        {
            get { return _activeFontStyle; }
            set { _activeFontStyle = value; 
                OnPropertyChanged("ActiveFontStyle");
            }
        }

        private int _activeFontSize;

        public int ActiveFontSize
        {
            get { return _activeFontSize; }
            set { _activeFontSize = value; 
                OnPropertyChanged("ActiveFontSize");
            }
        }


    }
}
