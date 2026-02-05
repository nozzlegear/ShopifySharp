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
    public sealed class StandardMetaobjectCapabilityTemplateQueryBuilder : FieldsQueryBuilderBase<StandardMetaobjectCapabilityTemplate, StandardMetaobjectCapabilityTemplateQueryBuilder>
    {
        protected override StandardMetaobjectCapabilityTemplateQueryBuilder Self => this;

        public StandardMetaobjectCapabilityTemplateQueryBuilder() : this("standardMetaobjectCapabilityTemplate")
        {
        }

        public StandardMetaobjectCapabilityTemplateQueryBuilder(string name) : base(new Query<StandardMetaobjectCapabilityTemplate>(name))
        {
        }

        public StandardMetaobjectCapabilityTemplateQueryBuilder(IQuery<StandardMetaobjectCapabilityTemplate> query) : base(query)
        {
        }

        public StandardMetaobjectCapabilityTemplateQueryBuilder CapabilityType()
        {
            base.InnerQuery.AddField("capabilityType");
            return this;
        }
    }
}