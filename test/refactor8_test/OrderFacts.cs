using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using refactor8;

namespace refactor8_test
{
    public class OrderFacts
    {
        [Fact]
        public void should_get_name()
        {
            IEnumerable<Order> orders = new List<Order>
                {
                    new Order("1"),
                    new Order("2")
                };
            Assert.Equal(1, NumberOfOrdersFor(orders, "1"));
        }

        public static int NumberOfOrdersFor(IEnumerable<Order> orders, string customer)
        {
            return orders.Count(o => o.Customer == customer);
        }
    }
}
