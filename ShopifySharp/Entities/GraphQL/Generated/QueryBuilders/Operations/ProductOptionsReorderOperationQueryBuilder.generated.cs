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

        public ProductOptionsReorderOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionsReorderOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionsReorderUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionsReorderUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionsReorderUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionsReorderUserError>(query);
            return this;
        }
    }
}