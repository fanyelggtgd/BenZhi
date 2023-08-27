using System;

namespace Event {
    public class OrderEventArgs : EventArgs {
        public string DishName { get; set; }
        public string Size { get; set; }
    }
}