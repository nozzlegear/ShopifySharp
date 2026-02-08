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
    public sealed class MetafieldReferenceQueryBuilder : FieldsQueryBuilderBase<MetafieldReference, MetafieldReferenceQueryBuilder>
    {
        protected override MetafieldReferenceQueryBuilder Self => this;

        public MetafieldReferenceQueryBuilder() : this("metafieldReference")
        {
        }

        public MetafieldReferenceQueryBuilder(string name) : base(new Query<MetafieldReference>(name))
        {
        }

        public MetafieldReferenceQueryBuilder(IQuery<MetafieldReference> query) : base(query)
        {
        }

        public MetafieldReferenceQueryBuilder MetafieldReference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("metafieldReference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}