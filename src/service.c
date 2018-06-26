#include <tizen.h>
#include <service_app.h>
#include "service.h"
#include "sensor.h"
#include <http.h>
#include <curl/curl.h>
#include <net_connection.h>
#include <pthread.h>
#include <unistd.h>

connection_h connection;
CURL *curlHandlerE;
//CURLM *curlHandler;
//int* stillRunning;
char user[] = "Mike";

sensor_type_e sensors[7] = {SENSOR_ACCELEROMETER, SENSOR_GYROSCOPE, SENSOR_HRM, SENSOR_HUMAN_PEDOMETER, SENSOR_HUMAN_SLEEP_MONITOR, SENSOR_PRESSURE, SENSOR_HUMAN_STRESS_MONITOR};
sensor_listener_h listeners[7];

//struct arg_struct {
//	sensor_type_e sensors[];
//	sensor_listener_h listeners[];
//};

bool service_app_create(void *data)
{
    // Todo: add your code here.
    return true;
}

void service_app_terminate(void *data)
{
    // Todo: add your code here.
    return;
}

void service_app_control(app_control_h app_control, void *data)
{
    // Todo: add your code here.
    return;
}

static void
service_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	return;
}

static void
service_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
service_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
service_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

//char
//create_request(sensor_type_e sensors[], sensor_listener_h listeners[]) {
//	char post_msg[4096];
//	strcpy (post_msg, "user=");
//	strcat (post_msg, user);
//	sensor_event_s *event;
//
//	int i;
//	for (i = 0; i < 7; i++) {
//		int error = sensor_listener_read_data(listeners[i], *event);
//		if (error == SENSOR_ERROR_NONE) {
//			if (sensors[i] == SENSOR_ACCELEROMETER) {
//				float x = event->values[0];
//				float y = event->values[1];
//				float z = event->values[2];
//
//				char x_str[100];
//				char y_str[100];
//				char z_str[100];
//				sprintf(x_str, "%f", x);
//				sprintf(y_str, "%f", y);
//				sprintf(z_str, "%f", z);
//
//				strcat (post_msg, "&");
//				strcat (post_msg, "accel_x=");
//				strcat (post_msg, x_str);
//				strcat (post_msg, "&");
//				strcat (post_msg, "accel_y=");
//				strcat (post_msg, y_str);
//				strcat (post_msg, "&");
//				strcat (post_msg, "accel_z=");
//				strcat (post_msg, z_str);
//			} else if (sensors[i] == SENSOR_GYROSCOPE) {
//				float x = event->values[0];
//				float y = event->values[1];
//				float z = event->values[2];
//
//				char x_str[100];
//				char y_str[100];
//				char z_str[100];
//				sprintf(x_str, "%f", x);
//				sprintf(y_str, "%f", y);
//				sprintf(z_str, "%f", z);
//
//				strcat (post_msg, "&");
//				strcat (post_msg, "gyro_x=");
//				strcat (post_msg, x_str);
//				strcat (post_msg, "&");
//				strcat (post_msg, "gyro_y=");
//				strcat (post_msg, y_str);
//				strcat (post_msg, "&");
//				strcat (post_msg, "gyro_z=");
//				strcat (post_msg, z_str);
//			} else if (sensors[i] == SENSOR_HRM) {
//				float hrm = event->values[0];
//				char hrm_str[100];
//				sprintf(hrm_str, "%f", hrm);
//				strcat (post_msg, "&");
//				strcat (post_msg, "bpm=");
//				strcat (post_msg, hrm_str);
//			}
//		}
//	}
//
//	return post_msg;
//}

void
send_request(char post_msg[], char url[])
{
    if(curlHandlerE) {
      /* Set CURL parameters */
      curl_easy_setopt(curlHandlerE, CURLOPT_URL, url);
      curl_easy_setopt(curlHandlerE, CURLOPT_CUSTOMREQUEST, "POST");
      curl_easy_setopt(curlHandlerE, CURLOPT_POSTFIELDS, post_msg);

      curl_easy_perform(curlHandlerE);
//      curl_multi_add_handle(curlHandler, curlHandlerE);
//      curl_multi_perform(curlHandler, &stillRunning);
    }
}

void *threadproc(void *args)
{
	curlHandlerE = curl_easy_init();
    while(1)
    {
//    	struct arg_struct *args = args;
//    	sensor_type_e sensors[] = args->sensors;
//    	sensor_listener_h listeners[] = args->listeners;

        sleep(10);
//        call_function();
        char post_msg[4096];
		strcpy (post_msg, "user=");
		strcat (post_msg, user);
		sensor_event_s event;

		int i;
		for (i = 0; i < 7; i++) {
			int error = sensor_listener_read_data(listeners[i], &event);
			if (error == SENSOR_ERROR_NONE) {
				if (sensors[i] == SENSOR_ACCELEROMETER) {
					float x = event.values[0];
					float y = event.values[1];
					float z = event.values[2];

					char x_str[100];
					char y_str[100];
					char z_str[100];
					sprintf(x_str, "%f", x);
					sprintf(y_str, "%f", y);
					sprintf(z_str, "%f", z);

					strcat (post_msg, "&");
					strcat (post_msg, "accel_x=");
					strcat (post_msg, x_str);
					strcat (post_msg, "&");
					strcat (post_msg, "accel_y=");
					strcat (post_msg, y_str);
					strcat (post_msg, "&");
					strcat (post_msg, "accel_z=");
					strcat (post_msg, z_str);
				} else if (sensors[i] == SENSOR_GYROSCOPE) {
					float x = event.values[0];
					float y = event.values[1];
					float z = event.values[2];

					char x_str[100];
					char y_str[100];
					char z_str[100];
					sprintf(x_str, "%f", x);
					sprintf(y_str, "%f", y);
					sprintf(z_str, "%f", z);

					strcat (post_msg, "&");
					strcat (post_msg, "gyro_x=");
					strcat (post_msg, x_str);
					strcat (post_msg, "&");
					strcat (post_msg, "gyro_y=");
					strcat (post_msg, y_str);
					strcat (post_msg, "&");
					strcat (post_msg, "gyro_z=");
					strcat (post_msg, z_str);
				} else if (sensors[i] == SENSOR_HRM) {
					float hrm = event.values[0];
					char hrm_str[100];
					sprintf(hrm_str, "%f", hrm);
					strcat (post_msg, "&");
					strcat (post_msg, "bpm=");
					strcat (post_msg, hrm_str);
				} else if (sensors[i] == SENSOR_HUMAN_PEDOMETER) {
					float steps = event.values[0];
					char steps_str[100];
					sprintf(steps_str, "%f", steps);
					strcat (post_msg, "&");
					strcat (post_msg, "steps=");
					strcat (post_msg, steps_str);
				} else if (sensors[i] == SENSOR_HUMAN_SLEEP_MONITOR) {
					float sleep = event.values[0];
					char sleep_str[100];
					sprintf(sleep_str, "%f", sleep);
					strcat (post_msg, "&");
					strcat (post_msg, "sleep=");
					strcat (post_msg, sleep_str);
				} else if (sensors[i] == SENSOR_PRESSURE) {
					float press = event.values[0];
					char press_str[100];
					sprintf(press_str, "%f", press);
					strcat (post_msg, "&");
					strcat (post_msg, "press=");
					strcat (post_msg, press_str);
				} else if (sensors[i] == SENSOR_HUMAN_STRESS_MONITOR) {
					float stress = event.values[0];
					char stress_str[100];
					sprintf(stress_str, "%f", stress);
					strcat (post_msg, "&");
					strcat (post_msg, "stress=");
					strcat (post_msg, stress_str);
				}
			}
		}

		char url[] = "impaq.herokuapp.com/updateSensors";
		send_request(post_msg, url);
    }
    return 0;
}

sensor_listener_h
listen_to_sensor(sensor_type_e sensor_type)
{
	sensor_h sensor;
	sensor_listener_h listener;
	sensor_get_default_sensor(sensor_type, &sensor);
	sensor_create_listener(sensor, &listener);

//	if (sensor_type == SENSOR_ACCELEROMETER) {
//		sensor_listener_set_event_cb(listener, 20000, post_accel, ad);
//	} else if (sensor_type == SENSOR_GYROSCOPE) {
//		sensor_listener_set_event_cb(listener, 20000, post_gyro, ad);
//	} else if (sensor_type == SENSOR_HRM) {
//		sensor_listener_set_event_cb(listener, 30000, post_hrm, ad);
//	} else if (sensor_type == SENSOR_HUMAN_PEDOMETER) {
//		sensor_listener_set_event_cb(listener, 30000, post_ped, ad);
//	} else if (sensor_type == SENSOR_HUMAN_SLEEP_MONITOR ) {
//		sensor_listener_set_event_cb(listener, 60000, post_sleep, ad);
//	} else if (sensor_type == SENSOR_PRESSURE) {
//		sensor_listener_set_event_cb(listener, 60000, post_press, ad);
//	} else if (sensor_type == SENSOR_HUMAN_STRESS_MONITOR) {
//		sensor_listener_set_event_cb(listener, 30000, post_stress, ad);
//	}

	sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON);
	sensor_listener_set_attribute_int(listener, SENSOR_ATTRIBUTE_PAUSE_POLICY, SENSOR_PAUSE_NONE);
	sensor_listener_start(listener);
	return listener;
}

int main(int argc, char* argv[])
{
    char ad[50] = {0,};
	service_app_lifecycle_callback_s event_callback;
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = service_app_create;
	event_callback.terminate = service_app_terminate;
	event_callback.app_control = service_app_control;

	service_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, service_app_low_battery, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, service_app_low_memory, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, service_app_lang_changed, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, service_app_region_changed, &ad);

	int i;
	for (i = 0; i < 7; i++) {
		sensor_listener_h listener = listen_to_sensor(sensors[i]);
		listeners[i] = listener;
	}

	pthread_t tid;
//	struct arg_struct args;
//	args.sensors = sensors;
//	args.listeners = listeners;

	pthread_create(&tid, NULL, &threadproc, NULL);

	return service_app_main(argc, argv, &event_callback, ad);
}
