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
    public sealed class MetaobjectCapabilityDataQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilityData, MetaobjectCapabilityDataQueryBuilder>
    {
        protected override MetaobjectCapabilityDataQueryBuilder Self => this;

        public MetaobjectCapabilityDataQueryBuilder() : this("metaobjectCapabilityData")
        {
        }

        public MetaobjectCapabilityDataQueryBuilder(string name) : base(new Query<MetaobjectCapabilityData>(name))
        {
        }

        public MetaobjectCapabilityDataQueryBuilder(IQuery<MetaobjectCapabilityData> query) : base(query)
        {
        }

        public MetaobjectCapabilityDataQueryBuilder OnlineStore(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataOnlineStoreQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityDataOnlineStore>("onlineStore");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataOnlineStoreQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityDataOnlineStore>(query);
            return this;
        }

        public MetaobjectCapabilityDataQueryBuilder Publishable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataPublishableQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityDataPublishable>("publishable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataPublishableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityDataPublishable>(query);
            return this;
        }
    }
}