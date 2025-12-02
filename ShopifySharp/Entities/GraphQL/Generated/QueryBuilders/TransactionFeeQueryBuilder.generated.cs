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

public class TransactionFeeQueryBuilder() : GraphQueryBuilder<TransactionFee>("transactionFee")
{
    public TransactionFeeQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldFlatFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("flatFee", build);
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

    public TransactionFeeQueryBuilder AddFieldTaxAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("taxAmount", build);
        return this;
    }

    public TransactionFeeQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}