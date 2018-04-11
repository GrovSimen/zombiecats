using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data{

	private static int bones, coins, score, goldenBones;

	public static int Bones{
		get{ 
			return bones;
		}

		set{ 
			bones = value;
		}
	}

	public static int Coins{
		get{ 
			return coins;
		}

		set{ 
			coins = value;
		}
	}
	public static int Score{
		get{ 
			return score;
		}

		set{ 
			score = value;
		}
	}
	public static int GoldenBones{
		get{ 
			return goldenBones;
		}

		set{ 
			goldenBones = value;
		}
	}
}
