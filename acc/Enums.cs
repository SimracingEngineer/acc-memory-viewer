namespace acc
{
    public enum ACC_STATUS
    {
        ACC_OFF = 0,
        ACC_REPLAY = 1,
        ACC_LIVE = 2,
        ACC_PAUSE = 3
    }

    public enum ACC_SESSION_TYPE
    {
        ACC_UNKNOWN = -1,
        ACC_PRACTICE = 0,
        ACC_QUALIFY = 1,
        ACC_RACE = 2,
        ACC_HOTLAP = 3,
        ACC_TIMEATTACK = 4,
        ACC_DRIFT = 5,
        ACC_DRAG = 6,
        ACC_HOTSTINT = 7,
        ACC_HOTSTINTSUPERPOLE = 8
    }

    public enum ACC_FLAG_TYPE
    {
        ACC_NO_FLAG = 0,
        ACC_BLUE_FLAG = 1,
        ACC_YELLOW_FLAG = 2,
        ACC_BLACK_FLAG = 3,
        ACC_WHITE_FLAG = 4,
        ACC_CHECKERED_FLAG = 5,
        ACC_PENALTY_FLAG = 6,
        ACC_GREEN_FLAG = 7,
        ACC_ORANGE_FLAG = 8
    }

    public enum ACC_PENALTY_TYPE
    {
        ACC_None = 0,
        ACC_DriveThrough_Cutting = 1,
        ACC_StopAndGo_10_Cutting = 2,
        ACC_StopAndGo_20_Cutting = 3,
        ACC_StopAndGo_30_Cutting = 4,
        ACC_Disqualified_Cutting = 5,
        ACC_RemoveBestLaptime_Cutting = 6,
        ACC_DriveThrough_PitSpeeding = 7,
        ACC_StopAndGo_10_PitSpeeding = 8,
        ACC_StopAndGo_20_PitSpeeding = 9,
        ACC_StopAndGo_30_PitSpeeding = 10,
        ACC_Disqualified_PitSpeeding = 11,
        ACC_RemoveBestLaptime_PitSpeeding = 12,
        ACC_Disqualified_IgnoredMandatoryPit = 13,
        ACC_PostRaceTime = 14,
        ACC_Disqualified_Trolling = 15,
        ACC_Disqualified_PitEntry = 16,
        ACC_Disqualified_PitExit = 17,
        ACC_Disqualified_Wrongway = 18,
        ACC_DriveThrough_IgnoredDriverStint = 19,
        ACC_Disqualified_IgnoredDriverStint = 20,
        ACC_Disqualified_ExceededDriverStintLimit = 21
    }

    public enum ACC_TRACK_GRIP_STATUS
    {
        ACC_GREEN = 0,
        ACC_FAST = 1,
        ACC_OPTIMUM = 2,
        ACC_GREASY = 3,
        ACC_DAMP = 4,
        ACC_WET = 5,
        ACC_FLOODED = 6
    }

    public enum ACC_RAIN_INTENSITY
    {
        ACC_NO_RAIN = 0,
        ACC_DRIZZLE = 1,
        ACC_LIGHT_RAIN = 2,
        ACC_MEDIUM_RAIN = 3,
        ACC_HEAVY_RAIN = 4,
        ACC_THUNDERSTORM = 5
    }
}
