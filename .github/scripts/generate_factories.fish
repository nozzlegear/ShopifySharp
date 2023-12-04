#! /usr/bin/env fish

set template_path "ShopifySharp.DependencyInjection/Factories/template.txt"

if ! test -e "$template_path"
    set_color yellow
    echo "Template file at $template_path does not exist."
    return 1
end

for service_file in (ls ShopifySharp/Services/*/I*Service.cs)
    set service_name (rg -o -e "public interface I([A-Z]\w+)Service" "$service_file")
    set service_name (string replace "public interface I" "" "$service_name")

    # The PartnerService has a different type of constructor
    if test -n "$service_name" -a "$service_name" != "PartnerService"
        set factory_file_name (printf "ShopifySharp.DependencyInjection/Factories/%sFactory.cs" "$service_name")
        set templated_service_text $template_text
        echo $service_name

        string replace --all "@@REPLACEME@@" "$service_name" (cat "$template_path") > "$factory_file_name"
    end
end
