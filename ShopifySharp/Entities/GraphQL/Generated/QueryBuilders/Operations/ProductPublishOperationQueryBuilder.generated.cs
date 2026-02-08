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
    [Obsolete("Use `publishablePublish` instead.")]
    public sealed class ProductPublishOperationQueryBuilder : FieldsQueryBuilderBase<ProductPublishPayload, ProductPublishOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductPublishPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductPublishArgumentsBuilder Arguments { get; }
        protected override ProductPublishOperationQueryBuilder Self => this;

        public ProductPublishOperationQueryBuilder() : this("productPublish")
        {
        }

        public ProductPublishOperationQueryBuilder(string name) : base(new Query<ProductPublishPayload>(name))
        {
            Arguments = new ProductPublishArgumentsBuilder(base.InnerQuery);
        }

        public ProductPublishOperationQueryBuilder(IQuery<ProductPublishPayload> query) : base(query)
        {
            Arguments = new ProductPublishArgumentsBuilder(base.InnerQuery);
        }

        public ProductPublishOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductPublishOperationQueryBuilder ProductPublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationQueryBuilder> build)
        {
            var query = new Query<ProductPublication>("productPublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublication>(query);
            return this;
        }

        public ProductPublishOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public ProductPublishOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}