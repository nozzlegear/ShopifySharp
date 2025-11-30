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

public class PaymentTermsTemplateQueryBuilder() : GraphQueryBuilder<PaymentTermsTemplate>("paymentTermsTemplate")
{
    public PaymentTermsTemplateQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public PaymentTermsTemplateQueryBuilder AddFieldDueInDays()
    {
        AddField("dueInDays");
        return this;
    }

    public PaymentTermsTemplateQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PaymentTermsTemplateQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public PaymentTermsTemplateQueryBuilder AddFieldPaymentTermsType()
    {
        AddField("paymentTermsType");
        return this;
    }

    public PaymentTermsTemplateQueryBuilder AddFieldTranslatedName()
    {
        AddField("translatedName");
        return this;
    }
}