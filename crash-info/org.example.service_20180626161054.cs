S/W Version Information
Model: SM-R365
Tizen-Version: 2.3.1.12
Build-Number: R365XXU2BQJ4
Build-Date: 2017.10.20 15:42:28

Crash Information
Process Name: service
PID: 3367
Date: 2018-06-26 16:10:54-0400
Executable File Path: /opt/usr/apps/org.example.service/bin/service
Signal: 7
      (SIGBUS)
      si_code: 1
      invalid address alignment
      si_addr: 0x16

Register Information
r0   = 0x00000002, r1   = 0x40011480
r2   = 0x411ea759, r3   = 0x43853764
r4   = 0xffffffff, r5   = 0xffffffff
r6   = 0x00000000, r7   = 0x43854b98
r8   = 0x00000000, r9   = 0x4005d13c
r10  = 0x4005d13c, fp   = 0x43854d5c
ip   = 0x00000000, sp   = 0x438537b0
lr   = 0x400553f8, pc   = 0x40000c88
cpsr = 0x60000030

Memory Information
MemTotal:   492024 KB
MemFree:     78520 KB
Buffers:     30112 KB
Cached:     173908 KB
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
PID = 3367 TID = 3394
3367 3378 3379 3383 3394 

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
41035000 41056000 rw-p [heap]
41057000 41856000 rw-p [stack:3378]
41857000 42056000 rw-p [stack:3379]
42857000 43056000 rw-p [stack:3383]
43057000 43856000 rw-p [stack:3394]
beba0000 bebc1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3367)
Call Stack Count: 2
 0: threadproc + 0x83 (0x40000c88) [/opt/usr/apps/org.example.service/bin/service] + 0xc88
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
th_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:27.965-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:27.965-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:27.975-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:27.975-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:27.975-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 16:10:27.980-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:10:27.985-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:27.985-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:27.985-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:10:27.990-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.005-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 16:10:28.005-0400 W/SHealth_Common(  833): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 16:10:28.045-0400 W/STARTER (  739): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
06-26 16:10:28.045-0400 W/STARTER (  739): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
06-26 16:10:28.055-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.075-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.080-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 16:10:28.085-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BhsvMTwYPDs4FAR7JiI8QDQ5OwYELSh8IDgVAjYfPQk0MBASLDohICcxJBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaRi8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9OBceHwAyJjkNDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0oGisOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQvKi58JQwgDSAHEh4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 16:10:28.105-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.110-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 16:10:28.115-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 16:10:28.115-0400 W/SHealth_Common( 1060): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 16:10:28.120-0400 W/LibServiceCommon( 1060): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(673) > [1;35m ###[0;m
06-26 16:10:28.120-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.130-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 16:10:28.130-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_pedometer_info|Bgw/PCgPO2csAz43JiU3GDQHNwYGPSB4NzgKEDV6MQ0gIBQULyktJzMhAjcDNCwLLj4/CSAvHiQ0LxEbCiAZHwk4JC8SNCp6JDkFOCcwKC0JNiQrJgM4PC8mCigSWysxF14AHzU/CSkvCiQ0IQcKXyoLKT84N14SNCoKKy8JOC4EOC0JNiY8FyFKJwYFJicnKCwTNCwLLhUjMgovAQI0LxIgKyIOKQk3NC8SNAh4KwESLj0hCDt9EQM2JTg4NAUmCigKHiEoNBoHKy4ZBSAvJSQ0LxIgPzYOKQlNNC8SNxEvLjs/Gl5+HjYQPQcNVRQTNC8MCigKKBoOHyw9IisvPywvClg=[0;m
06-26 16:10:28.140-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_pedometer_info : com.samsung.watchface][0;m
06-26 16:10:28.140-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.160-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 16:10:28.165-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 16:10:28.170-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [4990][0;m
06-26 16:10:28.175-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.185-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 16:10:28.190-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|EgsGJyoxBWIvFAR+JiUgQCApOFkELSB6NwUSXCMcNlI3ChMOLzkqeSQfAh0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw6NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCigzKCx/SA==[0;m
06-26 16:10:28.195-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
06-26 16:10:28.200-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:10:28.210-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.215-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:10:28.230-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 16:10:28.235-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 16:10:28.240-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1617) > [1;40;33mPedo client Ref Count [1][0;m
06-26 16:10:28.240-0400 W/LibServiceCommon( 1060): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1636) > [1;40;33mHR client Ref Count [1][0;m
06-26 16:10:28.245-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:28.245-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:28.245-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:28.245-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:28.245-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:28.245-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:28.250-0400 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 16:10:28.250-0400 E/watchface-loader(  806): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 16:10:28.250-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=right ']
06-26 16:10:28.255-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 32x40
06-26 16:10:28.255-0400 I/watchface-viewer(  806): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(565) > ImagesLoadingDoneSignal().Emit()
06-26 16:10:28.260-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:28.260-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:28.260-0400 I/watchface-viewer(  806): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
06-26 16:10:28.260-0400 W/healthData(  806): health_fw_share.c: __health_notify_share_cb(333) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
06-26 16:10:28.265-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:10:28.265-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 16:10:28.265-0400 W/SHealth_Common( 1060): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 16:10:28.270-0400 W/SHealth_Common( 1060): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 16:10:28.270-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 16:10:28.280-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 16:10:28.280-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BhsvMTwYPDs4FAR7JiI8QDQ5OwYELSh8IDgVAjYfPQk0MBASLDohICcxJBUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaRi8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwY9OBceHwAyJjkNDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0oGisOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQvKi58JQwgDSAHEh4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 16:10:28.285-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_heartrate : com.samsung.watchface][0;m
06-26 16:10:28.295-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=right ']
06-26 16:10:28.295-0400 I/watchface-viewer(  806): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 32x40
06-26 16:10:28.295-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 16:10:28.295-0400 I/watchface-viewer(  806): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(565) > ImagesLoadingDoneSignal().Emit()
06-26 16:10:28.295-0400 W/SHealth_Common( 1060): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 16:10:28.305-0400 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 16:10:28.305-0400 W/HealthDataService(  776): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_pedometer_info|Bgw/PCgPO2csAz43JiU3GDQHNwYGPSB4NzgKEDV6MQ0gIBQULyktJzMhAjcDNCwLLj4/CSAvHiQ0LxEbCiAZHwk4JC8SNCp6JDkFOCcwKC0JNiQrJgM4PC8mCigSWysxF14AHzU/CSkvCiQ0IQcKXyoLKT84N14SNCoKKy8JOC4EOC0JNiY8FyFKJwYFJicnKCwTNCwLLhUjMgovAQI0LxIgKyIOKQk3NC8SNAh4KwESLj0hCDt9EQM2JTg4NAUmCigKHiEoNBoHKy4ZBSAvJSQ0LxIgPzYOKQlNNC8SNxEvLjs/Gl5+HjYQPQcNVRQTNC8MCigKKBoOHyw9IisvPywvClg=[0;m
06-26 16:10:28.315-0400 W/HealthDataService(  776): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[shealth_pedometer_info : com.samsung.watchface][0;m
06-26 16:10:28.335-0400 I/healthData( 1060): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 16:10:28.865-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:28.865-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:28.870-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:28.870-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:10:28.870-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:10:28.870-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:28.870-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 16:10:28.870-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:28.885-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-26 16:10:28.890-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:10:28.890-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:10:28.890-0400 E/CAPI_APPFW_APP_CONTROL( 1103): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-26 16:10:28.890-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-service.c: _music_control_service_pasre_request(489) > [33m[TID:1103]   [com.samsung.w-home]register msg port [true][0m
06-26 16:10:28.920-0400 W/AUL_AMD (  543): amd_request.c: __request_handler(645) > __request_handler: 14
06-26 16:10:28.945-0400 W/AUL_AMD (  543): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
06-26 16:10:28.960-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:28.985-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1103]   [MUSIC_PLAYER_EVENT][0m
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 16:10:28.990-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:10:28.995-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:28.995-0400 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:unknown 
06-26 16:10:28.995-0400 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-26 16:10:29.000-0400 W/MUSIC_CONTROL_SERVICE( 1103): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1103]   [MUSIC_PLAYER_EVENT][0m
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 16:10:29.005-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:10:29.015-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:29.015-0400 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:remote state:unknown 
06-26 16:10:29.015-0400 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-26 16:10:29.020-0400 I/MESSAGE_PORT(  501): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-26 16:10:31.965-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:31.970-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1529178
06-26 16:10:31.970-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:31.980-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1529335
06-26 16:10:31.980-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:31.980-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:31.980-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:31.980-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:31.980-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:31.980-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:31.995-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:33.760-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:33.765-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1530987
06-26 16:10:33.765-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:33.770-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1531128
06-26 16:10:33.770-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:33.770-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:33.770-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:33.770-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:33.770-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:33.770-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:33.790-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:35.440-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:35.440-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:35.445-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1532657
06-26 16:10:35.445-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1532807
06-26 16:10:35.445-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:35.445-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:35.445-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:35.445-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:35.445-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:35.445-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:35.480-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:36.915-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:36.920-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:36.920-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1534104
06-26 16:10:36.920-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1534283
06-26 16:10:36.920-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:36.920-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:36.920-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:36.925-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:36.925-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:36.925-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:36.945-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:37.210-0400 E/WMS     (  538): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 16:10:38.105-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 16:10:38.180-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:10:38.190-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:10:38.320-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:38.320-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1535507
06-26 16:10:38.320-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:38.325-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1535690
06-26 16:10:38.325-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:38.325-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:38.325-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:38.325-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:38.325-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:38.325-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:38.340-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:38.340-0400 E/WMS     (  538): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 16:10:39.655-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:39.660-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1536831
06-26 16:10:39.660-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:39.670-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1537022
06-26 16:10:39.675-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:39.675-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:39.675-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:39.675-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:39.675-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:39.675-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:39.685-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:40.895-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:40.900-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1538062
06-26 16:10:40.900-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:40.900-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1538266
06-26 16:10:40.900-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:40.900-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:40.900-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:40.900-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:40.900-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:40.900-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:40.915-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:42.115-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:42.115-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:42.120-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1539290
06-26 16:10:42.120-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1539482
06-26 16:10:42.120-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:42.120-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:42.120-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:42.120-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:42.120-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:42.120-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:42.140-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:43.305-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:43.305-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:43.305-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1540477
06-26 16:10:43.305-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1540667
06-26 16:10:43.305-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:43.305-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:43.305-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:43.310-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:43.310-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:43.310-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:43.320-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:44.475-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:44.475-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1541652
06-26 16:10:44.475-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:44.480-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1541846
06-26 16:10:44.480-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:44.480-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:44.480-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:44.480-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:44.480-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:44.480-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:44.495-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:45.715-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:45.720-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1542888
06-26 16:10:45.720-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:45.720-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1543086
06-26 16:10:45.720-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:45.720-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:45.720-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:45.720-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:45.720-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:45.720-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:45.735-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:47.005-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:47.005-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1544156
06-26 16:10:47.005-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:47.010-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1544371
06-26 16:10:47.010-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:47.010-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:47.010-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:47.010-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:47.010-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:47.010-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:47.040-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:48.000-0400 E/WMS     (  538): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 16:10:48.060-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [4990][0;m
06-26 16:10:48.080-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:10:48.095-0400 W/LibServiceCommon( 1060): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 16:10:48.105-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:48.105-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1545288
06-26 16:10:48.110-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:48.115-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1545475
06-26 16:10:48.115-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:48.115-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:48.115-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:48.115-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:48.115-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:48.115-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:48.130-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:49.245-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:49.245-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:49.250-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1546401
06-26 16:10:49.250-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1546612
06-26 16:10:49.250-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:49.250-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:49.250-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:49.250-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:49.250-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:49.250-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:49.270-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:50.485-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:50.485-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:50.490-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1547637
06-26 16:10:50.490-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1547852
06-26 16:10:50.490-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:50.490-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:50.490-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:50.490-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:50.490-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:50.490-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:50.510-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:51.650-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:51.655-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:51.655-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1548815
06-26 16:10:51.655-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1549018
06-26 16:10:51.655-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:51.655-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:51.655-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:51.660-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:51.660-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:51.660-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:51.690-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:52.760-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:52.765-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1549960
06-26 16:10:52.765-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:52.780-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1550131
06-26 16:10:52.780-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:52.780-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:52.780-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:52.780-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:52.780-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:52.780-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:52.805-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:54.020-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3142) > Deliver KeyPress
06-26 16:10:54.025-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1551188
06-26 16:10:54.025-0400 W/KEYROUTER(  420): e_mod_main.c: DeliverDeviceKeyEvents(3153) > Deliver KeyRelease
06-26 16:10:54.030-0400 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1551391
06-26 16:10:54.030-0400 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40000
06-26 16:10:54.030-0400 W/W_HOME  (  769): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
06-26 16:10:54.030-0400 E/W_HOME  (  769): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
06-26 16:10:54.030-0400 W/W_HOME  (  769): main.c: _back_key_cb(1612) > Home Key operation tutorial:0 window:1 clock:1 apps:0
06-26 16:10:54.030-0400 W/W_HOME  (  769): main.c: _back_key_cb(1629) > emit:signal => key,back,clicked
06-26 16:10:54.035-0400 W/W_HOME  (  769): clock_event.c: _back_key_cb(286) > 
06-26 16:10:54.050-0400 W/WATCH_CORE(  806): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
06-26 16:10:55.130-0400 W/CRASH_MANAGER( 3584): worker.c: worker_job(1205) > 0703367736572153004385
