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
    public sealed class AttributeQueryBuilder : FieldsQueryBuilderBase<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>
    {
        protected override AttributeQueryBuilder Self => this;

        public AttributeQueryBuilder() : this("attribute")
        {
        }

        public AttributeQueryBuilder(string name) : base(new Query<ShopifySharp.GraphQL.Attribute>(name))
        {
        }

        public AttributeQueryBuilder(IQuery<ShopifySharp.GraphQL.Attribute> query) : base(query)
        {
        }

        public AttributeQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public AttributeQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}