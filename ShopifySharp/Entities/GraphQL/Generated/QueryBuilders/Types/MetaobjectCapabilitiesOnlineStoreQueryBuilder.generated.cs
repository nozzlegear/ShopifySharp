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
    public sealed class MetaobjectCapabilitiesOnlineStoreQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilitiesOnlineStore, MetaobjectCapabilitiesOnlineStoreQueryBuilder>
    {
        protected override MetaobjectCapabilitiesOnlineStoreQueryBuilder Self => this;

        public MetaobjectCapabilitiesOnlineStoreQueryBuilder() : this("metaobjectCapabilitiesOnlineStore")
        {
        }

        public MetaobjectCapabilitiesOnlineStoreQueryBuilder(string name) : base(new Query<MetaobjectCapabilitiesOnlineStore>(name))
        {
        }

        public MetaobjectCapabilitiesOnlineStoreQueryBuilder(IQuery<MetaobjectCapabilitiesOnlineStore> query) : base(query)
        {
        }

        public MetaobjectCapabilitiesOnlineStoreQueryBuilder Data(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityDefinitionDataOnlineStore>("data");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityDefinitionDataOnlineStore>(query);
            return this;
        }

        public MetaobjectCapabilitiesOnlineStoreQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}