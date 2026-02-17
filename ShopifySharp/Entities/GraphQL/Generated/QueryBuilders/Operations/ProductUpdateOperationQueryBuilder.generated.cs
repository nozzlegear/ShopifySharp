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
    public sealed class ProductUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ProductUpdatePayload, ProductUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductUpdateArgumentsBuilder Arguments { get; }
        protected override ProductUpdateOperationQueryBuilder Self => this;

        public ProductUpdateOperationQueryBuilder() : this("productUpdate")
        {
        }

        public ProductUpdateOperationQueryBuilder(string name) : base(new Query<ProductUpdatePayload>(name))
        {
            Arguments = new ProductUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductUpdateOperationQueryBuilder(IQuery<ProductUpdatePayload> query) : base(query)
        {
            Arguments = new ProductUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductUpdateOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}