using System;

namespace OrderPipeline2    // VERY IMPORTANT: match your project name
{
    public class ShipEventArgs : EventArgs
    {
        public string Product { get; private set; }
        public bool Express { get; private set; }

        public ShipEventArgs(string product, bool express)
        {
            Product = product;
            Express = express;
        }
    }
}
