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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload, ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder Arguments { get; }
        protected override ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder Self => this;

        public ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder() : this("shopifyPaymentsPayoutAlternateCurrencyCreate")
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload>(name))
        {
            Arguments = new ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder(IQuery<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload> query) : base(query)
        {
            Arguments = new ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder Payout(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsToolingProviderPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsToolingProviderPayout>("payout");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsToolingProviderPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsToolingProviderPayout>(query);
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>(query);
            return this;
        }
    }
}