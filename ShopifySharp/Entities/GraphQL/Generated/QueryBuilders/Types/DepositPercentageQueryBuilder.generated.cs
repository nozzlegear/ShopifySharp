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
    public sealed class DepositPercentageQueryBuilder : FieldsQueryBuilderBase<DepositPercentage, DepositPercentageQueryBuilder>
    {
        protected override DepositPercentageQueryBuilder Self => this;

        public DepositPercentageQueryBuilder() : this("depositPercentage")
        {
        }

        public DepositPercentageQueryBuilder(string name) : base(new Query<DepositPercentage>(name))
        {
        }

        public DepositPercentageQueryBuilder(IQuery<DepositPercentage> query) : base(query)
        {
        }

        public DepositPercentageQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}