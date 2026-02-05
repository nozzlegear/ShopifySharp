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
    public sealed class MetafieldCapabilityAdminFilterableQueryBuilder : FieldsQueryBuilderBase<MetafieldCapabilityAdminFilterable, MetafieldCapabilityAdminFilterableQueryBuilder>
    {
        protected override MetafieldCapabilityAdminFilterableQueryBuilder Self => this;

        public MetafieldCapabilityAdminFilterableQueryBuilder() : this("metafieldCapabilityAdminFilterable")
        {
        }

        public MetafieldCapabilityAdminFilterableQueryBuilder(string name) : base(new Query<MetafieldCapabilityAdminFilterable>(name))
        {
        }

        public MetafieldCapabilityAdminFilterableQueryBuilder(IQuery<MetafieldCapabilityAdminFilterable> query) : base(query)
        {
        }

        public MetafieldCapabilityAdminFilterableQueryBuilder Eligible()
        {
            base.InnerQuery.AddField("eligible");
            return this;
        }

        public MetafieldCapabilityAdminFilterableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public MetafieldCapabilityAdminFilterableQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}