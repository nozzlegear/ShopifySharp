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
    public sealed class CountQueryBuilder : FieldsQueryBuilderBase<Count, CountQueryBuilder>, IHasArguments<CountArgumentsBuilder>
    {
        public CountArgumentsBuilder Arguments { get; }
        protected override CountQueryBuilder Self => this;

        public CountQueryBuilder() : this("count")
        {
        }

        public CountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CountArgumentsBuilder(base.InnerQuery);
        }

        public CountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CountArgumentsBuilder(base.InnerQuery);
        }

        public CountQueryBuilder SetArguments(Action<CountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}