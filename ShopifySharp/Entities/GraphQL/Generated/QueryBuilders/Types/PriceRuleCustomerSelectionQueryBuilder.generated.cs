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
    public sealed class PriceRuleCustomerSelectionQueryBuilder : FieldsQueryBuilderBase<PriceRuleCustomerSelection, PriceRuleCustomerSelectionQueryBuilder>
    {
        protected override PriceRuleCustomerSelectionQueryBuilder Self => this;

        public PriceRuleCustomerSelectionQueryBuilder() : this("priceRuleCustomerSelection")
        {
        }

        public PriceRuleCustomerSelectionQueryBuilder(string name) : base(new Query<PriceRuleCustomerSelection>(name))
        {
        }

        public PriceRuleCustomerSelectionQueryBuilder(IQuery<PriceRuleCustomerSelection> query) : base(query)
        {
        }

        public PriceRuleCustomerSelectionQueryBuilder Customers(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerConnection>("customers");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerConnection>(query);
            return this;
        }

        public PriceRuleCustomerSelectionQueryBuilder ForAllCustomers()
        {
            base.InnerQuery.AddField("forAllCustomers");
            return this;
        }

        public PriceRuleCustomerSelectionQueryBuilder Segments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("segments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }
    }
}