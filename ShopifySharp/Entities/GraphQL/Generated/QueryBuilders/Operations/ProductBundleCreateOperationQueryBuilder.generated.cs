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
    public sealed class ProductBundleCreateOperationQueryBuilder : FieldsQueryBuilderBase<ProductBundleCreatePayload, ProductBundleCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductBundleCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductBundleCreateArgumentsBuilder Arguments { get; }
        protected override ProductBundleCreateOperationQueryBuilder Self => this;

        public ProductBundleCreateOperationQueryBuilder() : this("productBundleCreate")
        {
        }

        public ProductBundleCreateOperationQueryBuilder(string name) : base(new Query<ProductBundleCreatePayload>(name))
        {
            Arguments = new ProductBundleCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductBundleCreateOperationQueryBuilder(IQuery<ProductBundleCreatePayload> query) : base(query)
        {
            Arguments = new ProductBundleCreateArgumentsBuilder(base.InnerQuery);
        }

        public ProductBundleCreateOperationQueryBuilder ProductBundleOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder> build)
        {
            var query = new Query<ProductBundleOperation>("productBundleOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleOperation>(query);
            return this;
        }

        public ProductBundleCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}