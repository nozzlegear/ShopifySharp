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

public class ShopifyPaymentsPayoutQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayout>("shopifyPaymentsPayout")
{
    public ShopifyPaymentsPayoutQueryBuilder AddFieldBankAccount(Func<ShopifyPaymentsBankAccountQueryBuilder, ShopifyPaymentsBankAccountQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBankAccount, ShopifyPaymentsBankAccountQueryBuilder>("bankAccount", build);
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldBusinessEntity(Func<BusinessEntityQueryBuilder, BusinessEntityQueryBuilder> build)
    {
        AddField<BusinessEntity, BusinessEntityQueryBuilder>("businessEntity", build);
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldGross(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("gross", build);
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldIssuedAt()
    {
        AddField("issuedAt");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldNet(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("net", build);
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldSummary(Func<ShopifyPaymentsPayoutSummaryQueryBuilder, ShopifyPaymentsPayoutSummaryQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayoutSummary, ShopifyPaymentsPayoutSummaryQueryBuilder>("summary", build);
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldTransactionType()
    {
        AddField("transactionType");
        return this;
    }
}