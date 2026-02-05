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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class LimitedPendingOrderCountQueryBuilder : FieldsQueryBuilderBase<LimitedPendingOrderCount, LimitedPendingOrderCountQueryBuilder>
    {
        protected override LimitedPendingOrderCountQueryBuilder Self => this;

        public LimitedPendingOrderCountQueryBuilder() : this("limitedPendingOrderCount")
        {
        }

        public LimitedPendingOrderCountQueryBuilder(string name) : base(new Query<LimitedPendingOrderCount>(name))
        {
        }

        public LimitedPendingOrderCountQueryBuilder(IQuery<LimitedPendingOrderCount> query) : base(query)
        {
        }

        public LimitedPendingOrderCountQueryBuilder AtMax()
        {
            base.InnerQuery.AddField("atMax");
            return this;
        }

        public LimitedPendingOrderCountQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }
    }
}