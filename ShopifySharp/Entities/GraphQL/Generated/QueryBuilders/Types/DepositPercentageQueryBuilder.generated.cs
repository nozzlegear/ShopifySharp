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