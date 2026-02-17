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
    public sealed class ProductOperationOperationQueryBuilder : FieldsQueryBuilderBase<IProductOperation, ProductOperationOperationQueryBuilder>, IGraphOperationQueryBuilder<IProductOperation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductOperationArgumentsBuilder Arguments { get; }
        protected override ProductOperationOperationQueryBuilder Self => this;

        public ProductOperationOperationQueryBuilder() : this("productOperation")
        {
        }

        public ProductOperationOperationQueryBuilder(string name) : base(new Query<IProductOperation>(name))
        {
            Arguments = new ProductOperationArgumentsBuilder(base.InnerQuery);
        }

        public ProductOperationOperationQueryBuilder(IQuery<IProductOperation> query) : base(query)
        {
            Arguments = new ProductOperationArgumentsBuilder(base.InnerQuery);
        }

        public ProductOperationOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOperationOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}