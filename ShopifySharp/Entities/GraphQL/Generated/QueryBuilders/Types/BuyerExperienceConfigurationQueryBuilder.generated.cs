#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class BuyerExperienceConfigurationQueryBuilder : FieldsQueryBuilderBase<BuyerExperienceConfiguration, BuyerExperienceConfigurationQueryBuilder>
    {
        protected override BuyerExperienceConfigurationQueryBuilder Self => this;

        public BuyerExperienceConfigurationQueryBuilder() : this("buyerExperienceConfiguration")
        {
        }

        public BuyerExperienceConfigurationQueryBuilder(string name) : base(new Query<BuyerExperienceConfiguration>(name))
        {
        }

        public BuyerExperienceConfigurationQueryBuilder(IQuery<BuyerExperienceConfiguration> query) : base(query)
        {
        }

        public BuyerExperienceConfigurationQueryBuilder CheckoutToDraft()
        {
            base.InnerQuery.AddField("checkoutToDraft");
            return this;
        }

        public BuyerExperienceConfigurationQueryBuilder EditableShippingAddress()
        {
            base.InnerQuery.AddField("editableShippingAddress");
            return this;
        }

        public BuyerExperienceConfigurationQueryBuilder PaymentTermsTemplate(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsTemplateQueryBuilder> build)
        {
            var query = new Query<PaymentTermsTemplate>("paymentTermsTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentTermsTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentTermsTemplate>(query);
            return this;
        }

        [Obsolete("Please use `checkoutToDraft`(must be false) and `paymentTermsTemplate`(must be nil) to derive this instead.")]
        public BuyerExperienceConfigurationQueryBuilder PayNowOnly()
        {
            base.InnerQuery.AddField("payNowOnly");
            return this;
        }

        public BuyerExperienceConfigurationQueryBuilder Deposit(Action<DepositConfigurationUnionCasesBuilder> build)
        {
            var query = new Query<DepositConfiguration>("deposit");
            var unionBuilder = new DepositConfigurationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}