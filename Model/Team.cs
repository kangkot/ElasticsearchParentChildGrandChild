﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleElasticsearchParentChildGrandChild.Model
{
	public class Team
	{
		[Key]
		public long Id { get; set; }
		public string Name { get; set; }
		public string Stadium { get; set; }
		public List<Player> Players { get; set; }
	}
}
