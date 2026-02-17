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
    public sealed class DataSaleOptOutUserErrorQueryBuilder : FieldsQueryBuilderBase<DataSaleOptOutUserError, DataSaleOptOutUserErrorQueryBuilder>
    {
        protected override DataSaleOptOutUserErrorQueryBuilder Self => this;

        public DataSaleOptOutUserErrorQueryBuilder() : this("dataSaleOptOutUserError")
        {
        }

        public DataSaleOptOutUserErrorQueryBuilder(string name) : base(new Query<DataSaleOptOutUserError>(name))
        {
        }

        public DataSaleOptOutUserErrorQueryBuilder(IQuery<DataSaleOptOutUserError> query) : base(query)
        {
        }

        public DataSaleOptOutUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DataSaleOptOutUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DataSaleOptOutUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}