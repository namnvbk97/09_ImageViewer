using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Vision.Controls;
using Vision.Image;
using WPF.Common;

namespace ImageViewerTest
{
    public class MainContext: NotifyPropertyChanged
    {
        #region User DataContext
        private ImageViewerContext _imageContext = new ImageViewerContext();

        public ImageViewerContext ImageContext
        {
            get => _imageContext;
            set => _imageContext = value;
        }
        #endregion

        #region Command
        public RelayCommand LoadImageCommand { get; set; }
        #endregion

        #region Init
        public MainContext() 
        {
            LoadImageCommand = new RelayCommand(OnLoadImageCommand);
        }
        #endregion

        #region OnCommand
        private void OnLoadImageCommand(object o)
        {
            Ookii.Dialogs.Wpf.VistaOpenFileDialog op = new Ookii.Dialogs.Wpf.VistaOpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == true)                            // Hiển thị form chọn file ảnh
            { 
                string file           = op.FileName;                // Lấy đường dẫn ảnh
                BitmapSource bmsColor = BitmapSourceEx.Load(file);  // Load ảnh theo đường dẫn
                ImageContext.Image    = bmsColor;                   // Hiển thị ảnh lên ImageViewer
            }    
           
        }
        #endregion

    }
}
