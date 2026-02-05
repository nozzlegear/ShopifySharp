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
    public sealed class TagsRemovePayloadQueryBuilder : FieldsQueryBuilderBase<TagsRemovePayload, TagsRemovePayloadQueryBuilder>
    {
        protected override TagsRemovePayloadQueryBuilder Self => this;

        public TagsRemovePayloadQueryBuilder() : this("tagsRemovePayload")
        {
        }

        public TagsRemovePayloadQueryBuilder(string name) : base(new Query<TagsRemovePayload>(name))
        {
        }

        public TagsRemovePayloadQueryBuilder(IQuery<TagsRemovePayload> query) : base(query)
        {
        }

        public TagsRemovePayloadQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public TagsRemovePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}