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
    public sealed class CatalogCreateOperationQueryBuilder : FieldsQueryBuilderBase<CatalogCreatePayload, CatalogCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CatalogCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CatalogCreateArgumentsBuilder Arguments { get; }
        protected override CatalogCreateOperationQueryBuilder Self => this;

        public CatalogCreateOperationQueryBuilder() : this("catalogCreate")
        {
        }

        public CatalogCreateOperationQueryBuilder(string name) : base(new Query<CatalogCreatePayload>(name))
        {
            Arguments = new CatalogCreateArgumentsBuilder(base.InnerQuery);
        }

        public CatalogCreateOperationQueryBuilder(IQuery<CatalogCreatePayload> query) : base(query)
        {
            Arguments = new CatalogCreateArgumentsBuilder(base.InnerQuery);
        }

        public CatalogCreateOperationQueryBuilder Catalog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}