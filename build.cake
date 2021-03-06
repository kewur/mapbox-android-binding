#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=2.0.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var VERSION = "8.5.1";
var NUGET_SUFIX = ".0";

var GESTURES_VERSION = "0.5.1";
var GESTURES_NUGET_SUFIX=".1";

var ACCOUNTS_VERSION = "0.2.0";
var ACCOUNTS_NUGET_SUFIX=".0";

var OFFLINE_VERSION = "0.6.0";
var OFFLINE_NUGET_SUFIX=".0";

var ANNOTATION_VERSION="0.7.0";
var ANNOTATION_NUGET_SUFIX=".2";

var BUILDING_VERSION="0.6.0";
var BUILDING_NUGET_SUFIX="";

var LOCALIZATION_VERSION="0.11.0";
var LOCALIZATION_NUGET_SUFIX="";

var MARKERVIEW_VERSION="0.3.0";
var MARKERVIEW_NUGET_SUFIX="";

var PLACES_VERSION="0.9.0";
var PLACES_NUGET_SUFIX="";

var SCALEBAR_VERSION="0.3.0";
var SCALEBAR_NUGET_SUFIX="";

var TRAFFIC_VERSION="0.9.0";
var TRAFFIC_NUGET_SUFIX="";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var artifacts = new [] {
    // new Artifact {
    //     Version =GESTURES_VERSION + GESTURES_NUGET_SUFIX,
    //     NativeVersion = GESTURES_VERSION,
    //     ReleaseNotes = new string [] 
    //     {
    //         string.Format("Mapbox for Android Gestures - v{0}", GESTURES_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxGestures.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapboxgestures.nuspec",
    //     DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-gestures/{0}/mapbox-android-gestures-{0}.aar",
    //     JarPath = "./Naxam.MapboxGestures.Droid/Jars/mapbox-android-gestures.aar"
    //  },
    // new Artifact {
    //     Version =ACCOUNTS_VERSION + ACCOUNTS_NUGET_SUFIX,
    //     NativeVersion = ACCOUNTS_VERSION,
    //     ReleaseNotes = new string [] 
    //     {
    //         string.Format("Mapbox for Android Accounts - v{0}", ACCOUNTS_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = ".Naxam.MapboxAccounts.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapboxaccounts.nuspec",
    //     DownloadUrl = "http://jcenter.bintray.com/com/mapbox/mapboxsdk/mapbox-android-accounts/{0}/mapbox-android-accounts-{0}.aar",
    //     JarPath = "./Naxam.MapboxAccounts.Droid/Jars/mapbox-android-accounts.aar"
    //  },
    new Artifact {
        Version = VERSION + NUGET_SUFIX,
        NativeVersion = VERSION,
        ReleaseNotes = new string [] {
            string.Format("Mapbox for Android - v{0}", VERSION)
        },
        SolutionPath = "./mapbox-android.sln",
        AssemblyInfoPath = "./Naxam.Mapbox.Droid/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapbox.nuspec",
        DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-sdk/{0}/mapbox-android-sdk-{0}.aar",
        JarPath = "./Naxam.Mapbox.Droid/Jars/mapbox-android-sdk.aar",
        Dependencies = new NuSpecDependency[] {
            new NuSpecDependency {
                Id = "Naxam.MapboxAccounts.Droid",
                Version = ACCOUNTS_VERSION+ACCOUNTS_NUGET_SUFIX
            },
            new NuSpecDependency {
                Id = "Naxam.Mapbox.MapboxAndroidCore",
                Version = "1.3.0"
            },
            new NuSpecDependency {
                Id = "Naxam.MapboxGestures.Droid",
                Version = GESTURES_VERSION+GESTURES_NUGET_SUFIX
            },
            new NuSpecDependency {
                Id = "Naxam.Mapbox.Services.Android.Telemetry",
                Version = "4.5.1"
            },
            new NuSpecDependency {
                Id = "Naxam.MapboxSdkGeojson.Droid",
                Version = "4.9.0"
            },
            new NuSpecDependency {
                Id = "Naxam.MapboxSdkTurf.Droid",
                Version = "4.9.0"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.Fragment",
                Version = "28.0.0.3"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.Annotations",
                Version = "28.0.0.3"
            },
            new NuSpecDependency {
                Id = "Naxam.SoLoader.Droid",
                Version = "0.6.1.2"
            },
        },
    },
    // new Artifact {
    //     Version = OFFLINE_VERSION + OFFLINE_NUGET_SUFIX,
    //     NativeVersion = OFFLINE_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Offline Plugin v{0}", OFFLINE_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxOffline.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-offline-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-offline-v8/{0}/mapbox-android-plugin-offline-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxOffline.Droid/Jars/mapbox-android-plugin-offline-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //             new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.AppCompat",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v4",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.Design",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.Constraint.Layout",
    //             Version = "1.1.2"
    //         },
    //         new NuSpecDependency {
    //             Id = "Naxam.Jakewharton.Timber",
    //             Version = "4.7.1"
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = ANNOTATION_VERSION + ANNOTATION_NUGET_SUFIX,
    //     NativeVersion = ANNOTATION_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Annotation Plugin v{0}", ANNOTATION_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxAnnotation.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-annotation-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-annotation-v8/{0}/mapbox-android-plugin-annotation-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxAnnotation.Droid/Jars/mapbox-android-plugin-annotation-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //             new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.AppCompat",
    //             Version = "28.0.0.3"
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = BUILDING_VERSION + BUILDING_NUGET_SUFIX,
    //     NativeVersion = BUILDING_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Building Plugin v{0}", BUILDING_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxBuilding.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-building-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-building-v8/{0}/mapbox-android-plugin-building-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxBuilding.Droid/Jars/mapbox-android-plugin-building-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //             new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.Annotations",
    //             Version = "28.0.0.3"
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = LOCALIZATION_VERSION + LOCALIZATION_NUGET_SUFIX,
    //     NativeVersion = LOCALIZATION_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Localization Plugin v{0}", LOCALIZATION_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxLocalization.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-localization-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-localization-v8/{0}/mapbox-android-plugin-localization-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxLocalization.Droid/Jars/mapbox-android-plugin-localization-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //             new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.AppCompat",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Naxam.Jakewharton.Timber",
    //             Version = "4.7.1"
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = MARKERVIEW_VERSION + MARKERVIEW_NUGET_SUFIX,
    //     NativeVersion = MARKERVIEW_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - MarkerView Plugin v{0}", MARKERVIEW_NUGET_SUFIX)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxMarkerView.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-markerview-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-markerview-v8/{0}/mapbox-android-plugin-markerview-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxMarkerView.Droid/Jars/mapbox-android-plugin-markerview-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //             new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.AppCompat",
    //             Version = "28.0.0.3"
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = PLACES_VERSION + PLACES_NUGET_SUFIX,
    //     NativeVersion = PLACES_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Places Plugin v{0}", PLACES_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxPlaces.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-places-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-places-v8/{0}/mapbox-android-plugin-places-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxPlaces.Droid/Jars/mapbox-android-plugin-places-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //         new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.AppCompat",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Naxam.Jakewharton.Timber",
    //             Version = "4.7.1"
    //         },
    //         new NuSpecDependency {
    //             Id = "Naxam.MapboxSdkServices.Droid",
    //             Version = "4.9.0"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Arch.Lifecycle.Extensions",
    //             Version = "1.1.1.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Arch.Persistence.Room.Runtime",
    //             Version = "1.1.1.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.CardView",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v7.RecyclerView",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.v4",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.Design",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.Constraint.Layout",
    //             Version = "1.1.2"
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = SCALEBAR_VERSION + SCALEBAR_NUGET_SUFIX,
    //     NativeVersion = SCALEBAR_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Scalebar Plugin v{0}", SCALEBAR_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxScalebar.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-scalebar-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-scalebar-v8/{0}/mapbox-android-plugin-scalebar-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxScalebar.Droid/Jars/mapbox-android-plugin-scalebar-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //         new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //     }
    // },
    // new Artifact {
    //     Version = TRAFFIC_VERSION + TRAFFIC_NUGET_SUFIX,
    //     NativeVersion = TRAFFIC_VERSION,
    //     ReleaseNotes = new string [] {
    //         string.Format("Mapbox for Android - Traffic Plugin v{0}", TRAFFIC_VERSION)
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxTraffic.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapbox-android-plugin-traffic-v8.nuspec",
    //     DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-traffic-v8/{0}/mapbox-android-plugin-traffic-v8-{0}.aar",
    //     JarPath = "./Naxam.MapboxTraffic.Droid/Jars/mapbox-android-plugin-traffic-v8.aar",
    //     Dependencies = new NuSpecDependency[] {
    //             new NuSpecDependency {
    //             Id = "Naxam.Mapbox.Droid",
    //             Version = VERSION + NUGET_SUFIX
    //         },
    //         new NuSpecDependency {
    //             Id = "Xamarin.Android.Support.Annotations",
    //             Version = "28.0.0.3"
    //         },
    //         new NuSpecDependency {
    //             Id = "Naxam.Jakewharton.Timber",
    //             Version = "4.7.1"
    //         },
    //     }
    // },
};

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Downloads")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        var downloadUrl = string.Format(artifact.DownloadUrl, artifact.NativeVersion);
        var jarPath = string.Format(artifact.JarPath, artifact.NativeVersion);

        DownloadFile(downloadUrl, jarPath);
    }
});

Task("Clean")
    .Does(() =>
{
    CleanDirectory("**/*/packages");

    CleanDirectory("./nugets/*");

    var nugetPackages = GetFiles("./nugets/*.nupkg");

    foreach (var package in nugetPackages)
    {
        DeleteFile(package);
    }
});

Task("UpdateVersion")
    .Does(() => 
{
    foreach(var artifact in artifacts) {
        ReplaceRegexInFiles(artifact.AssemblyInfoPath, "\\[assembly\\: AssemblyVersion([^\\]]+)\\]", string.Format("[assembly: AssemblyVersion(\"{0}\")]", artifact.Version));
    }
});

Task("Build")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetRestore(artifact.SolutionPath);
        MSBuild(artifact.SolutionPath, settings => {
            settings.ToolVersion = MSBuildToolVersion.VS2019;
            settings.SetConfiguration(configuration);
            settings.WithTarget("Rebuild");
        });
        break;
    }
});

Task("Pack")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetPack(artifact.NuspecPath, new NuGetPackSettings {
            Version = artifact.Version ,
            Dependencies = artifact.Dependencies,
            ReleaseNotes = artifact.ReleaseNotes,
            OutputDirectory = "./nugets"
        });
    }
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Downloads")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("Build")
    .IsDependentOn("Pack")
    ;

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

class Artifact {
    public string Version { get; set; }
    public string NativeVersion { get; set; }

    public string AssemblyInfoPath { get; set; }

    public string SolutionPath { get; set; }

    public string DownloadUrl  { get; set; }

    public string JarPath { get; set; }

    public string NuspecPath { get; set; }

    public string[] ReleaseNotes { get; set; }

    public NuSpecDependency[] Dependencies { get; set; }
}