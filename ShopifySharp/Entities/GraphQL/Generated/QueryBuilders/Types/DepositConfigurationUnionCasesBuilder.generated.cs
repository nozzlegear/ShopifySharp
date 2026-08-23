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
    public sealed class DepositConfigurationUnionCasesBuilder : UnionCasesBuilderBase<DepositConfiguration, DepositConfigurationUnionCasesBuilder>
    {
        protected override DepositConfigurationUnionCasesBuilder Self => this;

        public DepositConfigurationUnionCasesBuilder(string fieldName = "deposit") : this(new Query<DepositConfiguration>(fieldName))
        {
        }

        public DepositConfigurationUnionCasesBuilder(IQuery<DepositConfiguration> query) : base(query)
        {
        }

        public DepositConfigurationUnionCasesBuilder OnDepositPercentage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DepositPercentageQueryBuilder> build)
        {
            var query = new Query<DepositPercentage>("... on DepositPercentage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DepositPercentageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}