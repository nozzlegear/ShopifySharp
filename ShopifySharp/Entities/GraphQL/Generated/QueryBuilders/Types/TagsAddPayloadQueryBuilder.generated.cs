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
    public sealed class TagsAddPayloadQueryBuilder : FieldsQueryBuilderBase<TagsAddPayload, TagsAddPayloadQueryBuilder>
    {
        protected override TagsAddPayloadQueryBuilder Self => this;

        public TagsAddPayloadQueryBuilder() : this("tagsAddPayload")
        {
        }

        public TagsAddPayloadQueryBuilder(string name) : base(new Query<TagsAddPayload>(name))
        {
        }

        public TagsAddPayloadQueryBuilder(IQuery<TagsAddPayload> query) : base(query)
        {
        }

        public TagsAddPayloadQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public TagsAddPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}