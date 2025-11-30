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

public class StaffMemberQueryBuilder() : GraphQueryBuilder<StaffMember>("query staffMember")
{
    public StaffMemberQueryBuilder AddFieldAccountType()
    {
        AddField("accountType");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldActive()
    {
        AddField("active");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldAvatar()
    {
        AddField("avatar");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldEmail()
    {
        AddField("email");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldExists()
    {
        AddField("exists");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldInitials()
    {
        AddField("initials");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldIsShopOwner()
    {
        AddField("isShopOwner");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldLocale()
    {
        AddField("locale");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public StaffMemberQueryBuilder AddFieldPrivateData()
    {
        AddField("privateData");
        return this;
    }
}