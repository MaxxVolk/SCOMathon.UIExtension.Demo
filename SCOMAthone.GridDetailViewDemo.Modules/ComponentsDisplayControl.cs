using Microsoft.EnterpriseManagement.Common;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.Mom.Internal.UI;
using Microsoft.EnterpriseManagement.Mom.Internal.UI.Common;
using Microsoft.EnterpriseManagement.Monitoring;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCOMAthon.GridDetailViewDemo.Modules
{
  public partial class ComponentsDisplayControl : CachedDetailView<PartialMonitoringObject>, IDisposable
  {
    public ComponentsDisplayControl()
    {
      InitializeComponent();
    }

    protected virtual void RefreshColors()
    {
      if (SystemInformation.HighContrast)
      {
        BackColor = SystemColors.Control;
      }
      else
      {
        BackColor = BrandedColors.OverviewBackgroundColor;
      }
    }

    protected override void OnSystemColorsChanged(EventArgs e)
    {
      RefreshColors();
    }

    protected override void OnForeColorChanged(EventArgs e)
    {
      base.OnForeColorChanged(e);
      RefreshColors();
    }

    public override string ViewName => "Server details view.";

    private ManagementPackClass logicalDiskClass = null;
    private Guid diskSizeStrPropertyId = Guid.Parse("60c0b971-d523-6564-0be5-e8649e194a25"); // (Get-SCOMClass -id 486adddb-2eb8-819a-fa24-8f6ab3e29543).propertycollection | ft name, displayname, type, id

    public override void OnCacheUpdated(PartialMonitoringObject monitoringObjectContext)
    {
      lvDisks.Items.Clear();
      if (monitoringObjectContext == null)
      {
        ShowStatusMessage("No computer object selected.", false);
        return;
      }
      HideStatusMessage();
      #region Show information related to the currently selected object
      if (logicalDiskClass == null)
        logicalDiskClass = ManagementGroup.EntityTypes.GetClass(Guid.Parse("486adddb-2eb8-819a-fa24-8f6ab3e29543")); // Microsoft.Windows.Server.LogicalDisk
      if (logicalDiskClass == null)
        return;
      IList<EnterpriseManagementRelationshipObject<MonitoringObject>> allDisksLinks = ManagementGroup.EntityObjects.GetRelationshipObjectsWhereSource<MonitoringObject>(monitoringObjectContext.Id, TraversalDepth.OneLevel, ObjectQueryOptions.Default);
      if (allDisksLinks != null && allDisksLinks.Count > 0)
        foreach (MonitoringObject diskMo in allDisksLinks.Where(r=>r.TargetObject.IsInstanceOf(logicalDiskClass)).Select(dl => dl.TargetObject).OrderBy(o=>o.Name))
          lvDisks.Items.Add(new ListViewItem(new string[] { diskMo.DisplayName, (Convert.ToDecimal(diskMo[diskSizeStrPropertyId].Value) / 1024 / 1024 / 1024).ToString("N2") })); // KB->MB->GB
      #endregion
    }
  }
}
