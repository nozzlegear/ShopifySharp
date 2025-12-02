#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DomainLocalizationQueryBuilder() : GraphQueryBuilder<DomainLocalization>("domainLocalization")
{
    public DomainLocalizationQueryBuilder AddFieldAlternateLocales()
    {
        AddField("alternateLocales");
        return this;
    }

    public DomainLocalizationQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public DomainLocalizationQueryBuilder AddFieldDefaultLocale()
    {
        AddField("defaultLocale");
        return this;
    }
}