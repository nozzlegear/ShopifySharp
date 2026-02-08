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
    public sealed class MetaobjectCapabilityDefinitionDataRenderableQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilityDefinitionDataRenderable, MetaobjectCapabilityDefinitionDataRenderableQueryBuilder>
    {
        protected override MetaobjectCapabilityDefinitionDataRenderableQueryBuilder Self => this;

        public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder() : this("metaobjectCapabilityDefinitionDataRenderable")
        {
        }

        public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder(string name) : base(new Query<MetaobjectCapabilityDefinitionDataRenderable>(name))
        {
        }

        public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder(IQuery<MetaobjectCapabilityDefinitionDataRenderable> query) : base(query)
        {
        }

        public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder MetaDescriptionKey()
        {
            base.InnerQuery.AddField("metaDescriptionKey");
            return this;
        }

        public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder MetaTitleKey()
        {
            base.InnerQuery.AddField("metaTitleKey");
            return this;
        }
    }
}