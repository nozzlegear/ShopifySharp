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
    public sealed class ProductOptionsReorderOperationQueryBuilder : FieldsQueryBuilderBase<ProductOptionsReorderPayload, ProductOptionsReorderOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductOptionsReorderPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductOptionsReorderArgumentsBuilder Arguments { get; }
        protected override ProductOptionsReorderOperationQueryBuilder Self => this;

        public ProductOptionsReorderOperationQueryBuilder() : this("productOptionsReorder")
        {
        }

        public ProductOptionsReorderOperationQueryBuilder(string name) : base(new Query<ProductOptionsReorderPayload>(name))
        {
            Arguments = new ProductOptionsReorderArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsReorderOperationQueryBuilder(IQuery<ProductOptionsReorderPayload> query) : base(query)
        {
            Arguments = new ProductOptionsReorderArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsReorderOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionsReorderOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsReorderUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionsReorderUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsReorderUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionsReorderUserError>(query);
            return this;
        }
    }
}