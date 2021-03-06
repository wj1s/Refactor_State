﻿using Xunit;
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

        [Fact]
        public void should_still_to_geared_when_acc_given_the_car_is_geared()
        {
            var car = new Car(State.Geared);
            car.ACC();
            Assert.Equal(State.Geared, car.State);
        }

        [Fact]
        public void should_change_to_ready_when_release_break_given_the_car_is_geared()
        {
            var car = new Car(State.Geared);
            car.ReleaseBreak();
            Assert.Equal(State.Ready, car.State);
        }

        [Fact]
        public void should_change_to_move_forward_when_acc_given_the_car_is_ready()
        {
            var car = new Car(State.Ready);
            car.ACC();
            Assert.Equal(State.MoveForward, car.State);
        }

        [Fact]
        public void should_still_to_move_forward_when_reverse_gear_given_the_car_is_move_forward()
        {
            var car = new Car(State.MoveForward);
            car.ReverseGear();
            Assert.Equal(State.MoveForward, car.State);
        }
    }
}