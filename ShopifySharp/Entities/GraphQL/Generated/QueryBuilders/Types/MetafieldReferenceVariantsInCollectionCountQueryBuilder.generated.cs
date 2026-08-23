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
    public sealed class MetafieldReferenceVariantsInCollectionCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferenceVariantsInCollectionCountQueryBuilder>, IHasArguments<MetafieldReferenceVariantsInCollectionCountArgumentsBuilder>
    {
        public MetafieldReferenceVariantsInCollectionCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceVariantsInCollectionCountQueryBuilder Self => this;

        public MetafieldReferenceVariantsInCollectionCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferenceVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceVariantsInCollectionCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferenceVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceVariantsInCollectionCountQueryBuilder SetArguments(Action<MetafieldReferenceVariantsInCollectionCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceVariantsInCollectionCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferenceVariantsInCollectionCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}