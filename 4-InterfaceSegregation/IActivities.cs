using System;
namespace InterfaceSegregation
{
	public interface IActivities : IGeneralWorkActivities, IDevelopActivities,
		ITestActivities, IArchitectActivities
	{
	}
}

