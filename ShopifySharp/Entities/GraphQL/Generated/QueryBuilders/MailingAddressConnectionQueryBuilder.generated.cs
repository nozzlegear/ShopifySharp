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

public class MailingAddressConnectionQueryBuilder() : GraphQueryBuilder<MailingAddressConnection>("mailingAddressConnection")
{
    public MailingAddressConnectionQueryBuilder AddFieldEdges(Func<MailingAddressEdgeQueryBuilder, MailingAddressEdgeQueryBuilder> build)
    {
        AddField<MailingAddressEdge, MailingAddressEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MailingAddressConnectionQueryBuilder AddFieldNodes(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("nodes", build);
        return this;
    }

    public MailingAddressConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}