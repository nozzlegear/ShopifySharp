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

public class MailingAddressConnectionQueryBuilder() : GraphQueryBuilder<MailingAddressConnection>("query mailingAddressConnection")
{
    public MailingAddressConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MailingAddressConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MailingAddressConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}