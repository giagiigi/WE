// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
using System;
using System.Linq;

namespace AspDotNetStorefrontCore.Tokens.Handlers
{
	public class NumWishItems : ITokenHandler
	{
		readonly string[] Tokens = { "num_wish_items", "numwishitems" };

		public string RenderToken(TokenHandlerContext context)
		{
			if(!Tokens.Contains(context.Token, StringComparer.OrdinalIgnoreCase))
				return null;

			return ShoppingCart
				.NumItems(context.Customer.CustomerID, CartTypeEnum.WishCart)
				.ToString();
		}
	}
}
