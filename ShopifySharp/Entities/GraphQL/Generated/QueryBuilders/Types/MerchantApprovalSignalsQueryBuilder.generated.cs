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
    public sealed class MerchantApprovalSignalsQueryBuilder : FieldsQueryBuilderBase<MerchantApprovalSignals, MerchantApprovalSignalsQueryBuilder>
    {
        protected override MerchantApprovalSignalsQueryBuilder Self => this;

        public MerchantApprovalSignalsQueryBuilder() : this("merchantApprovalSignals")
        {
        }

        public MerchantApprovalSignalsQueryBuilder(string name) : base(new Query<MerchantApprovalSignals>(name))
        {
        }

        public MerchantApprovalSignalsQueryBuilder(IQuery<MerchantApprovalSignals> query) : base(query)
        {
        }

        public MerchantApprovalSignalsQueryBuilder IdentityVerified()
        {
            base.InnerQuery.AddField("identityVerified");
            return this;
        }

        public MerchantApprovalSignalsQueryBuilder VerifiedByShopify()
        {
            base.InnerQuery.AddField("verifiedByShopify");
            return this;
        }

        public MerchantApprovalSignalsQueryBuilder VerifiedByShopifyTier()
        {
            base.InnerQuery.AddField("verifiedByShopifyTier");
            return this;
        }
    }
}