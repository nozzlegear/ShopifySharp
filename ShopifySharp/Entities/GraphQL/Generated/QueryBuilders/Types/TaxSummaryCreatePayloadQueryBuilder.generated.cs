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
    public sealed class TaxSummaryCreatePayloadQueryBuilder : FieldsQueryBuilderBase<TaxSummaryCreatePayload, TaxSummaryCreatePayloadQueryBuilder>
    {
        protected override TaxSummaryCreatePayloadQueryBuilder Self => this;

        public TaxSummaryCreatePayloadQueryBuilder() : this("taxSummaryCreatePayload")
        {
        }

        public TaxSummaryCreatePayloadQueryBuilder(string name) : base(new Query<TaxSummaryCreatePayload>(name))
        {
        }

        public TaxSummaryCreatePayloadQueryBuilder(IQuery<TaxSummaryCreatePayload> query) : base(query)
        {
        }

        public TaxSummaryCreatePayloadQueryBuilder EnqueuedOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("enqueuedOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public TaxSummaryCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxSummaryCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<TaxSummaryCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxSummaryCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxSummaryCreateUserError>(query);
            return this;
        }
    }
}