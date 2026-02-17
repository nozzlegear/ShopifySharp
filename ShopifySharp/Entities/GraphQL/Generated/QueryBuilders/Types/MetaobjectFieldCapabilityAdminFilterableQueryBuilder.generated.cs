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
    public sealed class MetaobjectFieldCapabilityAdminFilterableQueryBuilder : FieldsQueryBuilderBase<MetaobjectFieldCapabilityAdminFilterable, MetaobjectFieldCapabilityAdminFilterableQueryBuilder>
    {
        protected override MetaobjectFieldCapabilityAdminFilterableQueryBuilder Self => this;

        public MetaobjectFieldCapabilityAdminFilterableQueryBuilder() : this("metaobjectFieldCapabilityAdminFilterable")
        {
        }

        public MetaobjectFieldCapabilityAdminFilterableQueryBuilder(string name) : base(new Query<MetaobjectFieldCapabilityAdminFilterable>(name))
        {
        }

        public MetaobjectFieldCapabilityAdminFilterableQueryBuilder(IQuery<MetaobjectFieldCapabilityAdminFilterable> query) : base(query)
        {
        }

        public MetaobjectFieldCapabilityAdminFilterableQueryBuilder Eligible()
        {
            base.InnerQuery.AddField("eligible");
            return this;
        }

        public MetaobjectFieldCapabilityAdminFilterableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}