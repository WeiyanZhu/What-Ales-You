﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: story_a.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @story_a: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@story_a()
	{
		this.StartPassage = "intro";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: intro

	void passage1_Init()
	{
		this.Passages[@"intro"] = new StoryPassage(@"intro", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("oof oh boi.");
		yield return lineBreak();
		yield return link("ok", "new", null);
		yield break;
	}


	// .............
	// #2: new

	void passage2_Init()
	{
		this.Passages[@"new"] = new StoryPassage(@"new", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("ahhahahahhaha");
		yield break;
	}


}