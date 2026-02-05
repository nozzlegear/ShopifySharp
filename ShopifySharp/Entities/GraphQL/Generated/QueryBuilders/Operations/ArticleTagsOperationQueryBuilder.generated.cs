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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ArticleTagsOperationQueryBuilder : FieldsQueryBuilderBase<GraphQLCollection<string>, ArticleTagsOperationQueryBuilder>, IGraphOperationQueryBuilder<GraphQLCollection<string>>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ArticleTagsArgumentsBuilder Arguments { get; }
        protected override ArticleTagsOperationQueryBuilder Self => this;

        public ArticleTagsOperationQueryBuilder() : this("articleTags")
        {
        }

        public ArticleTagsOperationQueryBuilder(string name) : base(new Query<GraphQLCollection<string>>(name))
        {
            Arguments = new ArticleTagsArgumentsBuilder(base.InnerQuery);
        }

        public ArticleTagsOperationQueryBuilder(IQuery<GraphQLCollection<string>> query) : base(query)
        {
            Arguments = new ArticleTagsArgumentsBuilder(base.InnerQuery);
        }

        public ArticleTagsOperationQueryBuilder ReturnValue()
        {
            // This method is a no-op – the value will be included automatically by virtue of this QueryBuilder being used in a query
            return this;
        }
    }
}