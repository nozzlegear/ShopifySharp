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
    public sealed class QueryRootDraftOrdersCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootDraftOrdersCountQueryBuilder>, IHasArguments<QueryRootDraftOrdersCountArgumentsBuilder>
    {
        public QueryRootDraftOrdersCountArgumentsBuilder Arguments { get; }
        protected override QueryRootDraftOrdersCountQueryBuilder Self => this;

        public QueryRootDraftOrdersCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootDraftOrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDraftOrdersCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootDraftOrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDraftOrdersCountQueryBuilder SetArguments(Action<QueryRootDraftOrdersCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDraftOrdersCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootDraftOrdersCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}