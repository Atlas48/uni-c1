using System;

namespace GShare
{
     
    public enum Type {
        flot,
        slow,
        speed,
        bounce,
        jump,
        heavy,
        big,
        small

    }
    public enum KeyColorType {
        red,
        green,
        blue,
        yellow,
        black,
        white,
        grey,
        cyan
    }
    /*[System.Flags]
    enum Colliding : byte
    {
        up = 1,
        left = 2,
        down = 4,
        right = 8
    }*/
    public enum Direction
    {
        up,
        right,
        left,
        down
    }
    public static class Converter {
        public static int b2i(bool b) {
            return b ? 1 : 0;
        }
    }
    public static class PowState {
        public static string Convert(Type en) {
            switch (en) {
                case Type.flot: return "flot";
                case Type.slow: return "slow";
                case Type.speed: return "speed";
                case Type.bounce: return "bounce";
                case Type.jump: return "jump";
                case Type.heavy: return "heavy";
                case Type.big: return "big";
                case Type.small: return "small";
                default: return "unknown";
            }
        }
    }
}