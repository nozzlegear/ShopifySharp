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
    public sealed class MetafieldDefinitionDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionDeleteUserError, MetafieldDefinitionDeleteUserErrorQueryBuilder>
    {
        protected override MetafieldDefinitionDeleteUserErrorQueryBuilder Self => this;

        public MetafieldDefinitionDeleteUserErrorQueryBuilder() : this("metafieldDefinitionDeleteUserError")
        {
        }

        public MetafieldDefinitionDeleteUserErrorQueryBuilder(string name) : base(new Query<MetafieldDefinitionDeleteUserError>(name))
        {
        }

        public MetafieldDefinitionDeleteUserErrorQueryBuilder(IQuery<MetafieldDefinitionDeleteUserError> query) : base(query)
        {
        }

        public MetafieldDefinitionDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetafieldDefinitionDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetafieldDefinitionDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}