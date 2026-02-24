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
    public sealed class MetafieldReferencerCatalogsCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferencerCatalogsCountQueryBuilder>, IHasArguments<MetafieldReferencerCatalogsCountArgumentsBuilder>
    {
        public MetafieldReferencerCatalogsCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerCatalogsCountQueryBuilder Self => this;

        public MetafieldReferencerCatalogsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferencerCatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerCatalogsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferencerCatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerCatalogsCountQueryBuilder SetArguments(Action<MetafieldReferencerCatalogsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerCatalogsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferencerCatalogsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}