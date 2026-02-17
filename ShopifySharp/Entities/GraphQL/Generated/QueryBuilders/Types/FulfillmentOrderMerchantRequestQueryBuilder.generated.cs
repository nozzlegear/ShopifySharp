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
    public sealed class FulfillmentOrderMerchantRequestQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMerchantRequest, FulfillmentOrderMerchantRequestQueryBuilder>
    {
        protected override FulfillmentOrderMerchantRequestQueryBuilder Self => this;

        public FulfillmentOrderMerchantRequestQueryBuilder() : this("fulfillmentOrderMerchantRequest")
        {
        }

        public FulfillmentOrderMerchantRequestQueryBuilder(string name) : base(new Query<FulfillmentOrderMerchantRequest>(name))
        {
        }

        public FulfillmentOrderMerchantRequestQueryBuilder(IQuery<FulfillmentOrderMerchantRequest> query) : base(query)
        {
        }

        public FulfillmentOrderMerchantRequestQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderMerchantRequestQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentOrderMerchantRequestQueryBuilder Kind()
        {
            base.InnerQuery.AddField("kind");
            return this;
        }

        public FulfillmentOrderMerchantRequestQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public FulfillmentOrderMerchantRequestQueryBuilder RequestOptions()
        {
            base.InnerQuery.AddField("requestOptions");
            return this;
        }

        public FulfillmentOrderMerchantRequestQueryBuilder ResponseData()
        {
            base.InnerQuery.AddField("responseData");
            return this;
        }

        public FulfillmentOrderMerchantRequestQueryBuilder SentAt()
        {
            base.InnerQuery.AddField("sentAt");
            return this;
        }
    }
}