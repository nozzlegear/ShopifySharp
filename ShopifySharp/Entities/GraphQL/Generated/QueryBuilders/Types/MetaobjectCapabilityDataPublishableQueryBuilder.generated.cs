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
    public sealed class MetaobjectCapabilityDataPublishableQueryBuilder : FieldsQueryBuilderBase<MetaobjectCapabilityDataPublishable, MetaobjectCapabilityDataPublishableQueryBuilder>
    {
        protected override MetaobjectCapabilityDataPublishableQueryBuilder Self => this;

        public MetaobjectCapabilityDataPublishableQueryBuilder() : this("metaobjectCapabilityDataPublishable")
        {
        }

        public MetaobjectCapabilityDataPublishableQueryBuilder(string name) : base(new Query<MetaobjectCapabilityDataPublishable>(name))
        {
        }

        public MetaobjectCapabilityDataPublishableQueryBuilder(IQuery<MetaobjectCapabilityDataPublishable> query) : base(query)
        {
        }

        public MetaobjectCapabilityDataPublishableQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}