using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Threading;

namespace Sul
{
  public static class UI
  {
    /**
    * @brief A public static method to append text to RichTextBox control.
    * @see RichTextBox
    * @note
    *  The block height on RichTextBox shall be set "1" on xaml file, i.e. Block.LineHeight="1".
    */
    public static void vidAppendLog(
      RichTextBox rtb,
      String strLog
      )
    {
      var paragraph = new Paragraph();
      
      paragraph.Inlines.Add(new Run(strLog));
      rtb.Document.Blocks.Add(paragraph);

      rtb.Focus();
      rtb.ScrollToEnd();
    }
  }
};
