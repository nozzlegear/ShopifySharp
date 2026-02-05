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
    public sealed class MetafieldsSetUserErrorQueryBuilder : FieldsQueryBuilderBase<MetafieldsSetUserError, MetafieldsSetUserErrorQueryBuilder>
    {
        protected override MetafieldsSetUserErrorQueryBuilder Self => this;

        public MetafieldsSetUserErrorQueryBuilder() : this("metafieldsSetUserError")
        {
        }

        public MetafieldsSetUserErrorQueryBuilder(string name) : base(new Query<MetafieldsSetUserError>(name))
        {
        }

        public MetafieldsSetUserErrorQueryBuilder(IQuery<MetafieldsSetUserError> query) : base(query)
        {
        }

        public MetafieldsSetUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetafieldsSetUserErrorQueryBuilder ElementIndex()
        {
            base.InnerQuery.AddField("elementIndex");
            return this;
        }

        public MetafieldsSetUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetafieldsSetUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}