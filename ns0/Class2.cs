using System.Management;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class2
{
	public bool VM_Detected()
	{
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
		{
			using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementBaseObject item in managementObjectCollection)
			{
				string text = item["Manufacturer"].ToString().ToLower();
				if ((Operators.CompareString(text, "microsoft corporation", TextCompare: false) == 0 && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(item["Model"].ToString(), "VirtualBox", TextCompare: false) == 0)
				{
					return true;
				}
			}
		}
		return false;
	}
}
