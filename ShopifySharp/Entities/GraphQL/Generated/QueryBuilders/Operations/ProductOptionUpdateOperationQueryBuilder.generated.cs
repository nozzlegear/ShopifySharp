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
    public sealed class ProductOptionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ProductOptionUpdatePayload, ProductOptionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductOptionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductOptionUpdateArgumentsBuilder Arguments { get; }
        protected override ProductOptionUpdateOperationQueryBuilder Self => this;

        public ProductOptionUpdateOperationQueryBuilder() : this("productOptionUpdate")
        {
        }

        public ProductOptionUpdateOperationQueryBuilder(string name) : base(new Query<ProductOptionUpdatePayload>(name))
        {
            Arguments = new ProductOptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionUpdateOperationQueryBuilder(IQuery<ProductOptionUpdatePayload> query) : base(query)
        {
            Arguments = new ProductOptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionUpdateOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionUpdateUserError>(query);
            return this;
        }
    }
}