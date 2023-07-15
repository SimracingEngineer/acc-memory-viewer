using System.Runtime.InteropServices;

namespace acc
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct StaticSharedMemoryStruct
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string smVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string acVersion;
        public int numberOfSessions;
        public int numCars;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string carModel;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string track;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string playerName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string playerSurname;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string playerNick;
        public int sectorCount;
        public float maxTorque;
        public float maxPower;
        public int maxRpm;
        public float maxFuel;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionMaxTravel;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreRadius;
        public float maxTurboBoost;
        public float deprecated_1;
        public float deprecated_2;
        public int penaltiesEnabled;
        public float aidFuelRate;
        public float aidTireRate;
        public float aidMechanicalDamage;
        public float AllowTyreBlankets;
        public float aidStability;
        public int aidAutoclutch;
        public int aidAutoBlip;
        public int hasDRS;
        public int hasERS;
        public int hasKERS;
        public float kersMaxJ;
        public int engineBrakeSettingsCount;
        public int ersPowerControllerCount;
        public float trackSplineLength;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string trackConfiguration;
        public float ersMaxJ;
        public int isTimedRace;
        public int hasExtraLap;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string carSkin;
        public int reversedGridPositions;
        public int PitWindowStart;
        public int PitWindowEnd;
        public int isOnline;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string dryTyresName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string wetTyresName;
    }
}
