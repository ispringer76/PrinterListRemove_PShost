﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterListRemove
{
    public class Default_App_List
    {
        public static string[] defaultApps  = {
        // default Windows 10 apps
        "Microsoft.3DBuilder",
        "Microsoft.Appconnector",
        "Microsoft.BingFinance",
        "Microsoft.BingNews",
        "Microsoft.BingSports",
        "Microsoft.BingTranslator",
        //"Microsoft.BingWeather",
        //"Microsoft.FreshPaint",
        "Microsoft.GamingServices",
        "Microsoft.Microsoft3DViewer",
        "Microsoft.MicrosoftOfficeHub",
        "Microsoft.MicrosoftPowerBIForWindows",
        "Microsoft.MicrosoftSolitaireCollection",
        //"Microsoft.MicrosoftStickyNotes",
        "Microsoft.MinecraftUWP",
        "Microsoft.NetworkSpeedTest",
        "Microsoft.Office.OneNote",
        "Microsoft.OneConnect",
        "Microsoft.People",
        "Microsoft.Print3D",
        "Microsoft.SkypeApp",
        "Microsoft.Wallet",
        //"Microsoft.Windows.Photos",
        //"Microsoft.WindowsAlarms",
        //"Microsoft.WindowsCalculator",
        //"Microsoft.WindowsCamera",
        "microsoft.windowscommunicationsapps",
        "Microsoft.WindowsMaps",
        "Microsoft.WindowsPhone",
        //"Microsoft.WindowsSoundRecorder",
        //"Microsoft.WindowsStore"   // can't be re-installed
        "Microsoft.Xbox.TCUI",
        "Microsoft.XboxApp",
        "Microsoft.XboxGameOverlay",
        "Microsoft.XboxGamingOverlay",
        "Microsoft.XboxSpeechToTextOverlay",
        "Microsoft.YourPhone",
        //"Microsoft.ZuneMusic",
        //"Microsoft.ZuneVideo",

        // Threshold 2 apps
        "Microsoft.CommsPhone",
        "Microsoft.ConnectivityStore",
        "Microsoft.GetHelp",
        "Microsoft.Getstarted",
        "Microsoft.Messaging",
        "Microsoft.Office.Sway",
        "Microsoft.OneConnect",
        "Microsoft.WindowsFeedbackHub",

        // Creators Update apps
        "Microsoft.Microsoft3DViewer",
        //"Microsoft.MSPaint"

        //Redstone apps
        "Microsoft.BingFoodAndDrink",
        "Microsoft.BingHealthAndFitness",
        "Microsoft.BingTravel",
        "Microsoft.WindowsReadingList",

        // Redstone 5 apps,
        "Microsoft.MixedReality.Portal",
        "Microsoft.ScreenSketch",
        "Microsoft.XboxGamingOverlay",
        "Microsoft.YourPhone",

        // non-Microsoft
        "2FE3CB00.PicsArt-PhotoStudio",
        "46928bounde.EclipseManager",
        "4DF9E0F8.Netflix",
        "613EBCEA.PolarrPhotoEditorAcademicEdition",
        "6Wunderkinder.Wunderlist",
        "7EE7776C.LinkedInforWindows",
        "89006A2E.AutodeskSketchBook",
        "9E2F88E3.Twitter",
        "A278AB0D.DisneyMagicKingdoms",
        "A278AB0D.MarchofEmpires",
        "ActiproSoftwareLLC.562882FEEB491", // next one is for the Code Writer from Actipro Software LLC
        "CAF9E577.Plex",  
        "ClearChannelRadioDigital.iHeartRadio",
        "D52A8D61.FarmVille2CountryEscape",
        "D5EA27B7.Duolingo-LearnLanguagesforFree",
        "DB6EA5DB.CyberLinkMediaSuiteEssentials",
        "DolbyLaboratories.DolbyAccess",
        "DolbyLaboratories.DolbyAccess",
        "Drawboard.DrawboardPDF",
        "Facebook.Facebook",
        "Fitbit.FitbitCoach",
        "Flipboard.Flipboard",
        "GAMELOFTSA.Asphalt8Airborne",
        "KeeperSecurityInc.Keeper",
        "Microsoft.BingNews",
        "NORDCURRENT.COOKINGFEVER",
        "PandoraMediaInc.29680B314EFC2",
        "Playtika.CaesarsSlotsFreeCasino",
        "ShazamEntertainmentLtd.Shazam",
        "SpotifyAB.SpotifyMusic",
        "TheNewYorkTimes.NYTCrossword",
        "ThumbmunkeysLtd.PhototasticCollage",
        "TuneIn.TuneInRadio",
        "WinZipComputing.WinZipUniversal",
        "XINGAG.XING",
        "flaregamesGmbH.RoyalRevolt2",
        "king.com.*",
        "king.com.BubbleWitch3Saga",
        "king.com.CandyCrushSaga",
        "king.com.CandyCrushSodaSaga",
        "king.com.FarmHeroesSaga"
        // apps which cannot be removed using Remove-AppxPackage
        //"Microsoft.BioEnrollment",
        //"Microsoft.MicrosoftEdge",
        //"Microsoft.Windows.Cortana",
        //"Microsoft.WindowsFeedback",
        //"Microsoft.XboxGameCallableUI",
        //"Microsoft.XboxIdentityProvider",
        //"Windows.ContactSupport",

        // apps which other apps depend on
        //"Microsoft.Advertising.Xaml",
        };

        public static string[] CDM  = {
        "ContentDeliveryAllowed",
        "FeatureManagementEnabled",
        "OemPreInstalledAppsEnabled",
        "PreInstalledAppsEnabled",
        "PreInstalledAppsEverEnabled",
        "SilentInstalledAppsEnabled",
        "SubscribedContent-314559Enabled",
        "SubscribedContent-338387Enabled",
        "SubscribedContent-338388Enabled",
        "SubscribedContent-338389Enabled",
        "SubscribedContent-338393Enabled",
        "SubscribedContentEnabled",
        "SystemPaneSuggestionsEnabled"
        };
    }
}
