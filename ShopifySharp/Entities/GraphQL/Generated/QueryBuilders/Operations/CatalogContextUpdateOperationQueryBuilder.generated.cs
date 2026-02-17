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
    public sealed class CatalogContextUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CatalogContextUpdatePayload, CatalogContextUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CatalogContextUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CatalogContextUpdateArgumentsBuilder Arguments { get; }
        protected override CatalogContextUpdateOperationQueryBuilder Self => this;

        public CatalogContextUpdateOperationQueryBuilder() : this("catalogContextUpdate")
        {
        }

        public CatalogContextUpdateOperationQueryBuilder(string name) : base(new Query<CatalogContextUpdatePayload>(name))
        {
            Arguments = new CatalogContextUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CatalogContextUpdateOperationQueryBuilder(IQuery<CatalogContextUpdatePayload> query) : base(query)
        {
            Arguments = new CatalogContextUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CatalogContextUpdateOperationQueryBuilder Catalog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogContextUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}