using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public partial class SmartRetryExecutionPolicy
    {
        private class LeakyBucketState
        {
            public int Capacity { get; private set; }
            public int CurrentFillLevel { get; private set; }

            public LeakyBucketState(int capacity, int currentFillLevel)
            {
                this.Capacity = capacity;
                this.CurrentFillLevel = currentFillLevel;
            }
        }
    }
}
