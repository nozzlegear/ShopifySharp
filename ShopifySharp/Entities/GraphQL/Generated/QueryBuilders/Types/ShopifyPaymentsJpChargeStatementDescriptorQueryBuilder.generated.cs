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

        [Obsolete("This field is deprecated and will be removed in a future release.")]
        public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder Kana()
        {
            base.InnerQuery.AddField("kana");
            return this;
        }

        [Obsolete("This field is deprecated and will be removed in a future release.")]
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