﻿using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using System;
using System.Collections.Generic;

namespace PartyMorg
{
    public static class Config
    {
        private const string MenuName = "PartyMorg";

        private static readonly Menu Menu;

        static Config()
        {
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Welcome to PartyMorg settings menu!");

            Settings.Initialize();
        }

        public static void Initialize() { }

        public static class Settings
        {
            private static readonly Menu Menu0, Menu1, Menu2, Menu3, Menu4, Menu5, Menu6, Menu7, Menu8, Menu9, Menu10, Menu11;

            static Settings()
            {
                Menu0 = Config.Menu.AddSubMenu("Draw");
                Draw.Initialize();

                Menu1 = Config.Menu.AddSubMenu("Anti-Gapcloser");
                AntiGapcloser.Initialize();

                Menu2 = Config.Menu.AddSubMenu("Interrupter");
                Interrupter.Initialize();

                Menu3 = Config.Menu.AddSubMenu("Items");
                Items.Initialize();

                Menu4 = Config.Menu.AddSubMenu("Auto-Shield");
                AutoShield.Initialize();

                Menu5 = Config.Menu.AddSubMenu("Combo");
                Combo.Initialize();

                Menu6 = Config.Menu.AddSubMenu("Flee");
                Flee.Initialize();

                Menu7 = Config.Menu.AddSubMenu("Harass");
                Harass.Initialize();

                Menu10 = Config.Menu.AddSubMenu("Lane Clear");
                LaneClear.Initialize();

                Menu11 = Config.Menu.AddSubMenu("Jungle Clear");
                JungleClear.Initialize();

                Menu8 = Config.Menu.AddSubMenu("Humanizer");
                Humanizer.Initialize();

                Menu9 = Config.Menu.AddSubMenu("Skin Hack");
                SkinHack.Initialize();
            }

            public static void Initialize() { }

            public static class Draw
            {
                private static readonly CheckBox _drawQ;
                private static readonly CheckBox _drawW;
                private static readonly CheckBox _drawE;
                private static readonly CheckBox _drawR;

                public static bool DrawQ
                {
                    get { return _drawQ.CurrentValue; }
                }
                public static bool DrawW
                {
                    get { return _drawW.CurrentValue; }
                }
                public static bool DrawE
                {
                    get { return _drawE.CurrentValue; }
                }
                public static bool DrawR
                {
                    get { return _drawR.CurrentValue; }
                }

                static Draw()
                {
                    Menu0.AddGroupLabel("Draw Settings");

                    _drawQ = Menu0.Add("drawQ", new CheckBox("Draw Q Range"));
                    _drawW = Menu0.Add("drawW", new CheckBox("Draw W Range"));
                    _drawE = Menu0.Add("drawE", new CheckBox("Draw E Range"));
                    _drawR = Menu0.Add("drawR", new CheckBox("Draw R Range"));
                }

                public static void Initialize() { }
            }

            public static class Items
            {
                private static readonly CheckBox _useItems, _useItemsComboOnly;
                private static readonly Slider _allyHpPercentageDamage, _allyHpPercentageCc;
                private static readonly List<CheckBox> _isAllyList, _fotmAllyList, _mcAllyList, _fqcAllyList, _toaAllyList;

                public static bool UseItems
                {
                    get { return _useItems.CurrentValue; }
                }
                public static bool UseItemsComboOnly
                {
                    get { return _useItemsComboOnly.CurrentValue; }
                }
                public static int AllyHpPercentageDamage
                {
                    get { return _allyHpPercentageDamage.CurrentValue; }
                }
                public static int AllyHpPercentageCC
                {
                    get { return _allyHpPercentageCc.CurrentValue; }
                }
                public static List<CheckBox> ISAllyList
                {
                    get { return _isAllyList; }
                }
                public static List<CheckBox> FOTMAllyList
                {
                    get { return _fotmAllyList; }
                }
                public static List<CheckBox> MCAllyList
                {
                    get { return _mcAllyList; }
                }
                public static List<CheckBox> FQCAllyList
                {
                    get { return _fqcAllyList; }
                }
                public static List<CheckBox> TOAAllyList
                {
                    get { return _toaAllyList; }
                }

                static Items()
                {
                    _isAllyList = new List<CheckBox>();
                    _fotmAllyList = new List<CheckBox>();
                    _mcAllyList = new List<CheckBox>();
                    _fqcAllyList = new List<CheckBox>();
                    _toaAllyList = new List<CheckBox>();

                    Menu3.AddGroupLabel("Items");

                    _useItems = Menu3.Add("useItems", new CheckBox("Use Items"));

                    Menu3.AddSeparator(13);

                    _useItemsComboOnly = Menu3.Add("useItemsComboOnly", new CheckBox("Use Items only in Combo Mode", false));

                    Menu3.AddSeparator(13);

                    Menu3.AddGroupLabel("Locket of the Iron Solari");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _isAllyList.Add(Menu3.Add<CheckBox>("ironSolari" + ally.ChampionName, new CheckBox(string.Format("Use on {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu3.AddSeparator(13);

                    Menu3.AddGroupLabel("Face of the Mountain");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _fotmAllyList.Add(Menu3.Add<CheckBox>("mountain" + ally.ChampionName, new CheckBox(string.Format("Use on {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu3.AddSeparator(13);

                    Menu3.AddGroupLabel("Mikael's Crucible");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _mcAllyList.Add(Menu3.Add<CheckBox>("mikael" + ally.ChampionName, new CheckBox(string.Format("Use on {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu3.AddSeparator(13);

                    Menu3.AddGroupLabel("Frost Queen's Claim");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _fqcAllyList.Add(Menu3.Add<CheckBox>("frostQueen" + ally.ChampionName, new CheckBox(string.Format("Use on {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu3.AddSeparator(13);

                    Menu3.AddGroupLabel("Talisman of Ascension");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _toaAllyList.Add(Menu3.Add<CheckBox>("talisman" + ally.ChampionName, new CheckBox(string.Format("Use on {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu3.AddSeparator(13);

                    _allyHpPercentageDamage = Menu3.Add("allyHpPercentage", new Slider("Min. Ally Health on Damage (%):", 50, 1));

                    Menu3.AddSeparator(13);

                    _allyHpPercentageCc = Menu3.Add("allyHpPercentageCc", new Slider("Min. Ally Health on CC (%):", 100, 1));
                }

                public static void Initialize() { }
            }

            public static class AntiGapcloser
            {
                private static readonly CheckBox _antiGapcloser;

                public static bool AntiGap
                {
                    get { return _antiGapcloser.CurrentValue; }
                }

                static AntiGapcloser()
                {
                    Menu1.AddGroupLabel("Anti-Gapcloser Settings");

                    _antiGapcloser = Menu1.Add("antiGapcloser", new CheckBox("Use Q on Gapclosers"));
                }

                public static void Initialize() { }
            }

            public static class Interrupter
            {
                private static readonly CheckBox _qInterrupt;
                private static readonly CheckBox _qInterruptDangerous;
                private static readonly CheckBox _rInterruptDangerous;

                public static bool QInterrupt
                {
                    get { return _qInterrupt.CurrentValue; }
                }
                public static bool QInterruptDangerous
                {
                    get { return _qInterruptDangerous.CurrentValue; }
                }
                public static bool RInterruptDangerous
                {
                    get { return _rInterruptDangerous.CurrentValue; }
                }

                static Interrupter()
                {
                    Menu2.AddGroupLabel("Interrupter Settings");

                    _qInterrupt = Menu2.Add("qInterrupt", new CheckBox("Interrupt low/med-danger spells with Q"));
                    Menu2.AddSeparator(13);

                    _qInterruptDangerous = Menu2.Add("rInterrupt", new CheckBox("Interrupt high-danger spells with Q"));
                    Menu2.AddSeparator(13);

                    _rInterruptDangerous = Menu2.Add("rInterruptDangerous", new CheckBox("Interrupt high-danger spells with R"));
                }

                public static void Initialize() { }
            }

            public static class AutoShield
            {
                private static readonly ComboBox _priorMode;
                private static readonly List<Slider> _sliders;
                private static readonly List<AIHeroClient> _heros;
                private static readonly List<CheckBox> _shieldAllyList, _shieldSpellList;

                public static int PriorMode
                {
                    get { return _priorMode.SelectedIndex; }
                }
                public static List<Slider> Sliders
                {
                    get { return _sliders; }
                }
                public static List<AIHeroClient> Heros
                {
                    get { return _heros; }
                }
                public static List<CheckBox> ShieldAllyList
                {
                    get { return _shieldAllyList; }
                }
                public static List<CheckBox> ShieldSpellList
                {
                    get { return _shieldSpellList; }
                }

                static AutoShield()
                {
                    _shieldAllyList = new List<CheckBox>();
                    _shieldSpellList = new List<CheckBox>();

                    Menu4.AddGroupLabel("Auto-Shield Settings");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _shieldAllyList.Add(Menu4.Add<CheckBox>("shield" + ally.ChampionName, new CheckBox(string.Format("Shield {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu4.AddSeparator(13);

                    foreach (var enemy in EntityManager.Heroes.Enemies)
                    {
                        for (int i = 0; i <= 185; i++)
                        {
                            if (MissileDatabase.missileDatabase[i, 2] == enemy.ChampionName)
                                _shieldSpellList.Add(Menu4.Add<CheckBox>(MissileDatabase.missileDatabase[i, 0] + i, new CheckBox(string.Format("Shield from {0}'s {1} ({2})                                                 {3}", MissileDatabase.missileDatabase[i, 2], MissileDatabase.missileDatabase[i, 1], MissileDatabase.missileDatabase[i, 0], i))));
                        }
                    }

                    Menu4.AddSeparator(13);

                    _priorMode = Menu4.Add("autoShieldPriorMode", new ComboBox("AutoShield Priority Mode:", 0, new string[] { "Lowest Health", "Priority Level" }));
                    Menu4.AddSeparator(13);

                    _sliders = new List<Slider>();
                    _heros = new List<AIHeroClient>();

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        Slider PrioritySlider = Menu4.Add<Slider>(ally.ChampionName, new Slider(string.Format("{0} Priority:", ally.ChampionName, ally.Name), 1, 1, EntityManager.Heroes.Allies.Count));

                        Menu4.AddSeparator(13);

                        _sliders.Add(PrioritySlider);

                        _heros.Add(ally);
                    }
                }

                public static void Initialize() { }
            }

            public static class Combo
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useR;
                private static readonly CheckBox _useQBeforeW;
                private static readonly CheckBox _flashUlt;
                private static readonly CheckBox _ultZhonya;
                private static readonly CheckBox _wImmobileOnly;
                private static readonly Slider _qMinHitChance;
                private static readonly Slider _rMinEnemies;
                private static readonly Slider _ultMinRange;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }
                public static bool UseQBeforeW
                {
                    get { return _useQBeforeW.CurrentValue; }
                }
                public static bool FlashUlt
                {
                    get { return _flashUlt.CurrentValue; }
                }
                public static bool UltZhonya
                {
                    get { return _ultZhonya.CurrentValue; }
                }
                public static bool WImmobileOnly
                {
                    get { return _wImmobileOnly.CurrentValue; }
                }
                public static int QMinHitChance
                {
                    get { return _qMinHitChance.CurrentValue; }
                }
                public static int RMinEnemies
                {
                    get { return _rMinEnemies.CurrentValue; }
                }
                public static int UltMinRange
                {
                    get { return _ultMinRange.CurrentValue; }
                }

                static Combo()
                {
                    Menu5.AddGroupLabel("Combo Settings");

                    _useQ = Menu5.Add("comboUseQ", new CheckBox("Use Q"));
                    _useW = Menu5.Add("comboUseW", new CheckBox("Use W"));
                    _useR = Menu5.Add("comboUseR", new CheckBox("Use R"));
                    Menu5.AddSeparator();

                    _qMinHitChance = Menu5.Add<Slider>("comboQMinHitChance", new Slider("Q Min. Hit Chance (%):", 75, 50));
                    Menu5.AddSeparator();

                    _useQBeforeW = Menu5.Add("comboUseQBeforeW", new CheckBox("Use W after Q only"));
                    _flashUlt = Menu5.Add("flashUlt", new CheckBox("Use Flash + Ultimate", false));
                    _ultZhonya = Menu5.Add("ultZhonya", new CheckBox("Use Zhonya with Ultimate"));
                    _wImmobileOnly = Menu5.Add("comboWImmobileOnly", new CheckBox("W Only Immobile Enemies"));
                    Menu5.AddSeparator();

                    _rMinEnemies = Menu5.Add<Slider>("rMinEnemies", new Slider("Min. Enemies Around to use Ultimate:", 1, 1, EntityManager.Heroes.Enemies.Count));
                    _ultMinRange = Menu5.Add<Slider>("ultMinRange", new Slider("Min. Range from Enemy to use Ultimate:", 470, 1, Convert.ToInt32(SpellManager.R.Range)));
                }

                public static void Initialize() { }
            }

            public static class Flee
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useQBeforeW;
                private static readonly Slider _qMinHitChance;
                private static readonly CheckBox _wImmobileOnly;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseQBeforeW
                {
                    get { return _useQBeforeW.CurrentValue; }
                }
                public static int QMinHitChance
                {
                    get { return _qMinHitChance.CurrentValue; }
                }
                public static bool WImmobileOnly
                {
                    get { return _wImmobileOnly.CurrentValue; }
                }

                static Flee()
                {
                    Menu6.AddGroupLabel("Flee Settings");

                    _useQ = Menu6.Add("fleeUseQ", new CheckBox("Use Q"));
                    _useW = Menu6.Add("fleeUseW", new CheckBox("Use W"));
                    Menu6.AddSeparator();

                    _useQBeforeW = Menu6.Add("fleeUseQBeforeW", new CheckBox("Use W after Q only"));
                    _wImmobileOnly = Menu6.Add("fleeWImmobileOnly", new CheckBox("W Only Immobile Enemies"));
                    Menu6.AddSeparator();

                    _qMinHitChance = Menu6.Add<Slider>("fleeQMinHitChance", new Slider("Q Min. Hit Chance (%):", 75, 50));
                }

                public static void Initialize() { }
            }

            public static class Harass
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _wImmobileOnly;
                private static readonly CheckBox _useQBeforeW;
                private static readonly Slider _qMinHitChance;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseQBeforeW
                {
                    get { return _useQBeforeW.CurrentValue; }
                }
                public static int QMinHitChance
                {
                    get { return _qMinHitChance.CurrentValue; }
                }
                public static bool WImmobileOnly
                {
                    get { return _wImmobileOnly.CurrentValue; }
                }

                static Harass()
                {
                    Menu7.AddGroupLabel("Harass Settings");

                    _useQ = Menu7.Add("harassUseQ", new CheckBox("Use Q"));

                    _useW = Menu7.Add("harassUseW", new CheckBox("Use W"));
                    Menu7.AddSeparator();

                    _useQBeforeW = Menu7.Add("harassUseQBeforeW", new CheckBox("Use W after Q only"));
                    _wImmobileOnly = Menu7.Add("harassWImmobileOnly", new CheckBox("W Only Immobile Enemies"));
                    Menu7.AddSeparator();

                    _qMinHitChance = Menu7.Add<Slider>("harassQMinHitChance", new Slider("Q Min. Hit Chance (%):", 75, 50));
                }

                public static void Initialize() { }
            }

            public static class LaneClear
            {
                private static readonly CheckBox _useW;
                private static readonly Slider _minionsToUseW;

                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static int MinionsToUseW
                {
                    get { return _minionsToUseW.CurrentValue; }
                }

                static LaneClear()
                {
                    Menu10.AddGroupLabel("Lane Clear Settings");

                    _useW = Menu10.Add("laneClearUseW", new CheckBox("Use W"));
                    Menu10.AddSeparator();

                    _minionsToUseW = Menu10.Add<Slider>("minionsToUseW", new Slider("Minions to use W:", 3, 1, 7));
                }

                public static void Initialize() { }
            }

            public static class JungleClear
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                static JungleClear()
                {
                    Menu11.AddGroupLabel("Jungle Clear Settings");

                    _useQ = Menu11.Add("jungleClearUseQ", new CheckBox("Use Q"));
                    Menu11.AddSeparator();

                    _useW = Menu11.Add("jungleClearUseW", new CheckBox("Use W"));
                    Menu11.AddSeparator();
                }

                public static void Initialize() { }
            }

            public static class Humanizer
            {
                private static readonly CheckBox _qCastDelayEnabled;
                private static readonly CheckBox _eCastDelayEnabled;
                private static readonly CheckBox _rCastDelayEnabled;
                private static readonly Slider _qCastDelay;
                private static readonly Slider _eCastDelay;
                private static readonly Slider _rCastDelay;
                private static readonly CheckBox _qRndmDelay;
                private static readonly CheckBox _eRndmDelay;
                private static readonly CheckBox _rRndmDelay;

                public static bool QCastDelayEnabled
                {
                    get { return _qCastDelayEnabled.CurrentValue; }
                }
                public static bool ECastDelayEnabled
                {
                    get { return _eCastDelayEnabled.CurrentValue; }
                }
                public static bool RCastDelayEnabled
                {
                    get { return _rCastDelayEnabled.CurrentValue; }
                }
                public static int QCastDelay
                {
                    get { return _qCastDelay.CurrentValue; }
                }
                public static int ECastDelay
                {
                    get { return _eCastDelay.CurrentValue; }
                }
                public static int RCastDelay
                {
                    get { return _rCastDelay.CurrentValue; }
                }
                public static bool QRndmDelay
                {
                    get { return _qRndmDelay.CurrentValue; }
                }
                public static bool ERndmDelay
                {
                    get { return _eRndmDelay.CurrentValue; }
                }
                public static bool RRndmDelay
                {
                    get { return _rRndmDelay.CurrentValue; }
                }

                static Humanizer()
                {
                    Menu8.AddGroupLabel("Humanizer Settings");

                    _qCastDelayEnabled = Menu8.Add("qCastDelayEnabled", new CheckBox("Enabled", false));
                    _qCastDelay = Menu8.Add<Slider>("qCastDelay", new Slider("Q Cast Delay (1sec = 1000ms):", 500, 250, 1000));
                    Menu8.AddSeparator();

                    _eCastDelayEnabled = Menu8.Add("eCastDelayEnabled", new CheckBox("Enabled", false));
                    _eCastDelay = Menu8.Add<Slider>("eCastDelay", new Slider("E Cast Delay (1sec = 1000ms):", 500, 250, 1000));
                    Menu8.AddSeparator();

                    _rCastDelayEnabled = Menu8.Add("rCastDelayEnabled", new CheckBox("Enabled", false));
                    _rCastDelay = Menu8.Add<Slider>("rCastDelay", new Slider("R Cast Delay (1sec = 1000ms):", 500, 250, 1000));
                    Menu8.AddSeparator();

                    _qRndmDelay = Menu8.Add("qRndmDelay", new CheckBox("Randomize Q Cast Delay"));
                    Menu8.AddSeparator();

                    _eRndmDelay = Menu8.Add("eRndmDelay", new CheckBox("Randomize E Cast Delay"));
                    Menu8.AddSeparator();

                    _rRndmDelay = Menu8.Add("rRndmDelay", new CheckBox("Randomize R Cast Delay"));
                    Menu8.AddSeparator();
                }

                public static void Initialize() { }
            }

            public static class SkinHack
            {
                private static readonly CheckBox _skinHackEnabled;
                private static readonly Slider _skinId;

                public static bool SkinHackEnabled
                {
                    get { return _skinHackEnabled.CurrentValue; }
                }
                public static int SkinID
                {
                    get { return _skinId.CurrentValue; }
                }

                static SkinHack()
                {
                    Menu9.AddGroupLabel("Skin Hack Settings");

                    _skinHackEnabled = Menu9.Add("skinHackEnabled", new CheckBox("Enabled", false));
                    _skinId = Menu9.Add<Slider>("skinId", new Slider("Skin ID:", 0, 0, 11));

                    _skinId.OnValueChange += OnSkinIdChange;
                    _skinHackEnabled.OnValueChange += OnSkinHackToggle;

                    Player.Instance.SetSkinId(SkinID);
                }

                private static void OnSkinHackToggle(ValueBase<bool> sender, ValueBase<bool>.ValueChangeArgs args)
                {
                    if (!args.NewValue)
                        Player.Instance.SetSkinId(0);
                    else
                        Player.Instance.SetSkinId(SkinID);
                }

                private static void OnSkinIdChange(ValueBase<int> sender, ValueBase<int>.ValueChangeArgs args)
                {
                    if (SkinHackEnabled)
                        Player.Instance.SetSkinId(args.NewValue);
                }

                public static void Initialize() { }
            }
        }
    }
}
