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
    public sealed class CheckoutBrandingUpsertPayloadQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingUpsertPayload, CheckoutBrandingUpsertPayloadQueryBuilder>
    {
        protected override CheckoutBrandingUpsertPayloadQueryBuilder Self => this;

        public CheckoutBrandingUpsertPayloadQueryBuilder() : this("checkoutBrandingUpsertPayload")
        {
        }

        public CheckoutBrandingUpsertPayloadQueryBuilder(string name) : base(new Query<CheckoutBrandingUpsertPayload>(name))
        {
        }

        public CheckoutBrandingUpsertPayloadQueryBuilder(IQuery<CheckoutBrandingUpsertPayload> query) : base(query)
        {
        }

        public CheckoutBrandingUpsertPayloadQueryBuilder CheckoutBranding(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutBranding>("checkoutBranding");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBranding>(query);
            return this;
        }

        public CheckoutBrandingUpsertPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingUpsertUserErrorQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingUpsertUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingUpsertUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingUpsertUserError>(query);
            return this;
        }
    }
}