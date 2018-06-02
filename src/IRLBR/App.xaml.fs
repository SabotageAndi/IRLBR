namespace IRLBR

open Xamarin.Forms
open Microsoft.WindowsAzure.MobileServices

type App() =
    inherit Application(MainPage = MainPage())


    override this.OnStart() =
        let mobileService = new MobileServiceClient("MOBILE_APP_URL")
        ignore()


