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

public class OrderEditAgreementQueryBuilder() : GraphQueryBuilder<OrderEditAgreement>("orderEditAgreement")
{
    public OrderEditAgreementQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldSales(Func<SaleConnectionQueryBuilder, SaleConnectionQueryBuilder> build)
    {
        AddField<SaleConnection, SaleConnectionQueryBuilder>("sales", build);
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}