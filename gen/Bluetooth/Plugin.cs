// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Bluetooth {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Plugin {

		[DllImport("libgnome-bluetooth.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void bluetooth_plugin_manager_cleanup();

		public static void ManagerCleanup() {
			bluetooth_plugin_manager_cleanup();
		}

		[DllImport("libgnome-bluetooth.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void bluetooth_plugin_manager_device_deleted(IntPtr bdaddr);

		public static void ManagerDeviceDeleted(string bdaddr) {
			IntPtr native_bdaddr = GLib.Marshaller.StringToPtrGStrdup (bdaddr);
			bluetooth_plugin_manager_device_deleted(native_bdaddr);
			GLib.Marshaller.Free (native_bdaddr);
		}

		[DllImport("libgnome-bluetooth.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr bluetooth_plugin_manager_get_widgets(IntPtr bdaddr, IntPtr uuids);

		public static GLib.List ManagerGetWidgets(string bdaddr, string uuids) {
			IntPtr native_bdaddr = GLib.Marshaller.StringToPtrGStrdup (bdaddr);
			IntPtr native_uuids = GLib.Marshaller.StringToPtrGStrdup (uuids);
			IntPtr raw_ret = bluetooth_plugin_manager_get_widgets(native_bdaddr, native_uuids);
			GLib.List ret = new GLib.List(raw_ret);
			GLib.Marshaller.Free (native_bdaddr);
			GLib.Marshaller.Free (native_uuids);
			return ret;
		}

		[DllImport("libgnome-bluetooth.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool bluetooth_plugin_manager_init();

		public static bool ManagerInit() {
			bool raw_ret = bluetooth_plugin_manager_init();
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}