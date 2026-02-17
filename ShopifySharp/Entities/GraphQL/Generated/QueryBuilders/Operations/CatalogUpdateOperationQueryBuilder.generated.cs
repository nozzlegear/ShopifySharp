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
    public sealed class CatalogUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CatalogUpdatePayload, CatalogUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CatalogUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CatalogUpdateArgumentsBuilder Arguments { get; }
        protected override CatalogUpdateOperationQueryBuilder Self => this;

        public CatalogUpdateOperationQueryBuilder() : this("catalogUpdate")
        {
        }

        public CatalogUpdateOperationQueryBuilder(string name) : base(new Query<CatalogUpdatePayload>(name))
        {
            Arguments = new CatalogUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CatalogUpdateOperationQueryBuilder(IQuery<CatalogUpdatePayload> query) : base(query)
        {
            Arguments = new CatalogUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CatalogUpdateOperationQueryBuilder Catalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}