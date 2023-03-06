using Accessibility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json2PdF.Window.ViewModels
{
    public class RichTextViewModel
    {
        public RichTextViewModel()
        {

        }

        private FontFamily _activeFont;

        public FontFamily ActiveFont
        {
            get { return _activeFont; }
            set { _activeFont = value; }
        }

        private int _activeFontStyle;

        public int ActiveFontStyle
        {
            get { return _activeFontStyle; }
            set { _activeFontStyle = value; }
        }

        private int _activeFontSize;

        public int ActiveFontSize
        {
            get { return _activeFontSize; }
            set { _activeFontSize = value; }
        }


    }
}
