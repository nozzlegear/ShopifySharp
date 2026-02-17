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