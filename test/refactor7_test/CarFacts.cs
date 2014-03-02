using Xunit;
using state;

namespace state_test
{
    public class CarFacts
    {
        [Fact]
        public void should_still_stop_when_step_on_the_accelerator_given_the_car_is_stop()
        {
            var car = new Car(State.Stop);
            car.ACC();
            Assert.Equal(State.Stop, car.State);
        }
    }
}