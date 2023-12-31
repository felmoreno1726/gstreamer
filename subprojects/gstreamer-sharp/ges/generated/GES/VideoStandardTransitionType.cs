// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GES.VideoStandardTransitionTypeGType))]
	public enum VideoStandardTransitionType {

		None = 0,
		BarWipeLr = 1,
		BarWipeTb = 2,
		BoxWipeTl = 3,
		BoxWipeTr = 4,
		BoxWipeBr = 5,
		BoxWipeBl = 6,
		FourBoxWipeCi = 7,
		FourBoxWipeCo = 8,
		BarndoorV = 21,
		BarndoorH = 22,
		BoxWipeTc = 23,
		BoxWipeRc = 24,
		BoxWipeBc = 25,
		BoxWipeLc = 26,
		DiagonalTl = 41,
		DiagonalTr = 42,
		BowtieV = 43,
		BowtieH = 44,
		BarndoorDbl = 45,
		BarndoorDtl = 46,
		MiscDiagonalDbd = 47,
		MiscDiagonalDd = 48,
		VeeD = 61,
		VeeL = 62,
		VeeU = 63,
		VeeR = 64,
		BarnveeD = 65,
		BarnveeL = 66,
		BarnveeU = 67,
		BarnveeR = 68,
		IrisRect = 101,
		ClockCw12 = 201,
		ClockCw3 = 202,
		ClockCw6 = 203,
		ClockCw9 = 204,
		PinwheelTbv = 205,
		PinwheelTbh = 206,
		PinwheelFb = 207,
		FanCt = 211,
		FanCr = 212,
		DoublefanFov = 213,
		DoublefanFoh = 214,
		SinglesweepCwt = 221,
		SinglesweepCwr = 222,
		SinglesweepCwb = 223,
		SinglesweepCwl = 224,
		DoublesweepPv = 225,
		DoublesweepPd = 226,
		DoublesweepOv = 227,
		DoublesweepOh = 228,
		FanT = 231,
		FanR = 232,
		FanB = 233,
		FanL = 234,
		DoublefanFiv = 235,
		DoublefanFih = 236,
		SinglesweepCwtl = 241,
		SinglesweepCwbl = 242,
		SinglesweepCwbr = 243,
		SinglesweepCwtr = 244,
		DoublesweepPdtl = 245,
		DoublesweepPdbl = 246,
		SaloondoorT = 251,
		SaloondoorL = 252,
		SaloondoorB = 253,
		SaloondoorR = 254,
		WindshieldR = 261,
		WindshieldU = 262,
		WindshieldV = 263,
		WindshieldH = 264,
		Crossfade = 512,
		FadeIn = 513,
	}

	internal class VideoStandardTransitionTypeGType {
		[DllImport ("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_video_standard_transition_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (ges_video_standard_transition_type_get_type ());
			}
		}
	}
#endregion
}
