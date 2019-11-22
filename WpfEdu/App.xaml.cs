using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using WpfEdu.Views;

namespace WpfEdu
{
	/// <summary>
	/// App.xaml の相互作用ロジック
	/// </summary>
	public partial class App : PrismApplication
	{
		protected override Window CreateShell()
		{
			return this.Container.Resolve<MainWindow>();
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
		}
	}
}
