using Xunit;
using state;

namespace state_test
{
    public class CarStateFacts
    {
        [Fact]
        public void should_still_stop_when_step_on_the_accelerator_given_the_car_is_stop()
        {
            var car = new Car(State.Stop);
            car.ACC();
            Assert.Equal(State.Stop, car.State);
        }

        [Fact]
        public void should_change_to_geared_when_gear_given_the_car_is_stop()
        {
            var car = new Car(State.Stop);
            car.Gear();
            Assert.Equal(State.Geared, car.State);
        }
    }
}