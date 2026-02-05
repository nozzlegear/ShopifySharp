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
    public sealed class DataSaleOptOutPayloadQueryBuilder : FieldsQueryBuilderBase<DataSaleOptOutPayload, DataSaleOptOutPayloadQueryBuilder>
    {
        protected override DataSaleOptOutPayloadQueryBuilder Self => this;

        public DataSaleOptOutPayloadQueryBuilder() : this("dataSaleOptOutPayload")
        {
        }

        public DataSaleOptOutPayloadQueryBuilder(string name) : base(new Query<DataSaleOptOutPayload>(name))
        {
        }

        public DataSaleOptOutPayloadQueryBuilder(IQuery<DataSaleOptOutPayload> query) : base(query)
        {
        }

        public DataSaleOptOutPayloadQueryBuilder CustomerId()
        {
            base.InnerQuery.AddField("customerId");
            return this;
        }

        public DataSaleOptOutPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutUserErrorQueryBuilder> build)
        {
            var query = new Query<DataSaleOptOutUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DataSaleOptOutUserError>(query);
            return this;
        }
    }
}