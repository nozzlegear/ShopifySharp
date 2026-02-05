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
    public sealed class ProductOptionsCreateOperationQueryBuilder : FieldsQueryBuilderBase<ProductOptionsCreatePayload, ProductOptionsCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductOptionsCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductOptionsCreateArgumentsBuilder Arguments { get; }
        protected override ProductOptionsCreateOperationQueryBuilder Self => this;

        public ProductOptionsCreateOperationQueryBuilder() : this("productOptionsCreate")
        {
        }

        public ProductOptionsCreateOperationQueryBuilder(string name) : base(new Query<ProductOptionsCreatePayload>(name))
        {
            Arguments = new ProductOptionsCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsCreateOperationQueryBuilder(IQuery<ProductOptionsCreatePayload> query) : base(query)
        {
            Arguments = new ProductOptionsCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsCreateOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionsCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionsCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionsCreateUserError>(query);
            return this;
        }
    }
}