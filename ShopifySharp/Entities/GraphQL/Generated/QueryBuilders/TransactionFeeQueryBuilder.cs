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

public class TransactionFeeQueryBuilder() : GraphQueryBuilder<TransactionFee>("query transactionFee")
{
    public TransactionFeeQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldFlatFee()
    {
        AddField("flatFee");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldFlatFeeName()
    {
        AddField("flatFeeName");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldRate()
    {
        AddField("rate");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldRateName()
    {
        AddField("rateName");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldTaxAmount()
    {
        AddField("taxAmount");
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}