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
    public sealed class MetafieldDefinitionPinUserErrorQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionPinUserError, MetafieldDefinitionPinUserErrorQueryBuilder>
    {
        protected override MetafieldDefinitionPinUserErrorQueryBuilder Self => this;

        public MetafieldDefinitionPinUserErrorQueryBuilder() : this("metafieldDefinitionPinUserError")
        {
        }

        public MetafieldDefinitionPinUserErrorQueryBuilder(string name) : base(new Query<MetafieldDefinitionPinUserError>(name))
        {
        }

        public MetafieldDefinitionPinUserErrorQueryBuilder(IQuery<MetafieldDefinitionPinUserError> query) : base(query)
        {
        }

        public MetafieldDefinitionPinUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetafieldDefinitionPinUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetafieldDefinitionPinUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}