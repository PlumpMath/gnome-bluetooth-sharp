// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Bluetooth {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ChooserCombo : Gtk.Box {

		public ChooserCombo (IntPtr raw) : base(raw) {}

		[DllImport("libgnome-bluetooth.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr bluetooth_chooser_combo_new();

		public ChooserCombo () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ChooserCombo)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = bluetooth_chooser_combo_new();
		}

		static ChooserCreatedNativeDelegate ChooserCreated_cb_delegate;
		static ChooserCreatedNativeDelegate ChooserCreatedVMCallback {
			get {
				if (ChooserCreated_cb_delegate == null)
					ChooserCreated_cb_delegate = new ChooserCreatedNativeDelegate (ChooserCreated_cb);
				return ChooserCreated_cb_delegate;
			}
		}

		static void OverrideChooserCreated (GLib.GType gtype)
		{
			OverrideChooserCreated (gtype, ChooserCreatedVMCallback);
		}

		static void OverrideChooserCreated (GLib.GType gtype, ChooserCreatedNativeDelegate callback)
		{
			BluetoothChooserComboClass class_iface = GetClassStruct (gtype, false);
			class_iface.ChooserCreated = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChooserCreatedNativeDelegate (IntPtr inst, IntPtr chooser);

		static void ChooserCreated_cb (IntPtr inst, IntPtr chooser)
		{
			try {
				ChooserCombo __obj = GLib.Object.GetObject (inst, false) as ChooserCombo;
				__obj.OnChooserCreated (GLib.Object.GetObject(chooser) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Bluetooth.ChooserCombo), ConnectionMethod="OverrideChooserCreated")]
		protected virtual void OnChooserCreated (Gtk.Widget chooser)
		{
			InternalChooserCreated (chooser);
		}

		private void InternalChooserCreated (Gtk.Widget chooser)
		{
			ChooserCreatedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ChooserCreated;
			if (unmanaged == null) return;

			unmanaged (this.Handle, chooser == null ? IntPtr.Zero : chooser.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct BluetoothChooserComboClass {
			public ChooserCreatedNativeDelegate ChooserCreated;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Box)).GetClassSize ();
		static Dictionary<GLib.GType, BluetoothChooserComboClass> class_structs;

		static BluetoothChooserComboClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, BluetoothChooserComboClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				BluetoothChooserComboClass class_struct = (BluetoothChooserComboClass) Marshal.PtrToStructure (class_ptr, typeof (BluetoothChooserComboClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, BluetoothChooserComboClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgnome-bluetooth.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr bluetooth_chooser_combo_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = bluetooth_chooser_combo_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}