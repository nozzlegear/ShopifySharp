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
    public sealed class DataSaleOptOutPageQueryBuilder : FieldsQueryBuilderBase<DataSaleOptOutPage, DataSaleOptOutPageQueryBuilder>
    {
        protected override DataSaleOptOutPageQueryBuilder Self => this;

        public DataSaleOptOutPageQueryBuilder() : this("dataSaleOptOutPage")
        {
        }

        public DataSaleOptOutPageQueryBuilder(string name) : base(new Query<DataSaleOptOutPage>(name))
        {
        }

        public DataSaleOptOutPageQueryBuilder(IQuery<DataSaleOptOutPage> query) : base(query)
        {
        }

        public DataSaleOptOutPageQueryBuilder AutoManaged()
        {
            base.InnerQuery.AddField("autoManaged");
            return this;
        }
    }
}