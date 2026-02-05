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
    public sealed class MetaobjectDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MetaobjectDeletePayload, MetaobjectDeletePayloadQueryBuilder>
    {
        protected override MetaobjectDeletePayloadQueryBuilder Self => this;

        public MetaobjectDeletePayloadQueryBuilder() : this("metaobjectDeletePayload")
        {
        }

        public MetaobjectDeletePayloadQueryBuilder(string name) : base(new Query<MetaobjectDeletePayload>(name))
        {
        }

        public MetaobjectDeletePayloadQueryBuilder(IQuery<MetaobjectDeletePayload> query) : base(query)
        {
        }

        public MetaobjectDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MetaobjectDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}