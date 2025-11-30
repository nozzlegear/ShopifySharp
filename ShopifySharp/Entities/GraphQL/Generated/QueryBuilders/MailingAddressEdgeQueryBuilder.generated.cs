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

public class MailingAddressEdgeQueryBuilder() : GraphQueryBuilder<MailingAddressEdge>("mailingAddressEdge")
{
    public MailingAddressEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MailingAddressEdgeQueryBuilder AddFieldNode(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("node", build);
        return this;
    }
}