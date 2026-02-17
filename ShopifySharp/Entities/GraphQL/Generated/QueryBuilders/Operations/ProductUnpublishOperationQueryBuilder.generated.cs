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
    [Obsolete("Use `publishableUnpublish` instead.")]
    public sealed class ProductUnpublishOperationQueryBuilder : FieldsQueryBuilderBase<ProductUnpublishPayload, ProductUnpublishOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductUnpublishPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductUnpublishArgumentsBuilder Arguments { get; }
        protected override ProductUnpublishOperationQueryBuilder Self => this;

        public ProductUnpublishOperationQueryBuilder() : this("productUnpublish")
        {
        }

        public ProductUnpublishOperationQueryBuilder(string name) : base(new Query<ProductUnpublishPayload>(name))
        {
            Arguments = new ProductUnpublishArgumentsBuilder(base.InnerQuery);
        }

        public ProductUnpublishOperationQueryBuilder(IQuery<ProductUnpublishPayload> query) : base(query)
        {
            Arguments = new ProductUnpublishArgumentsBuilder(base.InnerQuery);
        }

        public ProductUnpublishOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductUnpublishOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public ProductUnpublishOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}