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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CatalogUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CatalogUpdatePayload, CatalogUpdatePayloadQueryBuilder>
    {
        protected override CatalogUpdatePayloadQueryBuilder Self => this;

        public CatalogUpdatePayloadQueryBuilder() : this("catalogUpdatePayload")
        {
        }

        public CatalogUpdatePayloadQueryBuilder(string name) : base(new Query<CatalogUpdatePayload>(name))
        {
        }

        public CatalogUpdatePayloadQueryBuilder(IQuery<CatalogUpdatePayload> query) : base(query)
        {
        }

        public CatalogUpdatePayloadQueryBuilder Catalog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}