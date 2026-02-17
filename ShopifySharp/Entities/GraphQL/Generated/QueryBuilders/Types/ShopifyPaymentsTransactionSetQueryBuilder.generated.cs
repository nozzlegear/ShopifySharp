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
    public sealed class ShopifyPaymentsTransactionSetQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsTransactionSet, ShopifyPaymentsTransactionSetQueryBuilder>
    {
        protected override ShopifyPaymentsTransactionSetQueryBuilder Self => this;

        public ShopifyPaymentsTransactionSetQueryBuilder() : this("shopifyPaymentsTransactionSet")
        {
        }

        public ShopifyPaymentsTransactionSetQueryBuilder(string name) : base(new Query<ShopifyPaymentsTransactionSet>(name))
        {
        }

        public ShopifyPaymentsTransactionSetQueryBuilder(IQuery<ShopifyPaymentsTransactionSet> query) : base(query)
        {
        }

        public ShopifyPaymentsTransactionSetQueryBuilder ExtendedAuthorizationSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsExtendedAuthorizationQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsExtendedAuthorization>("extendedAuthorizationSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsExtendedAuthorizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsExtendedAuthorization>(query);
            return this;
        }

        public ShopifyPaymentsTransactionSetQueryBuilder RefundSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsRefundSetQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsRefundSet>("refundSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsRefundSetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsRefundSet>(query);
            return this;
        }
    }
}