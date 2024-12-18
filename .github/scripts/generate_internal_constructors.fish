#! /usr/bin/env fish

for service_file in (ls ShopifySharp/Services/*/*Service.cs)
    set service_name (rg -o -e "public class ([A-Z]\w+)Service" "$service_file")
    set service_name (string replace "public class " "" "$service_name")

    # The for loop will have matched interfaces as well, don't operate on those.
    # The PartnerService and GraphService have constructors that are multiple lines long, which is not worth the extra complication of dealing with in this script.
    if test -n "$service_name" -a "$service_name" != "PartnerService" -a "$service_name" != "GraphService" -a "$service_name" != "ShopPlanService"
        echo $service_name

        set using_line_number (rg --line-number "using ShopifySharp.*;" "$service_file" | cut -d ':' -f 1 | sort --numeric-sort -r | head -n1)
        set constructor_line_number (rg --line-number "public $service_name\(" "$service_file" | cut -d ":" -f 1 | sort --numeric-sort -r | head -n1)

        sed -i '' "$using_line_number a\\
using ShopifySharp.Credentials;\\
" $service_file
        sed -i '' "$(math $constructor_line_number + 1) a\\
    #nullable enable\\
    internal $service_name(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility) : base(shopifyApiCredentials, shopifyDomainUtility) {}\\
    #nullable restore\\
" $service_file
    end
end
