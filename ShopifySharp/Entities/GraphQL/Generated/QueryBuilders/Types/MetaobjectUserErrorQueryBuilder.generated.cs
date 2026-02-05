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
    public sealed class MetaobjectUserErrorQueryBuilder : FieldsQueryBuilderBase<MetaobjectUserError, MetaobjectUserErrorQueryBuilder>
    {
        protected override MetaobjectUserErrorQueryBuilder Self => this;

        public MetaobjectUserErrorQueryBuilder() : this("metaobjectUserError")
        {
        }

        public MetaobjectUserErrorQueryBuilder(string name) : base(new Query<MetaobjectUserError>(name))
        {
        }

        public MetaobjectUserErrorQueryBuilder(IQuery<MetaobjectUserError> query) : base(query)
        {
        }

        public MetaobjectUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetaobjectUserErrorQueryBuilder ElementIndex()
        {
            base.InnerQuery.AddField("elementIndex");
            return this;
        }

        public MetaobjectUserErrorQueryBuilder ElementKey()
        {
            base.InnerQuery.AddField("elementKey");
            return this;
        }

        public MetaobjectUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetaobjectUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}