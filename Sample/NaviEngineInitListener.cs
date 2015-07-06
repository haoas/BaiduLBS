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

namespace Sample
{
    /// <summary>
    /// µ¼º½ÒýÇæ³õÊ¼¼àÌýÆ÷
    /// </summary>
    public class NaviEngineInitListener : Java.Lang.Object, Com.Baidu.Navisdk.BNaviEngineManager.INaviEngineInitListener
    {
        private bool mIsEngineInitSuccess;

        public void EngineInitFail()
        {

        }

        public void EngineInitStart()
        {

        }

        public void EngineInitSuccess()
        {
            mIsEngineInitSuccess = true;
        }

        public bool IsEngineInitSuccess
        {
            get
            {
                return mIsEngineInitSuccess;
            }
        }
    }
}