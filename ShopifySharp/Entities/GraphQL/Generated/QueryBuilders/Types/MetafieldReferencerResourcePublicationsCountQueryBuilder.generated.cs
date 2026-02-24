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
    public sealed class MetafieldReferencerResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, MetafieldReferencerResourcePublicationsCountQueryBuilder>, IHasArguments<MetafieldReferencerResourcePublicationsCountArgumentsBuilder>
    {
        public MetafieldReferencerResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerResourcePublicationsCountQueryBuilder Self => this;

        public MetafieldReferencerResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MetafieldReferencerResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MetafieldReferencerResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerResourcePublicationsCountQueryBuilder SetArguments(Action<MetafieldReferencerResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MetafieldReferencerResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}