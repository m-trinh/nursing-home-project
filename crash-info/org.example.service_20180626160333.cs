S/W Version Information
Model: SM-R365
Tizen-Version: 2.3.1.12
Build-Number: R365XXU2BQJ4
Build-Date: 2017.10.20 15:42:28

Crash Information
Process Name: service
PID: 2866
Date: 2018-06-26 16:03:33-0400
Executable File Path: /opt/usr/apps/org.example.service/bin/service
Signal: 7
      (SIGBUS)
      si_code: 1
      invalid address alignment
      si_addr: 0x16

Register Information
r0   = 0x00000002, r1   = 0x400114f0
r2   = 0x4112226c, r3   = 0x437ba764
r4   = 0xffffffff, r5   = 0xffffffff
r6   = 0x00000000, r7   = 0x437bbb98
r8   = 0x00000000, r9   = 0x4005d13c
r10  = 0x4005d13c, fp   = 0x437bbd5c
ip   = 0x00000000, sp   = 0x437ba7b0
lr   = 0x400553f8, pc   = 0x40000cf4
cpsr = 0x60000030

Memory Information
MemTotal:   492024 KB
MemFree:     80984 KB
Buffers:     28916 KB
Cached:     172912 KB
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
PID = 2866 TID = 2889
2866 2873 2874 2878 2889 

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
40c5c000 414cc000 rw-p [stack:2873]
4179c000 417bd000 rw-p [heap]
417be000 41fbd000 rw-p [stack:2874]
427be000 42fbd000 rw-p [stack:2878]
42fbe000 437bd000 rw-p [stack:2889]
beb83000 beba4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2866)
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
y_visibility_cb(789) > apps,show
06-26 16:03:16.080-0400 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
06-26 16:03:16.080-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x80000
06-26 16:03:16.080-0400 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1483) > is_app_tray_displayed: 1
06-26 16:03:16.080-0400 E/APPS    (  769): apps_main.c: apps_main_resume(682) >  resumed already
06-26 16:03:16.085-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
06-26 16:03:16.090-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppPause(646) > 
06-26 16:03:16.095-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.095-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|BQssJz8fDSo7BAx6JRwzGCA+JwYFEywxIysCXSIiHBsgVRdMOzkuMjMcPB0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw1NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCigzKCx/SA==[0;m
06-26 16:03:16.100-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
06-26 16:03:16.100-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1617) > [1;40;33mPedo client Ref Count [0][0;m
06-26 16:03:16.105-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1636) > [1;40;33mHR client Ref Count [1][0;m
06-26 16:03:16.105-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.110-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.110-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.115-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.115-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.115-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.115-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.115-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.120-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.120-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:03:16.120-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.120-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.120-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.125-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:03:16.125-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 16:03:16.130-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.135-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 16:03:16.140-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BhsvMTwYPDs4FAR7JiI8QDQ5OwYELSh8IDgVAjYfPQk0MBASLDohICcxJBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaRi8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9OBceHwAyJjkNDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0oGisOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQvKi58JQwgDSAHEh4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 16:03:16.140-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_heartrate : com.samsung.watchface][0;m
06-26 16:03:16.145-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.155-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 16:03:16.155-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 16:03:16.155-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.160-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.165-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.165-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|BVMjMSoiI2cvOj57JTIjGTQ5PBESPSckNisNACEiJlQhIwQRLyoEeDMmLB0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw1NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCig8KCx/SA==[0;m
06-26 16:03:16.170-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
06-26 16:03:16.175-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1617) > [1;40;33mPedo client Ref Count [0][0;m
06-26 16:03:16.175-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1636) > [1;40;33mHR client Ref Count [0][0;m
06-26 16:03:16.180-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.180-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.180-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.180-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.180-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.180-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_REMOVE_OBSERVER[0;m
06-26 16:03:16.180-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.185-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.185-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.185-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:03:16.190-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:03:16.190-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:03:16.190-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:03:16.190-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 16:03:16.195-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 16:03:16.195-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BhsvMTwYPDs4FAR7JiI8QDQ5OwYELSh8IDgVAjYfPQk0MBASLDohICcxJBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaRi8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9OBceHwAyJjkNDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0oGisOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQvKi58JQwgDSAHEh4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 16:03:16.205-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 16:03:16.205-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 16:03:16.750-0400 W/AUL_AMD (  543): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-26 16:03:16.750-0400 W/AUL_AMD (  543): amd_launch.c: __grab_timeout_handler(1379) > back key ungrab error
06-26 16:03:20.635-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1098005 button=1
06-26 16:03:20.635-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.635-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:20.635-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,242,216,124]
06-26 16:03:20.655-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.670-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.685-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.685-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:20.695-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.715-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.725-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.745-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.755-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.770-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.770-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.785-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.800-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.815-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.820-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.835-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.850-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.865-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.870-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.885-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.900-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.915-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.930-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.950-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:20.960-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1098331 button=1
06-26 16:03:20.965-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:21.025-0400 E/WMS     (  538): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 16:03:21.540-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1098907 button=1
06-26 16:03:21.540-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.550-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:21.550-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,271,216,124]
06-26 16:03:21.555-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.560-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.560-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:21.580-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.585-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.600-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.610-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:21.630-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1098994 button=1
06-26 16:03:21.630-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:21.690-0400 E/CAPI_MEDIA_CONTROLLER(  867): media_controller_main.c: __mc_main_check_connection(34) > [0m[No-error] Timer is Called but there is working Process, connection_cnt = 3
06-26 16:03:22.450-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 16:03:22.565-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1099937 button=1
06-26 16:03:22.570-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:22.570-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:22.570-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,42,216,124]
06-26 16:03:22.590-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:22.595-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:22.595-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:22.630-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1099998 button=1
06-26 16:03:22.635-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:22.635-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:22.635-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:22.670-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:03:22.695-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:03:23.480-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1100850 button=1
06-26 16:03:23.480-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:23.480-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:23.480-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,16,216,124]
06-26 16:03:23.490-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:23.505-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:23.505-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:23.520-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:23.535-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:23.540-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1100912 button=1
06-26 16:03:23.545-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:24.325-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1101696 button=1
06-26 16:03:24.330-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:24.335-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:24.335-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,242,216,124]
06-26 16:03:24.345-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:24.350-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:24.350-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:24.360-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:24.380-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:24.410-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1101769 button=1
06-26 16:03:24.410-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:24.410-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:25.070-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1102437 button=1
06-26 16:03:25.070-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.075-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:25.075-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,254,216,124]
06-26 16:03:25.080-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.080-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:25.100-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.105-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.115-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1102486 button=1
06-26 16:03:25.120-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:25.805-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1103177 button=1
06-26 16:03:25.805-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.810-0400 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
06-26 16:03:25.810-0400 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(889) >  Find item [0,42,216,124]
06-26 16:03:25.815-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.815-0400 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(674) >  touch cancel
06-26 16:03:25.830-0400 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
06-26 16:03:25.845-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1103213 button=1
06-26 16:03:25.850-0400 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(950) >  (__bTouchCanceled) -> _scrollerMouseUp() return
06-26 16:03:26.195-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 16:03:26.240-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1060): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-26 16:03:26.240-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1060): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-26 16:03:26.245-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1060): preference.c: preference_get_double(1214) > preference_get_double(1060) : pedometer_inactive_period error
06-26 16:03:26.245-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1060): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
06-26 16:03:26.245-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1060): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
06-26 16:03:26.245-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1060): preference.c: preference_get_boolean(1173) > preference_get_boolean(1060) : inactive_test_mode_on error
06-26 16:03:26.245-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:03:26.285-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:03:26.640-0400 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
06-26 16:03:26.640-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [palm]
06-26 16:03:26.640-0400 W/STARTER (  739): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
06-26 16:03:26.645-0400 E/STARTER (  739): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
06-26 16:03:26.645-0400 W/STARTER (  739): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
06-26 16:03:26.645-0400 W/STARTER (  739): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
06-26 16:03:26.660-0400 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-26 16:03:26.660-0400 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
06-26 16:03:26.660-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 16:03:26.660-0400 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
06-26 16:03:26.660-0400 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
06-26 16:03:26.660-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:26.900-0400 I/watchface-viewer(  806): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-26 16:03:26.905-0400 W/SHealth_Common(  833): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:3[0;m
06-26 16:03:26.940-0400 W/SHealth_Common( 1060): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:3[0;m
06-26 16:03:26.940-0400 W/LibServiceCommon( 1060): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(673) > [1;35m ###[0;m
06-26 16:03:26.945-0400 W/LibServiceCommon( 1060): ContinuousHrFeatureController.cpp: Stop(138) > [1;40;33mwas not running[0;m
06-26 16:03:27.015-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [palm]
06-26 16:03:27.015-0400 W/STARTER (  739): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
06-26 16:03:27.015-0400 W/STARTER (  739): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
06-26 16:03:27.015-0400 W/STARTER (  739): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
06-26 16:03:27.100-0400 E/ALARM_MANAGER(  739): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-6-2018, 16:03:47), repeat(1), interval(20), type(-1073741822)
06-26 16:03:27.115-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [739].
06-26 16:03:27.170-0400 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
06-26 16:03:27.170-0400 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-26 16:03:27.170-0400 W/W_HOME  (  769): main.c: _appcore_pause_cb(694) > appcore pause
06-26 16:03:27.170-0400 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
06-26 16:03:27.170-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:27.170-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:27.170-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:03:27.175-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:27.175-0400 E/CAPI_APPFW_APP_CONTROL( 1103): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-26 16:03:27.175-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-service.c: _music_control_service_pasre_request(489) > [33m[TID:1103]   [com.samsung.w-home]register msg port [false][0m
06-26 16:03:27.205-0400 E/ALARM_MANAGER(  539): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1847585148, next duetime: 1530043427
06-26 16:03:27.210-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __alarm_add_to_list(485) > [alarm-server]: After add alarm_id(1847585148)
06-26 16:03:27.210-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __alarm_create(1050) > [alarm-server]:alarm_context.c_due_time(1530058560), due_time(1530043427)
06-26 16:03:27.210-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-26 16:03:27.210-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 26-6-2018, 20:03:47 (UTC).
06-26 16:03:27.210-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-26 16:03:27.680-0400 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
06-26 16:03:27.870-0400 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
06-26 16:03:27.870-0400 I/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
06-26 16:03:27.870-0400 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 16:03:27.870-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 16:03:27.870-0400 I/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
06-26 16:03:27.875-0400 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-26 16:03:27.875-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_set(165) > timer set
06-26 16:03:27.875-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 16:03:27.875-0400 W/W_HOME  (  769): gesture.c: _apps_status_get(126) > apps status:0
06-26 16:03:27.875-0400 W/W_HOME  (  769): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:1 info->offtime:1129
06-26 16:03:27.875-0400 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
06-26 16:03:27.875-0400 W/W_HOME  (  769): event_manager.c: _lcd_on_cb(696) > lcd state: 1
06-26 16:03:27.875-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:27.885-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [1129]ms
06-26 16:03:27.885-0400 W/STARTER (  739): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
06-26 16:03:27.930-0400 W/W_HOME  (  769): gesture.c: _widget_updated_cb(194) > widget updated
06-26 16:03:27.930-0400 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 16:03:27.930-0400 W/W_HOME  (  769): gesture.c: _manual_render(180) > 
06-26 16:03:27.975-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [739].
06-26 16:03:27.975-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __alarm_remove_from_list(564) > [alarm-server]:Remove alarm id(1847585148)
06-26 16:03:27.975-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-26 16:03:27.975-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 27-6-2018, 00:16:00 (UTC).
06-26 16:03:27.975-0400 E/ALARM_MANAGER(  539): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-26 16:03:27.975-0400 E/ALARM_MANAGER(  539): alarm-manager.c: alarm_manager_alarm_delete(2457) > alarm_id[1847585148] is removed.
06-26 16:03:28.010-0400 W/W_HOME  (  769): gesture.c: _manual_render(180) > 
06-26 16:03:28.025-0400 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 0
06-26 16:03:28.025-0400 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESUME State: PAUSED
06-26 16:03:28.025-0400 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-26 16:03:28.025-0400 W/W_HOME  (  769): main.c: _appcore_resume_cb(685) > appcore resume
06-26 16:03:28.025-0400 W/W_HOME  (  769): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
06-26 16:03:28.025-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:28.025-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:28.025-0400 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-26 16:03:28.025-0400 W/APPS    (  769): apps_main.c: _time_changed(303) >  date : 26->26
06-26 16:03:28.025-0400 W/SHealth_Common(  833): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 16:03:28.030-0400 I/watchface-viewer(  806): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
06-26 16:03:28.040-0400 W/W_INDICATOR(  740): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(374) > [_windicator_dbus_lcd_changed_cb:374] 374, str=[powerkey],charge : 0, connected : 0
06-26 16:03:28.075-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
06-26 16:03:28.075-0400 W/STARTER (  739): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
06-26 16:03:28.080-0400 W/SHealth_Common( 1060): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 16:03:28.080-0400 W/LibServiceCommon( 1060): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(673) > [1;35m ###[0;m
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 16:03:29.035-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:03:29.100-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:03:29.100-0400 E/CAPI_APPFW_APP_CONTROL( 1103): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-26 16:03:29.105-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-service.c: _music_control_service_pasre_request(489) > [33m[TID:1103]   [com.samsung.w-home]register msg port [true][0m
06-26 16:03:29.130-0400 W/AUL_AMD (  543): amd_request.c: __request_handler(645) > __request_handler: 14
06-26 16:03:29.175-0400 W/AUL_AMD (  543): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
06-26 16:03:29.190-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.190-0400 E/WMS     (  538): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 16:03:29.215-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1103]   [MUSIC_PLAYER_EVENT][0m
06-26 16:03:29.220-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 16:03:29.225-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:03:29.240-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.240-0400 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:unknown 
06-26 16:03:29.240-0400 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-26 16:03:29.250-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1103]   [MUSIC_PLAYER_EVENT][0m
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 16:03:29.250-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:03:29.260-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.260-0400 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:unknown 
06-26 16:03:29.260-0400 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 16:03:29.265-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:03:29.275-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:03:32.395-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 16:03:32.500-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:03:32.540-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:03:33.945-0400 W/CRASH_MANAGER( 2988): worker.c: worker_job(1205) > 0702866736572153004341
