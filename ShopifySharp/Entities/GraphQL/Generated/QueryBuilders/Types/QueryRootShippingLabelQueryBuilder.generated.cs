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
    public sealed class QueryRootShippingLabelQueryBuilder : FieldsQueryBuilderBase<ShippingLabel, QueryRootShippingLabelQueryBuilder>, IHasArguments<QueryRootShippingLabelArgumentsBuilder>
    {
        public QueryRootShippingLabelArgumentsBuilder Arguments { get; }
        protected override QueryRootShippingLabelQueryBuilder Self => this;

        public QueryRootShippingLabelQueryBuilder(string name) : base(new Query<ShippingLabel>(name))
        {
            Arguments = new QueryRootShippingLabelArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShippingLabelQueryBuilder(IQuery<ShippingLabel> query) : base(query)
        {
            Arguments = new QueryRootShippingLabelArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShippingLabelQueryBuilder SetArguments(Action<QueryRootShippingLabelArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShippingLabelQueryBuilder Cancellable()
        {
            base.InnerQuery.AddField("cancellable");
            return this;
        }

        public QueryRootShippingLabelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootShippingLabelQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootShippingLabelQueryBuilder Printed()
        {
            base.InnerQuery.AddField("printed");
            return this;
        }

        public QueryRootShippingLabelQueryBuilder ShippingDocuments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingObjectsShippingDocumentQueryBuilder> build)
        {
            var query = new Query<ShippingObjectsShippingDocument>("shippingDocuments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingObjectsShippingDocumentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingObjectsShippingDocument>(query);
            return this;
        }

        public QueryRootShippingLabelQueryBuilder TrackingInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder> build)
        {
            var query = new Query<FulfillmentTrackingInfo>("trackingInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentTrackingInfo>(query);
            return this;
        }
    }
}