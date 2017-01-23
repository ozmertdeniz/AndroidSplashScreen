
using Android.App;
using Android.OS;

namespace AndroidSplashScreen.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, Label = "AndroidSplash", Icon = "@drawable/icon")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
         // System.Threading.Thread.Sleep(1500);
            this.StartActivity(typeof(MainActivity));
        }
    }
}