// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoSEIUserDataUnregisteredMeta : IEquatable<VideoSEIUserDataUnregisteredMeta> {

		public Gst.Meta Meta;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=16)]
		public byte[] Uuid;
		public byte Data;
		private UIntPtr size;
		public ulong Size {
			get {
				return (ulong) size;
			}
			set {
				size = new UIntPtr (value);
			}
		}

		public static Gst.Video.VideoSEIUserDataUnregisteredMeta Zero = new Gst.Video.VideoSEIUserDataUnregisteredMeta ();

		public static Gst.Video.VideoSEIUserDataUnregisteredMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoSEIUserDataUnregisteredMeta.Zero;
			return (Gst.Video.VideoSEIUserDataUnregisteredMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoSEIUserDataUnregisteredMeta));
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_sei_user_data_unregistered_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_sei_user_data_unregistered_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (VideoSEIUserDataUnregisteredMeta other)
		{
			return true && Meta.Equals (other.Meta) && Uuid.Equals (other.Uuid) && Data.Equals (other.Data) && Size.Equals (other.Size);
		}

		public override bool Equals (object other)
		{
			return other is VideoSEIUserDataUnregisteredMeta && Equals ((VideoSEIUserDataUnregisteredMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ Uuid.GetHashCode () ^ Data.GetHashCode () ^ Size.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
