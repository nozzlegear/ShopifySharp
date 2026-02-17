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
    public sealed class MetafieldRelationQueryBuilder : FieldsQueryBuilderBase<MetafieldRelation, MetafieldRelationQueryBuilder>
    {
        protected override MetafieldRelationQueryBuilder Self => this;

        public MetafieldRelationQueryBuilder() : this("metafieldRelation")
        {
        }

        public MetafieldRelationQueryBuilder(string name) : base(new Query<MetafieldRelation>(name))
        {
        }

        public MetafieldRelationQueryBuilder(IQuery<MetafieldRelation> query) : base(query)
        {
        }

        public MetafieldRelationQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldRelationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldRelationQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public MetafieldRelationQueryBuilder Referencer(Action<MetafieldReferencerUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReferencer>("referencer");
            var unionBuilder = new MetafieldReferencerUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("No longer supported. Access the object directly instead.")]
        public MetafieldRelationQueryBuilder Target(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("target");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}