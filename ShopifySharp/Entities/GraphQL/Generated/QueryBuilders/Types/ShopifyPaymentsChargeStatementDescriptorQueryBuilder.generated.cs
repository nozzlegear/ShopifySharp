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
    public sealed class ShopifyPaymentsChargeStatementDescriptorQueryBuilder : FieldsQueryBuilderBase<IShopifyPaymentsChargeStatementDescriptor, ShopifyPaymentsChargeStatementDescriptorQueryBuilder>
    {
        protected override ShopifyPaymentsChargeStatementDescriptorQueryBuilder Self => this;

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder() : this("shopifyPaymentsChargeStatementDescriptor")
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder(string name) : base(new Query<IShopifyPaymentsChargeStatementDescriptor>(name))
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder(IQuery<IShopifyPaymentsChargeStatementDescriptor> query) : base(query)
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }
    }
}