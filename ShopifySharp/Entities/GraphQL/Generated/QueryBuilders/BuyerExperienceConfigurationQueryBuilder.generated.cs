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

public class BuyerExperienceConfigurationQueryBuilder() : GraphQueryBuilder<BuyerExperienceConfiguration>("buyerExperienceConfiguration")
{
    public BuyerExperienceConfigurationQueryBuilder AddFieldCheckoutToDraft()
    {
        AddField("checkoutToDraft");
        return this;
    }

    public BuyerExperienceConfigurationQueryBuilder AddUnionCaseDeposit(Func<DepositPercentageQueryBuilder, DepositPercentageQueryBuilder> build)
    {
        AddUnion<DepositPercentage, DepositPercentageQueryBuilder>("deposit", build);
        return this;
    }

    public BuyerExperienceConfigurationQueryBuilder AddFieldEditableShippingAddress()
    {
        AddField("editableShippingAddress");
        return this;
    }

    public BuyerExperienceConfigurationQueryBuilder AddFieldPaymentTermsTemplate(Func<PaymentTermsTemplateQueryBuilder, PaymentTermsTemplateQueryBuilder> build)
    {
        AddField<PaymentTermsTemplate, PaymentTermsTemplateQueryBuilder>("paymentTermsTemplate", build);
        return this;
    }

    [Obsolete("Please use `checkoutToDraft`(must be false) and `paymentTermsTemplate`(must be nil) to derive this instead.")]
    public BuyerExperienceConfigurationQueryBuilder AddFieldPayNowOnly()
    {
        AddField("payNowOnly");
        return this;
    }
}