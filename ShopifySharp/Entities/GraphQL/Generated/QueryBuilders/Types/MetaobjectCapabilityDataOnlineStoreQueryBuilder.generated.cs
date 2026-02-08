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
    public sealed class MetaobjectCapabilityDataOnlineStoreQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilityDataOnlineStore, MetaobjectCapabilityDataOnlineStoreQueryBuilder>
    {
        protected override MetaobjectCapabilityDataOnlineStoreQueryBuilder Self => this;

        public MetaobjectCapabilityDataOnlineStoreQueryBuilder() : this("metaobjectCapabilityDataOnlineStore")
        {
        }

        public MetaobjectCapabilityDataOnlineStoreQueryBuilder(string name) : base(new Query<MetaobjectCapabilityDataOnlineStore>(name))
        {
        }

        public MetaobjectCapabilityDataOnlineStoreQueryBuilder(IQuery<MetaobjectCapabilityDataOnlineStore> query) : base(query)
        {
        }

        public MetaobjectCapabilityDataOnlineStoreQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }
    }
}