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
    public sealed class FailedRequirementQueryBuilder : FieldsQueryBuilderBase<FailedRequirement, FailedRequirementQueryBuilder>
    {
        protected override FailedRequirementQueryBuilder Self => this;

        public FailedRequirementQueryBuilder() : this("failedRequirement")
        {
        }

        public FailedRequirementQueryBuilder(string name) : base(new Query<FailedRequirement>(name))
        {
        }

        public FailedRequirementQueryBuilder(IQuery<FailedRequirement> query) : base(query)
        {
        }

        public FailedRequirementQueryBuilder Action(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("action");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        public FailedRequirementQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}