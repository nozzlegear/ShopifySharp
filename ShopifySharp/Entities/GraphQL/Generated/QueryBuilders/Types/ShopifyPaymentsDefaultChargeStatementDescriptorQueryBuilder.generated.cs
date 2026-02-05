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
    public sealed class ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDefaultChargeStatementDescriptor, ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder>
    {
        protected override ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder Self => this;

        public ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder() : this("shopifyPaymentsDefaultChargeStatementDescriptor")
        {
        }

        public ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder(string name) : base(new Query<ShopifyPaymentsDefaultChargeStatementDescriptor>(name))
        {
        }

        public ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder(IQuery<ShopifyPaymentsDefaultChargeStatementDescriptor> query) : base(query)
        {
        }

        public ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }
    }
}