﻿namespace MajdataPlay.Types
{
    public enum SensorStatus
    {
        On,
        Off
    }
    public enum SensorType
    {
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        A7,
        A8,
        B1,
        B2,
        B3,
        B4,
        B5,
        B6,
        B7,
        B8,
        C,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        E1,
        E2,
        E3,
        E4,
        E5,
        E6,
        E7,
        E8,
        Test,
        P1,
        Service,
        P2
    }
    public enum SensorGroup
    {
        A,
        B,
        C,
        D,
        E
    }
    public enum JudgeType
    {
        Miss,
        LateGood,
        LateGreat2,
        LateGreat1,
        LateGreat,
        LatePerfect2,
        LatePerfect1,
        Perfect,
        FastPerfect1,
        FastPerfect2,
        FastGreat,
        FastGreat1,
        FastGreat2,
        FastGood
    }
    public enum NoteStatus
    {
        Start,
        Initialized,
        Scaling,
        Running,
        End,
        Destroyed
    }
    public enum ComboState
    {
        None,
        FC,
        FCPlus,
        AP,
        APPlus
    }
    public enum ScoreNoteType
    {
        Tap,
        Hold,
        Slide,
        Break,
        Touch
    }
    public enum ComponentState
    {
        Idle,
        Scanning,
        Loading,
        Parsing,
        Running,
        Backend,
        Calculate,
        Finished,
        Failed,
    }
    public enum ChartLevel
    {
        Easy,
        Basic,
        Advance,
        Expert,
        Master,
        ReMaster,
        UTAGE
    }
    public enum SoundBackendType
    {
        Unity, Wasapi, Asio
    }
    public enum JudgeMode
    {
        Classic,
        Modern
    }
    public enum JudgeDisplayType
    {
        /// <summary>
        /// CriticalPerfect, Perfect, Great, Good
        /// </summary>
        All,
        /// <summary>
        /// Perfect, Great, Good
        /// </summary>
        BelowCP,
        /// <summary>
        /// Great, Good
        /// </summary>
        BelowP,
        /// <summary>
        /// Good
        /// </summary>
        BelowGR,
        /// <summary>
        /// Miss
        /// </summary>
        MissOnly,
        /// <summary>
        /// None
        /// </summary>
        Disable,
    }
    public enum NoteLoaderStatus
    {
        Idle,
        ParsingNote,
        Backend,
        Error,
        Finished
    }
    public enum BGInfoType
    {
        CPCombo,
        PCombo,
        Combo,
        Achievement_101,
        Achievement_100,
        Achievement,
        AchievementClassical,
        AchievementClassical_100,
        DXScore,
        DXScoreRank,
        S_Board,
        SS_Board,
        SSS_Board,
        MyBest,
        Diff,
        None

    }
    public enum RendererStatus
    {
        Off,
        On
    }
    public enum SFXSampleType
    {
        Answer, BGM, Tap, Slide, Break, Touch, Voice
    }
    public enum MajText
    {
        MISSING_MSVC,
        MISSING_MSVC_CONTENT,
        SCANNING_CHART,
        SCAN_CHART_FAILED,
        NO_CHARTS,
        PRESS_ANY_KEY,
        DOWNLOADING,
        UNKNOWN_ERROR,
        DOWNLOAD_CHART_FAILED,
        DOWNLOADING_AUDIO_TRACK,
        DOWNLOADING_CHART,
        DOWNLOADING_PICTURE,
        LOAD_CHART_FAILED,
        DESERIALIZATION,
        LOADING_CHART,
        // Setting UI
        GAME,
        JUDGE,
        DISPLAY,
        AUDIO,
        VOLUME,
        DEBUG,
        ONLINE,
        // GameOptions
        TAP_SPEED,
        TAP_SPEED_DESC,
        TOUCH_SPEED,
        TOUCH_SPEED_DESC,
        SLIDE_FADEIN_OFFSET,
        SLIDE_FADEIN_OFFSET_DESC,
        BACKGROUND_DIM,
        BACKGROUND_DIM_DESC,
        STAR_ROTATION,
        STAR_ROTATION_DESC,
        LANGUAGE,
        LANGUAGE_DESC,
        BGINFO,
        BGINFO_DESC,
        // JudgeOptions
        AUDIO_OFFSET,
        AUDIO_OFFSET_DESC,
        JUDGE_OFFSET,
        JUDGE_OFFSET_DESC,
        MODE,
        MODE_DESC,
        //DisplayOptions
        NOTE_SKIN,
        NOTE_SKIN_DESC,
        DISPLAY_CRITICAL_PERFECT,
        DISPLAY_CRITICAL_PERFECT_DESC,
        DISPLAY_BREAK_SCORE,
        DISPLAY_BREAK_SCORE_DESC,
        FAST_LATE_TYPE,
        FAST_LATE_TYPE_DESC,
        NOTE_JUDGE_TYPE,
        NOTE_JUDGE_TYPE_DESC,
        TOUCH_JUDGE_TYPE,
        TOUCH_JUDGE_TYPE_DESC,
        SLIDE_JUDGE_TYPE,
        SLIDE_JUDGE_TYPE_DESC,
        BREAK_JUDGE_TYPE,
        BREAK_JUDGE_TYPE_DESC,
        BREAK_FAST_LATE_TYPE,
        BREAK_FAST_LATE_TYPE_DESC,
        SLIDE_SORT_ORDER,
        SLIDE_SORT_ORDER_DESC,
        OUTER_JUDGE_DISTANCE,
        OUTER_JUDGE_DISTANCE_DESC,
        INNER_JUDGE_DISTANCE,
        INNER_JUDGE_DISTANCE_DESC,
        RESOLUTION,
        RESOLUTION_DESC,
        // SoundOptions
        ANSWER_VOL,
        ANSWER_VOL_DESC,
        BGM_VOL,
        BGM_VOL_DESC,
        TAP_VOL,
        TAP_VOL_DESC,
        SLIDE_VOL,
        SLIDE_VOL_DESC,
        BREAK_VOL,
        BREAK_VOL_DESC,
        TOUCH_VOL,
        TOUCH_VOL_DESC,
        VOICE_VOL,
        VOICE_VOL_DESC,
        // DebugOptions
        DISPLAY_SENSOR,
        DISPLAY_SENSOR_DESC,
        DISPLAY_FPS,
        DISPLAY_FPS_DESC,
        FULLSCREEN,
        FULLSCREEN_DESC,
        TRY_FIX_AUDIO_SYNC,
        TRY_FIX_AUDIO_SYNC_DESC,
        NOTE_APPEAR_RATE,
        NOTE_APPEAR_RATE_DESC,
        DISABLE_GC_IN_GAMING,
        DISABLE_GC_IN_GAMING_DESC,
        // Undefined
        OTHER_MAJTEXT,
        UNAVAILABLE
    }
    public enum SortType
    {
        Default = 4, 
        ByTime = 0, 
        ByDiff = 1, 
        ByDes = 2, 
        ByTitle = 3
    }
    public enum CoverListMode
    {
        Directory,
        Chart
    }
    public enum DeviceType
    {
        Keyboard,
        HID,
        IO4
    }
}
