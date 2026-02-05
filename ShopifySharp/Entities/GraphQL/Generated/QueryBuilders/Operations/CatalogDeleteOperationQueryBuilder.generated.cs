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
    public sealed class CatalogDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CatalogDeletePayload, CatalogDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CatalogDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CatalogDeleteArgumentsBuilder Arguments { get; }
        protected override CatalogDeleteOperationQueryBuilder Self => this;

        public CatalogDeleteOperationQueryBuilder() : this("catalogDelete")
        {
        }

        public CatalogDeleteOperationQueryBuilder(string name) : base(new Query<CatalogDeletePayload>(name))
        {
            Arguments = new CatalogDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CatalogDeleteOperationQueryBuilder(IQuery<CatalogDeletePayload> query) : base(query)
        {
            Arguments = new CatalogDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CatalogDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CatalogDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}