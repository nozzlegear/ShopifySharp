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
    public sealed class ShippingLabelQueryBuilder : FieldsQueryBuilderBase<ShippingLabel, ShippingLabelQueryBuilder>, IHasArguments<ShippingLabelArgumentsBuilder>
    {
        public ShippingLabelArgumentsBuilder Arguments { get; }
        protected override ShippingLabelQueryBuilder Self => this;

        public ShippingLabelQueryBuilder() : this("shippingLabel")
        {
        }

        public ShippingLabelQueryBuilder(string name) : base(new Query<ShippingLabel>(name))
        {
            Arguments = new ShippingLabelArgumentsBuilder(base.InnerQuery);
        }

        public ShippingLabelQueryBuilder(IQuery<ShippingLabel> query) : base(query)
        {
            Arguments = new ShippingLabelArgumentsBuilder(base.InnerQuery);
        }

        public ShippingLabelQueryBuilder SetArguments(Action<ShippingLabelArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShippingLabelQueryBuilder Cancellable()
        {
            base.InnerQuery.AddField("cancellable");
            return this;
        }

        public ShippingLabelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShippingLabelQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public ShippingLabelQueryBuilder Printed()
        {
            base.InnerQuery.AddField("printed");
            return this;
        }

        public ShippingLabelQueryBuilder ShippingDocuments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingObjectsShippingDocumentQueryBuilder> build)
        {
            var query = new Query<ShippingObjectsShippingDocument>("shippingDocuments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingObjectsShippingDocumentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingObjectsShippingDocument>(query);
            return this;
        }

        public ShippingLabelQueryBuilder TrackingInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder> build)
        {
            var query = new Query<FulfillmentTrackingInfo>("trackingInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentTrackingInfo>(query);
            return this;
        }
    }
}