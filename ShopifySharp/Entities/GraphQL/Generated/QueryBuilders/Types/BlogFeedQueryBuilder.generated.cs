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
    public sealed class BlogFeedQueryBuilder : FieldsQueryBuilderBase<BlogFeed, BlogFeedQueryBuilder>
    {
        protected override BlogFeedQueryBuilder Self => this;

        public BlogFeedQueryBuilder() : this("blogFeed")
        {
        }

        public BlogFeedQueryBuilder(string name) : base(new Query<BlogFeed>(name))
        {
        }

        public BlogFeedQueryBuilder(IQuery<BlogFeed> query) : base(query)
        {
        }

        public BlogFeedQueryBuilder Location()
        {
            base.InnerQuery.AddField("location");
            return this;
        }

        public BlogFeedQueryBuilder Path()
        {
            base.InnerQuery.AddField("path");
            return this;
        }
    }
}