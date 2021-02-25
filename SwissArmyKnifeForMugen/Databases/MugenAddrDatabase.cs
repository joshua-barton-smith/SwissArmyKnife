﻿// Decompiled with JetBrains decompiler
// Type: SwissArmyKnifeForMugen.MugenAddrDatabase
// Assembly: SAKnifeWM, Version=1.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 09478AD8-365C-4BF3-BEA1-B5785151259B
// Assembly location: C:\Users\ziddi\Downloads\Swiss Army Knife 1.1 Conversion\Swiss Army Knife 1.1 Conversion\SAKnifeWM.exe

namespace SwissArmyKnifeForMugen.Databases
{
    /// <summary>
    /// Contains addresses and offsets for a particular MUGEN version.
    /// </summary>
    public class MugenAddrDatabase
    {
        /// <summary>
        /// WinMUGEN database instance.
        /// </summary>
        private static MugenAddrDatabase _default_db;
        /// <summary>
        /// Mugen 1.0 database instance.
        /// </summary>
        private static Mugen10DB _mugen10_db;
        /// <summary>
        /// Mugen 1.1a4 database instance.
        /// </summary>
        private static Mugen11A4DB _mugen11a4_db;
        /// <summary>
        /// Mugen 1.1b1 database instance.
        /// </summary>
        private static Mugen11B1DB _mugen11b1_db;

        /* Global Offsets -- relative to nothing */
        /// <summary>
        /// determines whether to use the new Debug color offsets
        /// <para>
        /// false=overwrite the values MUGEN stores in memory<br/>
        /// true=patch MUGEN code to overwrite hardcoded color arguments
        /// </para>
        /// </summary>
        public bool USE_NEW_DEBUG_COLOR_ADDR = false;
        /// <summary>
        /// list of offsets in MUGEN code which comprise debug color offsets
        /// </summary>
        public uint[] NEW_DEBUG_COLOR_OFFSETS = null;
        /// <summary>
        /// debug colors for the StateNo line are structured differently, so need a separated list.
        /// </summary>
        public uint[] NEW_DEBUG_COLOR_SN_OFFSETS = null;
        /// <summary>
        /// Game structure base offset.
        /// </summary>
        public uint MUGEN_POINTER_BASE_OFFSET = 0x4B5B4C;
        /// <summary>
        /// Location of the Pause flag.
        /// </summary>
        public uint PAUSE_ADDR = 0x4B6A81;
        /// <summary>
        /// Pointer to the current index in the keyboard input buffer.
        /// </summary>
        public uint CMD_CURRENT_INDEX_ADDR = 0x4B5948;
        /// <summary>
        /// Pointer to the current index in the keyboard input buffer.
        /// </summary>
        public uint CMD_NEXT_INDEX_ADDR = 0x4B594C;
        ///  <summary> 
        ///  Location of the keyboard input buffer. 
        ///  </summary> 
        public uint CMD_KEY_ADDR = 0x4B5548;

        /* Game Offsets - relative to MUGEN_POINTER_BASE_OFFSET */
        /// <summary>
        /// Demo mode flag.
        /// </summary>
        public uint DEMO_BASE_OFFSET = 0xBB8C;
        /// <summary>
        /// Mugen active flag.
        /// </summary>
        public uint MUGEN_ACTIVE_BASE_OFFSET = 0xBB88;
        /// <summary>
        /// High-speed/uncapped FPS mode flag.
        /// </summary>
        public uint SPEED_MODE_BASE_OFFSET = 0xC934;
        /// <summary>
        /// Skip mode flag (for frameskip).
        /// </summary>
        public uint SKIP_MODE_BASE_OFFSET = 0xB400;
        /// <summary>
        /// Debug mode flag (for bottom-left debug text).
        /// </summary>
        public uint DEBUG_MODE_BASE_OFFSET = 0xC520;
        /// <summary>
        /// Offset to int identifying the target for displayed debug text.
        /// </summary>
        public uint DEBUG_TARGET_BASE_OFFSET = 0xC518;
        /// <summary>
        /// Current gametime for match.
        /// </summary>
        public uint GAMETIME_BASE_OFFSET = 0xB3FC;
        /// <summary>
        /// Width of the screen.
        /// </summary>
        public uint SCREEN_X_BASE_OFFSET = 0xB428;
        /// <summary>
        /// Height of the screen.
        /// </summary>
        public uint SCREEN_Y_BASE_OFFSET = 0xB434;
        /// <summary>
        /// Current value of RoundState.
        /// </summary>
        public uint ROUND_STATE_BASE_OFFSET = 0xBC30;
        /// <summary>
        /// Current value of RoundNo.
        /// </summary>
        public uint ROUND_NO_BASE_OFFSET = 0xBC04;
        /// <summary>
        /// Total time spent in current round.
        /// </summary>
        public uint ROUND_TIME_BASE_OFFSET = 0xBC40;
        /// <summary>
        /// TODO
        /// </summary>
        public uint ROUND_NO_OF_MATCH_TIME_BASE_OFFSET = 0x5BF8;
        /// <summary>
        /// Turns mode flag.
        /// </summary>
        public uint TURNS_MODE_BASE_OFFSET = 0x5BFC;
        /// <summary>
        /// Stores an int showing which TeamSide won the current round.
        /// </summary>
        public uint TEAM_WIN_BASE_OFFSET = 0xBC34;
        /// <summary>
        /// Flag indicating the round was won by KO (rather than Judgement/timeout).
        /// </summary>
        public uint TEAM_WIN_KO_BASE_OFFSET = 0xBC38;
        /// <summary>
        /// Number of rounds team 1 has won.
        /// </summary>
        public uint TEAM_1_WIN_COUNT_BASE_OFFSET = 0xBC08;
        /// <summary>
        /// Number of rounds team 2 has won.
        /// </summary>
        public uint TEAM_2_WIN_COUNT_BASE_OFFSET = 0xBC0C;
        /// <summary>
        /// Number of drawn rounds.
        /// </summary>
        public uint DRAW_GAME_COUNT_BASE_OFFSET = 0xBC14;
        /// <summary>
        /// Offset to the player list (technically location of player 1's base address).
        /// </summary>
        public uint PLAYER_1_BASE_OFFSET = 0xB754;
        /// <summary>
        /// Offset to the explod list pointer.
        /// </summary>
        public uint EXPLOD_LIST_BASE_OFFSET = 0xA2E4;
        /// <summary>
        /// Location of the display timer for WinMUGEN debug text color.
        /// <br/>Only used if <c>USE_NEW_DEBUG_COLOR_ADDR</c> is false.
        /// </summary>
        public uint PAL_TIME_BASE_OFFSET = 0xB180;
        /// <summary>
        /// TODO: has to do with WinMUGEN debug text color.
        /// <br/>Only used if <c>USE_NEW_DEBUG_COLOR_ADDR</c> is false.
        /// </summary>
        public uint PAL_GRAY_BASE_OFFSET = 0xB184;
        /// <summary>
        /// Location of the red value for WinMUGEN debug text color.
        /// <br/>Only used if <c>USE_NEW_DEBUG_COLOR_ADDR</c> is false.
        /// </summary>
        public uint PAL_R_BASE_OFFSET = 0xB188;
        /// <summary>
        /// Location of the green value for WinMUGEN debug text color.
        /// <br/>Only used if <c>USE_NEW_DEBUG_COLOR_ADDR</c> is false.
        /// </summary>
        public uint PAL_G_BASE_OFFSET = 0xB18C;
        /// <summary>
        /// Location of the green value for WinMUGEN debug text color.
        /// <br/>Only used if <c>USE_NEW_DEBUG_COLOR_ADDR</c> is false.
        /// </summary>
        public uint PAL_B_BASE_OFFSET = 0xB190;
        /// <summary>
        /// Current amount of global PauseTime.
        /// </summary>
        public uint PAUSE_TIME_BASE_OFFSET = 0xBBD4;
        /// <summary>
        /// Current amount of global SuperPauseTime.
        /// </summary>
        public uint SUPER_PAUSE_TIME_BASER_OFFSET = 0xBBF8;
        /// <summary>
        /// Offset to the Global AssertSpecial flags.
        /// </summary>
        public uint ASSERT_1_PLAYER_OFFSET = 0xBB78;
        /// <summary>
        /// X-position of the camera relative to its origin (1.0+)
        /// </summary>
        public uint CAMERAPOS_X_BASE_OFFSET;
        /// <summary>
        /// Y-position of the camera relative to its origin (1.0+)
        /// </summary>
        public uint CAMERAPOS_Y_BASE_OFFSET;

        /* Explod Offsets - relative to EXPLOD_LIST_BASE_OFFSET */
        /// <summary>
        /// Length of each entry in the Explod list (offset to each new Explod in the list).
        /// </summary>
        public uint OFFSET_EXPLOD_LIST_OFFSET = 0xE4;
        /// <summary>
        /// Pointer to the animation in use for an Explod (for data lookup).
        /// </summary>
        public uint ANIM_ADDR_EXPLOD_OFFSET = 0x80;
        /// <summary>
        /// Index of the animation in use, relative to <c>ANIM_ADDR_EXPLOD_OFFSET</c>.
        /// </summary>
        public uint ANIM_INDEX_EXPLOD_OFFSET = 0xC;
        /// <summary>
        /// Offset to the Explod ID.
        /// </summary>
        public uint EXPLOD_ID_EXPLOD_OFFSET = 0x10;
        /// <summary>
        /// Offset to the Explod's Owner ID.
        /// </summary>
        public uint EXPLOD_OWNER_ID_EXPLOD_OFFSET = 0xC;
        /// <summary>
        /// Indicates whether an explod exists or if this list entry is deleted.
        /// </summary>
        public uint EXIST_EXPLOD_OFFSET;

        /* Projectile Metadata Offsets - relative to PROJ_BASE_PLAYER_OFFSET */
        /// <summary>
        /// Offset to the list of Projectiles.
        /// </summary>
        public uint PROJ_LIST_PROJ_BASE_OFFSET = 0x14;
        /// <summary>
        /// Offset to the max number of Projectiles (global).
        /// </summary>
        public uint PROJ_MAX_PROJ_BASE_OFFSET = 0x28;

        /* Projectile Offsets - relative to PROJ_LIST_PROJ_BASE_OFFSET */
        /// <summary>
        /// Length of each entry in the Projectile list (offset to each new Projectile in the list).
        /// </summary>
        public uint OFFSET_PROJ_LIST_OFFSET = 0x2DC;
        /// <summary>
        /// Flag showing if a Projectile exists (as entries in the list can become 'dead').
        /// </summary>
        public uint EXIST_PROJ_OFFSET = 0x4;
        /// <summary>
        /// X-pos of the Projectile.
        /// </summary>
        public uint PROJ_X_PROJ_OFFSET = 0x5C;
        /// <summary>
        /// Y-pos of the Projectile.
        /// </summary>
        public uint PROJ_Y_PROJ_OFFSET = 0x60;
        /// <summary>
        /// Offset to the ProjID.
        /// </summary>
        public uint PROJ_ID_PROJ_OFFSET;


        /* Player Offsets - relative to PLAYER_1_BASE_OFFSET */
        /// <summary>
        /// Flag indicating if a player exists (used for e.g. unfilled Helper slots).
        /// </summary>
        public uint EXIST_PLAYER_OFFSET = 0x158;
        /// <summary>
        /// Offset to unique PlayerID.
        /// </summary>
        public uint PLAYER_ID_PLAYER_OFFSET = 0x4;
        /// <summary>
        /// Offset to HelperID.
        /// </summary>
        public uint HELPER_ID_PLAYER_OFFSET = 0x2618;
        /// <summary>
        /// Offset to parent's PlayerID value.
        /// </summary>
        public uint PARENT_ID_PLAYER_OFFSET = 0x261C;
        /// <summary>
        /// Offset to this player's Projectile list.
        /// </summary>
        public uint PROJ_BASE_PLAYER_OFFSET = 0x21C;
        /// <summary>
        /// Offset to a PlayerID showing the current state owner (for custom states).
        /// </summary>
        public uint STATE_OWNER_PLAYER_OFFSET = 0xBF0;
        /// <summary>
        /// Offset to the StateNo value.
        /// </summary>
        public uint STATE_NO_PLAYER_OFFSET = 0xBF4;
        /// <summary>
        /// Offset to the PrevStateNo value.
        /// </summary>
        public uint PREV_STATE_NO_PLAYER_OFFSET = 0xBF8;
        /// <summary>
        /// Offset to the PalNo value.
        /// </summary>
        public uint PALNO_PLAYER_OFFSET = 0x13C4;
        /// <summary>
        /// Offset to the Alive value.
        /// </summary>
        public uint ALIVE_PLAYER_OFFSET = 0xE24;
        /// <summary>
        /// Offset to the current Life value.
        /// </summary>
        public uint LIFE_PLAYER_OFFSET = 0x160;
        /// <summary>
        /// Offset to the current Power value.
        /// </summary>
        public uint POWER_PLAYER_OFFSET = 0x178;
        /// <summary>
        /// Offset to the Damage value (i.e. GetHitVar(damage)).
        /// </summary>
        public uint DAMAGE_PLAYER_OFFSET = 0x1028;
        /// <summary>
        /// Offset to the Ctrl value.
        /// </summary>
        public uint CTRL_PLAYER_OFFSET = 0xE0C;
        /// <summary>
        /// Offset to the StateType value (represented by an int).
        /// </summary>
        public uint STATE_TYPE_PLAYER_OFFSET = 0xE00;
        /// <summary>
        /// Offset to the MoveType value (represented by an int).
        /// </summary>
        public uint MOVE_TYPE_PLAYER_OFFSET = 0xE04;
        /// <summary>
        /// Offset to the HitPauseTime value.
        /// </summary>
        public uint HIT_PAUSE_TIME_PLAYER_OFFSET = 0xE18;
        /// <summary>
        /// Offset to the MoveContact value.
        /// </summary>
        public uint MOVE_CONTACT_PLAYER_OFFSET = 0xE30;
        /// <summary>
        /// Offset to the MoveHit value.
        /// </summary>
        public uint MOVE_HIT_PLAYER_OFFSET = 0xE34;
        /// <summary>
        /// Pointer to the animation data block.
        /// </summary>
        public uint ANIM_ADDR_PLAYER_OFFSET = 0x13BC;
        /// <summary>
        /// Flag indicating if the player is unhittable (ex due to Throw immunity).
        /// </summary>
        public uint MUTEKI_PLAYER_OFFSET = 0xFF8;
        /// <summary>
        /// Offset to the HitBy value1 enum (represented as an int).
        /// </summary>
        public uint HITBY_1_PLAYER_OFFSET = 0xFFC;
        /// <summary>
        /// Offset to the HitBy value2 enum (represented as an int).
        /// </summary>
        public uint HITBY_2_PLAYER_OFFSET = 0x1000;
        /// <summary>
        /// Pointer to the list of active HitOverrides.
        /// </summary>
        public uint HITOVERRIDE_LIST_PLAYER_OFFSET = 0x10A8;
        /// <summary>
        /// Offset to the Target structure.
        /// </summary>
        public uint TARGET_ENTRY_PLAYER_OFFSET = 0x220;
        /// <summary>
        /// Offset to the Fall Damage value (i.e. GetHitVar(fall.damage)).
        /// </summary>
        public uint FALL_DAMAGE_PLAYER_OFFSET = 0x1074;
        /// <summary>
        /// Offset to the Facing flag.
        /// </summary>
        public uint FACING_PLAYER_OFFSET = 0x190;
        /// <summary>
        /// Offset to the Pos x value (represented as stage co-ords).
        /// </summary>
        public uint POS_X_PLAYER_OFFSET = 0x19C;
        /// <summary>
        /// Offset to the Pos y value (represented as stage co-ords).
        /// </summary>
        public uint POS_Y_PLAYER_OFFSET = 0x1A0;
        /// <summary>
        /// X-position of the player within the overall stage bounds. (1.0+)
        /// </summary>
        public uint STAGEPOS_X_PLAYER_OFFSET;
        /// <summary>
        /// Y-position of the player within the overall stage bounds. (1.0+)
        /// </summary>
        public uint STAGEPOS_Y_PLAYER_OFFSET;
        /// <summary>
        /// Offset to the Vel x value (before LocalCoord conversion).
        /// </summary>
        public uint VEL_X_PLAYER_OFFSET = 0x1B4;
        /// <summary>
        /// Offset to the Vel y value (before LocalCoord conversion).
        /// </summary>
        public uint VEL_Y_PLAYER_OFFSET = 0x1B8;
        /// <summary>
        /// Offset to sysvar(0) - start of sysvar list.
        /// </summary>
        public uint SYS_VAR_PLAYER_OFFSET = 0xFD0;
        /// <summary>
        /// Offset to sysfvar(0) - start of sysfvar list.
        /// </summary>
        public uint SYS_FVAR_PLAYER_OFFSET = 0xFE4;
        /// <summary>
        /// Offset to var(0) - start of var list.
        /// </summary>
        public uint VAR_PLAYER_OFFSET = 0xE40;
        /// <summary>
        /// Offset to fvar(0) - start of fvar list.
        /// </summary>
        public uint FVAR_PLAYER_OFFSET = 0xF30;
        /// <summary>
        /// TODO
        /// </summary>
        public uint ACTIVE_PLAYER_OFFSET = 0xBA68;
        /// <summary>
        /// Offset to the Player AssertSpecial flags.
        /// </summary>
        public uint SELF_ASSERT_PLAYER_OFFSET;
        /// <summary>
        /// Offset to the PauseMoveTime granted to the Player.
        /// </summary>
        public uint PAUSE_MOVE_TIME_PLAYER_OFFSET = 0x1DC;
        /// <summary>
        /// Offset to the SuperPauseMoveTime granted to the Player.
        /// </summary>
        public uint SUPER_PAUSE_MOVE_TIME_PLAYER_OFFSET = 0x1E0;
        /// <summary>
        /// Offset to the AttackMulSet multiplier.
        /// </summary>
        public uint ATTACK_MUL_SET_PLAYER_OFFSET = 0x188;

        /* Player Info Offsets - relative to the pointer at the first byte of [PLAYER_1_BASE_OFFSET]. */
        /// <summary>
        /// Offset to the DisplayName string from the player info block.
        /// </summary>
        public uint DISPLAY_NAME_PLAYER_INFO_OFFSET = 0x30;
        /// <summary>
        /// Offset to the first anim list pointer, relative to the player info block.
        /// </summary>
        public uint ANIM_LIST_REF1_PLAYER_INFO_OFFSET = 0x3CC;
        /// <summary>
        /// Offset to the second anim list pointer, relative to <c>ANIM_LIST_REF1_PLAYER_INFO_OFFSET</c>.
        /// </summary>
        public uint ANIM_LIST_REF2_PLAYER_INFO_OFFSET;
        /// <summary>
        /// Offset to the third anim list pointer, relative to <c>ANIM_LIST_REF2_PLAYER_INFO_OFFSET</c>.
        /// </summary>
        public uint ANIM_LIST_REF3_PLAYER_INFO_OFFSET = 0x18;
        /// <summary>
        /// Offset to the LocalCoord X-value.
        /// <br/>Does not exist in WinMUGEN.
        /// </summary>
        public uint LOCALCOORD_X_PLAYER_INFO_OFFSET;
        /// <summary>
        /// Offset to the LocalCoord Y-value.
        /// <br/>Does not exist in WinMUGEN.
        /// </summary>
        public uint LOCALCOORD_Y_PLAYER_INFO_OFFSET;

        /* Anim-related. */
        /// <summary>
        /// Length of each animation metadata entry.
        /// </summary>
        public uint OFFSET_ANIM_LIST_OFFSET = 0x10;
        /// <summary>
        /// Location of the action number for an animation, relative to <c>ANIM_LIST_REF3_PLAYER_INFO_OFFSET</c>.
        /// </summary>
        public uint ANIM_NO_ANIM_OFFSET = 0xC;
        /// <summary>
        /// Location of the animation info for a player, relative to <c>ANIM_ADDR_PLAYER_OFFSET</c>.
        /// <br/>Used in Clsn1/Clsn2 reading.
        /// </summary>
        public uint ANIM_INFO_ANIM_OFFSET = 0x10;
        /// <summary>
        /// Offset to Clsn1 data, relative to <c>ANIM_INFO_ANIM_OFFSET</c>.
        /// </summary>
        public uint CLSN1_ADDR_ANIM_INFO_OFFSET = 0x28;
        /// <summary>
        /// Offset to Clsn2 data, relative to <c>ANIM_INFO_ANIM_OFFSET</c>.
        /// </summary>
        public uint CLSN2_ADDR_ANIM_INFO_OFFSET = 0x2C;

        /* Misc. */
        /// <summary>
        /// Length of HitOverride entries.
        /// </summary>
        public uint OFFSET_HITOVERRIDE_LIST_OFFSET = 0x14;
        /// <summary>
        /// HitOverride attribute enum as an int.
        /// </summary>
        public uint ATTR_HITOVERRIDE_OFFSET = 0x4;
        /// <summary>
        /// HitOverride existence flag.
        /// </summary>
        public uint EXIST_HITOVERRIDE_OFFSET;
        /// <summary>
        /// Location of NumTarget value, relative to <c>TARGET_ENTRY_PLAYER_OFFSET</c>.
        /// </summary>
        public uint NUMTARGET_TARGET_ENTRY_OFFSET = 0x8;
        /// <summary>
        /// Location of the first target entry, relative to <c>TARGET_ENTRY_PLAYER_OFFSET</c>.
        /// </summary>
        public uint TARGET_LIST_TARGET_ENTRY_OFFSET = 0x14;
        /// <summary>
        /// Length of each target entry.
        /// </summary>
        public uint OFFSET_TARGET_LIST_OFFSET = 0x20;

        /// <summary>
        /// Gets the address database instance for an input MugenType_t.
        /// </summary>
        /// <param name="mugen_type">a <c>MugenWindow.MugenType_t</c> representing the current Mugen version.</param>
        /// <returns>an instance of <c>MugenAddrDatabase</c></returns>
        public static MugenAddrDatabase GetAddrDatabase(
          MugenWindow.MugenType_t mugen_type)
        {
            switch (mugen_type)
            {
                case MugenWindow.MugenType_t.MUGEN_TYPE_MUGEN10:
                    if (_mugen10_db == null)
                        _mugen10_db = new Mugen10DB();
                    return _mugen10_db;
                case MugenWindow.MugenType_t.MUGEN_TYPE_MUGEN11A4:
                    if (_mugen11a4_db == null)
                        _mugen11a4_db = new Mugen11A4DB();
                    return _mugen11a4_db;
                case MugenWindow.MugenType_t.MUGEN_TYPE_MUGEN11B1:
                    if (_mugen11b1_db == null)
                        _mugen11b1_db = new Mugen11B1DB();
                    return _mugen11b1_db;
                default:
                    if (_default_db == null)
                        _default_db = new MugenAddrDatabase();
                    return _default_db;
            }
        }
    }
}
