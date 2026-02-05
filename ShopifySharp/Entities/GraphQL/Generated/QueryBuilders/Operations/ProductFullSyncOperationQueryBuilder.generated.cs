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
    public sealed class ProductFullSyncOperationQueryBuilder : FieldsQueryBuilderBase<ProductFullSyncPayload, ProductFullSyncOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductFullSyncPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductFullSyncArgumentsBuilder Arguments { get; }
        protected override ProductFullSyncOperationQueryBuilder Self => this;

        public ProductFullSyncOperationQueryBuilder() : this("productFullSync")
        {
        }

        public ProductFullSyncOperationQueryBuilder(string name) : base(new Query<ProductFullSyncPayload>(name))
        {
            Arguments = new ProductFullSyncArgumentsBuilder(base.InnerQuery);
        }

        public ProductFullSyncOperationQueryBuilder(IQuery<ProductFullSyncPayload> query) : base(query)
        {
            Arguments = new ProductFullSyncArgumentsBuilder(base.InnerQuery);
        }

        public ProductFullSyncOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductFullSyncOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFullSyncUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductFullSyncUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFullSyncUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFullSyncUserError>(query);
            return this;
        }
    }
}