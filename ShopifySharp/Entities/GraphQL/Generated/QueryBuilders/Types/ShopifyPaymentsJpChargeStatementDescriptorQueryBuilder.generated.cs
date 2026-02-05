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
    public sealed class ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsJpChargeStatementDescriptor, ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder>
    {
        protected override ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder Self => this;

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder() : this("shopifyPaymentsJpChargeStatementDescriptor")
        {
        }

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder(string name) : base(new Query<ShopifyPaymentsJpChargeStatementDescriptor>(name))
        {
        }

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder(IQuery<ShopifyPaymentsJpChargeStatementDescriptor> query) : base(query)
        {
        }

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder Kana()
        {
            base.InnerQuery.AddField("kana");
            return this;
        }

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder Kanji()
        {
            base.InnerQuery.AddField("kanji");
            return this;
        }

        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }
    }
}