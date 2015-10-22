using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonteCarloSimulationLib {
    public class MonteCarloSimulator {

        public const byte SUIT_S = 0x01;
        public const byte SUIT_H = 0x02;
        public const byte SUIT_C = 0x03;
        public const byte SUIT_D = 0x04;

        public const byte NUM_2 = 0x01;
        public const byte NUM_3 = 0x02;
        public const byte NUM_4 = 0x03;
        public const byte NUM_5 = 0x04;
        public const byte NUM_6 = 0x05;
        public const byte NUM_7 = 0x06;
        public const byte NUM_8 = 0x07;
        public const byte NUM_9 = 0x08;
        public const byte NUM_T = 0x09;
        public const byte NUM_J = 0x010;
        public const byte NUM_Q = 0x011;
        public const byte NUM_K = 0x012;
        public const byte NUM_A = 0x013;

        public static double Simulate(byte[] myCards, List<Dictionary<string, double>> enemyHoleCardPos){
            // TO IMPLEMENT
            return 0;
        }

        public static byte[] ShuffleHoleCard(Dictionary<string, double> holeCardPos) {
            return null;
        }

        // true:win, false:loose
        public static bool SimulateOnce(int[] myHoleCards, List<byte[]> enemyHoleCards) {
            return false;
        }
    }
}
