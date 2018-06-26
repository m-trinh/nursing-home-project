S/W Version Information
Model: SM-R365
Tizen-Version: 2.3.1.12
Build-Number: R365XXU2BQJ4
Build-Date: 2017.10.20 15:42:28

Crash Information
Process Name: service
PID: 16940
Date: 2018-06-26 15:43:33-0400
Executable File Path: /opt/usr/apps/org.example.service/bin/service
Signal: 7
      (SIGBUS)
      si_code: 1
      invalid address alignment
      si_addr: 0x16

Register Information
r0   = 0x00000002, r1   = 0x400114f0
r2   = 0x40ea61bc, r3   = 0x42efd764
r4   = 0xffffffff, r5   = 0xffffffff
r6   = 0x00000000, r7   = 0x42efeb98
r8   = 0x00000000, r9   = 0x4005d13c
r10  = 0x4005d13c, fp   = 0x42efed5c
ip   = 0x00000000, sp   = 0x42efd7b0
lr   = 0x400553f8, pc   = 0x40000cf4
cpsr = 0x60000030

Memory Information
MemTotal:   492024 KB
MemFree:      8396 KB
Buffers:     55760 KB
Cached:     164824 KB
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
PID = 16940 TID = 16962
16940 16947 16948 16962 16963 

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
40c5c000 4145b000 rw-p [stack:16947]
4145c000 41cce000 rw-p [stack:16948]
41ce1000 41d02000 rw-p [heap]
42701000 42f00000 rw-p [stack:16962]
42f01000 43700000 rw-p [stack:16963]
beb25000 beb46000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16940)
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
wapps_install_res(2786) > send_install_response completed : END
06-26 15:43:00.929-0400 E/WMS     (  548): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7317) > queued event count[0]
06-26 15:43:00.964-0400 E/EFL     (16919): elementary<16919> elm_config.c:2755 _elm_config_init() _elm_config_init step 2 done.
06-26 15:43:00.964-0400 E/EFL     (16919): elementary<16919> elm_config.c:2759 _elm_config_init() _elm_config_init step 3 done.
06-26 15:43:00.969-0400 E/EFL     (16919): elementary<16919> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-26 15:43:01.004-0400 E/EFL     (16919): elementary<16919> elm_config.c:2799 _elm_config_sub_init() ecore_x_init done.
06-26 15:43:01.014-0400 E/EFL     (16919): elementary<16919> elm_config.c:2854 _elm_config_sub_init() _config_sub_apply done.
06-26 15:43:01.014-0400 E/EFL     (16919): elementary<16919> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-26 15:43:01.019-0400 E/EFL     (16919): elementary<16919> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-26 15:43:01.019-0400 E/EFL     (16919): elementary<16919> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-26 15:43:01.019-0400 E/EFL     (16919): elementary<16919> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-26 15:43:01.019-0400 E/EFL     (16919): elementary<16919> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-26 15:43:01.019-0400 I/AUL_PAD (16919): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-26 15:43:02.104-0400 E/rpm-installer(16908): rpm-appcore-intf.c: main(273) > ------------------------------------------------
06-26 15:43:02.104-0400 E/rpm-installer(16908): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
06-26 15:43:02.104-0400 E/rpm-installer(16908): rpm-appcore-intf.c: main(275) > ------------------------------------------------
06-26 15:43:02.144-0400 E/PKGMGR_SERVER(16907): pkgmgr-server.c: sighandler(409) > child NORMAL exit [16908]
06-26 15:43:02.179-0400 E/PKGMGR_SERVER(16907): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
06-26 15:43:02.179-0400 E/PKGMGR_SERVER(16907): pkgmgr-server.c: main(2221) > package manager server terminated.
06-26 15:43:02.194-0400 E/RESOURCED(  552): procfs.c: proc_get_oom_score_adj(162) > fopen /proc/16908/oom_score_adj failed
06-26 15:43:02.194-0400 E/RESOURCED(  552): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 16908
06-26 15:43:03.349-0400 W/AUL     (16939): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.service)
06-26 15:43:03.354-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 0
06-26 15:43:03.379-0400 I/AUL_AMD (  551): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
06-26 15:43:03.394-0400 I/AUL_AMD (  551): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
06-26 15:43:03.394-0400 E/AUL_AMD (  551): amd_launch.c: _start_app(1703) > no caller appid info, ret: -1
06-26 15:43:03.394-0400 W/AUL_AMD (  551): amd_launch.c: _start_app(1713) > caller pid : 16939
06-26 15:43:03.404-0400 W/AUL_AMD (  551): amd_launch.c: start_process(581) > child process: 16940
06-26 15:43:03.444-0400 E/CAPI_APPFW_APPLICATION(16940): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-26 15:43:03.444-0400 E/CAPI_APPFW_APPLICATION(16940): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-26 15:43:03.459-0400 W/AUL_AMD (  551): amd_launch.c: __send_app_launch_signal(380) > send launch signal done: 16940
06-26 15:43:03.459-0400 E/RESOURCED(  552): proc-main.c: proc_add_app_list(272) > not found previous pai : org.example.service
06-26 15:43:03.459-0400 E/RESOURCED(  552): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.service
06-26 15:43:03.459-0400 W/AUL     (16939): launch.c: app_request_to_launchpad(282) > request cmd(0) result(16940)
06-26 15:43:03.479-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 14
06-26 15:43:03.484-0400 W/AUL_AMD (  551): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16940
06-26 15:43:03.484-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 14
06-26 15:43:03.494-0400 W/AUL_AMD (  551): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16940
06-26 15:43:03.494-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 12
06-26 15:43:03.494-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 12
06-26 15:43:03.504-0400 W/AUL_AMD (  551): amd_status.c: __socket_monitor_cb(1292) > (16940) was created
06-26 15:43:11.554-0400 W/W_INDICATOR(  727): windicator_moment_view.c: _watch_battery_capacity_cb(1470) > [_watch_battery_capacity_cb:1470] percentage 94
06-26 15:43:11.564-0400 E/RESOURCED(  552): heart-battery.c: heart_battery_cal_charging_rem_time(1490) > data_avail_chg = 1, index_chg = 0
06-26 15:43:11.564-0400 E/RESOURCED(  552): heart-battery.c: heart_battery_cal_charging_rem_time(1492) > last_wall_time_chg = 1530042110, curr_wall_time = 1530042191
06-26 15:43:11.564-0400 E/RESOURCED(  552): heart-battery.c: heart_battery_cal_charging_rem_time(1493) > time diff before averaging = 81 seconds
06-26 15:43:11.564-0400 E/RESOURCED(  552): heart-battery.c: heart_battery_get_time_diff_avg(1231) > time_diff after averaging= 83 seconds
06-26 15:43:11.564-0400 E/RESOURCED(  552): heart-battery.c: heart_battery_cal_charging_rem_time(1524) > Capacity = 94, charging remaining time = 8 minutes
06-26 15:43:11.574-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(163) > [wnidicator_moment_view_battery_image_update:163] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
06-26 15:43:11.574-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(167) > [wnidicator_moment_view_battery_image_update:167] [SHOW charging icon] Connected / not Full / not charge -1
06-26 15:43:11.579-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(180) > [wnidicator_moment_view_battery_image_update:180] battery level 94, index 18, bg level 90
06-26 15:43:11.579-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(184) > [wnidicator_moment_view_battery_image_update:184] Battery signal emit : bg_level_90
06-26 15:43:11.579-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(230) > [wnidicator_moment_view_battery_image_update:230] Battery level : 94
06-26 15:43:11.589-0400 E/EFL     (  727): edje<727> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.min'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-26 15:43:28.399-0400 W/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
06-26 15:43:28.399-0400 I/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
06-26 15:43:28.404-0400 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 15:43:28.404-0400 E/watchface-loader(  816): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 15:43:28.404-0400 I/watchface-loader(  816): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
06-26 15:43:28.404-0400 E/BASE_UTILS(  816): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
06-26 15:43:28.404-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-26 15:43:28.404-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 188x105
06-26 15:43:28.414-0400 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
06-26 15:43:28.414-0400 W/W_HOME  (  776): gesture.c: _manual_render_schedule(212) > schedule, manual render
06-26 15:43:28.424-0400 E/BASE_UTILS(  816): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
06-26 15:43:28.439-0400 W/SHealth_Common(  840): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 15:43:28.479-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-26 15:43:28.479-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 188x105
06-26 15:43:28.509-0400 E/BASE_UTILS(  816): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
06-26 15:43:28.509-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-26 15:43:28.519-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 188x105
06-26 15:43:28.519-0400 E/BASE_UTILS(  816): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
06-26 15:43:28.544-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(866) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-26 15:43:28.544-0400 I/watchface-viewer(  816): viewer-part-resource-evas.cpp: CreateTextImage(880) > formatted size 188x105
06-26 15:43:28.549-0400 W/W_CLOCK_VIEWER(15915): clock-viewer.c: __clock_viewer_lcdon_cb(415) >  event lcdon[1][0]
06-26 15:43:28.549-0400 W/W_CLOCK_VIEWER(15915): clock-viewer.c: __clock_viewer_lcdon_cb(425) >  Exit from charger alpm mode
06-26 15:43:28.549-0400 E/EFL     (15915): ecore<15915> ecore.c:573 _ecore_magic_fail() 
06-26 15:43:28.549-0400 E/EFL     (15915): *** ECORE ERROR: Ecore Magic Check Failed!!!
06-26 15:43:28.549-0400 E/EFL     (15915): *** IN FUNCTION: ecore_timer_del()
06-26 15:43:28.549-0400 E/EFL     (15915): ecore<15915> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
06-26 15:43:28.549-0400 E/EFL     (15915): ecore<15915> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
06-26 15:43:28.549-0400 E/EFL     (15915): *** SPANK SPANK SPANK!!!
06-26 15:43:28.549-0400 E/EFL     (15915): *** Now go fix your code. Tut tut tut!
06-26 15:43:28.549-0400 W/W_CLOCK_VIEWER(15915): clock-viewer.c: _clock_viewer_set_black_cover(967) >  Set black cover[1] ani[0]
06-26 15:43:28.574-0400 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-26 15:43:28.574-0400 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_set(165) > timer set
06-26 15:43:28.574-0400 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 15:43:28.574-0400 W/W_HOME  (  776): gesture.c: _apps_status_get(126) > apps status:0
06-26 15:43:28.574-0400 W/W_HOME  (  776): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:1511438
06-26 15:43:28.574-0400 W/W_HOME  (  776): gesture.c: _manual_render_schedule(212) > schedule, manual render
06-26 15:43:28.574-0400 W/W_HOME  (  776): event_manager.c: _lcd_on_cb(696) > lcd state: 1
06-26 15:43:28.574-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:28.574-0400 W/STARTER (  724): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [1511438]ms
06-26 15:43:28.574-0400 W/STARTER (  724): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[1]
06-26 15:43:28.589-0400 I/watchface-viewer(  816): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(565) > ImagesLoadingDoneSignal().Emit()
06-26 15:43:28.589-0400 I/watchface-viewer(  816): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
06-26 15:43:28.594-0400 W/SHealth_Common( 1073): SystemUtil.cpp: OnDeviceStatusChanged(1010) > [1;35mlcdState:1[0;m
06-26 15:43:28.594-0400 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
06-26 15:43:28.594-0400 I/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
06-26 15:43:28.594-0400 W/LibServiceCommon( 1073): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(673) > [1;35m ###[0;m
06-26 15:43:28.594-0400 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-26 15:43:28.594-0400 E/watchface-loader(  816): watchface-loader.cpp: OnAppTimeTick(673) > 
06-26 15:43:28.594-0400 I/watchface-loader(  816): watchface-loader.cpp: OnAppTimeTick(684) > set force update!!
06-26 15:43:28.599-0400 W/LibServiceCommon( 1073): ContinuousHrFeatureController.cpp: OnSystemUtilLcdStateChanged(269) > [1;40;33m# 1534919[0;m
06-26 15:43:28.599-0400 W/LibServiceCommon( 1073): ContinuousHrRawDataController.cpp: Flush(72) > [1;35m#[0;m
06-26 15:43:28.599-0400 W/LibServiceCommon( 1073): ContinuousHRController.cpp: OnContinuousHRDataUpdated(67) > [1;40;33m1 min binning heart rate value is [0][0;m
06-26 15:43:28.599-0400 W/LibServiceCommon( 1073): ContinuousSyncDataController.cpp: ForceFlush(68) > [1;40;33mForce flush[0;m
06-26 15:43:28.599-0400 W/LibServiceCommon( 1073): ContinuousSyncDataController.cpp: CreateRecord(115) > [1;40;33m1530039600000.000000 1530042208604.000000[0;m
06-26 15:43:28.609-0400 W/LibServiceCommon( 1073): ContinuousSyncDataController.cpp: CreateRecord(120) > [1;40;33mempty continuous HR raw[0;m
06-26 15:43:28.614-0400 W/SHealth_Common( 1073): TimelineSessionStorage.cpp: OnTriggered(1292) > [1;40;33mlocalStartTime: 1529971200000.000000[0;m
06-26 15:43:28.619-0400 E/WMS     (  548): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23262) > _wms_event_handler_cb_nomove_detector is called
06-26 15:43:28.634-0400 W/W_HOME  (  776): gesture.c: _widget_updated_cb(194) > widget updated
06-26 15:43:28.634-0400 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
06-26 15:43:28.634-0400 W/W_HOME  (  776): gesture.c: _manual_render(180) > 
06-26 15:43:28.699-0400 W/W_HOME  (  776): gesture.c: _manual_render(180) > 
06-26 15:43:28.709-0400 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 0
06-26 15:43:28.724-0400 W/W_CLOCK_VIEWER(15915): clock-viewer.c: __clock_viewer_lcdon_completed_cb(477) >  event lcdon completed[1]
06-26 15:43:28.724-0400 W/W_CLOCK_VIEWER(15915): clock-viewer.c: __clock_viewer_lcdon_completed_cb(481) >  Exit from charger alpm mode
06-26 15:43:28.724-0400 W/W_CLOCK_VIEWER(15915): clock-viewer.c: _clock_viewer_send_clock_changed(1087) >  clock changed <<
06-26 15:43:28.729-0400 W/STARTER (  724): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
06-26 15:43:28.744-0400 W/STARTER (  724): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[1]
06-26 15:43:28.759-0400 E/ALARM_MANAGER(  549): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [15915].
06-26 15:43:28.759-0400 E/ALARM_MANAGER(  549): alarm-manager.c: __alarm_remove_from_list(564) > [alarm-server]:Remove alarm id(319799037)
06-26 15:43:28.759-0400 E/ALARM_MANAGER(  549): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-26 15:43:28.759-0400 E/ALARM_MANAGER(  549): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 27-6-2018, 00:16:00 (UTC).
06-26 15:43:28.759-0400 E/ALARM_MANAGER(  549): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-26 15:43:28.759-0400 E/ALARM_MANAGER(  549): alarm-manager.c: alarm_manager_alarm_delete(2457) > alarm_id[319799037] is removed.
06-26 15:43:28.789-0400 E/EFL     (15915): edje<15915> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'opr_info_bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-26 15:43:28.999-0400 W/SHealth_Common( 1073): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
06-26 15:43:29.004-0400 W/LibServiceCommon( 1073): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-26 15:43:29.009-0400 I/APP_CORE(  727): appcore-efl.c: __do_app(429) > [APP 727] Event: RESUME State: PAUSED
06-26 15:43:29.009-0400 I/CAPI_APPFW_APPLICATION(  727): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-26 15:43:29.044-0400 I/W_INDICATOR(  727): windicator_brightness.c: _current_device_brightness_level_get(94) > [_current_device_brightness_level_get:94] Brightness level : 80
06-26 15:43:29.044-0400 W/W_INDICATOR(  727): windicator_brightness.c: windicator_brightness_update(292) > [windicator_brightness_update:292] current device brightness level : 80 / isOutdoorMode : 0
06-26 15:43:29.044-0400 W/W_INDICATOR(  727): windicator_brightness.c: windicator_brightness_update(301) > [windicator_brightness_update:301] NOT Outdoor mode
06-26 15:43:29.049-0400 W/W_INDICATOR(  727): windicator_brightness.c: windicator_brightness_icon_set_by_level(271) > [windicator_brightness_icon_set_by_level:271] layout(0x4450bf48) signal name : brightness.icon.7
06-26 15:43:29.049-0400 E/W_INDICATOR(  727): windicator_util.c: _ecore_event_client_message_cb(1017) > [_ecore_event_client_message_cb:1017] _ecore_event_client_message_cb
06-26 15:43:29.064-0400 E/EFL     (  727): edje<727> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-26 15:43:29.074-0400 W/wnotib  (  776): w-notification-board-broker-main.c: _wnb_charger_status_changed_cb(439) > 
06-26 15:43:29.074-0400 W/wnotib  (  776): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1753) > num_categoreis: 0
06-26 15:43:29.074-0400 I/wnotib  (  776): w-notification-board-panel-summary.c: _wnb_summary_draw_dynamic_empty_view(1715) > Use existing dynamic_empty_view.
06-26 15:43:29.084-0400 E/WMS     (  548): wms_event_handler.c: _wms_event_handler_cb_charger_status(8239) > Charging status changed[0]
06-26 15:43:29.084-0400 W/STARTER (  724): clock-mgr.c: _charger_status_setting_changed_cb(890) > [_charger_status_setting_changed_cb:890] charger status is changed to [0] ambient[0]
06-26 15:43:29.084-0400 W/AUL     (  724): launch.c: app_request_to_launchpad(268) > request cmd(4) to(15915)
06-26 15:43:29.089-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 4
06-26 15:43:29.099-0400 W/AUL_AMD (  551): amd_launch.c: __reply_handler(925) > listen fd(23) , send fd(22), pid(15915), cmd(4)
06-26 15:43:29.099-0400 I/APP_CORE(15915): appcore-efl.c: __do_app(429) > [APP 15915] Event: TERMINATE State: RUNNING
06-26 15:43:29.099-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 22
06-26 15:43:29.099-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(916) > app status : 4
06-26 15:43:29.099-0400 E/APP_CORE(15915): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
06-26 15:43:29.099-0400 I/APP_CORE(15915): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
06-26 15:43:29.099-0400 I/CAPI_APPFW_APPLICATION(15915): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
06-26 15:43:29.104-0400 W/AUL     (  724): launch.c: app_request_to_launchpad(282) > request cmd(4) result(0)
06-26 15:43:29.119-0400 I/SCONTEXT-LIB(15915): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 45
06-26 15:43:29.174-0400 W/wnotib  (  776): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1774) > current_summary_type: 2, new_summary_type: 2
06-26 15:43:29.259-0400 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
06-26 15:43:29.264-0400 W/W_HOME  (  776): dbox.c: _dbus_rotation_cb(1349) > angle changed:0
06-26 15:43:29.289-0400 W/W_INDICATOR(  727): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(374) > [_windicator_dbus_lcd_changed_cb:374] 374, str=[gesture],charge : 1, connected : 1
06-26 15:43:29.289-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(163) > [wnidicator_moment_view_battery_image_update:163] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
06-26 15:43:29.299-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(167) > [wnidicator_moment_view_battery_image_update:167] [SHOW charging icon] Connected / not Full / not charge -1
06-26 15:43:29.299-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(180) > [wnidicator_moment_view_battery_image_update:180] battery level 94, index 18, bg level 90
06-26 15:43:29.299-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(184) > [wnidicator_moment_view_battery_image_update:184] Battery signal emit : bg_level_90
06-26 15:43:29.304-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(230) > [wnidicator_moment_view_battery_image_update:230] Battery level : 94
06-26 15:43:29.309-0400 W/W_INDICATOR(  727): windicator_moment_view.c: indicator_get_time_by_region(1114) > [indicator_get_time_by_region:1114] DATE & TIME is / en_US / 3:43  /4 / h:mm
06-26 15:43:29.309-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1221) > [windicator_clock_changed_cb:1221] [Time] PM / 3:43
06-26 15:43:29.314-0400 W/LibServiceCommon( 1073): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [4690][0;m
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1230) > [windicator_clock_changed_cb:1230] Not Korean
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1241) > [windicator_clock_changed_cb:1241] ptr1 : 3
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1250) > [windicator_clock_changed_cb:1250] ptr2 : 43
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1269) > [windicator_clock_changed_cb:1269] [Time] hour :  3
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1274) > [windicator_clock_changed_cb:1274] [Time] min :  43
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1281) > [windicator_clock_changed_cb:1281] [Time] 3 / 43 / 3:43
06-26 15:43:29.314-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_clock_changed_cb(1343) > [windicator_clock_changed_cb:1343] Show AMPM (1)
06-26 15:43:29.319-0400 W/W_INDICATOR(  727): windicator_battery.c: windicator_battery_icon_update(331) > [windicator_battery_icon_update:331] 94%
06-26 15:43:29.319-0400 E/EFL     (  727): <727> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
06-26 15:43:29.319-0400 W/W_INDICATOR(  727): windicator_battery.c: windicator_battery_icon_update(341) > [windicator_battery_icon_update:341] battery_level: 94, isCharging: 0
06-26 15:43:29.319-0400 W/W_INDICATOR(  727): windicator_battery.c: windicator_battery_icon_update(376) > [windicator_battery_icon_update:376] [SIGNAL] battery file : change_level_95
06-26 15:43:29.324-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(163) > [wnidicator_moment_view_battery_image_update:163] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
06-26 15:43:29.324-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(172) > [wnidicator_moment_view_battery_image_update:172] [HIDE charging icon] Not connected or Battery full (5)
06-26 15:43:29.324-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(180) > [wnidicator_moment_view_battery_image_update:180] battery level 94, index 18, bg level 90
06-26 15:43:29.324-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(184) > [wnidicator_moment_view_battery_image_update:184] Battery signal emit : bg_level_90
06-26 15:43:29.334-0400 W/W_INDICATOR(  727): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(230) > [wnidicator_moment_view_battery_image_update:230] Battery level : 94
06-26 15:43:29.334-0400 W/W_INDICATOR(  727): windicator_battery.c: _battery_charging_changed_cb(119) > [_battery_charging_changed_cb:119] Hide Moment View (unconnected)
06-26 15:43:29.334-0400 W/W_INDICATOR(  727): windicator_battery.c: _battery_charging_changed_cb(129) > [_battery_charging_changed_cb:129] moment view timer will be created.
06-26 15:43:29.344-0400 I/SCONTEXT-LIB(15915): comm.c: disconnect_dbus(105) > Disconnecting Dbus
06-26 15:43:29.379-0400 W/LibServiceCommon( 1073): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:43:29.399-0400 W/W_INDICATOR(  727): windicator_moment_view.c: windicator_moment_view_charging_watch_window_show(1379) > [windicator_moment_view_charging_watch_window_show:1379] windicator_moment_view_charging_watch_window_show
06-26 15:43:29.404-0400 E/EFL     (  727): edje<727> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.min'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-26 15:43:29.434-0400 W/LibServiceCommon( 1073): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-26 15:43:29.459-0400 W/W_INDICATOR(  727): windicator_battery.c: _battery_charger_status_changed_cb(178) > [_battery_charger_status_changed_cb:178] Hide Moment View (unconnected)
06-26 15:43:29.459-0400 W/W_INDICATOR(  727): windicator_battery.c: _battery_charger_status_changed_cb(188) > [_battery_charger_status_changed_cb:188] moment view timer was created.
06-26 15:43:29.484-0400 W/SHealth_Common( 1073): TimelineSessionStorage.cpp: OnTriggered(1292) > [1;40;33mlocalStartTime: 1529971200000.000000[0;m
06-26 15:43:29.509-0400 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 15915 pgid = 15915
06-26 15:43:29.509-0400 E/DATA_PROVIDER_MASTER(  736): client_life.c: client_deactivated_by_fault(494) > Client[0x42df9240] is faulted(1), pid(15915)
06-26 15:43:29.524-0400 W/SHealth_Common( 1073): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
06-26 15:43:29.539-0400 W/SHealth_Common( 1073): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
06-26 15:43:29.564-0400 W/W_INDICATOR(  727): windicator_dbus.c: _rotation_set(801) > [_rotation_set:801] [ROTATION] ROT_CHANGE, state:1 angle:0 / is_connected : 0
06-26 15:43:29.569-0400 E/W_INDICATOR(  727): windicator_dbus.c: _rotation_set(809) > [_rotation_set:809] [ROTATION] DBus rotation callback error
06-26 15:43:29.589-0400 E/RESOURCED(  552): procfs.c: proc_get_oom_score_adj(162) > fopen /proc/15915/oom_score_adj failed
06-26 15:43:29.589-0400 E/RESOURCED(  552): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 15915
06-26 15:43:29.634-0400 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
06-26 15:43:29.639-0400 E/STARTER (  724): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.39/src/starter.c:241:E] w-clock-viewer (pid:15915) is destroyed. ambient mode[0], charging[0], sports mode[0]
06-26 15:43:29.639-0400 W/STARTER (  724): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
06-26 15:43:29.639-0400 I/AUL_AMD (  551): amd_main.c: __app_dead_handler(263) > __app_dead_handler, pid: 15915
06-26 15:43:29.654-0400 E/RESOURCED(  552): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.387
06-26 15:43:29.674-0400 W/WATCH_CORE(  816): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 3
06-26 15:43:29.674-0400 E/WATCH_CORE(  816): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
06-26 15:43:31.099-0400 W/AUL_AMD (  551): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-26 15:43:31.459-0400 I/W_INDICATOR(  727): windicator_moment_view.c: windicator_moment_view_timer_cb(107) > [windicator_moment_view_timer_cb:107] moment view timer is expired
06-26 15:43:31.464-0400 E/W_INDICATOR(  727): windicator_moment_view.c: windicator_moment_view_hide(1556) > [windicator_moment_view_hide:1556] Hide Moment View : dynamic_layout((nil)),Type(1)
06-26 15:43:31.469-0400 E/EFL     (  727): <727> elm_main.c:1608 elm_object_signal_emit() safety check failed: obj == NULL
06-26 15:43:31.469-0400 E/EFL     (  727): <727> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
06-26 15:43:31.469-0400 E/W_INDICATOR(  727): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
06-26 15:43:31.719-0400 W/W_INDICATOR(  727): windicator_moment_view.c: _charging_watch_fade_out_end_cb(1642) > [_charging_watch_fade_out_end_cb:1642] 
06-26 15:43:31.719-0400 W/APP_CORE(  727): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000a
06-26 15:43:31.719-0400 I/APP_CORE(  727): appcore-efl.c: __do_app(429) > [APP 727] Event: PAUSE State: RUNNING
06-26 15:43:31.719-0400 I/CAPI_APPFW_APPLICATION(  727): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-26 15:43:31.744-0400 W/AUL_AMD (  551): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-26 15:43:31.744-0400 W/AUL_AMD (  551): amd_launch.c: __e17_status_handler(2295) > back key ungrab error
06-26 15:43:31.759-0400 I/APP_CORE(16594): appcore-efl.c: __do_app(429) > [APP 16594] Event: RESUME State: PAUSED
06-26 15:43:31.759-0400 I/CAPI_APPFW_APPLICATION(16594): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-26 15:43:31.764-0400 W/AUL_AMD (  551): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-26 15:43:31.764-0400 W/AUL_AMD (  551): amd_launch.c: __e17_status_handler(2295) > back key ungrab error
06-26 15:43:31.989-0400 E/W_INDICATOR(  727): windicator_util.c: _ecore_event_client_message_cb(1017) > [_ecore_event_client_message_cb:1017] _ecore_event_client_message_cb
06-26 15:43:31.989-0400 E/W_INDICATOR(  727): windicator_util.c: _ecore_event_client_message_cb(1017) > [_ecore_event_client_message_cb:1017] _ecore_event_client_message_cb
06-26 15:43:31.989-0400 E/W_INDICATOR(  727): windicator_util.c: _ecore_event_client_message_cb(1017) > [_ecore_event_client_message_cb:1017] _ecore_event_client_message_cb
06-26 15:43:31.994-0400 E/W_INDICATOR(  727): windicator_util.c: _ecore_event_client_message_cb(1017) > [_ecore_event_client_message_cb:1017] _ecore_event_client_message_cb
06-26 15:43:31.994-0400 E/W_INDICATOR(  727): windicator_util.c: _ecore_event_client_message_cb(1017) > [_ecore_event_client_message_cb:1017] _ecore_event_client_message_cb
06-26 15:43:32.164-0400 E/AUL     (  551): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
06-26 15:43:33.464-0400 W/KEYROUTER(  424): e_mod_main.c: DeliverDeviceKeyEvents(3222) > Deliver KeyPress to focus window
06-26 15:43:33.464-0400 W/KEYROUTER(  424): e_mod_main.c: DeliverDeviceKeyEvents(3233) > Deliver KeyPress as shared grab
06-26 15:43:33.464-0400 W/KEYROUTER(  424): e_mod_main.c: DeliverDeviceKeyEvents(3233) > Deliver KeyPress as shared grab
06-26 15:43:33.469-0400 W/STARTER (  724): hw_key.c: _key_press_cb(1379) > [_key_press_cb:1379] POWER Key is pressed
06-26 15:43:33.469-0400 W/STARTER (  724): hw_key.c: _key_press_cb(1382) > [_key_press_cb:1382] LCD state : 1
06-26 15:43:33.469-0400 W/STARTER (  724): hw_key.c: _key_press_cb(1389) > [_key_press_cb:1389] PM state : 1
06-26 15:43:33.469-0400 E/STARTER (  724): hw_key.c: _key_press_cb(1395) > [_key_press_cb:1395] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
06-26 15:43:33.469-0400 W/STARTER (  724): hw_key.c: _key_press_cb(1398) > [_key_press_cb:1398] Simple Clock state : 0
06-26 15:43:33.469-0400 W/STARTER (  724): hw_key.c: _key_press_cb(1403) > [_key_press_cb:1403] powerkey count : 1
06-26 15:43:33.469-0400 E/EFL     (  776): ecore_x<776> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=27068296
06-26 15:43:33.469-0400 E/EFL     (16594): ecore_x<16594> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=27068296
06-26 15:43:33.539-0400 E/W_HOME  (  776): key.c: _key_press_cb(218) > (APP_STATE_PAUSE == main_get_info()->state) -> _key_press_cb() return
06-26 15:43:33.669-0400 W/KEYROUTER(  424): e_mod_main.c: DeliverDeviceKeyEvents(3260) > Deliver KeyRelease
06-26 15:43:33.669-0400 W/KEYROUTER(  424): e_mod_main.c: DeliverDeviceKeyEvents(3260) > Deliver KeyRelease
06-26 15:43:33.669-0400 W/KEYROUTER(  424): e_mod_main.c: DeliverDeviceKeyEvents(3260) > Deliver KeyRelease
06-26 15:43:33.669-0400 E/EFL     (  776): ecore_x<776> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=27068503
06-26 15:43:33.669-0400 W/STARTER (  724): hw_key.c: _key_release_cb(1303) > [_key_release_cb:1303] POWER Key is released
06-26 15:43:33.669-0400 W/STARTER (  724): hw_key.c: _is_enable_to_launch_home_directly(1264) > [_is_enable_to_launch_home_directly:1264] launching home directly
06-26 15:43:33.674-0400 E/EFL     (16594): ecore_x<16594> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=27068503
06-26 15:43:33.684-0400 W/STARTER (  724): hw_key.c: _powerkey_timer_cb(884) > [_powerkey_timer_cb:884] _powerkey_timer_cb, powerkey count[1]
06-26 15:43:33.684-0400 W/STARTER (  724): hw_key.c: _powerkey_timer_cb(1106) > [_powerkey_timer_cb:1106] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
06-26 15:43:33.694-0400 E/STARTER (  724): dbus-util.c: dbus_request_cpu_boost(376) > [dbus_request_cpu_boost:376] failed to _invoke_dbus_method_sync
06-26 15:43:33.694-0400 W/AUL     (  724): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
06-26 15:43:33.694-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 0
06-26 15:43:33.699-0400 W/AUL_AMD (  551): amd_launch.c: _start_app(1713) > caller pid : 724
06-26 15:43:33.704-0400 W/AUL_AMD (  551): amd_launch.c: __nofork_processing(1155) > __nofork_processing, cmd: 0, pid: 776
06-26 15:43:33.704-0400 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: RESET State: RUNNING
06-26 15:43:33.704-0400 I/CAPI_APPFW_APPLICATION(  776): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-26 15:43:33.704-0400 W/W_HOME  (  776): main.c: _app_control(1739) > Service value : powerkey
06-26 15:43:33.704-0400 W/CAPI_APPFW_APP_CONTROL(  776): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-26 15:43:33.704-0400 I/wnotib  (  776): w-notification-board-broker-main.c: _wnb_view_event_handler(833) > Home view event: 0x40001
06-26 15:43:33.704-0400 I/wnotib  (  776): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(827) > 
06-26 15:43:33.704-0400 W/W_HOME  (  776): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
06-26 15:43:33.704-0400 E/W_HOME  (  776): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
06-26 15:43:33.709-0400 W/W_HOME  (  776): main.c: _home_key_cb(1653) > Home Key operation tutorial:0 window:0 clock:1 apps:0
06-26 15:43:33.709-0400 E/W_HOME  (  776): move.c: move_back_to_home_no_anim(276) > home is already on position
06-26 15:43:33.709-0400 I/APP_CORE(  776): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
06-26 15:43:33.709-0400 W/AUL_AMD (  551): amd_launch.c: __reply_handler(925) > listen fd(23) , send fd(22), pid(776), cmd(0)
06-26 15:43:33.709-0400 W/W_HOME  (  776): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
06-26 15:43:33.709-0400 W/W_HOME  (  776): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
06-26 15:43:33.709-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.709-0400 E/AUL     (  551): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
06-26 15:43:33.709-0400 W/W_INDICATOR(  727): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(441) > [_windicator_dbus_home_button_clicked_cb:441] show 0, scroll 0
06-26 15:43:33.709-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.709-0400 W/W_HOME  (  776): main.c: home_resume(733) > journal_appcore_app_fully_loaded called
06-26 15:43:33.709-0400 W/W_HOME  (  776): main.c: home_resume(737) > clock/widget resumed
06-26 15:43:33.709-0400 W/W_HOME  (  776): clock_indicator.c: clock_indicator_resume(548) > 
06-26 15:43:33.709-0400 W/AUL     (  724): launch.c: app_request_to_launchpad(282) > request cmd(0) result(776)
06-26 15:43:33.714-0400 E/AUL     (  724): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
06-26 15:43:33.714-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.719-0400 W/AUL_AMD (  551): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-26 15:43:33.739-0400 W/AUL_AMD (  551): amd_launch.c: __e17_status_handler(2295) > back key ungrab error
06-26 15:43:33.739-0400 W/PROCESSMGR(  424): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
06-26 15:43:33.739-0400 W/WATCH_CORE(  816): appcore-watch.c: __widget_resume(1039) > widget_resume
06-26 15:43:33.739-0400 E/watchface-loader(  816): watchface-loader.cpp: OnAppResume(654) > 
06-26 15:43:33.739-0400 I/watchface-viewer(  816): viewer-data-provider.cpp: FlushPendingChanges(2395) > notify pending [56]
06-26 15:43:33.759-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.759-0400 W/HealthDataService(  786): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:SHealthDataListenerList|BlM7eD8xLD8uOS0nMgw8RiBhOBISWysiIygCESIyPlU3DRQTOAMuPCYPCh0DNCwLLj4/CSAsKCQ0LxEbDyAZACoxJwELRiknMypxDTUfOwArG1geBS8jAy8mAigKKCw6NC4bLi4vCSMsCiQ0KzQgLyYHJicjIiggESwjDwwPLwckBz4xLjk8CwM4PC8mCig8KCx/SA==[0;m
06-26 15:43:33.759-0400 W/HealthDataService(  786): ShareManager.cpp: NotifySharedDataChanged(489) > [1;40;33mShare Category[SHealthDataListenerList : com.samsung.shealth-service][0;m
06-26 15:43:33.794-0400 I/APP_CORE(16594): appcore-efl.c: __do_app(429) > [APP 16594] Event: PAUSE State: RUNNING
06-26 15:43:33.794-0400 I/CAPI_APPFW_APPLICATION(16594): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
06-26 15:43:33.804-0400 W/LibServiceCommon( 1073): SHealthDataShareManager.cpp: SetPedometerClientRefCount(1617) > [1;40;33mPedo client Ref Count [1][0;m
06-26 15:43:33.819-0400 W/W_HOME  (  776): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
06-26 15:43:33.819-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.819-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.819-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.834-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.849-0400 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
06-26 15:43:33.849-0400 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
06-26 15:43:33.849-0400 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-26 15:43:33.849-0400 W/W_HOME  (  776): main.c: _window_visibility_cb(1227) > Window [0x2600003] is now visible(0)
06-26 15:43:33.849-0400 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: RESUME State: RUNNING
06-26 15:43:33.849-0400 W/wnotib  (  776): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(419) > fully_obscured: 0
06-26 15:43:33.859-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.869-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.869-0400 I/MALI    (  776): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b1b80] swap changed from async to sync
06-26 15:43:33.879-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.884-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.894-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.904-0400 W/AUL     (16992): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.service]
06-26 15:43:33.904-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(645) > __request_handler: 23
06-26 15:43:33.909-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.909-0400 W/LibServiceCommon( 1073): SHealthDataShareManager.cpp: SetHeartRateClientRefCount(1636) > [1;40;33mHR client Ref Count [0][0;m
06-26 15:43:33.914-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:43:33.914-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:43:33.914-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:43:33.914-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:43:33.914-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:43:33.914-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:43:33.919-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.934-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.944-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.944-0400 W/AUL_AMD (  551): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
06-26 15:43:33.944-0400 W/AUL_AMD (  551): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 16940
06-26 15:43:33.944-0400 W/AUL_AMD (  551): amd_request.c: __send_app_termination_signal(510) > send dead signal done
06-26 15:43:33.949-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:43:33.949-0400 I/AUL_AMD (  551): amd_main.c: __app_dead_handler(263) > __app_dead_handler, pid: 16940
06-26 15:43:33.949-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:43:33.954-0400 W/SHealth_Common( 1073): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:43:33.954-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(192) > [1;40;33mblob size = [0][0;m
06-26 15:43:33.959-0400 W/SHealth_Common( 1073): HeartRateStorage.cpp: ExecuteSelectQuery(215) > [1;40;33mblobSize [0][0;m
06-26 15:43:33.959-0400 W/SHealth_Common( 1073): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
06-26 15:43:33.959-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.959-0400 W/SHealth_Common( 1073): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
06-26 15:43:33.974-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-26 15:43:33.979-0400 W/HealthDataService(  786): HealthShareDBHelper.cpp: SetShareInfo(217) > [1;40;33mCategory:shealth_heartrate|BVMjMioyO2cvKS5/Jw8wDzdhMFkELSsjNjskXCIiJhYjDRNLOyk9IzMhDhUDNCwLLj4/CSAsfyQ0LxEYND8BWCkuQAALRy15MzUCETV1PwopMDcGBCwrDDc/GQUTW1wyFwoLKy4vCSAgISA0IwIgLyYOLQ04NC82NCoKKA4lLxUjLgA9LVBXDyYUIxc+HA0nMV8qGTQSJV8NJSdeETNMGgo5CSYOHwk4NCowRyoIOCwJOC4FKy0JNiQ/JgM4PSQLElsdHAkETAIQOCkXLCkkIwEyOxIgGSYOKQwaDC8XOCoKKCwKOy4GKCgvNiAvIHMVLDYpegomPwYaRj86DTg7CSc/CiQ0KhZQIx0OHwUDFlodIQh7JAcZDCIDKBsFMyAZJgEKNC8mCisJKCwDMiwLLi4mAg03eTMAChVYFD0YJj4bGDw1FCwdAQ4mKxYeMT4kNiAjJgM4NF0pGisOKCwDNCwbPi4vClkvCiQ3Fwk2IAstBhofFlwFHwl5XAYQSwc+MV55Gzg2KXMaGDgME1oZGQ8VICwMPi4vCSUreigPLyQsFD59JSISDyMHFh4GLSw/NCsGHi0LFCAvJgM7Ny8mCi8KKCwDMj8iDjgWfTlcehUXAmoONDAJESwxPwY3Mj4KKBoJOC4DMFkJNAIvJgM4NywmCigNKCwDNCoYBw45MFQ2eVQdCxVYAT0YLjEdPSQ7ESweKCw/OC4GLQt6NiBTWg==[0;m
06-26 15:43:33.984-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
06-26 15:43:33.989-0400 I/healthData( 1073): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-26 15:43:33.989-0400 I/HealthDataService(  786): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
06-26 15:43:33.989-0400 W/SHealth_Common( 1073): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: latest_hr_updated, pendingClientInfoList.size(): 1[0;m
06-26 15:43:34.024-0400 W/CRASH_MANAGER(16988): worker.c: worker_job(1205) > 0716940736572153004221
