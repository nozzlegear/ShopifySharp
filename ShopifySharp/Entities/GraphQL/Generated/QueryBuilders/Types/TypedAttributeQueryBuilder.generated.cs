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
    public sealed class TypedAttributeQueryBuilder : FieldsQueryBuilderBase<TypedAttribute, TypedAttributeQueryBuilder>
    {
        protected override TypedAttributeQueryBuilder Self => this;

        public TypedAttributeQueryBuilder() : this("typedAttribute")
        {
        }

        public TypedAttributeQueryBuilder(string name) : base(new Query<TypedAttribute>(name))
        {
        }

        public TypedAttributeQueryBuilder(IQuery<TypedAttribute> query) : base(query)
        {
        }

        public TypedAttributeQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public TypedAttributeQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}