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
    public sealed class ShippingLabelPurchaseResultQueryBuilder : FieldsQueryBuilderBase<ShippingLabelPurchaseResult, ShippingLabelPurchaseResultQueryBuilder>
    {
        protected override ShippingLabelPurchaseResultQueryBuilder Self => this;

        public ShippingLabelPurchaseResultQueryBuilder() : this("shippingLabelPurchaseResult")
        {
        }

        public ShippingLabelPurchaseResultQueryBuilder(string name) : base(new Query<ShippingLabelPurchaseResult>(name))
        {
        }

        public ShippingLabelPurchaseResultQueryBuilder(IQuery<ShippingLabelPurchaseResult> query) : base(query)
        {
        }

        public ShippingLabelPurchaseResultQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public ShippingLabelPurchaseResultQueryBuilder Errors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseErrorQueryBuilder> build)
        {
            var query = new Query<ShippingLabelPurchaseError>("errors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLabelPurchaseError>(query);
            return this;
        }

        public ShippingLabelPurchaseResultQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShippingLabelPurchaseResultQueryBuilder ShippingLabels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelQueryBuilder> build)
        {
            var query = new Query<ShippingLabel>("shippingLabels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLabel>(query);
            return this;
        }

        public ShippingLabelPurchaseResultQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}