#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class TagsRemoveOperationQueryBuilder : FieldsQueryBuilderBase<TagsRemovePayload, TagsRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<TagsRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TagsRemoveArgumentsBuilder Arguments { get; }
        protected override TagsRemoveOperationQueryBuilder Self => this;

        public TagsRemoveOperationQueryBuilder() : this("tagsRemove")
        {
        }

        public TagsRemoveOperationQueryBuilder(string name) : base(new Query<TagsRemovePayload>(name))
        {
            Arguments = new TagsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public TagsRemoveOperationQueryBuilder(IQuery<TagsRemovePayload> query) : base(query)
        {
            Arguments = new TagsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public TagsRemoveOperationQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public TagsRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}