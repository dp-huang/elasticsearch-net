﻿using System;
using Nest;
using Tests.Domain;

namespace ClientMasterScratch
{
	public class PropertyNameInferenceRunner : RunBase
	{
		protected override RoutineBase Routine() =>
			this.Loop(
				create:() => Infer.Property<Project>(p => p.LeadDeveloper.FirstName),
				act: (c, f) => c.Infer.PropertyName(f)
			);
	}
}