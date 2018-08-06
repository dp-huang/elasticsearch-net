﻿using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Core.ManagedElasticsearch.NodeSeeders;

namespace Tests.Framework.Profiling
{
	public class ProfilingCluster : ClientTestClusterBase
	{
		protected override void SeedCluster()
		{
			var seeder = new DefaultSeeder(this.Client);
			seeder.DeleteIndicesAndTemplates();
			seeder.CreateIndices();
		}
	}
}
