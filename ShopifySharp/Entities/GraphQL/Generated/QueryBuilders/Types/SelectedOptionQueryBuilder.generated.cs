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
    public sealed class SelectedOptionQueryBuilder : FieldsQueryBuilderBase<SelectedOption, SelectedOptionQueryBuilder>
    {
        protected override SelectedOptionQueryBuilder Self => this;

        public SelectedOptionQueryBuilder() : this("selectedOption")
        {
        }

        public SelectedOptionQueryBuilder(string name) : base(new Query<SelectedOption>(name))
        {
        }

        public SelectedOptionQueryBuilder(IQuery<SelectedOption> query) : base(query)
        {
        }

        public SelectedOptionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SelectedOptionQueryBuilder OptionValue(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductOptionValue>("optionValue");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionValue>(query);
            return this;
        }

        public SelectedOptionQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}