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
    public sealed class LegacyInteroperabilityQueryBuilder : FieldsQueryBuilderBase<ILegacyInteroperability, LegacyInteroperabilityQueryBuilder>
    {
        protected override LegacyInteroperabilityQueryBuilder Self => this;

        public LegacyInteroperabilityQueryBuilder() : this("legacyInteroperability")
        {
        }

        public LegacyInteroperabilityQueryBuilder(string name) : base(new Query<ILegacyInteroperability>(name))
        {
        }

        public LegacyInteroperabilityQueryBuilder(IQuery<ILegacyInteroperability> query) : base(query)
        {
        }

        public LegacyInteroperabilityQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }
    }
}