using System;
using System.Text;

namespace SingleResponsability
{
	public class ExportHelper<T>
	{
		public ExportHelper()
		{
		}

        public void Export(IEnumerable<T> elements)
        {
            string csv = String.Join(",", elements.Select(x => x?.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            elements.ToList().ForEach(el => sb.AppendLine(el?.ToString()));

            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }
    }
}

