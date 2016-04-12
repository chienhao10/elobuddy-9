﻿namespace PartyMorg
{
    public static class MissileDatabase
    {
        public static string[,] missileDatabase { get; private set; }
        public static int[,] rangeRadiusDatabase { get; private set; }

        static MissileDatabase()
        {
            missileDatabase = new string[186, 3]
            {
                { "disabled/TestCubeRender", "Summoner", "Any" },
                { "AatroxQ", "Q", "Aatrox" },
                { "AatroxE", "E", "Aatrox" },
                { "AhriOrbMissile", "Q", "Ahri" },
                { "AhriSeduceMissile", "E", "Ahri" },
                { "AhriOrbofDeception2", "Q", "Ahri" },
                { "Pulverize", "Q", "Alistar" },
                { "CurseoftheSadMummy", "R", "Amumu" },
                { "SadMummyBandageToss", "Q", "Amumu" },
                { "FlashFrostSpell", "Q", "Anivia" },
                { "Incinerate", "W", "Annie" },
                { "InfernalGuardian", "R", "Annie" },
                { "EnchantedCrystalArrow", "R", "Ashe" },
                { "VolleyAttack", "W", "Ashe" },
                { "azirsoldiermissile", "Q", "Azir" },
                { "BardQMissile", "Q", "Bard" },
                { "RocketGrabMissile", "Q", "Blitzcrank" },
                { "BrandBlazeMissile", "Q", "Brand" },
                { "BrandFissure", "W", "Brand" },
                { "braumrmissile", "R", "Braum" },
                { "BraumQMissile", "Q", "Braum" },
                { "CaitlynPiltoverPeacemaker", "Q", "Caitlyn" },
                { "CaitlynEntrapmentMissile", "E", "Caitlyn" },
                { "CassiopeiaPetrifyingGaze", "R", "Cassiopeia" },
                { "CassiopeiaNoxiousBlast", "Q", "Cassiopeia" },
                { "CassiopeiaMiasma", "W", "Cassiopeia" },
                { "FeralScream", "W", "Chogath" },
                { "Rupture", "Q", "Chogath" },
                { "MissileBarrageMissile2", "R", "Corki" },
                { "PhosphorusBombMissile", "Q", "Corki" },
                { "MissileBarrageMissile", "R", "Corki" },
                { "DariusAxeGrabCone", "E", "Darius" },
                { "DianaArc", "Q", "Diana" },
                { "InfectedCleaverMissile", "Q", "DrMundo" },
                { "DravenR", "R", "Draven" },
                { "DravenDoubleShotMissile", "E", "Draven" },
                { "ekkoqmis", "Q", "Ekko" },
                { "EkkoW", "W", "Ekko" },
                { "EkkoR", "R", "Ekko" },
                { "EliseHumanE", "E", "Elise" },
                { "EvelynnR", "R", "Evelynn" },
                { "EzrealMysticShotMissile", "Q", "Ezreal" },
                { "EzrealTrueshotBarrage", "R", "Ezreal" },
                { "EzrealEssenceFluxMissile", "W", "Ezreal" },
                { "FizzMarinerDoomMissile", "R", "Fizz" },
                { "GalioRighteousGust", "E", "Galio" },
                { "GalioResoluteSmite", "Q", "Galio" },
                { "GalioIdolOfDurand", "R", "Galio" },
                { "gnarbigq", "Q", "Gnar" },
                { "GnarR", "R", "Gnar" },
                { "gnarbigw", "W", "Gnar" },
                { "GnarQ", "Q", "Gnar" },
                { "GnarQMissileReturn", "Q", "Gnar" },
                { "GnarE", "E", "Gnar" },
                { "gnarbige", "E", "Gnar" },
                { "GragasQ", "Q", "Gragas" },
                { "GragasE", "E", "Gragas" },
                { "GragasR", "R", "Gragas" },
                { "GravesClusterShotAttack", "Q", "Graves" },
                { "GravesChargeShotShot", "R", "Graves" },
                { "HecarimUlt", "R", "Hecarim" },
                { "HeimerdingerWAttack2", "W", "Heimerdinger" },
                { "HeimerdingerWAttack2Ult", "W", "Heimerdinger" },
                { "HeimerdingerESpell", "E", "Heimerdinger" },
                { "heimerdingerespell_ult", "E", "Heimerdinger" },
                { "ireliatranscendentbladesspell", "R", "Irelia" },
                { "HowlingGaleSpell", "Q", "Janna" },
                { "JarvanIVDragonStrike", "Q", "JarvanIV" },
                { "JarvanIVDragonStrike2", "Q", "JarvanIV" },
                { "JarvanIVCataclysm", "R", "JarvanIV" },
                { "JayceShockBlastWallMis", "Q", "Jayce" },
                { "JayceShockBlastMis", "Q", "Jayce" },
                { "JinxR", "R", "Jinx" },
                { "JinxWMissile", "W", "Jinx" },
                { "kalistamysticshotmistrue", "Q", "Kalista" },
                { "KarmaQMissile", "Q", "Karma" },
                { "KarmaQMissileMantra", "Q", "Karma" },
                { "KarthusLayWasteA1", "Q", "Karthus" },
                { "RiftWalk", "R", "Kassadin" },
                { "ForcePulse", "E", "Kassadin" },
                { "KennenShurikenHurlMissile1", "Q", "Kennen" },
                { "KhazixWMissile", "W", "Khazix" },
                { "khazixwlong", "W", "Khazix" },
                { "KogMawQMis", "Q", "KogMaw" },
                { "KogMawVoidOozeMissile", "E", "KogMaw" },
                { "KogMawLivingArtillery", "R", "KogMaw" },
                { "LeblancSoulShackleM", "R Mimic", "Leblanc" },
                { "LeblancSoulShackle", "E", "Leblanc" },
                { "LeblancSlideM", "R Mimic", "Leblanc" },
                { "LeblancSlide", "W", "Leblanc" },
                { "BlindMonkQOne", "Q", "LeeSin" },
                { "LeonaSolarFlare", "R", "Leona" },
                { "FlashFrostSpell", "E", "Leona" },
                { "LissandraW", "W", "Lissandra" },
                { "LissandraQ", "Q", "Lissandra" },
                { "LucianW", "W", "Lucian" },
                { "LucianQ", "Q", "Lucian" },
                { "LuluQMissile", "Q", "Lulu" },
                { "LuluQMissileTwo", "Q", "Lulu" },
                { "LuxLightStrikeKugel", "E", "Lux" },
                { "LuxMaliceCannon", "R", "Lux" },
                { "LuxLightBindingMis", "Q", "Lux" },
                { "UFSlash", "R", "Malphite" },
                { "AlZaharCalloftheVoidMissile", "Q", "Malzahar" },
                { "MonkeyKingSpinToWin", "R", "MonkeyKing" },
                { "DarkBindingMissile", "Q", "Morgana" },
                { "NamiQ", "Q", "Nami" },
                { "NamiRMissile", "R", "Nami" },
                { "NautilusAnchorDragMissile", "Q", "Nautilus" },
                { "JavelinToss", "Q", "Nidalee" },
                { "NocturneDuskbringer", "Q", "Nocturne" },
                { "OlafAxeThrowCast", "Q", "Olaf" },
                { "OrianaIzunaCommand", "Q", "Orianna" },
                { "OrianaDetonateCommand", "R", "Orianna" },
                { "OrianaDissonanceCommand", "W", "Orianna" },
                { "PantheonE", "E", "Pantheon" },
                { "QuinnQMissile", "Q", "Quinn" },
                { "RekSaiQBurrowedMis", "E", "RekSai" },
                { "RengarEFinal", "E", "Rengar" },
                { "rivenizunablade", "R", "Riven" },
                { "RivenMartyr", "W", "Riven" },
                { "RumbleGrenade", "E", "Rumble" },
                { "RyzeQ", "Q", "Ryze" },
                { "SejuaniArcticAssault", "Q", "Sejuani" },
                { "SejuaniGlacialPrison", "R", "Sejuani" },
                { "ShenShadowDash", "E", "Shen" },
                { "ShyvanaFireball", "E", "Shyvana" },
                { "ShyvanaTransformCast", "R", "Shyvana" },
                { "SionEMissile", "E", "Sion" },
                { "SivirQMissile", "Q", "Sivir" },
                { "SivirQMissileReturn", "Q", "Sivir" },
                { "SkarnerFractureMissile", "E", "Skarner" },
                { "SonaR", "R", "Sona" },
                { "SorakaQ", "Q", "Soraka" },
                { "SorakaE", "E", "Soraka" },
                { "SwainShadowGrasp", "W", "Swain" },
                { "SyndraE", "E", "Syndra" },
                { "syndrawcast", "W", "Syndra" },
                { "SyndraQ", "Q", "Syndra" },
                { "tahmkenchqmissile", "Q", "TahmKench" },
                { "TalonRake", "W", "Talon" },
                { "ThreshQMissile", "Q", "Thresh" },
                { "ThreshEMissile1", "E", "Thresh" },
                { "SealFateMissile", "Q", "TwistedFate" },
                { "UrgotHeatseekingLineMissile", "Q", "Urgot" },
                { "UrgotPlasmaGrenadeBoom", "E", "Urgot" },
                { "VarusE", "E", "Varus" },
                { "VarusQMissile", "Q", "Varus" },
                { "VarusRMissile", "R", "Varus" },
                { "VeigarBalefulStrikeMis", "Q", "Veigar" },
                { "VeigarDarkMatter", "W", "Veigar" },
                { "VeigarEventHorizon", "E", "Veigar" },
                { "VelkozEMissile", "E", "Velkoz" },
                { "VelkozW", "W", "Velkoz" },
                { "VelkozQMissileSplit", "Q Splited", "Velkoz" },
                { "VelkozQMissile", "Q", "Velkoz" },
                { "ViQMissile", "Q", "Vi" },
                { "ViktorDeathRayMissile", "E1", "Viktor" },
                { "ViktorDeathRay3", "E3", "Viktor" },
                { "ViktorDeathRayMissile2", "E2", "Viktor" },
                { "ViktorGravitonField", "W", "Viktor" },
                { "VladimirHemoplague", "R", "Vladimir" },
                { "XerathArcaneBarrage2", "W", "Xerath" },
                { "xeratharcanopulse2", "Q", "Xerath" },
                { "xerathrmissilewrapper", "R", "Xerath" },
                { "XerathMageSpearMissile", "E", "Xerath" },
                { "YasuoQ3Mis", "Q Tornado", "Yasuo" },
                //{ "YasuoQ3Mis/disabled", "Q", "Yasuo" },
                { "yasuoq", "Q1", "Yasuo" },
                { "yasuoq2", "Q2", "Yasuo" },
                { "ZedQMissile", "Q", "Zed" },
                { "ZedPBAOEDummy", "E", "Zed" },
                { "ZiggsE", "E", "Ziggs" },
                { "ZiggsW", "W", "Ziggs" },
                { "ZiggsQSpell", "Q", "Ziggs" },
                { "ZiggsR", "R", "Ziggs" },
                { "ZileanQ", "Q", "Zilean" },
                { "ZyraGraspingRoots", "E", "Zyra" },
                { "zyrapassivedeathmanager", "Passive", "Zyra" },
                { "ZyraQFissure", "Q", "Zyra" },
                { "ZyraBrambleZone", "R", "Zyra" },
                { "illaoiemis", "Q", "Illaoi" },
                { "illaoiemis", "E", "Illaoi" },
                { "GravesQLineMis", "Q", "Graves" },
                { "PoppyQ", "Q", "Poppy" },
                { "JhinWMissile", "W", "Jhin" },
                { "JhinRShotMis", "R", "Jhin" },
            };

            rangeRadiusDatabase = new int[186, 2]
            {
                { 1600, 60 },
                { 650, 285 },
                { 1075, 100 },
                { 925, 100 },
                { 1000, 60 },
                { 925, 100 },
                { 365, 365 },
                { 560, 560 },
                { 1100, 80 },
                { 1250, 110 },
                { 625, 80 },
                { 600, 290 },
                { 12500, 130 },
                { 1150, 20 },
                { 850, 80 },
                { 950, 60 },
                { 1050, 70 },
                { 1100, 60 },
                { 1100, 250 },
                { 1250, 100 },
                { 1000, 100 },
                { 1300, 90 },
                { 950, 80 },
                { 825, 20 },
                { 600, 200 },
                { 850, 220 },
                { 650, 20 },
                { 950, 250 },
                { 1500, 40 },
                { 825, 270 },
                { 1300, 40 },
                { 570, 20 },
                { 850, 50 },
                { 1050, 60 },
                { 12500, 160 },
                { 1100, 130 },
                { 950, 60 },
                { 1600, 375 },
                { 1600, 375 },
                { 1100, 70 },
                { 650, 350 },
                { 1200, 60 },
                { 20000, 160 },
                { 1050, 80 },
                { 1275, 120 },
                { 1280, 120 },
                { 1040, 235 },
                { 600, 600 },
                { 1150, 90 },
                { 500, 500 },
                { 600, 100 },
                { 1185, 60 },
                { 1185, 60 },
                { 475, 150 },
                { 475, 100 },
                { 975, 250 },
                { 950, 200 },
                { 1050, 350 },
                { 1025, 60 },
                { 1000, 100 },
                { 1500, 300 },
                { 1500, 70 },
                { 1500, 70 },
                { 925, 135 },
                { 925, 135 },
                { 1200, 65 },
                { 1700, 120 },
                { 845, 80 },
                { 845, 120 },
                { 825, 350 },
                { 1170, 70 },
                { 1050, 70 },
                { 25000, 120 },
                { 1500, 60 },
                { 1200, 70 },
                { 1050, 90 },
                { 1050, 90 },
                { 875, 190 },
                { 700, 270 },
                { 700, 20 },
                { 1175, 50 },
                { 1100, 70 },
                { 1025, 70 },
                { 1125, 70 },
                { 1360, 120 },
                { 2200, 235 },
                { 960, 70 },
                { 960, 70 },
                { 725, 250 },
                { 1100, 60 },
                { 1200, 250 },
                { 975, 70 },
                { 725, 450 },
                { 825, 75 },
                { 1000, 80 },
                { 1140, 65 },
                { 925, 80 },
                { 925, 80 },
                { 1100, 340 },
                { 3500, 110 },
                { 1300, 70 },
                { 1000, 270 },
                { 900, 85 },
                { 300, 225 },
                { 1300, 80 },
                { 875, 200 },
                { 2750, 250 },
                { 1080, 90 },
                { 1500, 40 },
                { 1125, 60 },
                { 1000, 90 },
                { 2000, 80 },
                { 410, 410 },
                { 1825, 250 },
                { 650, 100 },
                { 1050, 80 },
                { 1500, 65 },
                { 1000, 70 },
                { 1100, 100 },
                { 650, 280 },
                { 950, 90 },
                { 900, 60 },
                { 900, 70 },
                { 1200, 110 },
                { 1600, 75 },
                { 950, 60 },
                { 1000, 160 },
                { 800, 80 },
                { 1275, 100 },
                { 1275, 100 },
                { 1000, 60 },
                { 1000, 150 },
                { 970, 260 },
                { 925, 275 },
                { 900, 200 },
                { 800, 140 },
                { 925, 220 },
                { 800, 210 },
                { 951, 90 },
                { 780, 75 },
                { 1200, 70 },
                { 1075, 110 },
                { 1450, 40 },
                { 1000, 60 },
                { 900, 250 },
                { 925, 235 },
                { 1600, 75 },
                { 1200, 100 },
                { 950, 70 },
                { 900, 225 },
                { 700, 425 },
                { 950, 225 },
                { 1100, 90 },
                { 900, 90 },
                { 1200, 90 },
                { 725, 90 },
                { 800, 80 },
                { 800, 80 },
                { 800, 80 },
                { 625, 300 },
                { 700, 375 },
                { 1100, 270 },
                { 1525, 80 },
                { 5600, 200 },
                { 1125, 60 },
                { 1150, 90 },
                { 1150, 90 },
                //{ 1150, 90 },
                { 550, 40 },
                { 550, 40 },
                { 925, 50 },
                { 290, 290 },
                { 2000, 235 },
                { 2000, 275 },
                { 850, 150 },
                { 5300, 550 },
                { 900, 250 },
                { 1150, 70 },
                { 1474, 80 },
                { 825, 260 },
                { 700, 525 },
                { 850, 100 },
                { 950, 50 },
                { 808, 40 },
                { 430, 100 },
                { 3000, 40 },
                { 3500, 80 },
            };
        }
    }
}
