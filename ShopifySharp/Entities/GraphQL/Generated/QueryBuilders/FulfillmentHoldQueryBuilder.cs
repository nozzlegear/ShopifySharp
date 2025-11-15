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

public class FulfillmentHoldQueryBuilder() : GraphQueryBuilder<FulfillmentHold>("query fulfillmentHold")
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

    public FulfillmentHoldQueryBuilder AddFieldHeldByApp()
    {
        AddField("heldByApp");
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