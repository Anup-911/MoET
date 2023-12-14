package com.caesiumlab.alphareturns;

import com.moengage.unity.wrapper.MoEInitializer;
import com.moengage.core.MoEngage;
import com.moengage.core.DataCenter;
import com.moengage.core.config.LogConfig;
import com.moengage.core.LogLevel;
import com.caesiumlab.mylib.R;
import com.moengage.core.config.NotificationConfig;
import com.moengage.pushbase.MoEPushHelper;

import com.moengage.core.config.FcmConfig;

public class MyApp extends android.app.Application {

    @Override
    public void onCreate() {
        super.onCreate();
        
        MoEngage.Builder moEngage = new MoEngage.Builder(this, "X4XEW5AQPPYFZ7XAVMAZ8BU4",  DataCenter.DATA_CENTER_4)
                                                //.configureFcm(new FcmConfig(false))
                                                .configureNotificationMetaData(new NotificationConfig(R.drawable.ic_small, R.drawable.ic_large))
                                                .configureLogs(new LogConfig(LogLevel.VERBOSE, true));
        MoEInitializer.INSTANCE.initialiseDefaultInstance(getApplicationContext(), moEngage);
        
        //val moEngage = MoEngage.Builder(this, "X4XEW5AQPPYFZ7XAVMAZ8BU4",DataCenter.DATA_CENTER_4)
  
        //MoEInitializer.initialize(getApplicationContext(), moEngage)
    }
}