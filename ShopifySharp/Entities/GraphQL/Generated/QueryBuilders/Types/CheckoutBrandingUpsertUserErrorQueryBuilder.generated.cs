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
    public sealed class CheckoutBrandingUpsertUserErrorQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingUpsertUserError, CheckoutBrandingUpsertUserErrorQueryBuilder>
    {
        protected override CheckoutBrandingUpsertUserErrorQueryBuilder Self => this;

        public CheckoutBrandingUpsertUserErrorQueryBuilder() : this("checkoutBrandingUpsertUserError")
        {
        }

        public CheckoutBrandingUpsertUserErrorQueryBuilder(string name) : base(new Query<CheckoutBrandingUpsertUserError>(name))
        {
        }

        public CheckoutBrandingUpsertUserErrorQueryBuilder(IQuery<CheckoutBrandingUpsertUserError> query) : base(query)
        {
        }

        public CheckoutBrandingUpsertUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CheckoutBrandingUpsertUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CheckoutBrandingUpsertUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}