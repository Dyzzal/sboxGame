using Sandbox;
using Sandbox.UI;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tools
{
	public class NpcSpawner : Base
	{
		public override void OnClick( TraceResult tr, IList<Entity> selected )
		{
			if ( Input.Down( InputButton.Slot0 )){ 
				if ( !Host.IsServer ) return;

				var npc = new NpcTest
				{
					Position = tr.EndPos,
					Rotation = Rotation.LookAt( Owner.EyeRot.Backward.WithZ( 0 ) )
				};

				npc.Tags.Add( "selectable" );
				npc.Tags.Add( "npc" );
			}
		}
	}
}
