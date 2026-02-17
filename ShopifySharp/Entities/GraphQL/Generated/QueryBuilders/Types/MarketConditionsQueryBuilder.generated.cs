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
    public sealed class MarketConditionsQueryBuilder : FieldsQueryBuilderBase<MarketConditions, MarketConditionsQueryBuilder>
    {
        protected override MarketConditionsQueryBuilder Self => this;

        public MarketConditionsQueryBuilder() : this("marketConditions")
        {
        }

        public MarketConditionsQueryBuilder(string name) : base(new Query<MarketConditions>(name))
        {
        }

        public MarketConditionsQueryBuilder(IQuery<MarketConditions> query) : base(query)
        {
        }

        public MarketConditionsQueryBuilder CompanyLocationsCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationsConditionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationsCondition>("companyLocationsCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationsConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationsCondition>(query);
            return this;
        }

        public MarketConditionsQueryBuilder ConditionTypes()
        {
            base.InnerQuery.AddField("conditionTypes");
            return this;
        }

        public MarketConditionsQueryBuilder LocationsCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationsConditionQueryBuilder> build)
        {
            var query = new Query<LocationsCondition>("locationsCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationsConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationsCondition>(query);
            return this;
        }

        public MarketConditionsQueryBuilder RegionsCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RegionsConditionQueryBuilder> build)
        {
            var query = new Query<RegionsCondition>("regionsCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RegionsConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RegionsCondition>(query);
            return this;
        }
    }
}