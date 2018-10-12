using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClass : MonoBehaviour {

	#region variables
	public Vector2 position;
	public int priority;
	static private TileClass[] Tiles;
	public int noOfPriorityLevels;
	#endregion

	void Start()
	{
		Tiles = FindObjectsOfType<TileClass>();
	}

	#region functions
	public TileClass GetTileAt(Vector2 location)
	{
		foreach(TileClass tile in Tiles)
		{
			if (tile.position == location)
			{
				return tile;
			}
		}
		return null;
	}
	#endregion
}
