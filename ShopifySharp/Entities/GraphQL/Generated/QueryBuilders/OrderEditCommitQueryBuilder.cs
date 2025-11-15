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

public class OrderEditCommitQueryBuilder() : GraphQueryBuilder<OrderEditCommitPayload>("query orderEditCommit")
{
    public OrderEditCommitQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditCommitQueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }

    public OrderEditCommitQueryBuilder AddArgumentStaffNote(string? staffNote)
    {
        AddArgument("staffNote", staffNote);
        return this;
    }
}