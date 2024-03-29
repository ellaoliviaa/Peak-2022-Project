﻿namespace App7

open System
open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

type Resources = App7.Resource

[<Activity (Label = "PEAK", MainLauncher = true, Icon = "@mipmap/icon")>]
type MainActivity () =
    inherit Activity ()

    let mutable count:int = 1

    override this.OnCreate (bundle) =

        base.OnCreate (bundle)

        // Set our view from the "main" layout resource
        this.SetContentView (Resources.Layout.Main)

        // Get our button from the layout resource, and attach an event to it
        let button = this.FindViewById<Button>(Resources.Id.myButton)
        button.Click.Add (fun args -> 
            button.Text <- sprintf "%d investors!" count
            count <- count + 1

        // Centre Label
       
)