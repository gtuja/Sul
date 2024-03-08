using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sul;

namespace ShowCaseWpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  private readonly RichTextBox rtbLog;

  public MainWindow()
  {
    InitializeComponent();
    this.rtbLog = RichTextBoxLog;
  }

  private void vidBtnExecuteClick(
    object objSender,
    RoutedEventArgs reaEvent
  )
  {
    Sul.UI.vidAppendLog(this.rtbLog, "AAAAAA");
  }
}