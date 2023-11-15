using AutoRetainerAPI.Configuration;
using Dalamud;
using Dalamud.Utility;
using Lumina.Excel.GeneratedSheets;
using System.Collections.ObjectModel;

namespace AutoRetainer;

internal static class Lang
{
    internal const string CharPlant = "";
    internal const string CharLevel = "";
    internal const string CharItemLevel = "";
    internal const string CharDice = "";
    internal const string CharDeny = "";
    internal const string CharQuestion = "";
    internal const string CharLevelSync = "";
    internal const string CharP = "";
    internal const string StrDCV = "";

    internal const string IconRefresh = "\uf2f9";
    internal const string IconMultiMode = "\uf021";
    internal const string IconDuplicate = "\uf24d";
    internal const string IconGil = "\uf51e";
    internal const string IconPlanner = "\uf0ae";
    internal const string IconSettings = "\uf013";
    internal const string IconWarning = "\uf071";

    internal const string IconAnchor = "\uf13d";
    internal const string IconLevelup = "\ue098";
    internal const string IconResend = "\ue4bb";
    internal const string IconUnlock = "\uf13e";
    internal const string IconRepeat = "\uf363";
    internal const string IconPath = "\uf55b";

    internal static readonly ReadOnlyDictionary<UnlockMode, string> UnlockModeNames = new(new Dictionary<UnlockMode, string>()
    {
        { UnlockMode.MultiSelect, "Pick max amount of destinations" },
        { UnlockMode.SpamOne, "Spam one destination" },
        { UnlockMode.WhileLevelling, "Include one unlock destination while levelling" },
    });

    internal static readonly (string Normal, string GameFont) Digits = ("0123456789", "");

    internal static readonly string[] FieldExplorationNames =
    [
        "Field Exploration.",
        "Highland Exploration.",
        "Woodland Exploration.",
        "Waterside Exploration.",
        "探索依頼：平地　　（必要ベンチャースクリップ：2枚）",
        "探索依頼：山岳　　（必要ベンチャースクリップ：2枚）",
        "探索依頼：森林　　（必要ベンチャースクリップ：2枚）",
        "探索依頼：水辺　　（必要ベンチャースクリップ：2枚）",
        "Felderkundung (2 Wertmarken)",
        "Hochlanderkundung (2 Wertmarken)",
        "Forsterkundung (2 Wertmarken)",
        "Gewässererkundung (2 Wertmarken)",
        "Exploration en plaine (2 jetons)",
        "Exploration en montagne (2 jetons)",
        "Exploration en forêt (2 jetons)",
        "Exploration en rivage (2 jetons)",
        "平地探索委托（需要2枚探险币）",
        "山岳探索委托（需要2枚探险币）",
        "森林探索委托（需要2枚探险币）",
        "水岸探索委托（需要2枚探险币）",
        "탐색수행: 평지 (필요한 집사 급료: 2개)",
        "탐색수행: 산악 (필요한 집사 급료: 2개)",
        "탐색수행: 삼림 (필요한 집사 급료: 2개)",
        "탐색수행: 물가 (필요한 집사 급료: 2개)",
    ];

    internal static readonly string[] HuntingVentureNames =
    [
        "Hunting.",
        "Mining.",
        "Botany.",
        "Fishing.",
        "調達依頼：渉猟　　（必要ベンチャースクリップ：1枚）",
        "調達依頼：採掘　　（必要ベンチャースクリップ：1枚）",
        "調達依頼：園芸　　（必要ベンチャースクリップ：1枚）",
        "調達依頼：漁猟　　（必要ベンチャースクリップ：1枚）",
        "Beutezug (1 Wertmarke)",
        "Mineraliensuche (1 Wertmarke)",
        "Ernteausflug (1 Wertmarke)",
        "Fischzug (1 Wertmarke)",
        "Travail de chasse (1 jeton)",
        "Travail de mineur (1 jeton)",
        "Travail de botaniste (1 jeton)",
        "Travail de pêche (1 jeton)",
        "狩猎筹集委托（需要1枚探险币）",
        "采矿筹集委托（需要1枚探险币）",
        "采伐筹集委托（需要1枚探险币）",
        "捕鱼筹集委托（需要1枚探险币）",
        "조달수행: 사냥 (필요한 집사 급료: 1개)",
        "조달수행: 광부 (필요한 집사 급료: 1개)",
        "조달수행: 원예가 (필요한 집사 급료: 1개)",
        "조달수행: 어부 (필요한 집사 급료: 1개)",
    ];

    internal static readonly string[] QuickExploration =
    [
        "Quick Exploration.",
        "ほりだしもの依頼　（必要ベンチャースクリップ：2枚）",
        "Schneller Streifzug (2 Wertmarken)",
        "Tâche improvisée (2 jetons)",
        "自由探索委托（需要2枚探险币）",
        "발굴수행 (필요한 집사 급료: 2개)",
    ];

    internal static readonly string[] Entrance =
    [
        "ハウスへ入る",
        "Eingang",
        "Entrée",
        "Entrance",
        "주택으로 들어가기",
    ];

    internal static string ApartmentEntrance => Svc.Data.GetExcelSheet<EObjName>().GetRow(2007402).Singular.ToString();

    internal static readonly string[] ConfirmHouseEntrance =
    [
        "「ハウス」へ入りますか？",
        "Das Gebäude betreten?",
        "Entrer dans la maison ?",
        "Enter the estate hall?",
        "'주택'으로 들어가시겠습니까?",
    ];

    internal static readonly string[] RetainerAskCategoryText = 
    [
        "依頼するリテイナーベンチャーを選んでください",
        "Wähle eine Unternehmung, auf die du den Gehilfen schicken möchtest.",
        "Choisissez un type de tâche :",
        "Select a category.",
        "집사 수행의 종류를 선택하십시오.",
    ];

    internal static string[] BellName => 
    [
        Svc.Data.GetExcelSheet<EObjName>().GetRow(2000401).Singular.ExtractText(),
        "リテイナーベル",
        "집사 초인종",
    ];

    //0	TEXT_HOUFIXMANSIONENTRANCE_00359_HOUSINGAREA_MENU_ENTER_MYROOM	Go to your apartment
    //0	TEXT_HOUFIXMANSIONENTRANCE_00359_HOUSINGAREA_MENU_ENTER_MYROOM	自分の部屋に移動する
    //0	TEXT_HOUFIXMANSIONENTRANCE_00359_HOUSINGAREA_MENU_ENTER_MYROOM	Die eigene Wohnung betreten
    //0	TEXT_HOUFIXMANSIONENTRANCE_00359_HOUSINGAREA_MENU_ENTER_MYROOM	Aller dans votre appartement

    internal static readonly string[] GoToYourApartment =
    [
        "Go to your apartment",
        "自分の部屋に移動する",
        "Die eigene Wohnung betreten",
        "Aller dans votre appartement",
        "자신의 방으로 이동",
    ];

    internal static readonly string[] SkipCutsceneStr =
    [
        "Skip cutscene?",
        "要跳过这段过场动画吗？",
        "要跳過這段過場動畫嗎？",
        "Videosequenz überspringen?",
        "Passer la scène cinématique ?",
        "このカットシーンをスキップしますか？",
         "영상을 건너뛰시겠습니까?",
    ];
    //11	TEXT_CMNDEFHOUSINGPERSONALROOMENTRANCE_00178_GOTO_WORKSHOP	Move to the company workshop
    //11	TEXT_CMNDEFHOUSINGPERSONALROOMENTRANCE_00178_GOTO_WORKSHOP	地下工房に移動する
    //11	TEXT_CMNDEFHOUSINGPERSONALROOMENTRANCE_00178_GOTO_WORKSHOP	Die Ge<SoftHyphen/>sell<SoftHyphen/>schaftswerkstätte betreten
    //11	TEXT_CMNDEFHOUSINGPERSONALROOMENTRANCE_00178_GOTO_WORKSHOP	Aller dans l'atelier de compagnie
    internal static readonly string[] EnterWorkshop = 
    [
        "Move to the company workshop",
        "地下工房に移動する",
        "Die Gesellschaftswerkstätte betreten",
        "Aller dans l'atelier de compagnie",
        "지하공방으로 이동",
    ];

    internal static readonly string[] AirshipManagement = 
    [
        "Airship Management",
        "飛空艇の管理",
        "Luftschiff verwalten",
        "Contrôle aérien",
        "비공정 관리",
    ];

    internal static readonly string[] SubmarineManagement = 
    [
        "Submersible Management",
        "潜水艦の管理",
        "Tauchboot verwalten",
        "Contrôle sous-marin",
        "잠수함 관리",
    ];

    internal static readonly string[] CancelVoyage = 
    [
        "Cancel",
        "キャンセル",
        "Abbrechen",
        "Annuler",
        "취소",
    ];

    internal static readonly string[] NothingVoyage = 
    [
        "Nothing.",
        "やめる",
        "Nichts",
        "Annuler",
        "그만두기",
    ];

    internal static readonly string[] DeployOnSubaquaticVoyage = 
    [
        "Deploy submersible on subaquatic voyage",
        "ボイジャー出港",
        "Auf Erkundung gehen",
        "Expédier le sous-marin",
        "탐사 출항",
    ];

    internal static readonly string[] ViewPrevVoyageLog = 
    [
        "View previous voyage log",
        "前回のボイジャー報告",
        "Bericht der letzten Erkundung",
        "Consulter le journal de la précédente expédition",
        "이전 탐사 보고서",
    ];

    internal static readonly string[] VoyageQuitEntry = 
    [
        "Quit",
        "やめる",
        "Beenden",
        "Annuler",
        "중단"
    ];

    internal static readonly string[] PanelAirship = 
    [
        "Select an airship.",
        "飛空艇を選択してください。",
        "Wähle ein Luftschiff.",
        "Choisissez un aéronef.",
        "비공정을 선택하십시오.",
    ];

    internal static readonly string[] PanelSubmersible = 
    [
        "Select a submersible.",
        "潜水艦を選択してください。",
        "Wähle ein Tauchboot.",
        "Choisissez un sous-marin.",
        "잠수함을 선택하십시오.",
    ];

    //2004353	entrance to additional chambers	0	entrances to additional chambers	0	1	1	0	0
    internal static string AdditionalChambersEntrance => Svc.Data.GetExcelSheet<EObjName>().GetRow(2004353).Singular.ExtractText();

    //2005274	voyage control panel	0	voyage control panels	0	0	1	0	0
    internal static string PanelName => Svc.Data.GetExcelSheet<EObjName>().GetRow(2005274).Singular.ExtractText();

    //4160	60	9	0	False	Unable to retrieve extracted items. Insufficient inventory/crystal inventory space.
    internal static string VoyageInventoryError => Svc.Data.GetExcelSheet<LogMessage>().GetRow(4160).Text.ToDalamudString().ExtractText();

    internal static string[] UnableToVisitWorld = ["Unable to execute command. Character is currently visiting the", "他のデータセンター", "Der Vorgang kann nicht ausgeführt werden, da der Charakter gerade das Datenzentrum", "Impossible d'exécuter cette commande. Le personnage se trouve dans un autre centre de traitement de données"];

    //4169	60	9	0	False	Unable to repair vessel component without the required <SheetEn(Item,3,IntegerParameter(1),1,1)/>.
    //4272	60	9	0	False Unable to repair vessel.Insufficient<SheetEn(Item,3,IntegerParameter(1),3,1)/>.
    //4169	60	9	0	False	修理に必要な<Sheet(Item,IntegerParameter(1),0)/>を持っていません。
    //4272	60	9	0	False	修理に必要な<Sheet(Item,IntegerParameter(1),0)/>が足りません。
    //4272	60	9	0	False	Du hast nicht genug <SheetDe(Item,5,IntegerParameter(1),2,4,1)/> für die Reparatur.
    //4169	60	9	0	False	Für die Reparatur ist <SheetDe(Item,1,IntegerParameter(1),1,1,1)/> erforderlich.
    //4169	60	9	0	False	Réparation impossible. Vous n'avez pas <SheetFr(Item,2,IntegerParameter(1),1,1)/> nécessaire.
    //4272	60	9	0	False	Vous n'avez pas <SheetFr(Item,2,IntegerParameter(1),1,1)/> nécessaire à la réparation.

    internal static readonly string[] UnableToRepairVessel = 
    [
        "修理に必要な",
        "Unable to repair vessel",
        "Du hast nicht genug",
        "Für die Reparatur ist",
        "Réparation impossible. Vous n'avez pas",
        "nécessaire à la réparation",
        "수리에 필요한",
    ];
}
