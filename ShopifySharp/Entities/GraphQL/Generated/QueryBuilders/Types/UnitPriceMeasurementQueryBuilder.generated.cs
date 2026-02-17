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
    public sealed class UnitPriceMeasurementQueryBuilder : FieldsQueryBuilderBase<UnitPriceMeasurement, UnitPriceMeasurementQueryBuilder>
    {
        protected override UnitPriceMeasurementQueryBuilder Self => this;

        public UnitPriceMeasurementQueryBuilder() : this("unitPriceMeasurement")
        {
        }

        public UnitPriceMeasurementQueryBuilder(string name) : base(new Query<UnitPriceMeasurement>(name))
        {
        }

        public UnitPriceMeasurementQueryBuilder(IQuery<UnitPriceMeasurement> query) : base(query)
        {
        }

        public UnitPriceMeasurementQueryBuilder MeasuredType()
        {
            base.InnerQuery.AddField("measuredType");
            return this;
        }

        public UnitPriceMeasurementQueryBuilder QuantityUnit()
        {
            base.InnerQuery.AddField("quantityUnit");
            return this;
        }

        public UnitPriceMeasurementQueryBuilder QuantityValue()
        {
            base.InnerQuery.AddField("quantityValue");
            return this;
        }

        public UnitPriceMeasurementQueryBuilder ReferenceUnit()
        {
            base.InnerQuery.AddField("referenceUnit");
            return this;
        }

        public UnitPriceMeasurementQueryBuilder ReferenceValue()
        {
            base.InnerQuery.AddField("referenceValue");
            return this;
        }
    }
}