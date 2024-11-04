using System.Windows;

namespace InteractibleCharactersApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Position the window near the taskbar
            PositionWindow();
        }

        private void PositionWindow()
        {
            // Example: place the window near the bottom-right corner of the screen
            this.Left = SystemParameters.WorkArea.Width - this.Width - 20;
            this.Top = SystemParameters.WorkArea.Height - this.Height - 20;
        }
    }
}