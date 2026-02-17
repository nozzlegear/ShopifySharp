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

        public CatalogCreateOperationQueryBuilder Catalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}