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

public class OrderAgreementQueryBuilder() : GraphQueryBuilder<OrderAgreement>("orderAgreement")
{
    public OrderAgreementQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldSales(Func<SaleConnectionQueryBuilder, SaleConnectionQueryBuilder> build)
    {
        AddField<SaleConnection, SaleConnectionQueryBuilder>("sales", build);
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}