using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyAssetService_Tests
{
    static class AssetUtils
    {
        public static long GetValidThemeId()
        {
            //Temporarily using theme from my own test store. Will need ShopifyThemeService to get theme ids.
            return 10556555;
        }
    }
}
