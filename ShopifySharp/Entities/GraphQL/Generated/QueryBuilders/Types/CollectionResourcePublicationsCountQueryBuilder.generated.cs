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
    public sealed class CollectionResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, CollectionResourcePublicationsCountQueryBuilder>, IHasArguments<CollectionResourcePublicationsCountArgumentsBuilder>
    {
        public CollectionResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override CollectionResourcePublicationsCountQueryBuilder Self => this;

        public CollectionResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CollectionResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public CollectionResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CollectionResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public CollectionResourcePublicationsCountQueryBuilder SetArguments(Action<CollectionResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CollectionResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}