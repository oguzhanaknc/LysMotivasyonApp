using Android.App;
using Android.Widget;
using Android.OS;
using Com.OneSignal;
namespace LysMotivasyonApp
{
    [Activity(Label = "LysMotivasyonApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            OneSignal.Current.StartInit("91b11581-860b-4522-a067-b51434368542")
                  .EndInit();
        }
    }
}

