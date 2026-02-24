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
    public sealed class QueryRootGiftCardsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootGiftCardsCountQueryBuilder>, IHasArguments<QueryRootGiftCardsCountArgumentsBuilder>
    {
        public QueryRootGiftCardsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootGiftCardsCountQueryBuilder Self => this;

        public QueryRootGiftCardsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootGiftCardsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootGiftCardsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootGiftCardsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootGiftCardsCountQueryBuilder SetArguments(Action<QueryRootGiftCardsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootGiftCardsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootGiftCardsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}