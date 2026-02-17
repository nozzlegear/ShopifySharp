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
    public sealed class ProductBundleUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ProductBundleUpdatePayload, ProductBundleUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductBundleUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductBundleUpdateArgumentsBuilder Arguments { get; }
        protected override ProductBundleUpdateOperationQueryBuilder Self => this;

        public ProductBundleUpdateOperationQueryBuilder() : this("productBundleUpdate")
        {
        }

        public ProductBundleUpdateOperationQueryBuilder(string name) : base(new Query<ProductBundleUpdatePayload>(name))
        {
            Arguments = new ProductBundleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductBundleUpdateOperationQueryBuilder(IQuery<ProductBundleUpdatePayload> query) : base(query)
        {
            Arguments = new ProductBundleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductBundleUpdateOperationQueryBuilder ProductBundleOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder> build)
        {
            var query = new Query<ProductBundleOperation>("productBundleOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleOperation>(query);
            return this;
        }

        public ProductBundleUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}