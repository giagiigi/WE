// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
namespace AspDotNetStorefront.StringResource
{
	public class KeyOnlyStringResourceProvider : IStringResourceProvider
	{
		public string GetString(string key)
		{
			return key;
		}
	}
}
