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
    public sealed class QueryRootWebhookSubscriptionsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootWebhookSubscriptionsCountQueryBuilder>, IHasArguments<QueryRootWebhookSubscriptionsCountArgumentsBuilder>
    {
        public QueryRootWebhookSubscriptionsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootWebhookSubscriptionsCountQueryBuilder Self => this;

        public QueryRootWebhookSubscriptionsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootWebhookSubscriptionsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootWebhookSubscriptionsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootWebhookSubscriptionsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootWebhookSubscriptionsCountQueryBuilder SetArguments(Action<QueryRootWebhookSubscriptionsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootWebhookSubscriptionsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootWebhookSubscriptionsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}