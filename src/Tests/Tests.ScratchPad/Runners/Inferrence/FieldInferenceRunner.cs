﻿using System;
using Nest;
using Tests.Framework.MockData;

namespace ClientMasterScratch
{
	public class FieldInferenceRunner : RunBase
	{
		protected override int LoopCount => 1_000_000;

		protected override RoutineBase Routine() => this.Loop(() => Infer.Field<Project>(p => p.LeadDeveloper.LastName), (c, f) => c.Infer.Field(f));
	}
}
