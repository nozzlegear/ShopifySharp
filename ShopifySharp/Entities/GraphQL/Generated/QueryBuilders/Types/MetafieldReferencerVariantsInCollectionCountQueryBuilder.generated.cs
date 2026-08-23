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
    public sealed class MetafieldReferencerVariantsInCollectionCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferencerVariantsInCollectionCountQueryBuilder>, IHasArguments<MetafieldReferencerVariantsInCollectionCountArgumentsBuilder>
    {
        public MetafieldReferencerVariantsInCollectionCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerVariantsInCollectionCountQueryBuilder Self => this;

        public MetafieldReferencerVariantsInCollectionCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferencerVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerVariantsInCollectionCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferencerVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerVariantsInCollectionCountQueryBuilder SetArguments(Action<MetafieldReferencerVariantsInCollectionCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferencerVariantsInCollectionCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}