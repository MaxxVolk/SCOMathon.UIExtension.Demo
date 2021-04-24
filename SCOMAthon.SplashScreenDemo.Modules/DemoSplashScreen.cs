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

namespace SCOMAthon.SplashScreenDemo.Modules
{
  public partial class DemoSplashScreen : MomViewBase // UserControl -- replace it with MomViewBase
  {
    public DemoSplashScreen() : base(null)
    {
      InitializeComponent();
      Init();
    }

    public DemoSplashScreen(IViewTargetParser parser) : base(parser)
    {
      InitializeComponent();
      Init();
    }

    public DemoSplashScreen(Guid containerId, IViewTargetParser parser) : base(containerId, parser)
    {
      InitializeComponent();
      Init();
    }

    public DemoSplashScreen(IContainer parentContainer) : base(null)
    {
      ConnectToSite(parentContainer);
      InitializeComponent();
      Init();
    }

    public override string ViewName { get { return GetType().FullName; } }

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

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      // management group connection is not available in constructor
      lMGName.Text = ManagementGroup.Name;
      lMGId.Text = ManagementGroup.Id.ToString();
      lbConnectedUsers.Items.Clear();
      foreach (string user in ManagementGroup.GetConnectedUserNames())
        lbConnectedUsers.Items.Add(user);
    }
  }
}
