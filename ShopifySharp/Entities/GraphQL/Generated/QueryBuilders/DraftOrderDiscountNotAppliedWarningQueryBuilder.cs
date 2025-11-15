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

public class DraftOrderDiscountNotAppliedWarningQueryBuilder() : GraphQueryBuilder<DraftOrderDiscountNotAppliedWarning>("query draftOrderDiscountNotAppliedWarning")
{
    public DraftOrderDiscountNotAppliedWarningQueryBuilder AddFieldDiscountCode()
    {
        AddField("discountCode");
        return this;
    }

    public DraftOrderDiscountNotAppliedWarningQueryBuilder AddFieldDiscountTitle()
    {
        AddField("discountTitle");
        return this;
    }

    public DraftOrderDiscountNotAppliedWarningQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public DraftOrderDiscountNotAppliedWarningQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DraftOrderDiscountNotAppliedWarningQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public DraftOrderDiscountNotAppliedWarningQueryBuilder AddFieldPriceRule()
    {
        AddField("priceRule");
        return this;
    }
}