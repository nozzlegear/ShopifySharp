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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ArticleCommentsCountQueryBuilder : FieldsQueryBuilderBase<Count, ArticleCommentsCountQueryBuilder>, IHasArguments<ArticleCommentsCountArgumentsBuilder>
    {
        public ArticleCommentsCountArgumentsBuilder Arguments { get; }
        protected override ArticleCommentsCountQueryBuilder Self => this;

        public ArticleCommentsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ArticleCommentsCountArgumentsBuilder(base.InnerQuery);
        }

        public ArticleCommentsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ArticleCommentsCountArgumentsBuilder(base.InnerQuery);
        }

        public ArticleCommentsCountQueryBuilder SetArguments(Action<ArticleCommentsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ArticleCommentsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ArticleCommentsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}