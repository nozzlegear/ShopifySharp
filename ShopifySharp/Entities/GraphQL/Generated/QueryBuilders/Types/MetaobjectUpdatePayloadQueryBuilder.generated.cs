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
    public sealed class MetaobjectUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<MetaobjectUpdatePayload, MetaobjectUpdatePayloadQueryBuilder>
    {
        protected override MetaobjectUpdatePayloadQueryBuilder Self => this;

        public MetaobjectUpdatePayloadQueryBuilder() : this("metaobjectUpdatePayload")
        {
        }

        public MetaobjectUpdatePayloadQueryBuilder(string name) : base(new Query<MetaobjectUpdatePayload>(name))
        {
        }

        public MetaobjectUpdatePayloadQueryBuilder(IQuery<MetaobjectUpdatePayload> query) : base(query)
        {
        }

        public MetaobjectUpdatePayloadQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}