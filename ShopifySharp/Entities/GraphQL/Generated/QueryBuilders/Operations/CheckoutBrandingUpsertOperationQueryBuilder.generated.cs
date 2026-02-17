#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CheckoutBrandingUpsertOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingUpsertPayload, CheckoutBrandingUpsertOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutBrandingUpsertPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CheckoutBrandingUpsertArgumentsBuilder Arguments { get; }
        protected override CheckoutBrandingUpsertOperationQueryBuilder Self => this;

        public CheckoutBrandingUpsertOperationQueryBuilder() : this("checkoutBrandingUpsert")
        {
        }

        public CheckoutBrandingUpsertOperationQueryBuilder(string name) : base(new Query<CheckoutBrandingUpsertPayload>(name))
        {
            Arguments = new CheckoutBrandingUpsertArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutBrandingUpsertOperationQueryBuilder(IQuery<CheckoutBrandingUpsertPayload> query) : base(query)
        {
            Arguments = new CheckoutBrandingUpsertArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutBrandingUpsertOperationQueryBuilder CheckoutBranding(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingQueryBuilder> build)
        {
            var query = new Query<CheckoutBranding>("checkoutBranding");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBranding>(query);
            return this;
        }

        public CheckoutBrandingUpsertOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingUpsertUserErrorQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingUpsertUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingUpsertUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingUpsertUserError>(query);
            return this;
        }
    }
}