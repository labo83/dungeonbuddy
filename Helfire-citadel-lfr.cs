using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using Bots.DungeonBuddy.Attributes;
using Bots.DungeonBuddy.Helpers;
using Buddy.Coroutines;
using Styx;
using Styx.Common.Helpers;
using Styx.CommonBot;
using Styx.CommonBot.Coroutines;
using Styx.Helpers;
using Styx.Pathing;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using Vector2 = Tripper.Tools.Math.Vector2;



// ReSharper disable CheckNamespace
namespace Bots.DungeonBuddy.Raids.WarlordsOfDraenor
// ReSharper restore CheckNamespace
{

	// Class that contains common behavior for all WOD LFRs
	public abstract class WoDLfr : Dungeon
	{
		protected static LocalPlayer Me
		{
			get { return StyxWoW.Me; }
		}

        

        [EncounterHandler(0, "Root Handler")]
		public virtual async Task<bool> RootBehavior(WoWUnit npc)
		{
			if (await ScriptHelpers.CancelCinematicIfPlaying())
				return true;

			return false;
		}

	}
// To Do  


//  1  dungeonbuddy   dungeon ID  initial check   

public class HFC : hellbreachLFR
	{
		#region Overrides of Dungeon
	
		public override uint DungeonId
		{
			get { return 849; }   
		}
