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
    public sealed class CustomerStatisticsQueryBuilder : FieldsQueryBuilderBase<CustomerStatistics, CustomerStatisticsQueryBuilder>
    {
        protected override CustomerStatisticsQueryBuilder Self => this;

        public CustomerStatisticsQueryBuilder() : this("customerStatistics")
        {
        }

        public CustomerStatisticsQueryBuilder(string name) : base(new Query<CustomerStatistics>(name))
        {
        }

        public CustomerStatisticsQueryBuilder(IQuery<CustomerStatistics> query) : base(query)
        {
        }

        public CustomerStatisticsQueryBuilder PredictedSpendTier()
        {
            base.InnerQuery.AddField("predictedSpendTier");
            return this;
        }

        public CustomerStatisticsQueryBuilder RfmGroup()
        {
            base.InnerQuery.AddField("rfmGroup");
            return this;
        }
    }
}