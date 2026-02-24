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
    public sealed class QueryRootProductFeedQueryBuilder : FieldsQueryBuilderBase<ProductFeed, QueryRootProductFeedQueryBuilder>, IHasArguments<QueryRootProductFeedArgumentsBuilder>
    {
        public QueryRootProductFeedArgumentsBuilder Arguments { get; }
        protected override QueryRootProductFeedQueryBuilder Self => this;

        public QueryRootProductFeedQueryBuilder(string name) : base(new Query<ProductFeed>(name))
        {
            Arguments = new QueryRootProductFeedArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductFeedQueryBuilder(IQuery<ProductFeed> query) : base(query)
        {
            Arguments = new QueryRootProductFeedArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductFeedQueryBuilder SetArguments(Action<QueryRootProductFeedArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductFeedQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public QueryRootProductFeedQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootProductFeedQueryBuilder Language()
        {
            base.InnerQuery.AddField("language");
            return this;
        }

        public QueryRootProductFeedQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}