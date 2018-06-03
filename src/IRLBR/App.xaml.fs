namespace IRLBR

open System
open Xamarin.Forms
open Xamarin.Auth


type Constants =
    static member Scope = "profile"
    static member AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth"
    static member AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token"
    static member clientId = "1053012469782-cq3lpcp9051ne51eoj2pslfeaqrioe8p.apps.googleusercontent.com"

type App() =
    inherit Application(MainPage = MainPage())



    override this.OnStart() =
        let authenticator = new OAuth2Authenticator(
                                Constants.clientId,
                                null,
                                Constants.Scope,
                                new Uri(Constants.AuthorizeUrl),
                                new Uri(redirectUri),
                                new Uri(Constants.AccessTokenUrl),
                                null,
                                true)
        ignore()
                              