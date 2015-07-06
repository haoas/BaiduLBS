using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Baidu.Navisdk;
using System.Threading.Tasks;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private string GetSdcardDir()
        {
            if (Android.OS.Environment.ExternalStorageState == Android.OS.Environment.MediaMounted)
            {
                return Android.OS.Environment.ExternalStorageDirectory.ToString();
            }
            return null;
        }
        private NaviEngineInitListener mNaviEngineInitListener = new NaviEngineInitListener();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            BaiduNaviManager.Instance.InitEngine(this, GetSdcardDir(), mNaviEngineInitListener, "YrGwj0myYvfsiwdVulXy7xLq", new BNKeyVerifyListener());

            SetContentView(Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.MyButton).Click += (e, s) =>
            {
                if (mNaviEngineInitListener.IsEngineInitSuccess)
                {
                    Intent intent = new Intent(this, typeof(RouteGuideDemo));
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "导航未初始化", ToastLength.Long).Show();
                }
            };
        }
    }
}

