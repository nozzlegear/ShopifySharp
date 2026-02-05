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
    public sealed class DepositConfigurationQueryBuilder : FieldsQueryBuilderBase<DepositConfiguration, DepositConfigurationQueryBuilder>
    {
        protected override DepositConfigurationQueryBuilder Self => this;

        public DepositConfigurationQueryBuilder() : this("depositConfiguration")
        {
        }

        public DepositConfigurationQueryBuilder(string name) : base(new Query<DepositConfiguration>(name))
        {
        }

        public DepositConfigurationQueryBuilder(IQuery<DepositConfiguration> query) : base(query)
        {
        }

        public DepositConfigurationQueryBuilder DepositConfiguration(Action<DepositConfigurationUnionCasesBuilder> build)
        {
            var query = new Query<DepositConfiguration>("depositConfiguration");
            var unionBuilder = new DepositConfigurationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}