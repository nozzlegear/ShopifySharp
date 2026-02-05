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
    public sealed class MetaobjectUpsertPayloadQueryBuilder : FieldsQueryBuilderBase<MetaobjectUpsertPayload, MetaobjectUpsertPayloadQueryBuilder>
    {
        protected override MetaobjectUpsertPayloadQueryBuilder Self => this;

        public MetaobjectUpsertPayloadQueryBuilder() : this("metaobjectUpsertPayload")
        {
        }

        public MetaobjectUpsertPayloadQueryBuilder(string name) : base(new Query<MetaobjectUpsertPayload>(name))
        {
        }

        public MetaobjectUpsertPayloadQueryBuilder(IQuery<MetaobjectUpsertPayload> query) : base(query)
        {
        }

        public MetaobjectUpsertPayloadQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectUpsertPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}