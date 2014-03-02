##使用的例子：
* 车在停止状态   - 踩油 -> 停止状态
* 车在停止状态   - 挂挡 -> 档位就绪
* 档位就绪 -踩油-> 档位就绪
* 档位就绪 -松手刹-> 就绪
* 就绪 -踩油-> 前进
* 前进 -挂倒挡-> 前进




Refactor ACC Fun:

1. Change ACC to:  

        public void ACC()
        {
            var result = State;
            if (State == State.Ready)
            {
                result = State.MoveForward;
            }
            State = result;
        }
        
2. Extract TransformWhenCarACC method in ACC  
        
        public void ACC()
        {
            State = TransformWhenCarACC();
        }

3. Introduce State to param.  
4. change State from enum to class.  

        public class State
        {
            public static State Stop = new State();
            public static State Geared = new State();
            public static State Ready = new State();
            public static State MoveForward = new State();
        }
    
5. make static and non-static move TransformWhenCarACC to State  
    
        public class State
        {
            public static State Stop = new State();
            public static State Geared = new State();
            public static State Ready = new State();
            public static State MoveForward = new State();
        
            public State TransformWhenCarACC()
            {
                var result = this;
                if (this == State.Ready)
                {
                    result = State.MoveForward;
                }
                return result;
            }
        }
    
6. change ever State to new subClass() and alt+enter to create the subclass  

        public class State
        {
            public static State Stop = new StopState();
            public static State Geared = new GearedState();
            public static State Ready = new ReadyState();
            public static State MoveForward = new MoveForwardState();
        
            public State TransformWhenCarACC()
            {
                var result = this;
                if (this == State.Ready)
                {
                    result = State.MoveForward;
                }
                return result;
            }
        }

7.Push Method TransformWhenCarACC Down to every subClass and clean every subClass  

        public class ReadyState : State
        {
            public override State TransformWhenCarACC()
            {
                return MoveForward;
            }
        }

        public class StopState : State
            {
                public override State TransformWhenCarACC()
                {
                    return this;
                }
            }
        }
