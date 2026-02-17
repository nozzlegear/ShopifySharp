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
    public sealed class TagsAddOperationQueryBuilder : FieldsQueryBuilderBase<TagsAddPayload, TagsAddOperationQueryBuilder>, IGraphOperationQueryBuilder<TagsAddPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TagsAddArgumentsBuilder Arguments { get; }
        protected override TagsAddOperationQueryBuilder Self => this;

        public TagsAddOperationQueryBuilder() : this("tagsAdd")
        {
        }

        public TagsAddOperationQueryBuilder(string name) : base(new Query<TagsAddPayload>(name))
        {
            Arguments = new TagsAddArgumentsBuilder(base.InnerQuery);
        }

        public TagsAddOperationQueryBuilder(IQuery<TagsAddPayload> query) : base(query)
        {
            Arguments = new TagsAddArgumentsBuilder(base.InnerQuery);
        }

        public TagsAddOperationQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public TagsAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}