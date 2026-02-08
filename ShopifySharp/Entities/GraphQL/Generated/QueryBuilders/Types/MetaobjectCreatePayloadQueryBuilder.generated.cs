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
    public sealed class MetaobjectCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MetaobjectCreatePayload, MetaobjectCreatePayloadQueryBuilder>
    {
        protected override MetaobjectCreatePayloadQueryBuilder Self => this;

        public MetaobjectCreatePayloadQueryBuilder() : this("metaobjectCreatePayload")
        {
        }

        public MetaobjectCreatePayloadQueryBuilder(string name) : base(new Query<MetaobjectCreatePayload>(name))
        {
        }

        public MetaobjectCreatePayloadQueryBuilder(IQuery<MetaobjectCreatePayload> query) : base(query)
        {
        }

        public MetaobjectCreatePayloadQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}