namespace IRLBR.Droid
open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.Runtime
open Android.Views
open Android.Widget
open Android.OS
open Xamarin.Forms.Platform.Android
open Microsoft.WindowsAzure.MobileServices

type Resources = IRLBR.Droid.Resource

[<Activity (Label = "IRLBR.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type MainActivity() =
    inherit FormsAppCompatActivity()

    override this.OnCreate (bundle: Bundle) =
        FormsAppCompatActivity.TabLayoutResource <- Resources.Layout.Tabbar
        FormsAppCompatActivity.ToolbarResource <- Resources.Layout.Toolbar

        base.OnCreate (bundle)
        do CurrentPlatform.Init()
        
        Xamarin.Forms.Forms.Init (this, bundle)

        this.LoadApplication (new IRLBR.App ())
