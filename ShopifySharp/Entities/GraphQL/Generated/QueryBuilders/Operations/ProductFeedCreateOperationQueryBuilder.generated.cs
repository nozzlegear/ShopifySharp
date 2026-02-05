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
    public sealed class ProductFeedCreateOperationQueryBuilder : FieldsQueryBuilderBase<ProductFeedCreatePayload, ProductFeedCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductFeedCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductFeedCreateArgumentsBuilder Arguments { get; }
        protected override ProductFeedCreateOperationQueryBuilder Self => this;

        public ProductFeedCreateOperationQueryBuilder() : this("productFeedCreate")
        {
        }

        public ProductFeedCreateOperationQueryBuilder(string name) : base(new Query<ProductFeedCreatePayload>(name))
        {
            Arguments = new ProductFeedCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedCreateOperationQueryBuilder(IQuery<ProductFeedCreatePayload> query) : base(query)
        {
            Arguments = new ProductFeedCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedCreateOperationQueryBuilder ProductFeed(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("productFeed");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeed>(query);
            return this;
        }

        public ProductFeedCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductFeedCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedCreateUserError>(query);
            return this;
        }
    }
}