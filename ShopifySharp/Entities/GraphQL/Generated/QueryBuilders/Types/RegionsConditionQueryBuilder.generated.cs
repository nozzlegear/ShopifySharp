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
    public sealed class RegionsConditionQueryBuilder : FieldsQueryBuilderBase<RegionsCondition, RegionsConditionQueryBuilder>
    {
        protected override RegionsConditionQueryBuilder Self => this;

        public RegionsConditionQueryBuilder() : this("regionsCondition")
        {
        }

        public RegionsConditionQueryBuilder(string name) : base(new Query<RegionsCondition>(name))
        {
        }

        public RegionsConditionQueryBuilder(IQuery<RegionsCondition> query) : base(query)
        {
        }

        public RegionsConditionQueryBuilder ApplicationLevel()
        {
            base.InnerQuery.AddField("applicationLevel");
            return this;
        }

        public RegionsConditionQueryBuilder Regions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionConnectionQueryBuilder> build)
        {
            var query = new Query<MarketRegionConnection>("regions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionConnection>(query);
            return this;
        }
    }
}