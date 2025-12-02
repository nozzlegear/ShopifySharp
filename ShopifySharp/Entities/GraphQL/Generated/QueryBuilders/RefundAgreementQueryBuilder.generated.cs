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

public class RefundAgreementQueryBuilder() : GraphQueryBuilder<RefundAgreement>("refundAgreement")
{
    public RefundAgreementQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldRefund(Func<RefundQueryBuilder, RefundQueryBuilder> build)
    {
        AddField<Refund, RefundQueryBuilder>("refund", build);
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldSales(Func<SaleConnectionQueryBuilder, SaleConnectionQueryBuilder> build)
    {
        AddField<SaleConnection, SaleConnectionQueryBuilder>("sales", build);
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}