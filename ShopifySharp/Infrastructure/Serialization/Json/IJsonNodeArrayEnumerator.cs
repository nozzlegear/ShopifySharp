using System;
using System.Collections.Generic;

namespace ShopifySharp.Infrastructure.Serialization.Json;

public interface IJsonNodeArrayEnumerator : IEnumerable<IJsonNode>, IDisposable;
