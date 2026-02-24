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
    public sealed class BlogArticlesCountQueryBuilder : FieldsQueryBuilderBase<Count, BlogArticlesCountQueryBuilder>, IHasArguments<BlogArticlesCountArgumentsBuilder>
    {
        public BlogArticlesCountArgumentsBuilder Arguments { get; }
        protected override BlogArticlesCountQueryBuilder Self => this;

        public BlogArticlesCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new BlogArticlesCountArgumentsBuilder(base.InnerQuery);
        }

        public BlogArticlesCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new BlogArticlesCountArgumentsBuilder(base.InnerQuery);
        }

        public BlogArticlesCountQueryBuilder SetArguments(Action<BlogArticlesCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public BlogArticlesCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public BlogArticlesCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}