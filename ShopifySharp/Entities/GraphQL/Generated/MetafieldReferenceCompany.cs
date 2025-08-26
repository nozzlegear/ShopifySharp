#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

internal record MetafieldReferenceCompany(Company Value) : MetafieldReference;