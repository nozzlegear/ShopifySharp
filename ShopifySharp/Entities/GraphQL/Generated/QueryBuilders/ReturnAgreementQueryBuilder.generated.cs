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

public class ReturnAgreementQueryBuilder() : GraphQueryBuilder<ReturnAgreement>("returnAgreement")
{
    public ReturnAgreementQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldReturn(Func<ReturnQueryBuilder, ReturnQueryBuilder> build)
    {
        AddField<Return, ReturnQueryBuilder>("return", build);
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldSales(Func<SaleConnectionQueryBuilder, SaleConnectionQueryBuilder> build)
    {
        AddField<SaleConnection, SaleConnectionQueryBuilder>("sales", build);
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}