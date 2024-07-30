using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WPF.Common;

namespace Vision.Controls
{
    public class ImageViewerContext: NotifyPropertyChanged
    {
        private BitmapSource _image = null;

        public BitmapSource Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        public ImageViewerContext()
        {

        }
    }
}
