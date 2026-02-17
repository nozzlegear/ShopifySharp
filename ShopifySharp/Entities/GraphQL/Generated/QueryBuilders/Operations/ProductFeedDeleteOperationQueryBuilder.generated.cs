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
    public sealed class ProductFeedDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ProductFeedDeletePayload, ProductFeedDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductFeedDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductFeedDeleteArgumentsBuilder Arguments { get; }
        protected override ProductFeedDeleteOperationQueryBuilder Self => this;

        public ProductFeedDeleteOperationQueryBuilder() : this("productFeedDelete")
        {
        }

        public ProductFeedDeleteOperationQueryBuilder(string name) : base(new Query<ProductFeedDeletePayload>(name))
        {
            Arguments = new ProductFeedDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedDeleteOperationQueryBuilder(IQuery<ProductFeedDeletePayload> query) : base(query)
        {
            Arguments = new ProductFeedDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ProductFeedDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductFeedDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedDeleteUserError>(query);
            return this;
        }
    }
}