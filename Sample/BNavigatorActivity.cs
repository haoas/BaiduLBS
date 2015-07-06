using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Baidu.Nplatform.Comapi.Map;
using Com.Baidu.Navisdk;
using Com.Baidu.Navisdk.UI.Routeguide;
using Com.Baidu.Navisdk.Comapi.Mapcontrol;

namespace Sample
{
    [Activity(Label = "BNavigatorActivity")]
    public class BNavigatorActivity : Activity
    {
        private BNavigatorListener mBNavigatorListener;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            mBNavigatorListener = new BNavigatorListener(this);

            MapGLSurfaceView nMapView = BaiduNaviManager.Instance.CreateNMapView(this);
            View navigatorView = BNavigator.Instance.Init(this, Intent.Extras, nMapView);
            SetContentView(navigatorView);

            BNavigator.Instance.SetListener(mBNavigatorListener);
            BNavigator.Instance.StartNav();


        }

        protected override void OnResume()
        {
            BNavigator.Instance.Resume();
            base.OnResume();
            BNMapController.Instance.OnResume();
        }

        protected override void OnPause()
        {
            BNavigator.Instance.Pause();
            base.OnPause();
            BNMapController.Instance.OnPause();
        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            BNavigator.Instance.OnConfigurationChanged(newConfig);
            base.OnConfigurationChanged(newConfig);
        }

        public override void OnBackPressed()
        {
            BNavigator.Instance.OnBackPressed();
        }

        protected override void OnDestroy()
        {
            BNavigator.Destory();
            base.OnDestroy();
        }
    }
}