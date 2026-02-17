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
    [Obsolete("Use `productUpdate` instead.")]
    public sealed class ProductChangeStatusOperationQueryBuilder : FieldsQueryBuilderBase<ProductChangeStatusPayload, ProductChangeStatusOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductChangeStatusPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductChangeStatusArgumentsBuilder Arguments { get; }
        protected override ProductChangeStatusOperationQueryBuilder Self => this;

        public ProductChangeStatusOperationQueryBuilder() : this("productChangeStatus")
        {
        }

        public ProductChangeStatusOperationQueryBuilder(string name) : base(new Query<ProductChangeStatusPayload>(name))
        {
            Arguments = new ProductChangeStatusArgumentsBuilder(base.InnerQuery);
        }

        public ProductChangeStatusOperationQueryBuilder(IQuery<ProductChangeStatusPayload> query) : base(query)
        {
            Arguments = new ProductChangeStatusArgumentsBuilder(base.InnerQuery);
        }

        public ProductChangeStatusOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductChangeStatusOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductChangeStatusUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductChangeStatusUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductChangeStatusUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductChangeStatusUserError>(query);
            return this;
        }
    }
}