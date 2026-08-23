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
    public sealed class MetafieldCapabilityCartToOrderCopyableQueryBuilder : FieldsQueryBuilderBase<MetafieldCapabilityCartToOrderCopyable, MetafieldCapabilityCartToOrderCopyableQueryBuilder>
    {
        protected override MetafieldCapabilityCartToOrderCopyableQueryBuilder Self => this;

        public MetafieldCapabilityCartToOrderCopyableQueryBuilder() : this("metafieldCapabilityCartToOrderCopyable")
        {
        }

        public MetafieldCapabilityCartToOrderCopyableQueryBuilder(string name) : base(new Query<MetafieldCapabilityCartToOrderCopyable>(name))
        {
        }

        public MetafieldCapabilityCartToOrderCopyableQueryBuilder(IQuery<MetafieldCapabilityCartToOrderCopyable> query) : base(query)
        {
        }

        public MetafieldCapabilityCartToOrderCopyableQueryBuilder Eligible()
        {
            base.InnerQuery.AddField("eligible");
            return this;
        }

        public MetafieldCapabilityCartToOrderCopyableQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}