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
    public sealed class QueryRootDraftOrderTagQueryBuilder : FieldsQueryBuilderBase<DraftOrderTag, QueryRootDraftOrderTagQueryBuilder>, IHasArguments<QueryRootDraftOrderTagArgumentsBuilder>
    {
        public QueryRootDraftOrderTagArgumentsBuilder Arguments { get; }
        protected override QueryRootDraftOrderTagQueryBuilder Self => this;

        public QueryRootDraftOrderTagQueryBuilder(string name) : base(new Query<DraftOrderTag>(name))
        {
            Arguments = new QueryRootDraftOrderTagArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDraftOrderTagQueryBuilder(IQuery<DraftOrderTag> query) : base(query)
        {
            Arguments = new QueryRootDraftOrderTagArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDraftOrderTagQueryBuilder SetArguments(Action<QueryRootDraftOrderTagArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDraftOrderTagQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootDraftOrderTagQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDraftOrderTagQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}