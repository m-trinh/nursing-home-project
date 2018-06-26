S/W Version Information
Model: SM-R365
Tizen-Version: 2.3.1.12
Build-Number: R365XXU2BQJ4
Build-Date: 2017.10.20 15:42:28

Crash Information
Process Name: service
PID: 2208
Date: 2018-06-26 15:57:33-0400
Executable File Path: /opt/usr/apps/org.example.service/bin/service
Signal: 7
      (SIGBUS)
      si_code: 1
      invalid address alignment
      si_addr: 0x16

Register Information
r0   = 0x00000002, r1   = 0x400114f0
r2   = 0x41153281, r3   = 0x436fd764
r4   = 0xffffffff, r5   = 0xffffffff
r6   = 0x00000000, r7   = 0x436feb98
r8   = 0x00000000, r9   = 0x4005d13c
r10  = 0x4005d13c, fp   = 0x436fed5c
ip   = 0x00000000, sp   = 0x436fd7b0
lr   = 0x400553f8, pc   = 0x40000cf4
cpsr = 0x60000030

Memory Information
MemTotal:   492024 KB
MemFree:     85680 KB
Buffers:     27636 KB
Cached:     171356 KB
VmPeak:      55464 KB
VmSize:      55460 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4844 KB
VmRSS:        4844 KB
VmData:      43088 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       10464 KB
VmPTE:          28 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2208 TID = 2235
2208 2219 2220 2224 2235 

Maps Information
40000000 40002000 r-xp /opt/usr/apps/org.example.service/bin/service
40004000 40008000 r-xp /usr/lib/libsys-assert.so
40012000 4002f000 r-xp /lib/ld-2.13.so
4004b000 4005f000 r-xp /lib/libpthread-2.13.so
4006a000 4006d000 r-xp /usr/lib/libappcore-agent.so.1.1
40075000 40079000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
40082000 400c6000 r-xp /usr/lib/libcurl.so.4.3.0
400cf000 401ea000 r-xp /lib/libc-2.13.so
401f8000 40200000 r-xp /lib/libgcc_s-4.6.so.1
40201000 4020c000 r-xp /lib/libunwind.so.8.0.1
40239000 4023b000 r-xp /lib/libdl-2.13.so
40244000 40250000 r-xp /usr/lib/libaul.so.0.1.0
4025a000 4025c000 r-xp /usr/lib/libdlog.so.0.0.0
40264000 40268000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40271000 4027a000 r-xp /usr/lib/libvconf.so.0.2.45
40282000 40299000 r-xp /usr/lib/libecore.so.1.7.99
402b0000 402f1000 r-xp /usr/lib/libeina.so.1.7.99
402fa000 40324000 r-xp /usr/lib/libsensor.so.2.3.4
4032d000 403c1000 r-xp /usr/lib/libstdc++.so.6.0.16
403d4000 4043d000 r-xp /lib/libm-2.13.so
40446000 4044f000 r-xp /usr/lib/libcares.so.2.1.0
40458000 40486000 r-xp /usr/lib/libidn.so.11.5.44
4048e000 404d5000 r-xp /usr/lib/libssl.so.1.0.0
404e1000 4068a000 r-xp /usr/lib/libcrypto.so.1.0.0
406ab000 406c1000 r-xp /lib/libz.so.1.2.5
406c9000 406cc000 r-xp /usr/lib/libbundle.so.0.1.22
406d4000 406eb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
406f3000 4071d000 r-xp /usr/lib/libdbus-1.so.3.8.12
40726000 4072b000 r-xp /usr/lib/libxdgmime.so.1.1.0
40733000 40756000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4075e000 4079a000 r-xp /usr/lib/libsystemd.so.0.4.0
407a3000 407a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
407b0000 40880000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40881000 40887000 r-xp /usr/lib/libappsvc.so.0.1.0
4088f000 40895000 r-xp /lib/librt-2.13.so
4089e000 40971000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
4097c000 409b0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
409b9000 409bf000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
409c8000 409d2000 r-xp /usr/lib/libsensord-shared.so
409db000 409f1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
409fa000 40a6f000 r-xp /usr/lib/libsqlite3.so.0.8.6
40a79000 40a91000 r-xp /usr/lib/liblzma.so.5.0.3
40a99000 40b15000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b21000 40b31000 r-xp /lib/libresolv-2.13.so
40b35000 40b36000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40b3e000 40b43000 r-xp /usr/lib/libffi.so.5.0.10
40b4b000 40b4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40b56000 40c22000 r-xp /usr/lib/libxml2.so.2.7.8
40c2f000 40c31000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
40c3a000 40c3c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
40c44000 40c4f000 r-xp /usr/lib/libgpg-error.so.0.15.0
40ddb000 40dfc000 rw-p [heap]
40dfd000 415fc000 rw-p [stack:2219]
415fd000 41dfc000 rw-p [stack:2220]
42701000 42f00000 rw-p [stack:2224]
42f01000 43700000 rw-p [stack:2235]
bed7a000 bed9b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2208)
Call Stack Count: 2
 0: threadproc + 0x83 (0x40000cf4) [/opt/usr/apps/org.example.service/bin/service] + 0xcf4
 1: (0x40051d30) [/lib/libpthread.so.0] + 0x6d30
End of Call Stack

Package Information
Package Name: org.example.service
Package ID : org.example.service
Version: 1.0.0
Package Type: rpm
App Name: service
App ID: org.example.service
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
Size [0][0;m
06-26 15:57:05.575-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:57:05.575-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 15:57:05.585-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 15:57:05.585-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BiY/fyhHPDo7BAw3JTI7HCApNF8RPTh7NigKXCEfIQsgDRtLOCkyeSYPKBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaQC8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9PF0eMTIzJzkvDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0qLCsOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQsFAR7JhwaRSM5JB4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 15:57:05.595-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 15:57:05.595-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 15:57:05.825-0400 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
06-26 15:57:10.390-0400 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
06-26 15:57:11.045-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:57:11.180-0400 W/SHealth_Common( 1060): TimelineSessionStorage.cpp: OnTriggered(1292) > [1;40;33mlocalStartTime: 1529971200000.000000[0;m
06-26 15:57:11.245-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
06-26 15:57:11.255-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
06-26 15:57:20.300-0400 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
06-26 15:57:20.300-0400 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
06-26 15:57:20.300-0400 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 15:57:20.305-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 15:57:20.305-0400 I/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
06-26 15:57:20.330-0400 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
06-26 15:57:20.330-0400 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
06-26 15:57:20.360-0400 W/W_HOME  (  769): gesture.c: _widget_updated_cb(194) > widget updated
06-26 15:57:20.365-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 15:57:20.365-0400 W/W_HOME  (  769): gesture.c: _manual_render(180) > 
06-26 15:57:20.385-0400 W/W_HOME  (  769): gesture.c: _manual_render(180) > 
06-26 15:57:20.405-0400 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 0
06-26 15:57:20.420-0400 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
06-26 15:57:20.420-0400 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-26 15:57:20.420-0400 I/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
06-26 15:57:20.420-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_set(165) > timer set
06-26 15:57:20.420-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 15:57:20.425-0400 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 15:57:20.425-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 15:57:20.425-0400 I/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
06-26 15:57:20.425-0400 W/W_HOME  (  769): gesture.c: _apps_status_get(126) > apps status:0
06-26 15:57:20.425-0400 W/W_HOME  (  769): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:1 info->offtime:15460
06-26 15:57:20.425-0400 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
06-26 15:57:20.425-0400 W/W_HOME  (  769): event_manager.c: _lcd_on_cb(696) > lcd state: 1
06-26 15:57:20.425-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:57:20.425-0400 W/W_INDICATOR(  740): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(374) > [_windicator_dbus_lcd_changed_cb:374] 374, str=[gesture],charge : 0, connected : 0
06-26 15:57:20.430-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [15460]ms
06-26 15:57:20.430-0400 W/STARTER (  739): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
06-26 15:57:20.435-0400 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESUME State: PAUSED
06-26 15:57:20.435-0400 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-26 15:57:20.435-0400 W/W_HOME  (  769): main.c: _appcore_resume_cb(685) > appcore resume
06-26 15:57:20.435-0400 W/W_HOME  (  769): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
06-26 15:57:20.435-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:57:20.440-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:57:20.440-0400 W/W_HOME  (  769): main.c: home_resume(733) > journal_appcore_app_fully_loaded called
06-26 15:57:20.440-0400 W/W_HOME  (  769): main.c: home_resume(737) > clock/widget resumed
06-26 15:57:20.440-0400 W/W_HOME  (  769): clock_indicator.c: clock_indicator_resume(548) > 
06-26 15:57:20.450-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:57:20.460-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_resume(1039) > widget_resume
06-26 15:57:20.460-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppResume(654) > 
06-26 15:57:20.475-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.475-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|BlM7eD8xLD8uOS0nMgw8RiBhOBISWysiIygCESIyPlU3DRQTOAMuPCYPCh0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw6NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCig8KCx/SA==[0;m
06-26 15:57:20.480-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
06-26 15:57:20.505-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.520-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.520-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1617) > [1;40;33mPedo client Ref Count [1][0;m
06-26 15:57:20.530-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1636) > [1;40;33mHR client Ref Count [0][0;m
06-26 15:57:20.530-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.550-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.565-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.565-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.565-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.565-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.565-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.565-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.565-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.575-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.575-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.580-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.580-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:57:20.585-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.585-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.585-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:57:20.585-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 15:57:20.600-0400 W/SHealth_Common(  833): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 15:57:20.625-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
06-26 15:57:20.625-0400 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 0
06-26 15:57:20.625-0400 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
06-26 15:57:20.625-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
06-26 15:57:20.625-0400 W/STARTER (  739): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
06-26 15:57:20.640-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 15:57:20.640-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BiY/fyhHPDo7BAw3JTI7HCApNF8RPTh7NigKXCEfIQsgDRtLOCkyeSYPKBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaQC8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9PF0eMTIzJzkvDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0qLCsOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQsFAR7JhwaRSM5JB4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 15:57:20.650-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.660-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.670-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 15:57:20.675-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.675-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 15:57:20.680-0400 W/SHealth_Common( 1060): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 15:57:20.680-0400 W/LibServiceCommon( 1060): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(673) > [1;35m ###[0;m
06-26 15:57:20.690-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.700-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 15:57:20.705-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_pedometer_info|BiU3eCsPNDkvKj0lJh8sDTQ5HlgSPSMgNjgSWiMfMhkhMxtNOikuMTAfDjcDNCwLLj4/CSAvHiQ0LxEbCiAZHwk4JC8SNCp6JDkFOCcwKC0JNiQrJgM4PC8mCigSWysxF14AHzU/CSkvCiQ0IQcGFyoLKT84N14SNCoKKy8JOC4EOC0JNiY8FyFKJwYFJicnKCwTNCwLLhUjMgovAQI0LxIgKyIOKQk3NC8SNAh4KwESLj0hCDt9EQM2JTg4NAUmCigKHiEoNBoHKy4ZBSAvJSQ0LxIgPzYOKQlNNC8SNxEvLjs/Gl5+HjYQPQcNVRQTNC8MCigKKBoOHyw9IisvPywvClg=[0;m
06-26 15:57:20.710-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_pedometer_info : com.samsung.watchface][0;m
06-26 15:57:20.710-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.715-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 15:57:20.720-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 15:57:20.730-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.745-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.750-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:57:20.755-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.755-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|EgsGJyoxBWIvFAR+JiUgQCApOFkELSB6NwUSXCMcNlI3ChMOLzkqeSQfAh0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw6NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCigzKCx/SA==[0;m
06-26 15:57:20.760-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
06-26 15:57:20.765-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:57:20.775-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.790-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1617) > [1;40;33mPedo client Ref Count [1][0;m
06-26 15:57:20.790-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1636) > [1;40;33mHR client Ref Count [1][0;m
06-26 15:57:20.795-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:57:20.800-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.800-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.800-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.805-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.805-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.805-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.810-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:57:20.820-0400 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 15:57:20.820-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 15:57:20.820-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=right ']
06-26 15:57:20.820-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 32x40
06-26 15:57:20.825-0400 I/watchface-viewer(  806): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(565) > ImagesLoadingDoneSignal().Emit()
06-26 15:57:20.825-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.825-0400 I/watchface-viewer(  806): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
06-26 15:57:20.825-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.830-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:57:20.830-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=left ']
06-26 15:57:20.835-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 48x40
06-26 15:57:20.835-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:57:20.840-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:57:20.845-0400 I/watchface-viewer(  806): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(565) > ImagesLoadingDoneSignal().Emit()
06-26 15:57:20.850-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:57:20.850-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 15:57:20.865-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 15:57:20.865-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BiY/fyhHPDo7BAw3JTI7HCApNF8RPTh7NigKXCEfIQsgDRtLOCkyeSYPKBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaQC8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9PF0eMTIzJzkvDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0qLCsOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQsFAR7JhwaRSM5JB4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 15:57:20.880-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_heartrate : com.samsung.watchface][0;m
06-26 15:57:20.885-0400 W/healthData(  806): health_fw_share.c: __health_notify_share_cb(333) > [1;40;33mNotification is called [category:shealth_heartrate][0;m
06-26 15:57:20.885-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=right ']
06-26 15:57:20.885-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 15:57:20.885-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 32x40
06-26 15:57:20.885-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 15:57:20.890-0400 I/watchface-viewer(  806): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(565) > ImagesLoadingDoneSignal().Emit()
06-26 15:57:20.900-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 15:57:20.900-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_pedometer_info|BiU3eCsPNDkvKj0lJh8sDTQ5HlgSPSMgNjgSWiMfMhkhMxtNOikuMTAfDjcDNCwLLj4/CSAvHiQ0LxEbCiAZHwk4JC8SNCp6JDkFOCcwKC0JNiQrJgM4PC8mCigSWysxF14AHzU/CSkvCiQ0IQcGFyoLKT84N14SNCoKKy8JOC4EOC0JNiY8FyFKJwYFJicnKCwTNCwLLhUjMgovAQI0LxIgKyIOKQk3NC8SNAh4KwESLj0hCDt9EQM2JTg4NAUmCigKHiEoNBoHKy4ZBSAvJSQ0LxIgPzYOKQlNNC8SNxEvLjs/Gl5+HjYQPQcNVRQTNC8MCigKKBoOHyw9IisvPywvClg=[0;m
06-26 15:57:20.910-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_pedometer_info : com.samsung.watchface][0;m
06-26 15:57:20.920-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 15:57:21.395-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:21.395-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:21.405-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=738563
06-26 15:57:21.405-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=738761
06-26 15:57:21.405-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:21.405-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:21.405-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:21.405-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:21.405-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:21.405-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:21.420-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.455-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 15:57:21.460-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 15:57:21.460-0400 E/CAPI_APPFW_APP_CONTROL( 1103): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-26 15:57:21.460-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-service.c: _music_control_service_pasre_request(489) > [33m[TID:1103]   [com.samsung.w-home]register msg port [true][0m
06-26 15:57:21.465-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.465-0400 W/AUL_AMD (  543): amd_request.c: __request_handler(645) > __request_handler: 14
06-26 15:57:21.485-0400 W/AUL_AMD (  543): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
06-26 15:57:21.495-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1103]   [MUSIC_PLAYER_EVENT][0m
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 15:57:21.505-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.505-0400 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:unknown 
06-26 15:57:21.505-0400 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-26 15:57:21.510-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1103]   [MUSIC_PLAYER_EVENT][0m
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 15:57:21.510-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.510-0400 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:unknown 
06-26 15:57:21.510-0400 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 15:57:21.515-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 15:57:21.690-0400 E/CAPI_MEDIA_CONTROLLER(  867): media_controller_main.c: __mc_main_check_connection(34) > [0m[No-error] Timer is Called but there is working Process, connection_cnt = 3
06-26 15:57:22.685-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:22.685-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:22.690-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=739854
06-26 15:57:22.690-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=740056
06-26 15:57:22.690-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:22.690-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:22.690-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:22.690-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:22.690-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:22.690-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:22.720-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:23.945-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:23.950-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=741097
06-26 15:57:23.950-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:23.950-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=741316
06-26 15:57:23.950-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:23.950-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:23.955-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:23.955-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:23.955-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:23.955-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:23.965-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:25.320-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:25.320-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=742457
06-26 15:57:25.320-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:25.330-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=742686
06-26 15:57:25.335-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:25.335-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:25.335-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:25.335-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:25.345-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:25.345-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:25.360-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:26.890-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:26.890-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=744048
06-26 15:57:26.895-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:26.895-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=744261
06-26 15:57:26.900-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:26.900-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:26.900-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:26.900-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:26.900-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:26.900-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:26.915-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:27.685-0400 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
06-26 15:57:27.685-0400 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
06-26 15:57:28.140-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:28.145-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=745284
06-26 15:57:28.145-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:28.150-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=745506
06-26 15:57:28.155-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:28.155-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:28.155-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:28.155-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:28.155-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:28.155-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:28.175-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:29.400-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:29.400-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=746551
06-26 15:57:29.400-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:29.415-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=746766
06-26 15:57:29.415-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:29.415-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:29.415-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:29.415-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:29.415-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:29.415-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:29.435-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:29.465-0400 E/WMS     (  538): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 15:57:30.580-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 15:57:30.625-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:57:30.660-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:30.660-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=747807
06-26 15:57:30.665-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:30.670-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=748031
06-26 15:57:30.670-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:30.670-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:30.670-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:30.670-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:30.670-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:30.670-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:30.670-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:57:30.685-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:31.915-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:31.915-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:31.915-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=749062
06-26 15:57:31.915-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=749281
06-26 15:57:31.920-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:31.920-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:31.925-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:31.925-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:31.925-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:31.925-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:31.945-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:33.270-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 15:57:33.270-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 15:57:33.270-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=750407
06-26 15:57:33.270-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=750636
06-26 15:57:33.270-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 15:57:33.270-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 15:57:33.270-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 15:57:33.270-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 15:57:33.270-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 15:57:33.270-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 15:57:33.295-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 15:57:34.125-0400 W/CRASH_MANAGER( 2356): worker.c: worker_job(1205) > 0702208736572153004305
