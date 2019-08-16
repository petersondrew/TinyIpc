namespace TinyIpc
{
	public static class Resource
	{
		public static string SafeName(string prefix, string name)
		{
			var split = name.Split('\\');
			return split.Length > 1 ? $@"{split[0]}\{prefix}{name[1]}" : prefix + name;
		}
	}
}
