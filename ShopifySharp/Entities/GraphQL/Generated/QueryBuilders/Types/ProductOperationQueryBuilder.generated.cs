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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ProductOperationQueryBuilder : FieldsQueryBuilderBase<IProductOperation, ProductOperationQueryBuilder>, IHasArguments<ProductOperationArgumentsBuilder>
    {
        public ProductOperationArgumentsBuilder Arguments { get; }
        protected override ProductOperationQueryBuilder Self => this;

        public ProductOperationQueryBuilder() : this("productOperation")
        {
        }

        public ProductOperationQueryBuilder(string name) : base(new Query<IProductOperation>(name))
        {
            Arguments = new ProductOperationArgumentsBuilder(base.InnerQuery);
        }

        public ProductOperationQueryBuilder(IQuery<IProductOperation> query) : base(query)
        {
            Arguments = new ProductOperationArgumentsBuilder(base.InnerQuery);
        }

        public ProductOperationQueryBuilder SetArguments(Action<ProductOperationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}