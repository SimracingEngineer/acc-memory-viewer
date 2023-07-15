using System.Runtime.InteropServices;

namespace acc
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct PhysicsSharedMemoryStruct
    {
        public int packetId;
        public float gas;
        public float brake;
        public float fuel;
        public int gear;
        public int rpm;
        public float steerAngle;
        public float speedKmh;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] velocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] accG;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelSlip;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelLoad;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelPressure;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelAngularSpeed;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreWear;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreDirtyLevel;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreCoreTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] camberRAD;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionTravel;
        public float drs;
        public float tc;
        public float heading;
        public float pitch;
        public float roll;
        public float cgHeight;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] carDamage;
        public int numberOfTyresOut;
        public int pitLimiterOn;
        public float abs;
        public float kersCharge;
        public float kersInput;
        public int autoshifterOn;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] rideHeight;
        public float turboBoost;
        public float ballast;
        public float airDensity;
        public float airTemp;
        public float roadTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] localAngularVel;
        public float finalFF;
        public float performanceMeter;
        public int engineBrake;
        public int ersRecoveryLevel;
        public int ersPowerLevel;
        public int ersHeatCharging;
        public int ersIsCharging;
        public float kersCurrentKJ;
        public int drsAvailable;
        public int drsEnabled;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] brakeTemp;
        public float clutch;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreTempI;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreTempM;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreTempO;
        public int isAIControlled;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4 * 3)]
        public float[] tyreContactPoint; // Flat array
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4 * 3)]
        public float[] tyreContactNormal; // Flat array
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4 * 3)]
        public float[] tyreContactHeading; // Flat array
        public float brakeBias;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] localVelocity;
        public int P2PActivation;
        public int P2PStatus;
        public float currentMaxRpm;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mz;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] fx;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] fy;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] slipRatio;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] slipAngle;
        public int tcinAction;
        public int absInAction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionDamage;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreTemp;
        public float waterTemp;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] brakePressure;
        public int frontBrakeCompound;
        public int rearBrakeCompound;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] padLife;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] discLife;
        public int ignitionOn;
        public int starterEngineOn;
        public int isEngineRunning;
        public float kerbVibration;
        public float slipVibrations;
        public float gVibrations;
        public float absVibrations;
    }
}
