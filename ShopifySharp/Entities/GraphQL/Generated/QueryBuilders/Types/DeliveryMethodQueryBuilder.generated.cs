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
    public sealed class DeliveryMethodQueryBuilder : FieldsQueryBuilderBase<DeliveryMethod, DeliveryMethodQueryBuilder>
    {
        protected override DeliveryMethodQueryBuilder Self => this;

        public DeliveryMethodQueryBuilder() : this("deliveryMethod")
        {
        }

        public DeliveryMethodQueryBuilder(string name) : base(new Query<DeliveryMethod>(name))
        {
        }

        public DeliveryMethodQueryBuilder(IQuery<DeliveryMethod> query) : base(query)
        {
        }

        public DeliveryMethodQueryBuilder AdditionalInformation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryMethodAdditionalInformationQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodAdditionalInformation>("additionalInformation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryMethodAdditionalInformationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodAdditionalInformation>(query);
            return this;
        }

        public DeliveryMethodQueryBuilder BrandedPromise(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryBrandedPromiseQueryBuilder> build)
        {
            var query = new Query<DeliveryBrandedPromise>("brandedPromise");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryBrandedPromiseQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryBrandedPromise>(query);
            return this;
        }

        public DeliveryMethodQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryMethodQueryBuilder MaxDeliveryDateTime()
        {
            base.InnerQuery.AddField("maxDeliveryDateTime");
            return this;
        }

        public DeliveryMethodQueryBuilder MethodType()
        {
            base.InnerQuery.AddField("methodType");
            return this;
        }

        public DeliveryMethodQueryBuilder MinDeliveryDateTime()
        {
            base.InnerQuery.AddField("minDeliveryDateTime");
            return this;
        }

        public DeliveryMethodQueryBuilder PresentedName()
        {
            base.InnerQuery.AddField("presentedName");
            return this;
        }

        public DeliveryMethodQueryBuilder ServiceCode()
        {
            base.InnerQuery.AddField("serviceCode");
            return this;
        }

        public DeliveryMethodQueryBuilder SourceReference()
        {
            base.InnerQuery.AddField("sourceReference");
            return this;
        }
    }
}