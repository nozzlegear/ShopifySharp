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

public class FulfillmentHoldQueryBuilder() : GraphQueryBuilder<FulfillmentHold>("fulfillmentHold")
{
    public FulfillmentHoldQueryBuilder AddFieldDisplayReason()
    {
        AddField("displayReason");
        return this;
    }

    public FulfillmentHoldQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public FulfillmentHoldQueryBuilder AddFieldHeldByApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("heldByApp", build);
        return this;
    }

    public FulfillmentHoldQueryBuilder AddFieldHeldByRequestingApp()
    {
        AddField("heldByRequestingApp");
        return this;
    }

    public FulfillmentHoldQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentHoldQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public FulfillmentHoldQueryBuilder AddFieldReasonNotes()
    {
        AddField("reasonNotes");
        return this;
    }
}