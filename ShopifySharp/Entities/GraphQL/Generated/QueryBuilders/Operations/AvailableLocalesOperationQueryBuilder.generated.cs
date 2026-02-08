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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class AvailableLocalesOperationQueryBuilder : FieldsQueryBuilderBase<Locale, AvailableLocalesOperationQueryBuilder>, IGraphOperationQueryBuilder<Locale>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override AvailableLocalesOperationQueryBuilder Self => this;

        public AvailableLocalesOperationQueryBuilder() : this("availableLocales")
        {
        }

        public AvailableLocalesOperationQueryBuilder(string name) : base(new Query<Locale>(name))
        {
        }

        public AvailableLocalesOperationQueryBuilder(IQuery<Locale> query) : base(query)
        {
        }

        public AvailableLocalesOperationQueryBuilder IsoCode()
        {
            base.InnerQuery.AddField("isoCode");
            return this;
        }

        public AvailableLocalesOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}