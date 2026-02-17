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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ConsentPolicyOperationQueryBuilder : FieldsQueryBuilderBase<ConsentPolicy, ConsentPolicyOperationQueryBuilder>, IGraphOperationQueryBuilder<ConsentPolicy>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ConsentPolicyArgumentsBuilder Arguments { get; }
        protected override ConsentPolicyOperationQueryBuilder Self => this;

        public ConsentPolicyOperationQueryBuilder() : this("consentPolicy")
        {
        }

        public ConsentPolicyOperationQueryBuilder(string name) : base(new Query<ConsentPolicy>(name))
        {
            Arguments = new ConsentPolicyArgumentsBuilder(base.InnerQuery);
        }

        public ConsentPolicyOperationQueryBuilder(IQuery<ConsentPolicy> query) : base(query)
        {
            Arguments = new ConsentPolicyArgumentsBuilder(base.InnerQuery);
        }

        public ConsentPolicyOperationQueryBuilder ConsentRequired()
        {
            base.InnerQuery.AddField("consentRequired");
            return this;
        }

        public ConsentPolicyOperationQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public ConsentPolicyOperationQueryBuilder DataSaleOptOutRequired()
        {
            base.InnerQuery.AddField("dataSaleOptOutRequired");
            return this;
        }

        public ConsentPolicyOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ConsentPolicyOperationQueryBuilder RegionCode()
        {
            base.InnerQuery.AddField("regionCode");
            return this;
        }

        public ConsentPolicyOperationQueryBuilder ShopId()
        {
            base.InnerQuery.AddField("shopId");
            return this;
        }
    }
}