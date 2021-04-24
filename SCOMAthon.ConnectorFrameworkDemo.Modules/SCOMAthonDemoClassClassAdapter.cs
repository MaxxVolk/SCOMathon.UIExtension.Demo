using Maximus.Library.SCOM.Editors;

namespace SCOMAthon.ConnectorFrameworkDemo.Modules
{
  #region SCOMAthon.ConnectorFrameworkDemo.DemoClass Adapter
  /// <summary>
  /// SCOMAthon Demo Class (SCOMAthon.ConnectorFrameworkDemo.DemoClass) Adapter
  /// Generated with SCOMClassToCSharp.ps1
  /// </summary>
  public class SCOMAthonDemoClassClassAdapter : SCOMClassInstanceAdapter
  {
    /// <summary>
    /// SCOMAthon.ConnectorFrameworkDemo.DemoClass/KeyProperty
    /// </summary>
    private string _KeyProperty;
    [SCOMClassProperty("050dcd5c-8a4c-bcaf-d258-a75b462e27b8")]
    public string KeyProperty
    {
      get => _KeyProperty;
      set
      {
        if (CommitStatus == InstanceCommitStatus.New)
          _KeyProperty = value;
        else
          throw new SCOMClassInstanceEditorException("Cannot change key.");
        PropertyChangedInvoke(nameof(KeyProperty));
      }
    }

    /// <summary>
    /// SCOMAthon.ConnectorFrameworkDemo.DemoClass/StringProperty
    /// </summary>
    private string _StringProperty;
    [SCOMClassProperty("e323f172-29c4-7a1e-98d1-9e1bd9618d0c")]
    public string StringProperty
    {
      get => _StringProperty;
      set
      {
        _StringProperty = value;
        PropertyChangedInvoke(nameof(StringProperty));
      }
    }

    /// <summary>
    /// SCOMAthon.ConnectorFrameworkDemo.DemoClass/IntProperty
    /// </summary>
    private int _IntProperty;
    [SCOMClassProperty("1d599ddd-ed5a-8d82-ebe7-c2de55029ad8")]
    public int IntProperty
    {
      get => _IntProperty;
      set
      {
        _IntProperty = value;
        PropertyChangedInvoke(nameof(IntProperty));
      }
    }

  }
  #endregion
}
