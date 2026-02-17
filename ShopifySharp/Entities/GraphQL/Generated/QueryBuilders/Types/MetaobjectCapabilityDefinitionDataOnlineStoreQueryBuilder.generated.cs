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
    public sealed class MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilityDefinitionDataOnlineStore, MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder>
    {
        protected override MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder Self => this;

        public MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder() : this("metaobjectCapabilityDefinitionDataOnlineStore")
        {
        }

        public MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder(string name) : base(new Query<MetaobjectCapabilityDefinitionDataOnlineStore>(name))
        {
        }

        public MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder(IQuery<MetaobjectCapabilityDefinitionDataOnlineStore> query) : base(query)
        {
        }

        public MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder CanCreateRedirects()
        {
            base.InnerQuery.AddField("canCreateRedirects");
            return this;
        }

        public MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder UrlHandle()
        {
            base.InnerQuery.AddField("urlHandle");
            return this;
        }
    }
}