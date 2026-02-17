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
    public sealed class ProductCreateOperationQueryBuilder : FieldsQueryBuilderBase<ProductCreatePayload, ProductCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductCreateArgumentsBuilder Arguments { get; }
        protected override ProductCreateOperationQueryBuilder Self => this;

        public ProductCreateOperationQueryBuilder() : this("productCreate")
        {
        }

        public ProductCreateOperationQueryBuilder(string name) : base(new Query<ProductCreatePayload>(name))
        {
            Arguments = new ProductCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductCreateOperationQueryBuilder(IQuery<ProductCreatePayload> query) : base(query)
        {
            Arguments = new ProductCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductCreateOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductCreateOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public ProductCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}