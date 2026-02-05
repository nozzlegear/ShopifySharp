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
    public sealed class MetaobjectCapabilitiesPublishableQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilitiesPublishable, MetaobjectCapabilitiesPublishableQueryBuilder>
    {
        protected override MetaobjectCapabilitiesPublishableQueryBuilder Self => this;

        public MetaobjectCapabilitiesPublishableQueryBuilder() : this("metaobjectCapabilitiesPublishable")
        {
        }

        public MetaobjectCapabilitiesPublishableQueryBuilder(string name) : base(new Query<MetaobjectCapabilitiesPublishable>(name))
        {
        }

        public MetaobjectCapabilitiesPublishableQueryBuilder(IQuery<MetaobjectCapabilitiesPublishable> query) : base(query)
        {
        }

        public MetaobjectCapabilitiesPublishableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}