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
    public sealed class DepositConfigurationUnionCasesBuilder : UnionCasesBuilderBase<DepositConfiguration, DepositConfigurationUnionCasesBuilder>
    {
        protected override DepositConfigurationUnionCasesBuilder Self => this;

        public DepositConfigurationUnionCasesBuilder(string fieldName = "depositConfiguration") : this(new Query<DepositConfiguration>(fieldName))
        {
        }

        public DepositConfigurationUnionCasesBuilder(IQuery<DepositConfiguration> query) : base(query)
        {
        }

        public DepositConfigurationUnionCasesBuilder OnDepositPercentage(Action<DepositPercentageQueryBuilder> build)
        {
            var query = new Query<DepositPercentage>("... on DepositPercentage");
            var queryBuilder = new DepositPercentageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}