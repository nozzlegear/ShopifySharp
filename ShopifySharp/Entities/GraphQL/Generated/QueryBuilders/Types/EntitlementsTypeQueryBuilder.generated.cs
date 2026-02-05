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
    public sealed class EntitlementsTypeQueryBuilder : FieldsQueryBuilderBase<EntitlementsType, EntitlementsTypeQueryBuilder>
    {
        protected override EntitlementsTypeQueryBuilder Self => this;

        public EntitlementsTypeQueryBuilder() : this("entitlementsType")
        {
        }

        public EntitlementsTypeQueryBuilder(string name) : base(new Query<EntitlementsType>(name))
        {
        }

        public EntitlementsTypeQueryBuilder(IQuery<EntitlementsType> query) : base(query)
        {
        }

        public EntitlementsTypeQueryBuilder Markets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketsTypeQueryBuilder> build)
        {
            var query = new Query<MarketsType>("markets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketsTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsType>(query);
            return this;
        }
    }
}