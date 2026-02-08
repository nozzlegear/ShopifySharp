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
    public sealed class CatalogCreatePayloadQueryBuilder : FieldsQueryBuilderBase<CatalogCreatePayload, CatalogCreatePayloadQueryBuilder>
    {
        protected override CatalogCreatePayloadQueryBuilder Self => this;

        public CatalogCreatePayloadQueryBuilder() : this("catalogCreatePayload")
        {
        }

        public CatalogCreatePayloadQueryBuilder(string name) : base(new Query<CatalogCreatePayload>(name))
        {
        }

        public CatalogCreatePayloadQueryBuilder(IQuery<CatalogCreatePayload> query) : base(query)
        {
        }

        public CatalogCreatePayloadQueryBuilder Catalog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("catalog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}