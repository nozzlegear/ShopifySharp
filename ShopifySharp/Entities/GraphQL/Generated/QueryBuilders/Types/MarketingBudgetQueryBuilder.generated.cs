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
    public sealed class MarketingBudgetQueryBuilder : FieldsQueryBuilderBase<MarketingBudget, MarketingBudgetQueryBuilder>
    {
        protected override MarketingBudgetQueryBuilder Self => this;

        public MarketingBudgetQueryBuilder() : this("marketingBudget")
        {
        }

        public MarketingBudgetQueryBuilder(string name) : base(new Query<MarketingBudget>(name))
        {
        }

        public MarketingBudgetQueryBuilder(IQuery<MarketingBudget> query) : base(query)
        {
        }

        public MarketingBudgetQueryBuilder BudgetType()
        {
            base.InnerQuery.AddField("budgetType");
            return this;
        }

        public MarketingBudgetQueryBuilder Total(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("total");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}