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
    public sealed class MetafieldDefinitionUnpinUserErrorQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionUnpinUserError, MetafieldDefinitionUnpinUserErrorQueryBuilder>
    {
        protected override MetafieldDefinitionUnpinUserErrorQueryBuilder Self => this;

        public MetafieldDefinitionUnpinUserErrorQueryBuilder() : this("metafieldDefinitionUnpinUserError")
        {
        }

        public MetafieldDefinitionUnpinUserErrorQueryBuilder(string name) : base(new Query<MetafieldDefinitionUnpinUserError>(name))
        {
        }

        public MetafieldDefinitionUnpinUserErrorQueryBuilder(IQuery<MetafieldDefinitionUnpinUserError> query) : base(query)
        {
        }

        public MetafieldDefinitionUnpinUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetafieldDefinitionUnpinUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetafieldDefinitionUnpinUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}