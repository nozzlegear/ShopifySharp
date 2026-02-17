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
    public sealed class MetafieldDefinitionCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionCreateUserError, MetafieldDefinitionCreateUserErrorQueryBuilder>
    {
        protected override MetafieldDefinitionCreateUserErrorQueryBuilder Self => this;

        public MetafieldDefinitionCreateUserErrorQueryBuilder() : this("metafieldDefinitionCreateUserError")
        {
        }

        public MetafieldDefinitionCreateUserErrorQueryBuilder(string name) : base(new Query<MetafieldDefinitionCreateUserError>(name))
        {
        }

        public MetafieldDefinitionCreateUserErrorQueryBuilder(IQuery<MetafieldDefinitionCreateUserError> query) : base(query)
        {
        }

        public MetafieldDefinitionCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetafieldDefinitionCreateUserErrorQueryBuilder ElementIndex()
        {
            base.InnerQuery.AddField("elementIndex");
            return this;
        }

        public MetafieldDefinitionCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetafieldDefinitionCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}