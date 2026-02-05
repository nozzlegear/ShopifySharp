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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ProductOperationQueryBuilder : FieldsQueryBuilderBase<IProductOperation, ProductOperationQueryBuilder>
    {
        protected override ProductOperationQueryBuilder Self => this;

        public ProductOperationQueryBuilder() : this("productOperation")
        {
        }

        public ProductOperationQueryBuilder(string name) : base(new Query<IProductOperation>(name))
        {
        }

        public ProductOperationQueryBuilder(IQuery<IProductOperation> query) : base(query)
        {
        }

        public ProductOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
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