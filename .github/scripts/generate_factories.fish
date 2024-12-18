#! /usr/bin/env fish

set template_path "ShopifySharp/Factories/FactoryServiceTemplate.tt"

if ! test -e "$template_path"
    set_color yellow
    echo "Template file at $template_path does not exist."
    return 1
end

for service_file in (ls ShopifySharp/Services/*/I*Service.cs)
    set service_name (rg -o -e "public interface I([A-Z]\w+)Service" "$service_file")
    set service_name (string replace "public interface I" "" "$service_name")
    echo $service_name
    set factory_file_name (printf "ShopifySharp/Factories/%sFactory.cs" "$service_name")
    dotnet t4 -p "TypeName=$service_name" -o "$factory_file_name" "$template_path"
end
