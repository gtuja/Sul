using System.Xml.Linq;

#pragma warning disable IDE1006 // Naming Styles

/**
 * @brief A namespace for common utility.
 * @see Sul.UI
 * @see Sul.Xml
 * @see Sul.Debug
 */
namespace Sul;

/**
* @brief A public static class holding utilities for extracting XML, e.g., descendants, attribute, value, etc.
* @see using System.Xml.Linq
* @see using System.Reflection
*/
public static class Xml
{
  public const String Nothing = @"Nothing";

  /**
  * @brief A public static method to get descendants of dedicated tag(strTagName) on a xml file(strPath).
  * @param strPath A String object holding the file path of a xml file.
  * @param strTagName A String object holding the tag name to get.
  * @param lstException A list object to store exception information.
  * @return lstReturn A list object holding XElements extracted.
  * @see System.Reflection.MethodBase
  */
  public static List<XElement> lstGetDescendants(
    String strPath,
    String strTagName,
    List<String> lstException
    )
  {
    List<XElement> lstReturn = [];
    try
    {
      XDocument xd = XDocument.Load(strPath);
      foreach(XElement xe in xd.Descendants(strTagName))
      {
        lstReturn.Add(xe);
      }
    }
    catch (Exception e)
    {
      lstException.Add(Sul.Debug.strGetMethodNme() + " : " + e.ToString());
    }
    return lstReturn;
  }

  /**
  * @brief A public static method to get descendants of dedicated tag(strTagName) on a XElement(xeElement).
  * @param xeElement A XElement object for extracting.
  * @param strTagName A String object holding the tag name to get.
  * @param lstException A list object to store exception information.
  * @return lstReturn A list object holding XElements extracted.
  * @see System.Reflection.MethodBase
  */
  public static List<XElement> lstGetDescendants(
    XElement xeElement,
    String strTagName,
    List<String> lstException
    )
  {
    List<XElement> lstReturn = [];
    try
    {
      foreach(XElement xe in xeElement.Descendants(strTagName))
      {
        lstReturn.Add(xe);
      }
    }
    catch (Exception e)
    {
      lstException.Add(Sul.Debug.strGetMethodNme() + " : " + e.ToString());
    }
    return lstReturn;
  }

  /**
  * @brief A public static method to get the first descendants of dedicated tag(strTagName) on a XElement(xeElement).
  * @param xeElement A XElement object for extracting.
  * @param strTagName A String object holding the tag name to get.
  * @param lstException A list object to store exception information.
  * @return xeReturn A XElement object holding the first descendant.
  * @see System.Reflection.MethodBase
  */
  public static XElement xeGetFirstDescendant(
    XElement xeElement,
    String strTagName,
    List<String> lstException
    )
  {
    XElement xeReturn = new (Xml.Nothing);
    try
    {
      foreach(XElement xe in xeElement.Descendants(strTagName))
      {
        if (xe.Name.ToString() == strTagName)
        {
          xeReturn = xe;
          break;
        }
      }
    }
    catch (Exception e)
    {
      lstException.Add(Sul.Debug.strGetMethodNme() + " : " + e.ToString());
    }
    return xeReturn;
  }
};
