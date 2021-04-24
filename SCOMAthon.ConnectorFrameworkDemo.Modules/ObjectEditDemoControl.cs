using Maximus.Library.SCOM.Editors;
using Maximus.Library.Helpers;

using Microsoft.EnterpriseManagement.ConnectorFramework;
using Microsoft.EnterpriseManagement.Mom.Internal.UI;
using Microsoft.EnterpriseManagement.Mom.Internal.UI.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EnterpriseManagement.ConsoleFramework;

namespace SCOMAthon.ConnectorFrameworkDemo.Modules
{
  public partial class ObjectEditDemoControl : MomViewBase
  {
    private MonitoringConnector myConnector;
    private SCOMClassInstanceEditor<SCOMAthonDemoClassClassAdapter> scieDemoObjects;
    private BindingSource bsDemoObjects;

    private readonly Guid myConnectorId = Guid.Parse("{DBF18141-488D-42C4-BB45-FC3AA515B052}");
    private const string myConnectorName = "SCOMAthonDemoConnector";
    private const string myConnectorDisplayName = "SCOMAthon Demo Connector";
    private const string myConnectorDescription = "Connector for Managed Object Edit demo.";

    public ObjectEditDemoControl() : base(null)
    {
      InitializeComponent();
      Init();
    }

    public ObjectEditDemoControl(IViewTargetParser parser) : base(parser)
    {
      InitializeComponent();
      Init();
    }

    public ObjectEditDemoControl(Guid containerId, IViewTargetParser parser) : base(containerId, parser)
    {
      InitializeComponent();
      Init();
    }

    public ObjectEditDemoControl(System.ComponentModel.IContainer parentContainer) : base(null)
    {
      ConnectToSite(parentContainer);
      InitializeComponent();
      Init();
    }

    protected override void Initialize()
    {
      if (DesignMode)
        return;
      base.Initialize();
    }

    private void Init()
    {
      RefreshColors();
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

    private void RefreshColors()
    {
      if (SystemInformation.HighContrast)
      {
        BackColor = SystemColors.Control;
      }
      else
      {
        BackColor = BrandedColors.OverviewBackgroundColor;
        dgvDemoObjects.BackgroundColor = BrandedColors.GridBackground;
      }
    }

    public override string ViewName => "SCOMAthon Object Editor Demo";

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      dgvDemoObjects.AutoGenerateColumns = false;

      try
      {
        // Extension method GetOrCreateConnector defined in Maximus.Base.Library.Console assembly, see https://github.com/MaxxVolk/Maximus.Base.Library/tree/master/Maximus.Base.Library.Console
        myConnector = ManagementGroup.ConnectorFramework.GetOrCreateConnector(
          connectorID: myConnectorId,
          name: myConnectorName,
          displayName: myConnectorDisplayName,
          description: myConnectorDescription,
          discoveryDataIsManaged: true
          );
        if (myConnector == null)
          throw new Exception("Cannot find/create the connector.");

        ConsoleJobs.RunJob(this, delegate
        {
          // inserted object will be hosted at All Management Servers Resource Pool
          scieDemoObjects = new SCOMClassInstanceEditor<SCOMAthonDemoClassClassAdapter>(managementGroup: ManagementGroup,
           seedClass: ManagementGroup.EntityTypes.GetClass(DemoClassIds.SCOMAthonDemoClassClassId),
           insertConnector: myConnector);
        });
        if (scieDemoObjects == null)
          throw new Exception("Cannot load management point editor.");
        bsDemoObjects = new BindingSource
        {
          DataSource = scieDemoObjects
        };
        dgvDemoObjects.DataSource = bsDemoObjects;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btDelete_Click(object sender, EventArgs e)
    {
      if (dgvDemoObjects.SelectedRows != null && dgvDemoObjects.SelectedRows.Count > 0)
      {
        List<SCOMAthonDemoClassClassAdapter> itemsToDelete = new List<SCOMAthonDemoClassClassAdapter>(dgvDemoObjects.SelectedRows.Count);
        foreach (DataGridViewRow gridRow in dgvDemoObjects.SelectedRows)
          itemsToDelete.Add((SCOMAthonDemoClassClassAdapter)gridRow.DataBoundItem);
        foreach (SCOMAthonDemoClassClassAdapter item in itemsToDelete)
          scieDemoObjects.Remove(item);
      }
    }

    private void dgvDemoObjects_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      MessageBox.Show($"Invalid value or edit not allowed.\r\nError: {e.Exception?.Message ?? "No error specified."}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
