using System;
namespace DependencyInversion.Models
{
	public interface ILogbook
	{
        public void Add(string description);
    }
}

