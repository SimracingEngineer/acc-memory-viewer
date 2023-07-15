using System.Runtime.InteropServices;

namespace acc
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct GraphicsSharedMemoryStruct
    {
        public int packetId;
        public ACC_STATUS status;
        public ACC_SESSION_TYPE session;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string currentTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string lastTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string bestTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string split;
        public int completedLaps;
        public int position;
        public int iCurrentTime;
        public int iLastTime;
        public int iBestTime;
        public float sessionTimeLeft;
        public float distanceTraveled;
        public int isInPit;
        public int currentSectorIndex;
        public int lastSectorTime;
        public int numberOfLaps;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string tyreCompound;
        public float replayTimeMultiplier;
        public float normalizedCarPosition;
        public int activeCars;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60 * 3)]
        public float[] carCoordinates; // Flat array
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] carID;
        public int playerCarID;
        public float penaltyTime;
        public ACC_FLAG_TYPE flag;
        public ACC_PENALTY_TYPE penalty;
        public int idealLineOn;
        public int isInPitLane;
        public float surfaceGrip;
        public int mandatoryPitDone;
        public float windSpeed;
        public float windDirection;
        public int isSetupMenuVisible;
        public int mainDisplayIndex;
        public int secondaryDisplyIndex;
        public int TC;
        public int TCCUT;
        public int EngineMap;
        public int ABS;
        public float fuelXLap;
        public int rainLights;
        public int flashingLights;
        public int lightsStage;
        public float exhaustTemperature;
        public int wiperLV;
        public int driverStintTotalTimeLeft;
        public int driverStintTimeLeft;
        public int rainTyres;
        public int sessionIndex;
        public float usedFuel;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string deltaLapTime;
        public int iDeltaLapTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string estimatedLapTime;
        public int iEstimatedLapTime;
        public int isDeltaPositive;
        public int iSplit;
        public int isValidLap;
        public float fuelEstimatedLaps;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string trackStatus;
        public int missingMandatoryPits;
        public float Clock;
        public int directionLightsLeft;
        public int directionLightsRight;
        public int GlobalYellow;
        public int GlobalYellow1;
        public int GlobalYellow2;
        public int GlobalYellow3;
        public int GlobalWhite;
        public int GlobalGreen;
        public int GlobalChequered;
        public int GlobalRed;
        public int mfdTyreSet;
        public float mfdFuelToAdd;
        public float mfdTyrePressureLF;
        public float mfdTyrePressureRF;
        public float mfdTyrePressureLR;
        public float mfdTyrePressureRR;
        public ACC_TRACK_GRIP_STATUS trackGripStatus;
        public ACC_RAIN_INTENSITY rainIntensity;
        public ACC_RAIN_INTENSITY rainIntensityIn10min;
        public ACC_RAIN_INTENSITY rainIntensityIn30min;
        public int currentTyreSet;
        public int strategyTyreSet;
        public int gapAhead;
        public int gapBehind;
    }
}
