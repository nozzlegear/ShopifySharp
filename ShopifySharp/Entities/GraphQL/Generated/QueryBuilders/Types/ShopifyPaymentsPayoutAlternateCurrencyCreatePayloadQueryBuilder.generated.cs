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
    public sealed class ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload, ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder Self => this;

        public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder() : this("shopifyPaymentsPayoutAlternateCurrencyCreatePayload")
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload>(name))
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder(IQuery<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder Payout(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsToolingProviderPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsToolingProviderPayout>("payout");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsToolingProviderPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsToolingProviderPayout>(query);
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>(query);
            return this;
        }
    }
}