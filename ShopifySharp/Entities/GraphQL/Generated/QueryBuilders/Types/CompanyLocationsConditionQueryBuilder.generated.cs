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
    public sealed class CompanyLocationsConditionQueryBuilder : FieldsQueryBuilderBase<CompanyLocationsCondition, CompanyLocationsConditionQueryBuilder>
    {
        protected override CompanyLocationsConditionQueryBuilder Self => this;

        public CompanyLocationsConditionQueryBuilder() : this("companyLocationsCondition")
        {
        }

        public CompanyLocationsConditionQueryBuilder(string name) : base(new Query<CompanyLocationsCondition>(name))
        {
        }

        public CompanyLocationsConditionQueryBuilder(IQuery<CompanyLocationsCondition> query) : base(query)
        {
        }

        public CompanyLocationsConditionQueryBuilder ApplicationLevel()
        {
            base.InnerQuery.AddField("applicationLevel");
            return this;
        }

        public CompanyLocationsConditionQueryBuilder CompanyLocations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationConnection>("companyLocations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationConnection>(query);
            return this;
        }
    }
}