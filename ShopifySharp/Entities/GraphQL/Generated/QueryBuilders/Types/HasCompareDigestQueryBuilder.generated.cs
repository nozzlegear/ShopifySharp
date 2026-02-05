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
    public sealed class HasCompareDigestQueryBuilder : FieldsQueryBuilderBase<IHasCompareDigest, HasCompareDigestQueryBuilder>
    {
        protected override HasCompareDigestQueryBuilder Self => this;

        public HasCompareDigestQueryBuilder() : this("hasCompareDigest")
        {
        }

        public HasCompareDigestQueryBuilder(string name) : base(new Query<IHasCompareDigest>(name))
        {
        }

        public HasCompareDigestQueryBuilder(IQuery<IHasCompareDigest> query) : base(query)
        {
        }

        public HasCompareDigestQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }
    }
}