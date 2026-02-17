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
    public sealed class ReverseFulfillmentOrderDispositionQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderDisposition, ReverseFulfillmentOrderDispositionQueryBuilder>
    {
        protected override ReverseFulfillmentOrderDispositionQueryBuilder Self => this;

        public ReverseFulfillmentOrderDispositionQueryBuilder() : this("reverseFulfillmentOrderDisposition")
        {
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderDisposition>(name))
        {
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder(IQuery<ReverseFulfillmentOrderDisposition> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ReverseFulfillmentOrderDispositionQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}