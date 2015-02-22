﻿namespace LeagueSharp
{
  public enum GameEventId
  {
    OnDelete,
    OnSpawn,
    OnDie,
    OnKill,
    OnChampionDie,
    OnChampionKillPre,
    OnChampionKill,
    OnChampionKillPost,
    OnChampionSingleKill,
    OnChampionDoubleKill,
    OnChampionTripleKill,
    OnChampionQuadraKill,
    OnChampionPentaKill,
    OnChampionUnrealKill,
    OnFirstBlood,
    OnDamageTaken,
    OnDamageGiven,
    OnSpellCast1,
    OnSpellCast2,
    OnSpellCast3,
    OnSpellCast4,
    OnSpellAvatarCast1,
    OnSpellAvatarCast2,
    OnGoldSpent,
    OnGoldEarned,
    OnItemConsumeablePurchased,
    OnCriticalStrike,
    OnAce,
    OnReincarnate,
    OnDampenerKill,
    OnDampenerDie,
    OnDampenerRespawnSoon,
    OnDampenerRespawn,
    OnDampenerDamage,
    OnTurretKill,
    OnTurretDie,
    OnTurretDamage,
    OnMinionKill,
    OnMinionDenied,
    OnNeutralMinionKill,
    OnSuperMonsterKill,
    OnAcquireRedBuffFromNeutral,
    OnAcquireBlueBuffFromNeutral,
    OnHQKill,
    OnHQDie,
    OnHeal,
    OnCastHeal,
    OnBuff,
    OnCrowdControlDealt,
    OnKillingSpree,
    OnKillingSpreeSet1,
    OnKillingSpreeSet2,
    OnKillingSpreeSet3,
    OnKillingSpreeSet4,
    OnKillingSpreeSet5,
    OnKillingSpreeSet6,
    OnKilledUnitOnKillingSpree,
    OnKilledUnitOnKillingSpreeSet1,
    OnKilledUnitOnKillingSpreeSet2,
    OnKilledUnitOnKillingSpreeSet3,
    OnKilledUnitOnKillingSpreeSet4,
    OnKilledUnitOnKillingSpreeSet5,
    OnKilledUnitOnKillingSpreeSet6,
    OnKilledUnitOnKillingSpreeDoubleKill,
    OnKilledUnitOnKillingSpreeTripleKill,
    OnKilledUnitOnKillingSpreeQuadraKill,
    OnKilledUnitOnKillingSpreePentaKill,
    OnKilledUnitOnKillingSpreeUnrealKill,
    OnDeathAssist,
    OnQuit,
    OnLeave,
    OnReconnect,
    OnGameStart,
    OnAssistingSpreeSet1,
    OnAssistingSpreeSet2,
    OnChampionTripleAssist,
    OnChampionPentaAssist,
    OnPing,
    OnPingPlayer,
    OnPingBuilding,
    OnPingOther,
    OnEndGame,
    OnSpellLevelup1,
    OnSpellLevelup2,
    OnSpellLevelup3,
    OnSpellLevelup4,
    OnItemPurchased,
    OnItemSold,
    OnItemRemoved,
    OnItemCallout,
    OnItemChange,
    OnUndoEnabledChange,
    OnShopItemSubstitutionChange,
    OnSurrenderVoteStart,
    OnSurrenderVote,
    OnSurrenderVoteAlready,
    OnSurrenderFailedVotes,
    OnSurrenderTooEarly,
    OnSurrenderAgreed,
    OnSurrenderSpam,
    OnEqualizeVoteStart,
    OnEqualizeVote,
    OnEqualizeVoteAlready,
    OnEqualizeFailedVotes,
    OnEqualizeTooEarly,
    OnEqualizeNotEnoughGold,
    OnEqualizeNotEnoughLevels,
    OnEqualizeAgreed,
    OnEqualizeSpam,
    OnPause,
    OnPauseResume,
    OnMinionsSpawn,
    OnStartGameMessage1,
    OnStartGameMessage2,
    OnStartGameMessage3,
    OnStartGameMessage4,
    OnStartGameMessage5,
    OnAlert,
    OnScoreboardOpen,
    OnAudioEventFinished,
    OnNexusCrystalStart,
    OnCapturePointNeutralized_A,
    OnCapturePointNeutralized_B,
    OnCapturePointNeutralized_C,
    OnCapturePointNeutralized_D,
    OnCapturePointNeutralized_E,
    OnCapturePointCaptured_A,
    OnCapturePointCaptured_B,
    OnCapturePointCaptured_C,
    OnCapturePointCaptured_D,
    OnCapturePointCaptured_E,
    OnCapturePointFiveCap,
    OnVictoryPointThreshold1,
    OnVictoryPointThreshold2,
    OnVictoryPointThreshold3,
    OnVictoryPointThreshold4,
    OnMinionKillVictoryThreshold1,
    OnMinionKillVictoryThreshold2,
    OnReplayFastForwardStart,
    OnReplayFastForwardEnd,
    OnReplayOnKeyframeFinished,
    OnKillDragon,
    OnKillDragon_Spectator,
    OnKillDragonSteal,
    OnKillWorm,
    OnKillWorm_Spectator,
    OnKillWormSteal,
    OnKillSpiderBoss,
    OnKillSpiderBoss_Spectator,
    OnCaptureAltar,
    OnCaptureAltar_Spectator,
    OnPlaceWard,
    OnKillWard,
  }
}