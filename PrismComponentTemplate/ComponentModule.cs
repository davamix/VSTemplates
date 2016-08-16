using Prism.Modularity;
using Prism.Regions;
using PrismComponentTemplate.Views;

namespace PrismComponentTemplate
{
	/*
	 * You can create a Post-Build event script to copy the .dll to the components folder of the main app.
	 * xcopy "$(TargetPath)" "$(SolutionDir)\bin\Debug\Components" /y
	 */
	public class ComponentModule : IModule
	{
		private readonly IRegionManager _regionManager;

		public ComponentModule(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}

		public void Initialize()
		{
			_regionManager.RegisterViewWithRegion("regionName", typeof(ComponentView));
		}
	}
}
