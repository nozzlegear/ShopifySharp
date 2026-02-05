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
    public sealed class MetaobjectCapabilitiesTranslatableQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilitiesTranslatable, MetaobjectCapabilitiesTranslatableQueryBuilder>
    {
        protected override MetaobjectCapabilitiesTranslatableQueryBuilder Self => this;

        public MetaobjectCapabilitiesTranslatableQueryBuilder() : this("metaobjectCapabilitiesTranslatable")
        {
        }

        public MetaobjectCapabilitiesTranslatableQueryBuilder(string name) : base(new Query<MetaobjectCapabilitiesTranslatable>(name))
        {
        }

        public MetaobjectCapabilitiesTranslatableQueryBuilder(IQuery<MetaobjectCapabilitiesTranslatable> query) : base(query)
        {
        }

        public MetaobjectCapabilitiesTranslatableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}