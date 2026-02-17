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
    public sealed class OrderDisputeSummaryQueryBuilder : FieldsQueryBuilderBase<OrderDisputeSummary, OrderDisputeSummaryQueryBuilder>
    {
        protected override OrderDisputeSummaryQueryBuilder Self => this;

        public OrderDisputeSummaryQueryBuilder() : this("orderDisputeSummary")
        {
        }

        public OrderDisputeSummaryQueryBuilder(string name) : base(new Query<OrderDisputeSummary>(name))
        {
        }

        public OrderDisputeSummaryQueryBuilder(IQuery<OrderDisputeSummary> query) : base(query)
        {
        }

        public OrderDisputeSummaryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderDisputeSummaryQueryBuilder InitiatedAs()
        {
            base.InnerQuery.AddField("initiatedAs");
            return this;
        }

        public OrderDisputeSummaryQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}