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

public class StaffMemberPrivateDataQueryBuilder() : GraphQueryBuilder<StaffMemberPrivateData>("query staffMemberPrivateData")
{
    public StaffMemberPrivateDataQueryBuilder AddFieldAccountSettingsUrl()
    {
        AddField("accountSettingsUrl");
        return this;
    }

    public StaffMemberPrivateDataQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Theres no alternative field to use instead.")]
    public StaffMemberPrivateDataQueryBuilder AddFieldPermissions()
    {
        AddField("permissions");
        return this;
    }
}