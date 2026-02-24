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
    public sealed class SellingPlanGroupProductVariantsCountQueryBuilder : FieldsQueryBuilderBase<Count, SellingPlanGroupProductVariantsCountQueryBuilder>, IHasArguments<SellingPlanGroupProductVariantsCountArgumentsBuilder>
    {
        public SellingPlanGroupProductVariantsCountArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupProductVariantsCountQueryBuilder Self => this;

        public SellingPlanGroupProductVariantsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new SellingPlanGroupProductVariantsCountArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupProductVariantsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new SellingPlanGroupProductVariantsCountArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupProductVariantsCountQueryBuilder SetArguments(Action<SellingPlanGroupProductVariantsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SellingPlanGroupProductVariantsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public SellingPlanGroupProductVariantsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}