﻿using System;
using HugsLib.Settings;
using Verse;

namespace WM.SyncGrowth
{
	public class Config : HugsLib.ModBase
	{
		internal static float controlerRange = 20;
		internal static float LandingDesignatorRange = 20;

		private string modName = "SyncGrowth";

		public override string ModIdentifier
		{
			get
			{
				return modName;
			}
		}
		//public override void DefsLoaded()
		//{
		//	
		//}
	}
}
