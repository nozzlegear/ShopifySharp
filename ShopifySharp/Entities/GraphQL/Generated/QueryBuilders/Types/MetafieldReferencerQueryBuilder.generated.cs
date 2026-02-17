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
    public sealed class MetafieldReferencerQueryBuilder : FieldsQueryBuilderBase<MetafieldReferencer, MetafieldReferencerQueryBuilder>
    {
        protected override MetafieldReferencerQueryBuilder Self => this;

        public MetafieldReferencerQueryBuilder() : this("metafieldReferencer")
        {
        }

        public MetafieldReferencerQueryBuilder(string name) : base(new Query<MetafieldReferencer>(name))
        {
        }

        public MetafieldReferencerQueryBuilder(IQuery<MetafieldReferencer> query) : base(query)
        {
        }

        public MetafieldReferencerQueryBuilder MetafieldReferencer(Action<MetafieldReferencerUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReferencer>("metafieldReferencer");
            var unionBuilder = new MetafieldReferencerUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}