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
    public sealed class MetaobjectCapabilitiesQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilities, MetaobjectCapabilitiesQueryBuilder>
    {
        protected override MetaobjectCapabilitiesQueryBuilder Self => this;

        public MetaobjectCapabilitiesQueryBuilder() : this("metaobjectCapabilities")
        {
        }

        public MetaobjectCapabilitiesQueryBuilder(string name) : base(new Query<MetaobjectCapabilities>(name))
        {
        }

        public MetaobjectCapabilitiesQueryBuilder(IQuery<MetaobjectCapabilities> query) : base(query)
        {
        }

        public MetaobjectCapabilitiesQueryBuilder OnlineStore(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesOnlineStoreQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilitiesOnlineStore>("onlineStore");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesOnlineStoreQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilitiesOnlineStore>(query);
            return this;
        }

        public MetaobjectCapabilitiesQueryBuilder Publishable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesPublishableQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilitiesPublishable>("publishable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesPublishableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilitiesPublishable>(query);
            return this;
        }

        public MetaobjectCapabilitiesQueryBuilder Renderable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesRenderableQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilitiesRenderable>("renderable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesRenderableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilitiesRenderable>(query);
            return this;
        }

        public MetaobjectCapabilitiesQueryBuilder Translatable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesTranslatableQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilitiesTranslatable>("translatable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesTranslatableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilitiesTranslatable>(query);
            return this;
        }
    }
}