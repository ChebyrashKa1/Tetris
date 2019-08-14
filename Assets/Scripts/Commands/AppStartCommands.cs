using System.Collections;
using UnityEngine;
using strange.extensions.command.impl;

public class AppStartCommands : Command {
	public override void Execute ()
	{
		//base.Execute ();
		Debug.Log ("App start command!");
	}

}
