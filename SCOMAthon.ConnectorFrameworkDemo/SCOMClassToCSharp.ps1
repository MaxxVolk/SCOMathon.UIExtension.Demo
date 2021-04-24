# This file is not a part of the management pack, but used to generate C# code to manipulate SCOM class instances.

# Modify SCOM class name and resultant C# class name, then run the script.

## Inputs ##
cls
$InputClassName = "SCOMAthon.ConnectorFrameworkDemo.DemoClass" # Input: SCOM Class name
$ClassOnlyName = "SCOMAthonDemoClass" # Output: C# class name
$GenerateIDs = $true # Input: Create C# ID class -- the SCOM class ID and a list of all the property IDs
$GenerateClassAdapter = $true # Input: Create SCOM class adapter to use in with Maximus.Library.SCOM.Editors.SCOMClassInstanceEditor<T>
# $CopyToClipboard = $true # Input: not supported yet

$SCOMClass = Get-SCOMClass -Name $InputClassName

if ($GenerateIDs)
{
Write-Output "#region $($SCOMClass.Name)"
Write-Output "/// <summary>"
Write-Output "/// $($SCOMClass.DisplayName) ($($SCOMClass.Name))"
Write-Output "/// </summary>"
Write-Output "public static Guid $($ClassOnlyName)ClassId { get; } = new Guid(""$($SCOMClass.Id)"");"
if ($SCOMClass.PropertyCollection.Count -ge 1)
{
  Write-Output "public static class $($ClassOnlyName)ClassProperties"
  Write-Output "{"
  foreach ($property in $SCOMClass.PropertyCollection)
  {
    Write-Output "  /// <summary>"
    $descriptionLine = "  /// $($SCOMClass.Name)/$($property.Name)"
    if ($property.Key)
    {
      $descriptionLine += " (Key)"
    }
    Write-Output $descriptionLine
    Write-Output "  /// </summary>"
    Write-Output "  public static Guid $($property.Name)PropertyId { get; } = new Guid(""$($property.Id)"");"
  }
  Write-Output "}"
}
Write-Output "#endregion"
Write-Output ""
}

if ($GenerateClassAdapter)
{
Write-Output "#region $($SCOMClass.Name) Adapter"
Write-Output "/// <summary>"
Write-Output "/// $($SCOMClass.DisplayName) ($($SCOMClass.Name)) Adapter"
Write-Output "/// </summary>"
if ($SCOMClass.PropertyCollection.Count -ge 1)
{
  Write-Output "public class $($ClassOnlyName)ClassAdapter : SCOMClassInstanceAdapter"
  Write-Output "{"
  foreach ($property in $SCOMClass.PropertyCollection)
  {
    if ($property.Key)
    {
      Write-Output "  /// <summary>"
      Write-Output "  /// $($SCOMClass.Name)/$($property.Name)"
      Write-Output "  /// </summary>"
      Write-Output "  private $($property.SystemType.Name) _$($property.Name);"
      Write-Output "  [SCOMClassProperty(""$($property.Id)"")]"
      Write-Output "  public $($property.SystemType.Name) $($property.Name)"
      Write-Output "  {"
      Write-Output "  get => _$($property.Name);"
      Write-Output "  set"
      Write-Output "  {"
      Write-Output "  if (CommitStatus == InstanceCommitStatus.New)"
      Write-Output "    _$($property.Name) = value;"
      Write-Output "  else"
      Write-Output "  throw new SCOMClassInstanceEditorException(""Cannot change key."");"
      Write-Output "    PropertyChangedInvoke(nameof($($property.Name)));"
      Write-Output "  }"
      Write-Output "  }"
      Write-Output "  "
    }
    else
    {
      Write-Output "  /// <summary>"
      Write-Output "  /// $($SCOMClass.Name)/$($property.Name)"
      Write-Output "  /// </summary>"
      Write-Output "  private $($property.SystemType.Name) _$($property.Name);"
      Write-Output "  [SCOMClassProperty(""$($property.Id)"")]"
      Write-Output "  public $($property.SystemType.Name) $($property.Name)"
      Write-Output "  {"
      Write-Output "  get => _$($property.Name);"
      Write-Output "  set"
      Write-Output "  {"
      Write-Output "    _$($property.Name) = value;"
      Write-Output "    PropertyChangedInvoke(nameof($($property.Name)));"
      Write-Output "  }"
      Write-Output "  }"
      Write-Output "  "
    }
  }
  Write-Output "}"
}
Write-Output "#endregion"
Write-Output ""
}