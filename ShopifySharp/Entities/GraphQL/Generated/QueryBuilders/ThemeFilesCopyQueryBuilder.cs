#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ThemeFilesCopyQueryBuilder() : GraphQueryBuilder<ThemeFilesCopyPayload>("query themeFilesCopy")
{
    public ThemeFilesCopyQueryBuilder AddArgumentFiles(ICollection<ThemeFilesCopyFileInput>? files)
    {
        AddArgument("files", files);
        return this;
    }

    public ThemeFilesCopyQueryBuilder AddArgumentThemeId(string? themeId)
    {
        AddArgument("themeId", themeId);
        return this;
    }
}