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

public class SalesAgreementQueryBuilder() : GraphQueryBuilder<ISalesAgreement>("salesAgreement")
{
    public SalesAgreementQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public SalesAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public SalesAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SalesAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public SalesAgreementQueryBuilder AddFieldSales(Func<SaleConnectionQueryBuilder, SaleConnectionQueryBuilder> build)
    {
        AddField<SaleConnection, SaleConnectionQueryBuilder>("sales", build);
        return this;
    }

    public SalesAgreementQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}