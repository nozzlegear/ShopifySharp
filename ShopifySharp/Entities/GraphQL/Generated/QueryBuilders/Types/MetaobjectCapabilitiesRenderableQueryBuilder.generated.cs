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
    public sealed class MetaobjectCapabilitiesRenderableQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilitiesRenderable, MetaobjectCapabilitiesRenderableQueryBuilder>
    {
        protected override MetaobjectCapabilitiesRenderableQueryBuilder Self => this;

        public MetaobjectCapabilitiesRenderableQueryBuilder() : this("metaobjectCapabilitiesRenderable")
        {
        }

        public MetaobjectCapabilitiesRenderableQueryBuilder(string name) : base(new Query<MetaobjectCapabilitiesRenderable>(name))
        {
        }

        public MetaobjectCapabilitiesRenderableQueryBuilder(IQuery<MetaobjectCapabilitiesRenderable> query) : base(query)
        {
        }

        public MetaobjectCapabilitiesRenderableQueryBuilder Data(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilityDefinitionDataRenderableQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityDefinitionDataRenderable>("data");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilityDefinitionDataRenderableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityDefinitionDataRenderable>(query);
            return this;
        }

        public MetaobjectCapabilitiesRenderableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}