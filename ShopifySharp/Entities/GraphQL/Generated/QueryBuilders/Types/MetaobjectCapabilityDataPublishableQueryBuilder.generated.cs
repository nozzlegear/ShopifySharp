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