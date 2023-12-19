#! /usr/bin/env fish

for service_file in (ls ShopifySharp/Services/*/*Service.cs)
    set service_name (rg -o -e "public class ([A-Z]\w+)Service" "$service_file")
    set service_name (string replace "public class " "" "$service_name")

    # The for loop will have matched interfaces as well, don't operate on those.
    # The PartnerService and GraphService have constructors that are multiple lines long, which is not worth the extra complication of dealing with in this script.
    if test -n "$service_name" -a "$service_name" != "PartnerService" -a "$service_name" != "GraphService"
        rg --vimgrep "public $service_name\(" "$service_file" | while read -l line
            set file (echo $line | awk -F":" '{print $1}')
            set line_number (echo $line | awk -F":" '{print $2}')
            echo "$file"
            sed -i '' "$line_number a\\
        internal $service_name(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}\\
 " $file
        end
        echo $service_name
    end
end
